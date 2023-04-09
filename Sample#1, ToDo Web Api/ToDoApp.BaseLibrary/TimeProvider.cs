namespace ToDoApp.BaseLibrary
{
    public abstract class TimeProvider : ITimeProvider
    {
        private static ITimeProvider current = new DefaultTimeProvider();

        public static ITimeProvider Current
        {
            get { return current; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                current = value;
            }
        }

        public abstract DateTime UtcNow { get; }

        public abstract DateTime Now { get; }

        public abstract DateTimeOffset OffsetNow { get; }

        public abstract DateTimeOffset OffsetUtcNow { get; }

        public static void ResetToDefault()
        {
            current = new DefaultTimeProvider();
        }
    }
}
