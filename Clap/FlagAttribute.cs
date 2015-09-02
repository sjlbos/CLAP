namespace Clap
{
    public class FlagAttribute : OptionalArgumentAttribute
    {
        public FlagAttribute(
            char ShortName,
            string LongName = null,
            string HelpDescription = null,
            bool Required = false,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null)
                :base(ShortName, LongName, HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {
            
        }

        public FlagAttribute(
            string LongName,
            char? ShortName = null,
            string HelpDescription = null,
            bool Required = false,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null)
                : base(LongName, ShortName, HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {

        }
    }
}
