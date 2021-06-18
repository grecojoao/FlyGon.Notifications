using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class EmailValidationContractTests
    {
        private const string Message = "Invalid E-mail";
        private const string PropertyName = "Email";

        [Test]
        [Category("Validations/Email")]
        public void Email()
        {
            var wrong = new ValidationContract()
                .IsEmail("invalidemail", PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsEmail("meuemaildeteste@gmail.com", PropertyName, Message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Email")]
        public void EmailOrEmpty()
        {
            var wrong = new ValidationContract()
                .IsEmailOrEmpty("invalidemail", PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsEmailOrEmpty("meuemaildeteste@gmail.com", PropertyName, Message)
                .IsEmailOrEmpty("", PropertyName, Message);
            Assert.True(right.IsValid);
        }
    }
}