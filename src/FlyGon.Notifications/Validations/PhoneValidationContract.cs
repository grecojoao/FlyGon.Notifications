namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is phone'.
        /// </summary>
        /// <param name="phone">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate that a text is a valid phone.
        /// If the value is not a valid phone, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsPhone(string phone, string property, string message)
        {
            if (string.IsNullOrEmpty(phone) || !new PhoneValidation()
                .Validate(phone))
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is phone or empty'.
        /// </summary>
        /// <param name="phone">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid or empty phone.
        /// Use when phone is optional.
        /// If the value is not a valid phone, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsPhoneOrEmpty(string phone, string property, string message)
        {
            if (string.IsNullOrEmpty(phone))
                return this;
            return IsPhone(phone, property, message);
        }

        /// <summary>
        /// String validation: 'is phone in a certain pattern'.
        /// </summary>
        /// <param name="phone">Value to be validated.</param>
        /// <param name="numberFormat">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <param name="strictNineDigit">Optional parameter, must be informed as 'true' when there is a need to take into account the ninth digit.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid phone in a certain pattern.
        /// If the value is not a valid phone in the certain pattern, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsPhone(string phone, string numberFormat, string property, string message,
            bool strictNineDigit = false)
        {
            var result = new PhoneValidation(new PhoneValidationOptions { Format = numberFormat, StrictNineDigit = strictNineDigit })
                .Validate(phone);
            if (string.IsNullOrEmpty(phone) || !result)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is phone in certain pattern or empty'.
        /// </summary>
        /// <param name="phone">Value to be validated.</param>
        /// <param name="numberFormat">Value to be compared.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <param name="strictNineDigit">Optional parameter, must be informed as 'true' when there is a need to take into account the ninth digit.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid phone in a certain pattern or empty.
        /// Use when phone is optional.
        /// If the value is not a valid phone in the certain pattern, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsPhoneOrEmpty(string phone, string numberFormat, string property, string message,
            bool strictNineDigit = false)
        {
            if (string.IsNullOrEmpty(phone))
                return this;
            return IsPhone(phone, numberFormat, property, message, strictNineDigit);
        }

        /// <summary>
        /// String validation: 'is cell phone'.
        /// </summary>
        /// <param name="cellphone">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <param name="strictNineDigit">Optional parameter, must be informed as 'true' when there is a need to take into account the ninth digit.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid cell phone.
        /// If the value is not a valid cell phone, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCellPhone(string cellphone, string property, string message,
            bool strictNineDigit = false)
        {
            var result = new PhoneValidation(new PhoneValidationOptions { StrictNineDigit = strictNineDigit, CellPhonesOnly = true })
                .Validate(cellphone);
            if (string.IsNullOrEmpty(cellphone) || !result)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is cell phone or empty'.
        /// </summary>
        /// <param name="cellphone">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <param name="strictNineDigit">Optional parameter, must be informed as 'true' when there is a need to take into account the ninth digit.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid or empty cell phone.
        /// Use when cell phone is optional.
        /// If the value is not a valid cell phone, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCellPhoneOrEmpty(string cellphone, string property, string message,
            bool strictNineDigit = false)
        {
            if (string.IsNullOrEmpty(cellphone))
                return this;
            return IsCellPhone(cellphone, property, message, strictNineDigit);
        }

        /// <summary>
        /// String validation: 'is cell phone in the new Brazilian pattern'.
        /// </summary>
        /// <param name="cellphone">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid cell phone in the new Brazilian pattern.
        /// If the value is not a valid cell phone in the new Brazilian pattern, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNewFormatCellPhone(string cellphone, string property, string message)
        {
            var result = new PhoneValidation(new PhoneValidationOptions { StrictNineDigit = true, CellPhonesOnly = true })
                .Validate(cellphone);
            if (string.IsNullOrEmpty(cellphone) || !result)
                AddNotification(property, message);
            return this;
        }

        /// <summary>
        /// String validation: 'is cell phone in the new Brazilian pattern or empty'.
        /// </summary>
        /// <param name="cellphone">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid cell phone in the new Brazilian pattern or empty.
        /// Use when cell phone is optional.
        /// If the value is not a valid cell phone in the new Brazilian pattern, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsNewFormatCellPhoneOrEmpty(string cellphone, string property, string message)
        {
            if (string.IsNullOrEmpty(cellphone))
                return this;
            return IsNewFormatCellPhone(cellphone, property, message);
        }
    }
}