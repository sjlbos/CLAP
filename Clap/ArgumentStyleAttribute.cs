
using System;

namespace Clap
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
    public sealed class ArgumentStyleAttribute : Attribute
    {
        public ArgumentStyleAttribute(ArgumentStyle argumentStyle)
        {
            ArgumentStyle = argumentStyle;
        }

        public ArgumentStyle ArgumentStyle { get; private set; }
    }
}
