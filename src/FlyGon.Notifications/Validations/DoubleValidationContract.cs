namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        #region IsGreaterThan

        /// <summary>
        /// Double validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is greater than another.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(double value, double compared, string property, string message)
        {
            if (value <= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - double validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is greater than a double value.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(decimal value, double compared, string property, string message)
        {
            if ((double)value <= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Int - double validation: 'is greater than'.
        /// </summary>
        /// <param name="value">Value to be validated (int).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is greater than a double value.
        /// If the value is lower than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterThan(int value, double compared, string property, string message)
        {
            if (value <= compared)
                AddNotification(property, message);
            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan

        /// <summary>
        /// Double validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is greater than or equal to another.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(double value, double compared, string property, string message)
        {
            if (value < compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - double validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is greater than or equal to a double value.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(decimal value, double compared, string property, string message)
        {
            if ((double)value < compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Int - double validation: 'is greater than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (int).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is greater than or equal to a double value.
        /// If the value is lower, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsGreaterOrEqualsThan(int value, double compared, string property, string message)
        {
            if (value < compared)
                AddNotification(property, message);
            return this;
        }

        #endregion IsGreaterOrEqualsThan

        #region IsLowerThan

        /// <summary>
        /// Double validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is lower than another.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(double value, double compared, string property, string message)
        {
            if (value >= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - double validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is lower than a double value.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(decimal value, double compared, string property, string message)
        {
            if ((double)value >= compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Int - double validation: 'is lower than'.
        /// </summary>
        /// <param name="value">Value to be validated (int).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is lower than a double value.
        /// If the value is greater than or equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerThan(int value, double compared, string property, string message)
        {
            if (value >= compared)
                AddNotification(property, message);
            return this;
        }

        #endregion IsLowerThan

        #region IsLowerOrEqualsThan

        /// <summary>
        /// Double validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is lower than or equal to another.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(double value, double compared, string property, string message)
        {
            if (value > compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - double validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the decimal value is lower than or equal to a double value.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(decimal value, double compared, string property, string message)
        {
            if ((double)value > compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Int - double validation: 'is lower than or equals'.
        /// </summary>
        /// <param name="value">Value to be validated (int).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the int value is lower than or equal to a double value.
        /// If the value is greater, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsLowerOrEqualsThan(int value, double compared, string property, string message)
        {
            if (value > compared)
                AddNotification(property, message);
            return this;
        }

        #endregion IsLowerOrEqualsThan

        #region AreEquals

        /// <summary>
        /// Double validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is equal to another.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(double value, double compared, string property, string message)
        {
            if (value != compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - double validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the decimal value is equal to a double value.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(decimal value, double compared, string property, string message)
        {
            if ((double)value != compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Int - double validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated (int).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the int value is equal to a double value.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(int value, double compared, string property, string message)
        {
            if (value != compared)
                AddNotification(property, message);
            return this;
        }

        #endregion AreEquals

        #region AreNotEquals

        /// <summary>
        /// Double validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is not equal to another.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(double value, double compared, string property, string message)
        {
            if (value == compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Decimal - double validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated (decimal).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the decimal value is not equal to a double value
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(decimal value, double compared, string property, string message)
        {
            if ((double)value == compared)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Int - double validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated (int).</param>
        /// <param name="compared">Value to be compared (double).</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the int value is not equal to a double value.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(int value, double compared, string property, string message)
        {
            if (value == compared)
                AddNotification(property, message);
            return this;
        }

        #endregion AreNotEquals

        #region Between

        /// <summary>
        /// Double validation: 'is between'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="from">Value to be compared 'from'.</param>
        /// <param name="to">Value to be compared 'to'.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the double value is between two other values.
        /// If the value is not within the range, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsBetween(double value, double from, double to, string property, string message)
        {
            if (!(value >= from && value <= to))
                AddNotification(property, message);
            return this;
        }

        #endregion Between

        /// <summary>
        /// Double validation: 'is not null'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the double value is not null.
        /// If the value is null a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotNullOrNullable(double? value, string property, string message)
        {
            if (value == null || !value.HasValue)
                AddNotification(property, message);
            return this;
        }
    }
}