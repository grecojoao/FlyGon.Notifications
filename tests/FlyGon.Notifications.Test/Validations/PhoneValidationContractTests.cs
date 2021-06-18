using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class PhoneValidationContractTests
    {
        private const string MessageCellphone = "Invalid Cellphone";
        private const string MessagePhone = "Invalid Phone";
        private const string PropertyName = "Phone";

        [Test]
        [TestCase("")]
        [TestCase("123456789")]
        [TestCase("(1323) 9999-9999")]
        [TestCase("(99) 1199999-9999")]
        [TestCase("(99)911999-9999")]
        [TestCase("(99)9956999-9999")]
        [TestCase("59-9999")]
        [TestCase("999-9999")]
        [TestCase("999999999")]
        [TestCase("9995996666399999")]
        [TestCase("99 922999 9963699")]
        [TestCase("99 9994599 922999")]
        [TestCase("55(99) 9999-992299")]
        [TestCase("55(99) 99999-99959")]
        [TestCase("55(99)9999-999559")]
        [TestCase("55(99)99999-999559")]
        [TestCase("55999999-995299")]
        [TestCase("559999999-995599")]
        [TestCase("559999999996159")]
        [TestCase("559999999999assad9")]
        [TestCase("aa bb cccc-eeee")]
        [TestCase("5599 99999c5 9999")]
        [TestCase("55 (99) 999329-9999")]
        [TestCase("55 (9129) 99999-9999")]
        [TestCase("5522 (99)9999-9999")]
        [TestCase("525 (99)99999-9999")]
        [TestCase("552 999999-9999")]
        [TestCase("552 9999999-9999")]
        [TestCase("551 9999999999")]
        [TestCase("55 9ww9q999999999")]
        [TestCase("55 9955 9999 9999936")]
        [TestCase("55 99 99we999 9999")]
        [TestCase("+55 (92329) 932999-9999")]
        [TestCase("+55 (99) 9999999-9999")]
        [TestCase("+55 (99)2239999-9999")]
        [TestCase("+55 (9329)9992299-9999")]
        [TestCase("+5523 999922399-9999")]
        [TestCase("+55 9232999999-9999")]
        [TestCase("+5523 9999999992329")]
        [TestCase("+5523 232399999999999")]
        [TestCase("+55 99 999923 923999")]
        [TestCase("+55 99 99999 992399")]
        [Category("Validations/Phone")]
        public void IsPhoneWrong(string phone)
        {
            var wrong = new ValidationContract()
                .IsPhone(phone, PropertyName, MessagePhone);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("(99) 3999-9999")]
        [TestCase("(99) 99999-9999")]
        [TestCase("(99)99999-9999")]
        [TestCase("993999-9999")]
        [TestCase("9999999-9999")]
        [TestCase("9939999999")]
        [TestCase("99999999999")]
        [TestCase("99 3999 9999")]
        [TestCase("99 99999 9999")]
        [TestCase("55(99) 3999-9999")]
        [TestCase("55(99) 99999-9999")]
        [TestCase("55(99)3999-9999")]
        [TestCase("55(99)99999-9999")]
        [TestCase("55993999-9999")]
        [TestCase("559999999-9999")]
        [TestCase("559939999999")]
        [TestCase("5599999999999")]
        [TestCase("5599 3999 9999")]
        [TestCase("5599 99999 9999")]
        [TestCase("55 (99) 3999-9999")]
        [TestCase("55 (99) 99999-9999")]
        [TestCase("55 (99)3999-9999")]
        [TestCase("55 (99)99999-9999")]
        [TestCase("55 993999-9999")]
        [TestCase("55 9999999-9999")]
        [TestCase("55 9939999999")]
        [TestCase("55 99999999999")]
        [TestCase("55 99 3999 9999")]
        [TestCase("55 99 99999 9999")]
        [TestCase("+55 (99) 3999-9999")]
        [TestCase("+55 (99) 99999-9999")]
        [TestCase("+55 (99)3999-9999")]
        [TestCase("+55 (99)99999-9999")]
        [TestCase("+55 993999-9999")]
        [TestCase("+55 9999999-9999")]
        [TestCase("+55 9939999999")]
        [TestCase("+55 99999999999")]
        [TestCase("+55 99 3999 9999")]
        [TestCase("+55 99 99999 9999")]
        [TestCase("(99) 9999-9999")]
        [TestCase("999999-9999")]
        [TestCase("9999999999")]
        [TestCase("99 9999 9999")]
        [TestCase("55(99) 9999-9999")]
        [TestCase("55(99)9999-9999")]
        [TestCase("55999999-9999")]
        [TestCase("559999999999")]
        [TestCase("5599 9999 9999")]
        [TestCase("55 (99) 9999-9999")]
        [TestCase("55 (99)9999-9999")]
        [TestCase("(99)9999-9999")]
        [TestCase("55 999999-9999")]
        [TestCase("55 9999999999")]
        [TestCase("55 99 9999 9999")]
        [TestCase("+55 (99) 9999-9999")]
        [TestCase("+55 (99)9999-9999")]
        [TestCase("+55 999999-9999")]
        [TestCase("+55 9999999999")]
        [TestCase("+55 99 9999 9999")]
        [Category("Validations/Phone")]
        public void IsPhoneRight(string phone)
        {
            var right = new ValidationContract()
                .IsPhone(phone, PropertyName, MessagePhone);
            Assert.True(right.IsValid);
        }
        
        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("(99) 3999-9999")]
        [TestCase("(99) 99999-9999")]
        [Category("Validations/Phone")]
        public void IsPhoneOrEmptyRight(string phone)
        {
            var right = new ValidationContract()
                .IsPhoneOrEmpty(phone, PropertyName, MessagePhone);
            Assert.True(right.IsValid);
        }

        [Test]
        [TestCase("(999) 9999-9999", "(99) 9999-9999")]
        [TestCase("(995) 99999-9999", "(99) 99999-9999")]
        [TestCase("(99)995299-9999", "(99)9999-9999")]
        [TestCase("(99)999959-9999", "(99)99999-9999")]
        [TestCase("999999-995299", "999999-9999")]
        [TestCase("9999999-999559", "9999999-9999")]
        [TestCase("9999999999565", "9999999999")]
        [TestCase("999999999995", "99999999999")]
        [TestCase("99 9999 999s9s", "99 9999 9999")]
        [TestCase("99 99999 99969", "99 99999 9999")]
        [TestCase("55(99) 99959-95999", "55(99) 9999-9999")]
        [TestCase("55(99) 9999569-9999", "55(99) 99999-9999")]
        [TestCase("55(9ss9)9999-99699", "55(99)9999-9999")]
        [TestCase("55(99)2199999-9999", "55(99)99999-9999")]
        [TestCase("5599999129-921999", "55999999-9999")]
        [TestCase("55999992399-999129", "559999999-9999")]
        [TestCase("55999999923999", "559999999999")]
        [TestCase("559999999992399", "5599999999999")]
        [TestCase("5599 992399 992399", "5599 9999 9999")]
        [TestCase("5599 9999239 9999", "5599 99999 9999")]
        [TestCase("55 (99) 999239-923999", "55 (99) 9999-9999")]
        [TestCase("55 (99) 9992399-999239", "55 (99) 99999-9999")]
        [TestCase("55 (9912)999219-923999", "55 (99)9999-9999")]
        [TestCase("55 (9912)2199999-9999", "55 (99)99999-9999")]
        [TestCase("55 99999129-912999", "55 999999-9999")]
        [TestCase("55 999999921-93999", "55 9999999-9999")]
        [TestCase("55 999999999129", "55 9999999999")]
        [TestCase("55 9999999", "55 99999999999")]
        [TestCase("55 99 99929 921999", "55 99 9999 9999")]
        [TestCase("55 99 9923999 9999", "55 99 99999 9999")]
        [TestCase("+55 (99) 923999-129999", "+55 (99) 9999-9999")]
        [TestCase("+55 (1299) 99999-9921299", "+55 (99) 99999-9999")]
        [TestCase("+55 (9239)9999-9999", "+55 (99)9999-9999")]
        [TestCase("+55 (3299)2399999-9999", "+55 (99)99999-9999")]
        [TestCase("+55 999999-999239", "+55 999999-9999")]
        [TestCase("+55 9999999-99", "+55 9999999-9999")]
        [TestCase("+55 999999999", "+55 9999999999")]
        [TestCase("+55 99999999", "+55 99999999999")]
        [TestCase("+55 99 9999 99", "+55 99 9999 9999")]
        [TestCase("+55 99 99999 9", "+55 99 99999 9999")]
        [TestCase(null, "+55 99 99999 9999")]
        [Category("Validations/PhoneFormat")]
        public void IsPhoneFormatWrong(string phone, string format)
        {
            var wrong = new ValidationContract()
                .IsPhone(phone, format, PropertyName, MessagePhone);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("(99) 9999-9999", "(99) ?9999-9999")]
        [TestCase("(99) 99999-9999", "(99) ?9999-9999")]
        [TestCase("(99) 9999-9999", "(99) 9999-9999")]
        [TestCase("(99) 99999-9999", "(99) 99999-9999")]
        [TestCase("(99)9999-9999", "(99)9999-9999")]
        [TestCase("(99)99999-9999", "(99)99999-9999")]
        [TestCase("999999-9999", "999999-9999")]
        [TestCase("9999999-9999", "9999999-9999")]
        [TestCase("9999999999", "9999999999")]
        [TestCase("99999999999", "99999999999")]
        [TestCase("99 9999 9999", "99 9999 9999")]
        [TestCase("99 99999 9999", "99 99999 9999")]
        [TestCase("55(99) 9999-9999", "55(99) 9999-9999")]
        [TestCase("55(99) 99999-9999", "55(99) 99999-9999")]
        [TestCase("55(99)9999-9999", "55(99)9999-9999")]
        [TestCase("55(99)99999-9999", "55(99)99999-9999")]
        [TestCase("55999999-9999", "55999999-9999")]
        [TestCase("559999999-9999", "559999999-9999")]
        [TestCase("559999999999", "559999999999")]
        [TestCase("5599999999999", "5599999999999")]
        [TestCase("5599 9999 9999", "5599 9999 9999")]
        [TestCase("5599 99999 9999", "5599 99999 9999")]
        [TestCase("55 (99) 9999-9999", "55 (99) 9999-9999")]
        [TestCase("55 (99) 99999-9999", "55 (99) 99999-9999")]
        [TestCase("55 (99)9999-9999", "55 (99)9999-9999")]
        [TestCase("55 (99)99999-9999", "55 (99)99999-9999")]
        [TestCase("55 999999-9999", "55 999999-9999")]
        [TestCase("55 9999999-9999", "55 9999999-9999")]
        [TestCase("55 9999999999", "55 9999999999")]
        [TestCase("55 99999999999", "55 99999999999")]
        [TestCase("55 99 9999 9999", "55 99 9999 9999")]
        [TestCase("55 99 99999 9999", "55 99 99999 9999")]
        [TestCase("+55 (99) 9999-9999", "+55 (99) 9999-9999")]
        [TestCase("+55 (99) 99999-9999", "+55 (99) 99999-9999")]
        [TestCase("+55 (99)9999-9999", "+55 (99)9999-9999")]
        [TestCase("+55 (99)99999-9999", "+55 (99)99999-9999")]
        [TestCase("+55 999999-9999", "+55 999999-9999")]
        [TestCase("+55 9999999-9999", "+55 9999999-9999")]
        [TestCase("+55 9999999999", "+55 9999999999")]
        [TestCase("+55 99999999999", "+55 99999999999")]
        [TestCase("+55 99 9999 9999", "+55 99 9999 9999")]
        [TestCase("+55 99 99999 9999", "+55 99 99999 9999")]
        [Category("Validations/PhoneFormat")]
        public void IsPhoneFormatRight(string phone, string format)
        {
            var right = new ValidationContract()
                .IsPhone(phone, format, PropertyName, MessagePhone);
            Assert.True(right.IsValid);
        }
        
        [Test]
        [TestCase("", "(99) ?9999-9999")]
        [TestCase(null, "(99) ?9999-9999")]
        [TestCase("(99) 9999-9999", "(99) ?9999-9999")]
        [TestCase("(99) 99999-9999", "(99) ?9999-9999")]
        [Category("Validations/PhoneFormat")]
        public void IsPhoneFormatOrEmptyRight(string phone, string format)
        {
            var right = new ValidationContract()
                .IsPhoneOrEmpty(phone, format, PropertyName, MessagePhone);
            Assert.True(right.IsValid);
        }

        [Test]
        [TestCase(null)]
        [TestCase("456456444456")]
        [TestCase("(45)3333-3333")]
        [TestCase("(99) 8 9999-9999")]
        [Category("Validations/Phone")]
        public void IsCellPhoneWrong(string cellphone)
        {
            var wrong = new ValidationContract()
                .IsCellPhone(cellphone, PropertyName, MessageCellphone);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("(45)99999-9999")]
        [TestCase("+55(99)99999-9999")]
        [TestCase("+55(99)9-9999-9999")]
        [TestCase("+55 (99) 9999-9999")]
        [TestCase("+55 (99) 9999-9999")]
        [Category("Validations/Phone")]
        public void IsCellPhoneRight(string cellphone)
        {
            var right = new ValidationContract()
                .IsCellPhone(cellphone, PropertyName, MessageCellphone);
            Assert.True(right.IsValid);
        }
        
        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("(45)99999-9999")]
        [TestCase("+55(99)99999-9999")]
        [Category("Validations/PhoneFormat")]
        public void IsCellPhoneOrEmptyRight(string cellphone)
        {
            var right = new ValidationContract()
                .IsCellPhoneOrEmpty(cellphone, PropertyName, MessageCellphone);
            Assert.True(right.IsValid);
        }

        [Test]
        [TestCase("4599999999")]
        [TestCase("+55 (99) 3333-4444")]
        [TestCase("+55(99)9999-9999")]
        [TestCase("+55(99)9999-9999")]
        [TestCase("+55 (99) 9999-9999")]
        [TestCase("+55 (99) 9999-9999")]
        [TestCase("+55 (99) 3333-4444")]
        [Category("Validations/Phone")]
        public void IsNewCellPhoneWrong(string cellphone)
        {
            var wrong = new ValidationContract()
                .IsNewFormatCellPhone(cellphone, PropertyName, MessageCellphone);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("45999999999")]
        [TestCase("+55(99)99999-9999")]
        [TestCase("+55(99)9.9999-9999")]
        [TestCase("+55 (99) 9-9999-9999")]
        [TestCase("+55 (99) 9 9999-9999")]
        [Category("Validations/Phone")]
        public void IsNewCellPhoneRight(string cellphone)
        {
            var right = new ValidationContract()
                .IsNewFormatCellPhone(cellphone, PropertyName, MessageCellphone);
            Assert.True(right.IsValid);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("45999999999")]
        [TestCase("+55(99)99999-9999")]
        [Category("Validations/PhoneFormat")]
        public void IsNewCellPhoneOrEmptyRight(string cellphone)
        {
            var right = new ValidationContract()
                .IsNewFormatCellPhoneOrEmpty(cellphone, PropertyName, MessageCellphone);
            Assert.True(right.IsValid);
        }
    }
}