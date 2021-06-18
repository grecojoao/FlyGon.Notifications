using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    public class CarLicensePlateValidationContractTests
    {
        private const string Message = "Invalid Plate";
        private const string PropertyName = "Plate";

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("ABC1A1")]
        [TestCase("1111ABC")]
        [TestCase("AB11ABC")]
        [TestCase("1ABCDEF")]
        [TestCase("A1BCABC")]
        [TestCase("DLCZ946")]
        [TestCase("DLC94Z6")]
        [TestCase("DLC946Z")]
        [Category("Validations/CarLicensePlate")]
        public void CarLicensePlateWrong(string plate)
        {
            var wrong = new ValidationContract()
                .IsCarLicensePlate(plate, PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("GAG1A11")]
        [TestCase("RAR2150")]
        [TestCase("LOL9999")]
        [TestCase("ABC1111")]
        [TestCase("ABC1A23")]
        [TestCase("DLC9Z46")]
        [TestCase("IVY1X99")]
        [TestCase("KDA1E18")]
        [TestCase("LOL8Y11")]
        [TestCase("LMA0I11")]
        [TestCase("LMA-0I11")]
        [Category("Validations/CarLicensePlate")]
        public void CarLicensePlateRight(string plate)
        {
            var right = new ValidationContract()
                .IsCarLicensePlate(plate, PropertyName, Message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("ABC1K11")]
        [TestCase("ABC1R23")]
        [TestCase("DLC9E46")]
        [TestCase("IVY19")]
        [TestCase("KDA118")]
        [TestCase("DLC94Z6")]
        [TestCase("LMA0I11")]
        [TestCase("LMA0--11")]
        [TestCase("LMA--0611")]
        [TestCase("LMA-061")]
        [Category("Validations/CarLicensePlate")]
        public void OldCarLicensePlateWrong(string plate)
        {
            var wrong = new ValidationContract()
                   .IsOldCarLicensePlate(plate, PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("GAG1111")]
        [TestCase("RAR2150")]
        [TestCase("LOL9999")]
        [TestCase("ABC1111")]
        [TestCase("ABC1223")]
        [TestCase("DLC9946")]
        [TestCase("IVY1499")]
        [TestCase("KDA1718")]
        [TestCase("LOL8811")]
        [TestCase("LMA0611")]
        [TestCase("LMA-0611")]
        [Category("Validations/CarLicensePlate")]
        public void OldCarLicensePlateRight(string plate)
        {
            var right = new ValidationContract()
                .IsOldCarLicensePlate(plate, PropertyName, Message);
            Assert.IsTrue(right.IsValid);
        }

        [Test]
        [TestCase("1111ABC")]
        [TestCase("AB11ABC")]
        [TestCase("1ABCDEF")]
        [TestCase("A1BCABC")]
        [TestCase("DLCZ946")]
        [TestCase("DLC94Z6")]
        [TestCase("DLC946Z")]
        [Category("Validations/CarLicensePlate")]
        public void MercosulCarLicensePlateWrong(string plate)
        {
            var wrong = new ValidationContract()
                .IsMercosulCarLicensePlate(plate, PropertyName, Message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [Test]
        [TestCase("GAG1A11")]
        [TestCase("RAR2R50")]
        [TestCase("LOL9F99")]
        [TestCase("ABC1Z11")]
        [TestCase("ABC1A23")]
        [TestCase("DLC9Z46")]
        [TestCase("IVY1X99")]
        [TestCase("KDA1E18")]
        [TestCase("LOL8Y11")]
        [TestCase("LMA0I11")]
        [TestCase("LMA-0I11")]
        [Category("Validations/CarLicensePlate")]
        public void MercosulCarLicensePlateRight(string plate)
        {
            var right = new ValidationContract()
                .IsMercosulCarLicensePlate(plate, PropertyName, Message);
            Assert.IsTrue(right.IsValid);
        }
    }
}