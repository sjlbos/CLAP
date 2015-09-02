
using System;
using System.Runtime.Serialization;

namespace Clap.Core.Exceptions
{
    /// <summary>
    /// An exception to be thrown when the input program schema is invalid.
    /// </summary>
    [Serializable]
    internal class SchemaException : ClapException
    {
        public SchemaException() { }

        public SchemaException(string message) : base(message) { }

        public SchemaException(string message, Exception innerException) : base(message, innerException) { }

        protected SchemaException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
