using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class CepValidationContractTests
    {
        private const string Message = "Invalid CEP";
        private const string PropertyName = "Cep";

        [Test]
        [TestCase("99999")]
        [TestCase("abcde-999")]
        [TestCase("99999-fgh")]
        [TestCase("abcde-fgh")]
        [TestCase("abcdefgh")]
        [Category("Validations/Cep")]
        public void IsCepWrong(string cep)
        {
            var wrong = new ValidationContract()
                .IsCep(cep, PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("99999-999")]
        [TestCase("99999999")]
        [Category("Validations/Cep")]
        public void IsCepRight(string cep)
        {
            var right = new ValidationContract()
                .IsCep(cep, PropertyName, Message);
            Assert.True(right.IsValid);
        }
    }
}