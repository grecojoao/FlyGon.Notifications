using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class BoolContractTests
    {
        private const string PropertyName = "bool";

        [Test]
        [Category("Validations/Bool")]
        public void IsFalse()
        {
            var message = "Bool is true";
            var wrong = new ValidationContract()
                .IsFalse(true, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsFalse(false, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Bool")]
        public void IsTrue()
        {
            var message = "Bool is false";
            var wrong = new ValidationContract()
                .IsTrue(false, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsTrue(true, PropertyName, message);
            Assert.True(right.IsValid);
        }
    }
}