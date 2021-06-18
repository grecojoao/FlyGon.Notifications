using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class CnhValidationContractTests
    {
        private const string Message = "Invalid Cnh";
        private const string PropertyName = "Cnh";

        [Test]
        [TestCase("668247690132")]
        [TestCase("333438450601")]
        [TestCase("6568351232550")]
        [Category("Validations/Cnh")]
        public void IsCnhWrong(string cnh)
        {
            var wrong = new ValidationContract()
                .IsCnh(cnh, PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("09974348506")]
        [TestCase("32983022807")]
        [Category("Validations/Cnh")]
        public void IsCnhRight(string cnh)
        {
            var right = new ValidationContract()
                .IsCnh(cnh, PropertyName, Message);
            Assert.True(right.IsValid);
        }
    }
}