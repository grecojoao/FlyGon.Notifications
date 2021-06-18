using System;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// DateTime validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a DateTime is greater than another.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(DateTime value, DateTime compared, string property, string message)
        {
            if (value <= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// DateTime validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a DateTime is greater than or equal to another.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(DateTime value, DateTime compared, string property, string message)
        {
            if (value < compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// DateTime validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a DateTime is lower than another.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(DateTime value, DateTime compared, string property, string message)
        {
            if (value >= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// DateTime validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a DateTime is lower than or equal to another.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(DateTime value, DateTime compared, string property, string message)
        {
            if (value > compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// DateTime validation: 'is between'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="from">Value to be compared 'from'.</param>
        /// <param name="to">Value to be compared 'to'.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a DateTime is between two other values.
        /// If the value is not within the range, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsBetween(DateTime value, DateTime from, DateTime to, string property, string message)
        {
            if (!(value >= from && value <= to))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// DateTime validation: 'is not null'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that a DateTime is not null.
        /// If the value is null a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotNullOrNullable(DateTime? value, string property, string message)
        {
            if (value == null || !value.HasValue)
                AddNotification(property, message);
            return this;
        }
    }
}