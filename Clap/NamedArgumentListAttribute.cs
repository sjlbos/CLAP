namespace Clap
{
    public class NamedArgumentListAttribute : NamedArgumentAttribute
    {
        public NamedArgumentListAttribute(char ShortName) 
                : base(ShortName)
        {
        }

        public string Delimiter { get; set; }
        public uint MaxLength { get; set; }
        public uint MinLength { get; set; }
    }
}
