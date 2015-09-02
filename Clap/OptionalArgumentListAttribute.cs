namespace Clap
{
    public class OptionalArgumentListAttribute : OptionalArgumentAttribute
    {
        public OptionalArgumentListAttribute(
            char ShortName,
            string LongName = null,
            string HelpDescription = null,
            bool Required = false,
            uint MinLength = 0,
            uint MaxLength = 0,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null,
            string Delimiter = ", ") 
                : base(ShortName, LongName, HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {
            this.Delimiter = Delimiter;
            this.MinLength = MinLength;
            this.MaxLength = MaxLength;
        }

        public string Delimiter { get; private set; }
        public uint MaxLength { get; set; }
        public uint MinLength { get; set; }
    }
}
