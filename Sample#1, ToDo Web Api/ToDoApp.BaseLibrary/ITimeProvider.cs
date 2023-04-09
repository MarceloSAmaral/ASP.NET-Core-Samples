namespace ToDoApp.BaseLibrary
{

    public interface ITimeProvider
    {
        DateTime UtcNow { get; }

        DateTime Now { get; }

        DateTimeOffset OffsetNow { get; }

        DateTimeOffset OffsetUtcNow { get; }
    }
}
