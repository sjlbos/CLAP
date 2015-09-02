using System;
using System.Runtime.Serialization;

namespace Clap
{
    [Serializable]
    public class ClapException : Exception
    {
        public ClapException() { }

        public ClapException(string message) : base(message) { }

        public ClapException(string message, Exception innerException) : base(message, innerException) { }

        protected ClapException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
