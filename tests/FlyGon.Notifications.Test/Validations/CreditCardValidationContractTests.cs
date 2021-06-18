using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class CreditCardValidationContractTests
    {
        private const string Message = "Invalid card";
        private const string PropertyName = "CreditCard";

        [Test]
        [TestCase("0123-4567-8910-1112")]
        [TestCase("3559716521958")]
        [TestCase("3559 7165 2195 8234")]
        [Category("Validations/CreditCard")]
        public void IsCreditCardWrong(string card)
        {
            var wrong = new ValidationContract()
                .IsCreditCard(card, PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("5542-4867-7143-5554")]
        [TestCase("4485218645194493")]
        [TestCase("3416 608582 70977")]
        [Category("Validations/CreditCard")]
        public void IsCreditCardRight(string card)
        {
            var right = new ValidationContract()
                .IsCreditCard(card, PropertyName, Message);
            Assert.True(right.IsValid);
        }
    }
}