using System;

namespace Clap
{
    public class OptionalArgumentAttribute : ArgumentBase
    {
        public OptionalArgumentAttribute(
            string LongName,
            char? ShortName = null,
            string HelpDescription = null,
            bool Required = false,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null) 
                : base(HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {
            if(LongName == null)
                throw new ArgumentNullException("LongName");
            if(String.IsNullOrWhiteSpace(LongName))
                throw new ArgumentException("Argument \"LongName\" cannot be an empty string.");

            this.ShortName = ShortName;
            this.LongName = LongName;
        }

        public OptionalArgumentAttribute(
            char ShortName, 
            string LongName = null,
            string HelpDescription = null,
            bool Required = false,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null)
                : base(HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {
            this.ShortName = ShortName;
            this.LongName = LongName;
        }

        public char? ShortName { get; private set; }
        public string LongName { get; private set; }
    }
}
