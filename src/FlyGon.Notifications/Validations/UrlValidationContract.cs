namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is url'.
        /// </summary>
        /// <param name="url">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that a text is a valid url.
        /// If the value is not a valid url a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsUrl(string url, string property, string message)
        {
            const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
            return Matchs(url, pattern, property, message);
        }

        /// <summary>
        /// String validation: 'is url or empty'.
        /// </summary>
        /// <param name="url">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid or empty url.
        /// Use when url is optional.
        /// If the value is not a valid url a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsUrlOrEmpty(string url, string property, string message)
        {
            if (string.IsNullOrEmpty(url))
                return this;
            return IsUrl(url, property, message);
        }
    }
}