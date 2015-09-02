
using System;

namespace Clap
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = true)]
    public class ArgumentStyleAttribute : Attribute
    {
        public ArgumentStyleAttribute(ArgumentStyle ArgumentStyle)
        {
            this.ArgumentStyle = ArgumentStyle;
        }

        public ArgumentStyle ArgumentStyle { get; private set; }
    }
}
