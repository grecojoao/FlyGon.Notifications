using System.Linq;
using System.Text.RegularExpressions;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is credit card'.
        /// </summary>
        /// <param name="creditcard">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that a text is a valid credit card.
        /// If the value is not a valid credit card, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCreditCard(string creditcard, string property, string message)
        {
            if (string.IsNullOrEmpty(creditcard) || string.IsNullOrWhiteSpace(creditcard) || !ValidateCreditCard(creditcard))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateCreditCard(string creditcard)
        {
            creditcard = Regex.Replace(creditcard, @"[^0-9]+", "");

            bool even = false;
            int checksum = 0;

            foreach (char digit in creditcard.ToCharArray().Reverse())
            {
                if (!char.IsDigit(digit))
                    return false;

                int valueue = (digit - '0') * (even ? 2 : 1);
                even = !even;

                while (valueue > 0)
                {
                    checksum += valueue % 10;
                    valueue /= 10;
                }
            }

            if (checksum % 10 != 0)
                return false;
            return true;
        }
    }
}