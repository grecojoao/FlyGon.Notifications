using System.Text.RegularExpressions;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is CEP'.
        /// </summary>
        /// <param name="cep">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text has the pattern zip code.
        /// If the value does not have the zip code pattern, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCep(string cep, string property, string message)
        {
            if (string.IsNullOrEmpty(cep) || !ValidateCep(cep))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateCep(string cep)
        {
            if (cep.IndexOf("-") > 0)
                return new Regex(@"^\d{5}-\d{3}$", RegexOptions.Singleline).Match(cep).Success;
            return new Regex(@"^\d{8}$", RegexOptions.Singleline).Match(cep).Success;
        }
    }
}