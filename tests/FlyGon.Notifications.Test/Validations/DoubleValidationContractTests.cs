using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class DoubleContractTests
    {
        private const string PropertyName = "double";

        [Test]
        [Category("Validations/Double")]
        public void IsGreaterThanDouble()
        {
            var message = "Value is not greater than compared";
            double value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1d, 1d, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsGreaterThanDecimal()
        {
            var message = "Value is not greater than compared";
            decimal value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1M, 1d, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsGreaterThanInt()
        {
            var message = "Value is not greater than compared";
            int value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message)
                .IsGreaterThan(1, 1d, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 10;
            compared = 5;
            var right = new ValidationContract()
                .IsGreaterThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsGreaterOrEqualsThanDouble()
        {
            var message = "Value is not greater or equals than compared";
            double value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10d, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsGreaterOrEqualsThanDecimal()
        {
            var message = "Value is not greater or equals than compared";
            decimal value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (double)value;
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(value, compared, PropertyName, message)
                .IsGreaterOrEqualsThan(10M, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsGreaterOrEqualsThanInt()
        {
            var message = "Value is not greater or equals than compared";
            int value = 5;
            double compared = 10;
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
        [Category("Validations/Double")]
        public void IsLowerThanDouble()
        {
            var message = "Value is not lower than compared";
            double value = 10;
            double compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1d, 1d, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsLowerThanDecimal()
        {
            var message = "Value is not lower than compared";
            decimal value = 10;
            double compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1M, 1d, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsLowerThanInt()
        {
            var message = "Value is not lower than compared";
            int value = 10;
            double compared = 5;
            var wrong = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message)
                .IsLowerThan(1, 1d, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            value = 5;
            compared = 10;
            var right = new ValidationContract()
                .IsLowerThan(value, compared, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsLowerOrEqualsThanDouble()
        {
            var message = "Value is not lower or equals than compared";
            double value = 10;
            double compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5d, 10d, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsLowerOrEqualsThanDecimal()
        {
            var message = "Value is not lower or equals than compared";
            decimal value = 10;
            double compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = (double)value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5M, 10d, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsLowerOrEqualsThanInt()
        {
            var message = "Value is not lower or equals than compared";
            int value = 10;
            double compared = 5;
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(value, compared, PropertyName, message)
                .IsLowerOrEqualsThan(5, 10d, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void AreEqualsDouble()
        {
            var message = "Are not equals";
            double value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10d, 5d, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void AreEqualsDecimal()
        {
            var message = "Are not equals";
            decimal value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10M, 5d, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = (double)value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void AreEqualsInt()
        {
            var message = "Are not equals";
            int value = 5;
            double compared = 10;
            var wrong = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message)
                .AreEquals(10, 5d, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(2, wrong.Notifications.Count);

            compared = value;
            var right = new ValidationContract()
                .AreEquals(value, compared, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void AreNotEqualsDouble()
        {
            var message = "Are equals";
            double value = 5;
            double compared = value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10d, 5d, PropertyName, message)
                .AreNotEquals(5d, 10d, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void AreNotEqualsDecimal()
        {
            var message = "Are equals";
            decimal value = 5;
            double compared = (double)value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10M, 5d, PropertyName, message)
                .AreNotEquals(5M, 10d, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void AreNotEqualsInt()
        {
            var message = "Are equals";
            int value = 5;
            double compared = value;
            var wrong = new ValidationContract()
                .AreNotEquals(value, compared, PropertyName, message);
            Assert.IsTrue(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            var right = new ValidationContract()
                .AreNotEquals(10, 5d, PropertyName, message)
                .AreNotEquals(5, 10d, PropertyName, message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsBetween()
        {
            double value = 49.999;
            double from = 50.000;
            double to = 59.999;
            var wrong = new ValidationContract()
                .IsBetween(value, from, to, PropertyName, "The value 49.999 must be between 50.000 and 59.999");
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            value = 1250.01;
            from = 1250.00;
            to = 1299.99;
            var right = new ValidationContract()
                .IsBetween(value, from, to, PropertyName, "The value 1250.01 is between 1000.01 and 1299.99");
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/Double")]
        public void IsNullOrNullable()
        {
            var message = "The double is required";
            var value = new double?();
            var wrong = new ValidationContract()
                .IsNotNullOrNullable(value, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            double? valueNull = null;
            var wrongNull = new ValidationContract()
                .IsNotNullOrNullable(valueNull, PropertyName, message);
            Assert.True(wrongNull.IsInvalid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);

            var right = new ValidationContract()
                .IsNotNullOrNullable(1.7E+3, PropertyName, message);
            Assert.True(right.IsValid);
        }
    }
}