using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class IntContractTests
    {
        private const string PropertyName = "int";

        [Test]
        [Category("Validations/Int")]
        public void IsGreaterThanInt()
        {
            var message = "Value is not greater than compared";
            int value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1, 1, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsGreaterThanDecimal()
        {
            var message = "Value is not greater than compared";
            decimal value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1M, 1, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsGreaterThanDouble()
        {
            var message = "Value is not greater than compared";
            double value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1d, 1, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsGreaterOrEqualsThanInt()
        {
            var message = "Value is not greater or equals than compared";
            int value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsGreaterOrEqualsThanDecimal()
        {
            var message = "Value is not greater or equals than compared";
            decimal value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (int)value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10M, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsGreaterOrEqualsThanDouble()
        {
            var message = "Value is not greater or equals than compared";
            double value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (int)value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10d, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsLowerThanInt()
        {
            var message = "Value is not lower than compared";
            int value = 10;
            int compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1, 1, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsLowerThanDecimal()
        {
            var message = "Value is not lower than compared";
            decimal value = 10;
            int compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1M, 1, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsLowerThanDouble()
        {
            var message = "Value is not lower than compared";
            double value = 10;
            int compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1d, 1, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsLowerOrEqualsThanInt()
        {
            var message = "Value is not lower or equals than compared";
            int value = 10;
            int compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5, 10, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsLowerOrEqualsThanDecimal()
        {
            var message = "Value is not lower or equals than compared";
            decimal value = 10;
            int compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (int)value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(10M, 10, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsLowerOrEqualsThanDouble()
        {
            var message = "Value is not lower or equals than compared";
            double value = 10;
            int compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (int)value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(10d, 10, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void AreEqualsInt()
        {
            var message = "Are not equals";
            int value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10, 5, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void AreEqualsDecimal()
        {
            var message = "Are not equals";
            decimal value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10M, 5, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = (int)value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void AreEqualsDouble()
        {
            var message = "Are not equals";
            double value = 5;
            int compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10d, 5, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = (int)value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void AreNotEqualsInt()
        {
            var message = "Are equals";
            int value = 5;
            int compared = value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10, 5, PropertyName, message)
                .AreNotEquals(5, 10, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void AreNotEqualsDecimal()
        {
            var message = "Are equals";
            decimal value = 5;
            int compared = (int)value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10M, 5, PropertyName, message)
                .AreNotEquals(5M, 10, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void AreNotEqualsDouble()
        {
            var message = "Are equals";
            double value = 5;
            int compared = (int)value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10d, 5, PropertyName, message)
                .AreNotEquals(5d, 10, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsBetween()
        {
            int value = 11;
            int from = 1;
            int to = 10;
            var wrong = new ValidationContract()
                .IsBetween(value, from, to, PropertyName, "The value 11 must be between 1 and 10");
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 5;
            from = 1;
            to = 10;
            var right = new ValidationContract()
                .IsBetween(value, from, to, PropertyName, "The value 5 is between 1 and 10");
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Int")]
        public void IsNotNullOrNullable()
        {
            var value = new int?();
            var wrong = new ValidationContract()
                .IsNotNullOrNullable(value, PropertyName, "The int is required");
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            int? valueNull = null;
            var wrongNull = new ValidationContract()
                .IsNotNullOrNullable(valueNull, PropertyName, "The int is required");
            Assert.False(wrongNull.IsValid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);

            var right = new ValidationContract()
                .IsNotNullOrNullable((int?)3.5F, PropertyName, "The int is required");
            Assert.True(right.IsValid);
        }
    }
}