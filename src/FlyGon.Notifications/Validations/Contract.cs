namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract : Notifiable
    {
        /// <summary>
        /// Base class of validation contracts.
        /// </summary>
        /// <remarks>
        /// Use this class as a validation contract, validating cascading properties.
        /// </remarks>
        /// <example>
        /// Cascading Validation Example <see cref="ValidationContract"/>
        /// <code>
        ///     static void Validate()
        ///     {
        ///         var contract = new Contract()
        ///             .IsTrue(false, "Property", "Custom error message")
        ///             .IsEmail("mytestemail@gmail.com", "Email", "The email is not valid");
        ///     }
        /// </code>
        /// </example>
        public ValidationContract() { }
    }
}