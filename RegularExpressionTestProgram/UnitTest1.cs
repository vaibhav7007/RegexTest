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
        [Test]
        public void ShouldReturn_Email_ValidOrNot()
        {
            string result = regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_PhoneNumber_ValidOrNot()
        {
            string result = regex.ValidatePhoneNumber("91 6378023396");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot()
        {
            string result = regex.ValidatePassword("VaibhavID");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot_WithLeastOneUpperCase()
        {
            string result = regex.ValidatePasswordLeastUppercase("VaibhavID");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot_WithLeastOneNumericValue()
        {
            string result = regex.ValidatePasswordWithLeastNumericValue("Vaibhav12");
            Assert.AreEqual("Valid", result);
        }
        [Test]
        public void ShouldReturn_Password_ValidOrNot_WithExactlyOneSpecialCharacter()
        {
            string result = regex.ValidatePasswordWithExactlyOneSpecialCharacter("Vaibhav1@");
            Assert.AreEqual("Valid", result);

        }
    }
}
