using System;

namespace Clap
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ArgumentOptionsAttribute : Attribute
    {
        public ArgumentOptionsAttribute(string ProgramName = null, ArgumentStyle ArgumentStyle = ArgumentStyle.Unix)
        {
            this.ProgramName = ProgramName;
            this.ArgumentStyle = ArgumentStyle;
        }

        public string ProgramName { get; private set; }
        public ArgumentStyle ArgumentStyle { get; private set; }
    }
}
