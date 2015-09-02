
using System;
using System.Collections.Generic;

namespace Clap.Core
{
    internal abstract class ArgumentParser
    {
        public ParseStatus Parse(IList<string> args, object argumentContainer)
        {
            if (args == null)
                throw new ArgumentNullException("args");
            if(argumentContainer == null)
                throw new ArgumentNullException("argumentContainer");

            ParseStatus result = new ParseStatus{ Succeeded = true };

            // Get schema
            
            // Validate schema
            
            // Parse input
 
            // Map input to schema

            // Handle errors

            // Return status

            return result;
        }
    }
}
