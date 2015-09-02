using System.Collections.Generic;

namespace Clap
{
    public class ParseStatus
    {
        public bool Succeeded { get; set; }
        public IList<string> Errors { get; set; }

        public ParseStatus()
        {
            Errors = new List<string>();
        }
    }
}
