
using System;
using System.Collections.Generic;

namespace Clap
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
    public sealed class CommandAttribute : Attribute
    {
        public CommandAttribute(string Name = null, IList<string> Aliases = null,  string HelpDescription = null)
        {
            this.Name = Name;
            this.Aliases = Aliases;
            this.HelpDescription = HelpDescription;
        }

        public string Name { get; private set; }
        public string HelpDescription { get; private set; }
        public IList<string> Aliases { get; private set; } 
    }
}
