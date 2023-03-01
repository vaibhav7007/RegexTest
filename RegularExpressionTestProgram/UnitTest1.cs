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
        [Test]
        public void ShouldReturn_LastName_ValidOrNot()
        {
            string result = regex.ValidateLastName("Mehta");
            Assert.AreEqual("Valid", result);
        }
    }
}
