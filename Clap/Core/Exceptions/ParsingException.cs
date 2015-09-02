
using System;
using System.Runtime.Serialization;

namespace Clap.Core.Exceptions
{
    /// <summary>
    /// An exception to be thrown when input arguments do not match the program's schema or are otherwise 
    /// un-parsable.
    /// </summary>
    [Serializable]
    internal class ParsingException : ClapException
    {
        public ParsingException() { }

        public ParsingException(string message) : base(message) { }

        public ParsingException(string message, Exception innerException) : base(message, innerException) { }

        protected ParsingException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
