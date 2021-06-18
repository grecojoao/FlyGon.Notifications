using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class StringContractTests
    {
        private const string PropertyName = "string";

        [Test]
        [Category("Validations/String")]
        public void IsNotNullOrEmpty()
        {
            var message = "String is Null Or Empty";
            var wrong = new ValidationContract()
                .IsNotNullOrEmpty(null, PropertyName, message)
                .IsNotNullOrEmpty("", PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsNotNullOrEmpty("Some valid string", PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void IsNotNullOrWhiteSpace()
        {
            var message = "String is Null Or Empty";
            var wrong = new ValidationContract()
                .IsNotNullOrWhiteSpace(null, PropertyName, message)
                .IsNotNullOrWhiteSpace("     ", PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsNotNullOrWhiteSpace("Some valid string", PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void IsNullOrEmpty()
        {
            var message = "String is Null Or Empty";
            var wrong = new ValidationContract()
                .IsNullOrEmpty("Some valid string", PropertyName, message);
            Assert.True(wrong.IsInvalid);

            var right = new ValidationContract()
                .IsNullOrEmpty(null, PropertyName, message)
                .IsNullOrEmpty("", PropertyName, message);
            Assert.True(right.IsValid);
            Assert.AreEqual(0, right.Notifications.Count);
        }

        [Test]
        [Category("Validations/String")]
        public void MinLen()
        {
            var message = "String len is less than permited";
            var wrong = new ValidationContract()
                .HasMinLen("null", 5, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .HasMinLen("Some Valid String", 5, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void MaxLen()
        {
            var message = "String len is more than permited";
            var wrong = new ValidationContract()
                .HasMaxLen("null", 3, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .HasMaxLen("Some", 5, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void Len()
        {
            var message = "String len is less than permited";
            var wrong = new ValidationContract()
                .HasLen("null", 3, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .HasLen("Some1", 5, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void Contains()
        {
            var message = "String does not contains banana";
            var wrong = new ValidationContract()
                .Contains("some text here", "banana", PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .Contains("some banana here", "banana", PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void Match()
        {
            var message = "Invalid URL";
            var wrong = new ValidationContract()
                .Matchs("invalidurl", @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$",
                PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .Matchs("http://gmail.com", @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$",
                PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void IsDigit()
        {
            var message = "String must have digits only";
            var wrong = new ValidationContract()
                .IsDigit("asdfa989798", PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsDigit("1234567890", PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void HasMinLenOrIsNullOrEmpty()
        {
            var message = "String not null or empty and length is less than permitted";
            var wrong = new ValidationContract()
                .HasMinLenOrIsNullOrEmpty("123456789", 10, PropertyName, message)
                .HasMinLenOrIsNullOrEmpty("         ", 10, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new ValidationContract()
                .HasMinLenOrIsNullOrEmpty(null, 10, PropertyName, message)
                .HasMinLenOrIsNullOrEmpty("", 10, PropertyName, message)
                .HasMinLenOrIsNullOrEmpty("1234567890", 10, PropertyName, message)
                .HasMinLenOrIsNullOrEmpty("123456789012345", 10, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void HasMaxLenOrIsNullOrEmpty()
        {
            var message = "String not null or empty and length is more than permitted";
            var wrong = new ValidationContract()
                .HasMaxLenOrIsNullOrEmpty("123456789012345", 10, PropertyName, message)
                .HasMaxLenOrIsNullOrEmpty("               ", 10, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new ValidationContract()
                .HasMaxLenOrIsNullOrEmpty(null, 10, PropertyName, message)
                .HasMaxLenOrIsNullOrEmpty("", 10, PropertyName, message)
                .HasMaxLenOrIsNullOrEmpty("12345", 10, PropertyName, message)
                .HasMaxLenOrIsNullOrEmpty("1234567890", 10, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void HasLenOrIsNullOrEmpty()
        {
            var message = "String not null or empty and length is different than permitted";
            var wrong = new ValidationContract()
                .HasLenOrIsNullOrEmpty("123456789", 10, PropertyName, message)
                .HasLenOrIsNullOrEmpty("12345678901", 10, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            var right = new ValidationContract()
                .HasLenOrIsNullOrEmpty(null, 10, PropertyName, message)
                .HasLenOrIsNullOrEmpty("", 10, PropertyName, message)
                .HasLenOrIsNullOrEmpty("1234567890", 10, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void AreEquals()
        {
            var message = "String are not equals";
            var wrong = new ValidationContract()
                .AreEquals(null, "String not equals", PropertyName, message)
                .AreEquals("", "String not equals", PropertyName, message)
                .AreEquals("String almost equals", "String almolst equals", PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreEquals("Some valid string", "Some valid string", PropertyName, "String are equals");
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/String")]
        public void AreNotEquals()
        {
            var wrong = new ValidationContract()
                .AreNotEquals("Some valid string", "Some valid string", PropertyName, "String are equals");
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var message = "String are not equals";
            var right = new ValidationContract()
                .AreNotEquals(null, "String not equals", PropertyName, message)
                .AreNotEquals("", "String not equals", PropertyName, message)
                .AreNotEquals("String almost equals", "String almolst equals", PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }
    }
}