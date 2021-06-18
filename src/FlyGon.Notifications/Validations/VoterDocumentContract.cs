using System.Text.RegularExpressions;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is voter document'.
        /// </summary>
        /// <param name="document">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid voter document.
        /// If the value is not a valid voter document, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsVoterDocument(string document, string property, string message)
        {
            if (string.IsNullOrEmpty(document) || !ValidateVoterDocument(document))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateVoterDocument(string document)
        {
            int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, DV1, DV2, UltDig;
            document = new Regex(@"['\""&,\\]|\s{2,}").Replace(document, "").Trim();
            if (!new Regex(@"[0-9]+").IsMatch(document)) return false;
            if ((document.Length < 12))
                document = document.PadLeft(12 - document.Length, '0');

            UltDig = document.Length;
            if (document == "000000000000")
                return false;

            d1 = int.Parse(document.Substring(UltDig - 12, 1));
            d2 = int.Parse(document.Substring(UltDig - 11, 1));
            d3 = int.Parse(document.Substring(UltDig - 10, 1));
            d4 = int.Parse(document.Substring(UltDig - 9, 1));
            d5 = int.Parse(document.Substring(UltDig - 8, 1));
            d6 = int.Parse(document.Substring(UltDig - 7, 1));
            d7 = int.Parse(document.Substring(UltDig - 6, 1));
            d8 = int.Parse(document.Substring(UltDig - 5, 1));
            d9 = int.Parse(document.Substring(UltDig - 4, 1));
            d10 = int.Parse(document.Substring(UltDig - 3, 1));
            d11 = int.Parse(document.Substring(UltDig - 2, 1));
            d12 = int.Parse(document.Substring(UltDig - 1, 1));
            DV1 = ((d1 * 2)
                        + ((d2 * 3)
                        + ((d3 * 4)
                        + ((d4 * 5)
                        + ((d5 * 6)
                        + ((d6 * 7)
                        + ((d7 * 8)
                        + (d8 * 9))))))));
            DV1 %= 11;

            if ((DV1 == 10))
                DV1 = 0;

            DV2 = ((d9 * 7)
                        + ((d10 * 8)
                        + (DV1 * 9)));
            DV2 %= 11;
            if ((DV2 == 10))
                DV2 = 0;

            if ((d11 == DV1) && (d12 == DV2))
            {
                if ((d9 + d10) > 0 && (d9 + d10) < 29)
                    return true;
                return false;
            }
            return false;
        }
    }
}