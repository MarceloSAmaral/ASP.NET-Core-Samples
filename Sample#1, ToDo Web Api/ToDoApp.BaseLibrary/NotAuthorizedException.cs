using System.Runtime.Serialization;

namespace ToDoApp.BaseLibrary
{
    [Serializable]
    public class NotAuthorizedException : BaseException
    {
        protected NotAuthorizedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public NotAuthorizedException(string message, Exception innerException) : base(message, innerException) { }
        public NotAuthorizedException(string message) : base(message) { }
        public NotAuthorizedException() : base() { }
    }
}
