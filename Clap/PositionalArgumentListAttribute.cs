namespace Clap
{
    public class PositionalArgumentListAttribute : PositionalArgumentAttribute
    {
        public PositionalArgumentListAttribute(
            int? Index = null,
            string Delimeter = null,
            uint MinLength = 0,
            uint MaxLength = 0,
            string HelpDescription = null,
            bool Required = false,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null) 
                : base(Index, HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {
            this.Delimeter = Delimeter;
            this.MinLength = MinLength;
            this.MaxLength = MaxLength;
        }

        public string Delimeter { get; private set; }
        public uint MaxLength { get; set; }
        public uint MinLength { get; set; }
    }
}
