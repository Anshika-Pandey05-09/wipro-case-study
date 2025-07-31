using EmailValidationApp.Validators;

namespace EmailValidationApp.NUnitTests
{
    [TestFixture]
    public class EmailValidatorNUnitTest
    {
        private readonly EmailValidator _validator = new();

        [Test]
        public void ValidEmail_ShouldReturnTrue()
        {
            Assert.IsTrue(_validator.IsEmailValid("test@example.com"));
        }

        [Test]
        public void InvalidEmail_ShouldReturnFalse()
        {
            Assert.IsFalse(_validator.IsEmailValid("abc@"));
            Assert.IsFalse(_validator.IsEmailValid("abc.com"));
            Assert.IsFalse(_validator.IsEmailValid("@xyz.com"));
        }
    }

}