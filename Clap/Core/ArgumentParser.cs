
using System;
using System.Collections.Generic;
using Clap.Core.Exceptions;

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

            try
            {
                // Get schema

                // Validate schema

                // Parse input

                // Map input to schema

                // Handle errors

                // Return status
            }
            catch (SchemaException ex)
            {
                result.Succeeded = false;
                result.Errors.Add(ex.Message);
            }
            catch (ParsingException ex)
            {
                result.Succeeded = false;
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        protected abstract bool IsShortName(string arg);
        protected abstract bool IsLongName(string arg);
        protected abstract bool IsFlagList(string arg);
    }
}
