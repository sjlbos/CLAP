using System;
using System.Collections.Generic;
using System.ComponentModel;
using Clap.Core;

namespace Clap
{
    public static class Parser
    {
        private const ArgumentStyle DefaultArgumentStyle = ArgumentStyle.Unix;

        public static ParseStatus Parse(IList<string> args, object argumentContainer)
        {
            if (args == null)
                throw new ArgumentNullException("args");
            if (argumentContainer == null)
                throw new ArgumentNullException("argumentContainer");

            ArgumentParser parser = GetParser(argumentContainer);
            return parser.Parse(args, argumentContainer);
        }

        private static ArgumentStyle GetStyleForArgument(object argumentContainer)
        {
            var styleAttribute = Attribute.GetCustomAttribute(argumentContainer.GetType(), typeof (ArgumentStyleAttribute)) as ArgumentStyleAttribute;
            return styleAttribute == null ? DefaultArgumentStyle : styleAttribute.ArgumentStyle;
        }

        private static ArgumentParser GetParser(object argumentContainer)
        {
            var argumentStyle = GetStyleForArgument(argumentContainer);
            switch (argumentStyle)
            {
                case ArgumentStyle.Unix:
                    return new UnixParser();
                case ArgumentStyle.DOS:
                    return new DosParser();
                default:
                    throw new InvalidEnumArgumentException(argumentStyle.ToString());
            }
        }
    }
}
