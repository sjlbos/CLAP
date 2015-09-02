using System;

namespace Clap
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public abstract class ArgumentBase : Attribute
    {
        public string HelpDescription { get; set; }
        public bool Required { get; set; }
        public string MutuallyExclusiveSet { get; set; }
        public object DefaultValue { get; set; }
    }
}
