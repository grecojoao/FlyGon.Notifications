using System;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// Guid validation: 'are equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the Guid is the same as another.
        /// If the value is not the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(Guid value, Guid compared, string property, string message)
        {
            if (value.ToString() != compared.ToString())
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Guid validation: 'are not equals'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the Guid is not the same as another.
        /// If the value is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(Guid value, Guid compared, string property, string message)
        {
            if (value.ToString() == compared.ToString())
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Guid validation: 'is empty'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the Guid is empty.
        /// If the value is not empty, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsEmpty(Guid value, string property, string message)
        {
            if (value != Guid.Empty)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Guid validation: 'is not empty'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the Guid is not empty.
        /// If the value is empty a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotEmpty(Guid value, string property, string message)
        {
            if (value == Guid.Empty)
                AddNotification(property, message);
            return this;
        }
    }
}