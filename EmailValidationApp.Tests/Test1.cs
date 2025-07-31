using EmailValidationApp.Validators;

namespace EmailValidationApp.Tests
{
    [TestClass]
    public class EmailValidatorMSTest
    {
        private readonly EmailValidator _validator = new();

        [TestMethod]
        public void ValidEmail_ShouldReturnTrue()
        {
            Assert.IsTrue(_validator.IsEmailValid("test@example.com"));
        }

        [TestMethod]
        public void InvalidEmail_ShouldReturnFalse()
        {
            Assert.IsFalse(_validator.IsEmailValid("abc@"));
            Assert.IsFalse(_validator.IsEmailValid("abc.com"));
            Assert.IsFalse(_validator.IsEmailValid("@xyz.com"));
        }
    }

}
