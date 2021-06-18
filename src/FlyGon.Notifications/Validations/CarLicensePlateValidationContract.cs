using System.Text.RegularExpressions;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is car license plate'.
        /// </summary>
        /// <param name="plate">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that a text is a valid license plate.
        /// If the value is not a valid license plate, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCarLicensePlate(string plate, string property, string message)
        {
            if (string.IsNullOrEmpty(plate) || !ValidateCarLicensePlate(plate))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateCarLicensePlate(string plate)
        {
            return (plate.Length == 7 || plate.Length == 8) &&
                new Regex(@"[A-Z]{3}\-?[0-9][A-Z0-9][0-9]{2}", RegexOptions.Singleline).Match(plate).Success;
        }

        /// <summary>
        /// String validation: 'is Mercosul car license plate'.
        /// </summary>
        /// <param name="plate">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a license plate in Mercosur pattern.
        /// If the value is not a Mercosur license plate, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsMercosulCarLicensePlate(string plate, string property, string message)
        {
            if (string.IsNullOrEmpty(plate) || !ValidateMercosulCarLicensePlate(plate))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateMercosulCarLicensePlate(string plate)
        {
            return (plate.Length == 7 || plate.Length == 8) &&
                new Regex(@"[A-Z]{3}\-?[0-9][A-Z][0-9]{2}", RegexOptions.Singleline).Match(plate).Success;
        }

        /// <summary>
        /// String validation: 'is old car license plate'.
        /// </summary>
        /// <param name="plate">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a license plate in the old pattern.
        /// If the value is not a license plate in the old pattern a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsOldCarLicensePlate(string plate, string property, string message)
        {
            if (string.IsNullOrEmpty(plate) || !ValidateOldCarLicensePlate(plate))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateOldCarLicensePlate(string plate)
        {
            return (plate.Length == 7 || plate.Length == 8) &&
                new Regex(@"[A-Z]{3}\-?[0-9]{4}", RegexOptions.Singleline).Match(plate).Success;
        }
    }
}