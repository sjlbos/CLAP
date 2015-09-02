using System;

namespace Clap
{
    public class NamedArgumentAttribute : ArgumentBase
    {
        public NamedArgumentAttribute(string longName)
        {
            if(longName == null)
                throw new ArgumentNullException("LongName");
            if(String.IsNullOrWhiteSpace(longName))
                throw new ArgumentException("Argument \"LongName\" cannot be an empty string.");

            LongName = longName;
        }

        public NamedArgumentAttribute(char shortName)
        {
            ShortName = shortName;
        }

        public NamedArgumentAttribute(char shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;
        }

        public char ShortName { get; private set; }
        public string LongName { get; private set; }
    }
}
