namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is email'.
        /// </summary>
        /// <param name="email">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid email.
        /// If the value is not a valid email, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsEmail(string email, string property, string message)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Matchs(email, pattern, property, message);
        }

        /// <summary>
        /// String validation: 'is email or empty'.
        /// </summary>
        /// <param name="email">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid or empty email.
        /// Use when email is optional.
        /// If the value is not a valid email, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsEmailOrEmpty(string email, string property, string message)
        {
            if (string.IsNullOrEmpty(email))
                return this;
            return IsEmail(email, property, message);
        }
    }
}