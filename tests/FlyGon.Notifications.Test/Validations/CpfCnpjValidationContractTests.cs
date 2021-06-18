using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class CpfCnpjValidationContractTests
    {
        private const string MessageCpf = "Invalid Cpf";
        private const string PropertyNameCpf = "Cpf";
        private const string MessageCnpj = "Invalid Cnpj";
        private const string PropertyNameCnpj = "Cnpj";
        private const string MessageCpfCnpj = "Invalid CpfCnpj";
        private const string PropertyNameCpfCnpj = "CpfCnpj";

        [Test]
        [TestCase("12345678910")]
        [TestCase("124.835.069-34")]
        [TestCase("000.000.000-00")]
        [Category("Validations/Cpf")]
        public void IsCpfWrong(string cpf)
        {
            var wrong = new ValidationContract()
                .IsCpf(cpf, PropertyNameCpf, MessageCpf);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("08381614996")]
        [TestCase("489.062.735-92")]
        [Category("Validations/Cpf")]
        public void IsCpfRight(string cpf)
        {
            var right = new ValidationContract()
                .IsCpf(cpf, PropertyNameCpf, MessageCpf);
            Assert.True(right.IsValid);
        }

        [Test]
        [TestCase("123456789101112")]
        [TestCase("45.448.481/0501-18")]
        [TestCase("99.999.999/9999-99")]
        [Category("Validations/Cnpj")]
        public void IsCnpjWrong(string cnpj)
        {
            var wrong = new ValidationContract()
                .IsCnpj(cnpj, PropertyNameCnpj, MessageCnpj);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("16880249000179")]
        [TestCase("45.448.421/0001-18")]
        [Category("Validations/Cnpj")]
        public void IsCnpjRight(string cnpj)
        {
            var right = new ValidationContract()
                .IsCnpj(cnpj, PropertyNameCnpj, MessageCnpj);
            Assert.True(right.IsValid);
        }

        [Test]
        [TestCase("123456789101112")]
        [TestCase("45.448.481/0501-18")]
        [TestCase("99.999.999/9999-99")]
        [TestCase("12345678910")]
        [TestCase("124.835.069-34")]
        [TestCase("000.000.000-00")]
        [Category("Validations/CpfCnpj")]
        public void IsCpfOrCnpjWrong(string cpfCpnj)
        {
            var wrong = new ValidationContract()
                .IsCnpjOrCPF(cpfCpnj, PropertyNameCpfCnpj, MessageCpfCnpj);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("16880249000179")]
        [TestCase("45.448.421/0001-18")]
        [TestCase("08381614996")]
        [TestCase("489.062.735-92")]
        [Category("Validations/CpfCnpj")]
        public void IsCpfOrCnpjRight(string cpfCpnj)
        {
            var right = new ValidationContract()
                .IsCnpjOrCPF(cpfCpnj, PropertyNameCpfCnpj, MessageCpfCnpj);
            Assert.True(right.IsValid);
        }
    }
}