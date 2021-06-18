using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class UrlValidationContractTests
    {
        private const string Property = "Url";
        private const string Message = "Invalid Url";

        [Test]
        [Category("Validations/Url")]
        public void Url()
        {
            var wrong = new ValidationContract()
                .IsUrl("invalidurl", Property, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsUrl("https://gmail.com", Property, Message)
                .IsUrl("http://gmail.com", Property, Message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Url")]
        public void UrlOrEmpty()
        {
            var right = new ValidationContract()
                .IsUrlOrEmpty("", Property, Message);
            Assert.True(right.IsValid);
        }
    }
}