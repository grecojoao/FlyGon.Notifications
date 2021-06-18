﻿namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        #region IsGreaterThan

        /// <summary>
        /// Int validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is greater than another.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(int value, int compared, string property, string message)
        {
            if (value <= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - int validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is greater than an int value.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(decimal value, int compared, string property, string message)
        {
            if ((double)value <= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Double - int validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated (double).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is greater than an int value.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(double value, int compared, string property, string message)
        {
            if (value <= compared)
                AddNotification(property, message);
            return this;
        }

        #endregion

        #region IsGreaterOrEqualsThan

        /// <summary>
        /// Int validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is greater than or equal to another.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(int value, int compared, string property, string message)
        {
            if (value < compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - int validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is greater than or equal to an int value.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(decimal value, int compared, string property, string message)
        {
            if ((double)value < compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Double - int validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (double).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is greater than or equal to an int value.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(double value, int compared, string property, string message)
        {
            if (value < compared)
                AddNotification(property, message);
            return this;
        }

        #endregion

        #region IsLowerThan

        /// <summary>
        /// Int validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is lower than another.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(int value, int compared, string property, string message)
        {
            if (value >= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - int validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is lower than an int value.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(decimal value, int compared, string property, string message)
        {
            if ((double)value >= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Double - int validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated (double).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is lower than an int value.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(double value, int compared, string property, string message)
        {
            if (value >= compared)
                AddNotification(property, message);
            return this;
        }

        #endregion

        #region IsLowerOrEqualsThan

        /// <summary>
        /// Int validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is lower than or equal to another.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(int value, int compared, string property, string message)
        {
            if (value > compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - int validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is lower than or equal to an int value.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(decimal value, int compared, string property, string message)
        {
            if ((double)value > compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Double - int validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (double).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is lower than or equal to an int value.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(double value, int compared, string property, string message)
        {
            if (value > compared)
                AddNotification(property, message);
            return this;
        }

        #endregion

        #region AreEquals

        /// <summary>
        /// Int validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is equal to another.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(int value, int compared, string property, string message)
        {
            if (value != compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - int validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the decimal value is equal to an int value.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(decimal value, int compared, string property, string message)
        {
            if ((double)value != compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Double - int validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated (double).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the double value is equal to an int value.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(double value, int compared, string property, string message)
        {
            if (value != compared)
                AddNotification(property, message);
            return this;
        }

        #endregion

        #region AreNotEquals

        /// <summary>
        /// Int validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is not equal to another.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(int value, int compared, string property, string message)
        {
            if (value == compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - int validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the decimal value is not equal to an int value.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(decimal value, int compared, string property, string message)
        {
            if ((double)value == compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Double - int validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated (double).</param>
        /// <param name="compared">Value to be compared (int).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the double value is not equal to an int value.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(double value, int compared, string property, string message)
        {
            if (value == compared)
                AddNotification(property, message);
            return this;
        }

        #endregion

        #region Between    

        /// <summary>
        /// Int validation: 'is between'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="from">Value to be compared 'from'.</param>
        /// <param name="to">Value to be compared 'to'.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is between two other values.
        /// If the value is not within the range, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsBetween(int value, int from, int to, string property, string message)
        {
            if (!(value >= from && value <= to))
                AddNotification(property, message);
            return this;
        }

        #endregion

        /// <summary>
        /// Int validation: 'is not null'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the int value is not null.
        /// If the value is null a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotNullOrNullable(int? value, string property, string message)
        {
            if (value == null || !value.HasValue)
                AddNotification(property, message);
            return this;
        }
    }
} 