using FlyGon.Notifications.Validations;
using NUnit.Framework;
using System;

namespace FlyGon.Notifications.Test.Validations
{
    class GuidContractTests
    {
        private const string PropertyName = "Guid";

        [Test]
        [Category("Validations/Guid")]
        public void AreEquals()
        {
            var message = "Guid are not equals";
            var guid = Guid.NewGuid();
            var compared = Guid.NewGuid();
            var wrong = new ValidationContract()
                .AreEquals(guid, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = guid;
            var right = new ValidationContract()
                .AreEquals(guid, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }
        
        [Test]
        [Category("Validations/Guid")]
        public void AreNotEquals()
        {
            var message = "Guid are equals";
            var guid = Guid.NewGuid();
            var compared = guid;
            var wrong = new ValidationContract()
                .AreNotEquals(guid, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = Guid.NewGuid();
            var right = new ValidationContract()
                .AreNotEquals(guid, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Guid")]
        public void GuidIsEmpty()
        {
            var message = "Guid is not empty";
            var wrong = new ValidationContract()
                .IsEmpty(Guid.NewGuid(), PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsEmpty(Guid.Empty, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Guid")]
        public void GuidIsNotEmpty()
        {
            var message = "Guid is empty";
            var wrong = new ValidationContract()
                .IsNotEmpty(Guid.Empty, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsNotEmpty(Guid.NewGuid(), PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }
    }
}