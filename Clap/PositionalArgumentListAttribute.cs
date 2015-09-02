namespace Clap
{
    public class PositionalArgumentListAttribute : PositionalArgumentAttribute
    {
        public string Delimeter { get; set; }
        public uint MaxLength { get; set; }
        public uint MinLength { get; set; }
    }
}
