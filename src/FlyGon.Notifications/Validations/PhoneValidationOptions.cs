namespace FlyGon.Notifications.Validations
{
    internal class PhoneValidationOptions
    {
        public bool StrictNineDigit { get; set; }
        public bool CellPhonesOnly { get; set; }
        public string Format { get; set; }
    }
}