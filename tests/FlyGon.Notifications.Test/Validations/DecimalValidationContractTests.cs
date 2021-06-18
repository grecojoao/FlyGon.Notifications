using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class DecimalContractTests
    {
        private const string PropertyName = "decimal";

        [Test]
        [Category("Validations/Decimal")]
        public void IsGreaterThanDecimal()
        {
            var message = "Value is not greater than compared";
            decimal value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1M, 1M, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsGreaterThanDouble()
        {
            var message = "Value is not greater than compared";
            double value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1d, 1M, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsGreaterThanInt()
        {
            var message = "Value is not greater than compared";
            int value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1, 1M, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsGreaterOrEqualsThanDecimal()
        {
            var message = "Value is not greater or equals than compared";
            decimal value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10M, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsGreaterOrEqualsThanDouble()
        {
            var message = "Value is not greater or equals than compared";
            double value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (decimal)value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10d, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsGreaterOrEqualsThanInt()
        {
            var message = "Value is not greater or equals than compared";
            int value = 5;
            decimal compared = 10;
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
        [Category("Validations/Decimal")]
        public void IsLowerThanDecimal()
        {
            var message = "Value is not lower than compared";
            decimal value = 10;
            decimal compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1M, 1M, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsLowerThanDouble()
        {
            var message = "Value is not lower than compared";
            double value = 10;
            decimal compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1d, 1M, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsLowerThanInt()
        {
            var message = "Value is not lower than compared";
            int value = 10;
            decimal compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1, 1M, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsLowerOrEqualsThanDecimal()
        {
            var message = "Value is not lower or equals than compared";
            decimal value = 10;
            decimal compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5M, 10M, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsLowerOrEqualsThanDouble()
        {
            var message = "Value is not lower or equals than compared";
            double value = 10;
            decimal compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (decimal)value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5d, 10m, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsLowerOrEqualsThanInt()
        {
            var message = "Value is not lower or equals than compared";
            int value = 10;
            decimal compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5, 10M, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void AreEqualsDecimal()
        {
            var message = "Are not equals";
            decimal value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10M, 5M, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void AreEqualsDouble()
        {
            var message = "Are not equals";
            double value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10d, 5M, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = (decimal)value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void AreEqualsInt()
        {
            var message = "Are not equals";
            int value = 5;
            decimal compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10, 5M, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void AreNotEqualsDecimal()
        {
            var message = "Are equals";
            decimal value = 5;
            decimal compared = value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10M, 5M, PropertyName, message)
                .AreNotEquals(5M, 10M, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void AreNotEqualsDouble()
        {
            var message = "Are equals";
            double value = 5;
            decimal compared = (decimal)value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10d, 5M, PropertyName, message)
                .AreNotEquals(5d, 10M, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void AreNotEqualsInt()
        {
            var message = "Are equals";
            int value = 5;
            decimal compared = value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10, 5M, PropertyName, message)
                .AreNotEquals(5, 10M, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsBetween()
        {
            decimal value = -1.01M;
            decimal from = 1.01M;
            decimal to = 10;
            var wrong = new ValidationContract()
                .IsBetween(value, from, to, PropertyName, "The value -1.01 must be between 1.01 and 10");
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 1.015M;
            from = 1.01M;
            to = 1.02M;
            var right = new ValidationContract()
                .IsBetween(value, from, to, PropertyName, "The value 1.015 is between 1.01 and 1.02");
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Decimal")]
        public void IsNotNullOrNullable()
        {
            var message = "The decimal is required";
            var wrong = new ValidationContract()
                .IsNotNullOrNullable(new decimal?(), PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsNotNullOrNullable(10m, PropertyName, message);
            Assert.True(right.IsValid);
        }
    }
}