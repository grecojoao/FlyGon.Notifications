using FlyGon.Notifications.Validations;
using NUnit.Framework;
using System;

namespace FlyGon.Notifications.Test.Validations
{
    class DateTimeContractTests
    {
        private const string PropertyName = "DateTime";
        private DateTime _date;

        [Test]
        [Category("Validations/DateTime")]
        public void IsGreaterThan()
        {
            var message = "Date 1 should be greater than Date 2";
            _date = new DateTime(2021, 5, 15, 16, 0, 0);
            var wrong = new ValidationContract()
                .IsGreaterThan(_date, _date.AddMilliseconds(1), PropertyName, message)
                .IsGreaterThan(_date, _date.AddSeconds(1), PropertyName, message)
                .IsGreaterThan(_date, _date.AddMinutes(1), PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "Date 1 is not greater than Date 2";
            var right = new ValidationContract()
                .IsGreaterThan(_date, _date.AddMilliseconds(-2), PropertyName, message)
                .IsGreaterThan(_date, _date.AddSeconds(-2), PropertyName, message)
                .IsGreaterThan(_date, _date.AddMinutes(-2), PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/DateTime")]
        public void IsGreaterOrEqualsThan()
        {
            var message = "Date 1 should be greater than Date 2";
            _date = new DateTime(2021, 1, 1, 12, 0, 0);
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(_date, _date.AddMilliseconds(1), PropertyName, message)
                .IsGreaterOrEqualsThan(_date, _date.AddSeconds(1), PropertyName, message)
                .IsGreaterOrEqualsThan(_date, _date.AddMinutes(1), PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "Date 1 is not greater or equals than Date 2";
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(_date, _date, PropertyName, message)
                .IsGreaterOrEqualsThan(_date, _date.AddMilliseconds(-1), PropertyName, message)
                .IsGreaterOrEqualsThan(_date, _date.AddSeconds(-1), PropertyName, message)
                .IsGreaterOrEqualsThan(_date, _date.AddMinutes(-1), PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/DateTime")]
        public void IsLowerThan()
        {
            var message = "Date 1 should be lower than Date 2";
            _date = new DateTime(2021, 9, 26, 15, 0, 0);
            var wrong = new ValidationContract()
                .IsLowerThan(_date, _date.AddMilliseconds(-1), PropertyName, message)
                .IsLowerThan(_date, _date.AddSeconds(-1), PropertyName, message)
                .IsLowerThan(_date, _date.AddMinutes(-1), PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "Date 1 is not lower than Date 2";
            var right = new ValidationContract()
                .IsLowerThan(_date, _date.AddMilliseconds(1), PropertyName, message)
                .IsLowerThan(_date, _date.AddSeconds(1), PropertyName, message)
                .IsLowerThan(_date, _date.AddMinutes(1), PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/DateTime")]
        public void IsLowerOrEqualsThan()
        {
            var message = "Date 1 should be lower or equals than Date 2";
            _date = new DateTime(2021, 5, 15, 16, 0, 0);
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(_date, _date.AddMilliseconds(-1), PropertyName, message)
                .IsLowerOrEqualsThan(_date, _date.AddSeconds(-1), PropertyName, message)
                .IsLowerOrEqualsThan(_date, _date.AddMinutes(-1), PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "Date 1 is not lower or equals than Date 2";
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(_date, _date, PropertyName, message)
                .IsLowerOrEqualsThan(_date, _date.AddMilliseconds(1), PropertyName, message)
                .IsLowerOrEqualsThan(_date, _date.AddSeconds(1), PropertyName, message)
                .IsLowerOrEqualsThan(_date, _date.AddMinutes(1), PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/DateTime")]
        public void IsBetween()
        {
            var message = "The date is not between";
            var startDate = new DateTime(2021, 01, 01);
            var endDate = new DateTime(2021, 01, 10);
            _date = new DateTime(2021, 01, 5);
            var wrong = new ValidationContract()
                .IsBetween(DateTime.Now, startDate, endDate, PropertyName, message);
            Assert.True(wrong.IsInvalid);

            var right = new ValidationContract()
                .IsBetween(_date, startDate, endDate, PropertyName, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/DateTime")]
        public void IsNullOrNullable()
        {
            var message = "The date is required";
            var date = new DateTime?();
            var wrong = new ValidationContract()
                .IsNotNullOrNullable(date, PropertyName, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            DateTime? dateNull = null;
            var wrongNull = new ValidationContract()
                .IsNotNullOrNullable(dateNull, PropertyName, message);
            Assert.True(wrongNull.IsInvalid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);

            var right = new ValidationContract()
                .IsNotNullOrNullable(new DateTime(2021, 10, 30), PropertyName, message);
            Assert.True(right.IsValid);
        }
    }
}