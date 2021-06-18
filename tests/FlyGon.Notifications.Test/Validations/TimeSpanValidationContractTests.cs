using FlyGon.Notifications.Validations;
using NUnit.Framework;
using System;

namespace FlyGon.Notifications.Test.Validations
{
    class TimeSpanContractTests
    {
        private const string Property = "TimeSpan";
        private TimeSpan _timeSpan;

        [Test]
        [Category("Validations/TimeSpan")]
        public void IsGreaterThan()
        {
            var message = "TimeSpan 1 should be greater than TimeSpan 2";
            _timeSpan = new TimeSpan(0, 23, 54, 0);
            var wrong = new ValidationContract()
                .IsGreaterThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(10)), Property, message)
                .IsGreaterThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(10)), Property, message)
                .IsGreaterThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(10)), Property, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "TimeSpan 1 is not greater than TimeSpan 2";
            var right = new ValidationContract()
                .IsGreaterThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(-10)), Property, message)
                .IsGreaterThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(-10)), Property, message)
                .IsGreaterThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(-10)), Property, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/TimeSpan")]
        public void IsGreaterOrEqualsThan()
        {
            var message = "TimeSpan 1 should be greater or equals than TimeSpan 2";
            _timeSpan = new TimeSpan(0, 23, 54, 0);
            var wrong = new ValidationContract()
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(10)), Property, message)
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(10)), Property, message)
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(10)), Property, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "TimeSpan 1 is not greater or equals than TimeSpan 2";
            var right = new ValidationContract()
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(-10)), Property, message)
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(-10)), Property, message)
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(-10)), Property, message)
                .IsGreaterOrEqualsThan(_timeSpan, _timeSpan, Property, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/TimeSpan")]
        public void IsLowerThan()
        {
            var message = "TimeSpan 1 should be lower than TimeSpan 2";
            _timeSpan = new TimeSpan(0, 23, 54, 0);
            var wrong = new ValidationContract()
                .IsLowerThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(-10)), Property, message)
                .IsLowerThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(-10)), Property, message)
                .IsLowerThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(-10)), Property, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "TimeSpan 1 is not lower than TimeSpan 2";
            var right = new ValidationContract()
                .IsLowerThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(10)), Property, message)
                .IsLowerThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(10)), Property, message)
                .IsLowerThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(10)), Property, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/TimeSpan")]
        public void IsLowerOrEqualsThan()
        {
            var message = "TimeSpan 1 should be lower or equals than TimeSpan 2";
            _timeSpan = new TimeSpan(0, 23, 54, 0);
            var wrong = new ValidationContract()
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(-10)), Property, message)
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(-10)), Property, message)
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(-10)), Property, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            message = "TimeSpan 1 is not lower or equals than TimeSpan 2";
            var right = new ValidationContract()
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMilliseconds(10)), Property, message)
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromSeconds(10)), Property, message)
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan.Add(TimeSpan.FromMinutes(10)), Property, message)
                .IsLowerOrEqualsThan(_timeSpan, _timeSpan, Property, message);
            Assert.True(right.IsValid);
        }

        [Test]
        [Category("Validations/TimeSpan")]
        public void IsBetween()
        {
            _timeSpan = new TimeSpan(0, 23, 54, 0);
            var start = new TimeSpan(0, 23, 56, 0);
            var end = new TimeSpan(0, 23, 59, 0);
            var wrong = new ValidationContract()
                .IsBetween(_timeSpan, start, end, Property, "TimeSpan should be between start and end");
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);

            start = new TimeSpan(0, 23, 0, 0);
            var right = new ValidationContract()
                .IsBetween(_timeSpan, start, end, Property, "TimeSpan should be between start and end");
            Assert.True(right.IsValid);
        }
    }
}