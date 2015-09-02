namespace Clap
{
    public class FlagAttribute : NamedArgumentAttribute
    {
        public FlagAttribute(char ShortName)
                :base(ShortName)
        {
            
        }

        public FlagAttribute(string LongName)
                : base(LongName)
        {

        }

        public FlagAttribute(
            char ShortName,
            string LongName)
            : base(ShortName, LongName)
        {
            
        }
    }
}
