namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// Object validation: 'is null'.
        /// </summary>
        /// <param name="obj">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the object is null.
        /// If the object is not null a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNull(object obj, string property, string message)
        {
            if (obj != null)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Object validation: 'is not null'.
        /// </summary>
        /// <param name="obj">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that the object is not null.
        /// If the object is null a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNotNull(object obj, string property, string message)
        {
            if (obj == null)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Object validation: 'are equals'.
        /// </summary>
        /// <param name="obj">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the object is equal to the other.
        /// It is necessary to override the 'Equals' method of the object.
        /// If the object is not the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreEquals(object obj, object compared, string property, string message)
        {
            if (!obj.Equals(compared))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// Object validation: 'are not equals'.
        /// </summary>
        /// <param name="obj">Value to be validated.</param>
        /// <param name="compared">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if the object is not the same as the other.
        /// It is necessary to override the 'Equals' method of the object.
        /// If the object is the same, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract AreNotEquals(object obj, object compared, string property, string message)
        {
            if (obj.Equals(compared))
                AddNotification(property, message);
            return this;
        }
    }
}