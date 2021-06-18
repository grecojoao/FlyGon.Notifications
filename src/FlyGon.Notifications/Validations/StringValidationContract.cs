using System;
using System.Text.RegularExpressions;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is not null or empty'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the string is not null or empty.
        /// If the value is null or empty a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotNullOrEmpty(string value, string property, string message)
        {
            if (string.IsNullOrEmpty(value))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is not null, empty, or blanks'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the string is not null, empty, or whitespace.
        /// If the value is null, empty or blanks a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotNullOrWhiteSpace(string value, string property, string message)
        {
            if (string.IsNullOrWhiteSpace(value))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is null or empty'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string is null or empty.
        /// If the value is not null or empty a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNullOrEmpty(string value, string property, string message)
        {
            if (!string.IsNullOrEmpty(value))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'has minimum lenght'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="min">Lenght to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the string has at least 'n' characters.
        /// If the value has a character length shorter than specified, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract HasMinLen(string value, int min, string property, string message)
        {
            if (string.IsNullOrEmpty(value) || value.Length < min)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'has maximum lenght'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="max">Lenght to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string has up to 'n' characters.
        /// If the value has a character length greater than that specified, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract HasMaxLen(string value, int max, string property, string message)
        {
            if (string.IsNullOrEmpty(value) || value.Length > max)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'has lenght of'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="len">Lenght to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the string has 'n' characters.
        /// If the value has a character length shorter or longer than specified, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract HasLen(string value, int len, string property, string message)
        {
            if (string.IsNullOrEmpty(value) || value.Length != len)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'contains certain text'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="text">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string contains certain text.
        /// If the value does not contain the specified text, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract Contains(string value, string text, string property, string message)
        {
            if (!value.Contains(text))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="text">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string is equal to another.
        /// If the value is not equal, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(string value, string text, string property, string message,
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (!string.Equals(value, text, comparisonType))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="text">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string is not the same as another.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(string value, string text, string property, string message,
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            if (string.Equals(value, text, comparisonType))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'has a certain pattern'.
        /// </summary>
        /// <param name="text">Value to be validated.</param>
        /// <param name="pattern">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text has a certain pattern.
        /// If the value does not meet the certain pattern, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract Matchs(string text, string pattern, string property, string message)
        {
            if (!Regex.IsMatch(text ?? "", pattern))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is digit'.
        /// </summary>
        /// <param name="text">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that a text contains only digits.
        /// If the value does not contain only digits a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsDigit(string text, string property, string message)
        {
            const string pattern = @"^\d+$";
            return Matchs(text, pattern, property, message);
        }

        /// <summary>
        /// String validation: 'has minimum lenght or is null or empty'.
        /// </summary>
        /// <param name="text">Value to be validated.</param>
        /// <param name="min">Lenght to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string has at least 'n' characters or if it is null or empty.
        /// Use when the parameter is optional.
        /// If the value has a character length shorter than specified and is not null or empty, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract HasMinLenOrIsNullOrEmpty(string text, int min, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length < min)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'has maximum lenght or is null or empty'.
        /// </summary>
        /// <param name="text">Value to be validated.</param>
        /// <param name="max">Lenght to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string has up to 'n' characters or if it is null or empty.
        /// Use when the parameter is optional.
        /// If the value has a character length greater than that specified and is not null or empty, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract HasMaxLenOrIsNullOrEmpty(string text, int max, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length > max)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'has lenght of, or null or empty'.
        /// </summary>
        /// <param name="text">Value to be validated.</param>
        /// <param name="len">Lenght to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the string has 'n' characters or if it is null or empty.
        /// Use when the parameter is optional.
        /// If the value has a character length shorter or longer than specified and is not null or empty, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract HasLenOrIsNullOrEmpty(string text, int len, string property, string message)
        {
            if (!string.IsNullOrEmpty(text) && text.Length != len)
                AddNotification(property, message);
            return this;
        }
    }
}