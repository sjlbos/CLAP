
using System.Collections.Generic;

namespace Clap.Core
{
    internal class ProgramSchema
    {
        public IDictionary<string, IList<ArgumentBase>> MutuallyExclusiveSets { get; private set; }

        public ProgramSchema()
        {
            MutuallyExclusiveSets = new Dictionary<string, IList<ArgumentBase>>();
        }
    }
}
