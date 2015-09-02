namespace Clap
{
    public class PositionalArgumentAttribute : ArgumentBase
    {
        public PositionalArgumentAttribute(
            uint? Index = null,
            string HelpDescription = null,
            bool Required = false,
            string MutuallyExclusiveSet = null,
            object DefaultValue = null) 
                : base(HelpDescription, Required, MutuallyExclusiveSet, DefaultValue)
        {
            this.Index = Index;
        }

        public uint? Index { get; private set; }
    }
}
