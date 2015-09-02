using System;

namespace Clap
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public abstract class ArgumentBase : Attribute
    {
        protected ArgumentBase(
            string HelpDescription, 
            bool Required,
            string MutuallyExclusiveSet,
            object DefaultValue
            )
        {
            this.HelpDescription = HelpDescription;
            this.Required = Required;
            this.MutuallyExclusiveSet = MutuallyExclusiveSet;
            this.DefaultValue = DefaultValue;
        }

        public string HelpDescription { get; private set; }
        public bool Required { get; private set; }
        public string MutuallyExclusiveSet { get; private set; }
        public object DefaultValue { get; private set; }
    }
}
