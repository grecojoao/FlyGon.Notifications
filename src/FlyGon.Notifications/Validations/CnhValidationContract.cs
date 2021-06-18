using System;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is CNH'.
        /// </summary>
        /// <param name="cnh">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid CNH.
        /// If the value is not a valid CNH, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCnh(string cnh, string property, string message)
        {
            if (string.IsNullOrEmpty(cnh) || !ValidateCnh(cnh))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateCnh(string cnh)
        {
            bool isvalueid = false;
            var Cnh = cnh;

            if (Cnh.Length == 11 && Cnh != new string('1', 11))
            {
                var dsc = 0;
                var v = 0;

                for (int i = 0, j = 9; i < 9; i++, j--)
                    v += (Convert.ToInt32(Cnh[i].ToString()) * j);

                var vl1 = v % 11;

                if (vl1 >= 10)
                {
                    vl1 = 0;
                    dsc = 2;
                }

                v = 0;

                for (int i = 0, j = 1; i < 9; ++i, ++j)
                    v += (Convert.ToInt32(Cnh[i].ToString()) * j);

                var x = v % 11;
                var vl2 = (x >= 10) ? 0 : x - dsc;

                isvalueid = vl1.ToString() + vl2.ToString() == Cnh.Substring(Cnh.Length - 2, 2);
            }
            return isvalueid;
        }
    }
}