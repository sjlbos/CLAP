using NUnit.Framework;

namespace Clap.Tests.IndividualArgumentTypeTests
{

    public class FlagTestArgumentContainer
    {
        [Flag('f', "foo", HelpDescription="This is a helpful description.", DefaultValue="foo")]
        public bool TestFlag { get; set; }
    }

    [TestFixture]
    public class FlagTests
    {
         
        /*
         * 
         * Rules:
         * 
         * - short and long names are mutually exclusive
         * - presence of flag means it's set to the user-defined default value, otherwise set to type's default value
         *      bool: false
         *      int: 0
         *      double: 0
         *      string: null
         *      object: null
         *      char: /0
         *      
         * - need to deal with exclusive flags (if x is there then y can't be) and necessary flags (if x is there then y must be)
         * - need to deal with necessary sets (x or y)
         * - need to deal with necessity (x must be there)
         * 
         */

        [Test]
        public void Test_Property_Is_Set_To_User_Defined_Value_When_Short_Flag_Is_Set()
        {
            var args = new []{"-f"};
            var argContainer = new FlagTestArgumentContainer();

            ParseStatus status = Parser.Parse(args, argContainer);

            Assert.That(status.Succeeded, Is.True);
            Assert.That(status.Errors, Is.Empty);
            Assert.That(argContainer.TestFlag, Is.EqualTo("foo"));
        }

        [Test]
        public void Test_Property_Is_Set_To_User_Defined_Value_When_Long_Flag_Is_Set()
        {
            var args = new[] { "-flag" };
            var argContainer = new FlagTestArgumentContainer();

            ParseStatus status = Parser.Parse(args, argContainer);

            Assert.That(status.Succeeded, Is.True);
            Assert.That(status.Errors, Is.Empty);
            Assert.That(argContainer.TestFlag, Is.EqualTo("foo"));
        }

        [Test]
        public void Test_Parsing_Fails_When_Both_Flag_Names_Are_Specified_For_A_Single_Flag()
        {
            var args = new[] { "-f", "--flag" };
            var argContainer = new FlagTestArgumentContainer();

            ParseStatus status = Parser.Parse(args, argContainer);

            Assert.That(status.Succeeded, Is.False);
            Assert.That(status.Errors, Is.Not.Empty);
        }

    }
}