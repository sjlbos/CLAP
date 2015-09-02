
namespace Clap.Core
{
    internal struct Token
    {
        public string Value { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public TokenType TokenType { get; set; }
    }
}
