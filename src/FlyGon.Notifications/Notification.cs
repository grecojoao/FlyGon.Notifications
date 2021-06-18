namespace FlyGon.Notifications
{
    /// <summary>
    /// Represents a validation error notification.
    /// </summary>
    /// <remarks>
    /// Use when you want to notify that a validation error has occurred.
    /// </remarks>
    public sealed class Notification
    {
        /// <summary>
        /// Property that caused the error.
        /// </summary>
        public string Property { get; private set; }

        /// <summary>
        /// Message describing the validation error that occurred.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Notification"/> passing the property name and error message parameters.
        /// </summary>
        /// <param name="property">Property name. See <seealso cref="Property"/></param>
        /// <param name="message">Custom error message. See <seealso cref="Message"/></param>
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }
    }
}