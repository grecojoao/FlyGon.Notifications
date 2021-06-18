using System.Linq;

namespace FlyGon.Notifications.Validations
{
    public partial class ValidationContract
    {
        /// <summary>
        /// String validation: 'is CPF'.
        /// </summary>
        /// <param name="cpf">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid CPF.
        /// If the value is not a valid CPF, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCpf(string cpf, string property, string message)
        {
            if (string.IsNullOrEmpty(cpf) || !ValidateCpf(cpf))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateCpf(string cpf)
        {
            string[] cpfInvalueid =
        {
            "00000000000", "11111111111", "22222222222",
            "33333333333", "44444444444", "55555555555",
            "66666666666", "77777777777", "88888888888", "99999999999"
        };
            var multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (!long.TryParse(cpf, out _))
                return false;
            if (cpf.Length != 11 || cpfInvalueid.Contains(cpf))
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto;
            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// String validation: 'is CNPJ'.
        /// </summary>
        /// <param name="cnpj">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid CNPJ.
        /// If the value is not a valid CNPJ, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCnpj(string cnpj, string property, string message)
        {
            if (string.IsNullOrEmpty(cnpj) || !ValidateCnpj(cnpj))
                AddNotification(property, message);
            return this;
        }

        private static bool ValidateCnpj(string cnpj)
        {
            string[] cnpjInvalueid =
        {
            "00000000000000", "11111111111111", "22222222222222", "33333333333333",
            "44444444444444", "55555555555555", "66666666666666", "77777777777777",
            "88888888888888", "99999999999999",
        };
            var multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14 || !long.TryParse(cnpj, out _))
                return false;
            if (cnpjInvalueid.Contains(cnpj))
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;
            digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto;
            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// String validation: 'is CPF or CNPJ'.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to validate if a text is a valid CPF or valid CNPJ.
        /// If the value is not a valid CPF or valid CNPJ, a notification is added.
        /// </remarks>
        /// <returns>Returns the <see cref="ValidationContract"/> class reference after validation (with notifications or without notifications).</returns>
        public ValidationContract IsCnpjOrCPF(string value, string property, string message)
        {
            if (string.IsNullOrEmpty(value) || (!ValidateCnpj(value) && !ValidateCpf(value)))
                AddNotification(property, message);
            return this;
        }
    }
}