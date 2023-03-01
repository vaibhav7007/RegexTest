using NUnit.Framework;
using RegularExpressionTest;

namespace RegularExpressionTestProgram
{
    public class Tests
    {
        RegexPattern regex = new RegexPattern();
        [Test]
        public void ShouldReturn_FirstName_ValidOrNot()
        {
            string result = regex.ValidateFirstName("Vaibhav");
            Assert.AreEqual("Valid", result);
            Assert.Pass();
        }
    }
}
