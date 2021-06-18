using FlyGon.Notifications.Validations;
using NUnit.Framework;

namespace FlyGon.Notifications.Test.Validations
{
    class VoterDocumentContractTests
    {
        [Test]
        [Category("Validations/VoterDocument")]
        public void IsVoterDocument()
        {
            var property = "VoterDocument";
            var message = "Invalid Voter Document";
            var wrong = new ValidationContract()
                .IsVoterDocument("668247690132", property, message)
                .IsVoterDocument("333438450601", property, message)
                .IsVoterDocument("6568351232550", property, message);
            Assert.True(wrong.IsInvalid);
            Assert.AreEqual(3, wrong.Notifications.Count);

            var right = new ValidationContract()
                .IsVoterDocument("668247670132", property, message)
                .IsVoterDocument("333438450701", property, message);
            Assert.True(right.IsValid);
        }
    }
}