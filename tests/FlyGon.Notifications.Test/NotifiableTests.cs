using NUnit.Framework;

namespace FlyGon.Notifications.Test
{
    class NotifiableTests
    {
        [Test]
        [Category("Notifiable")]
        public void AddNotifications()
        {
            var customer = new Customer();
            Assert.True(customer.IsInvalid);
            Assert.AreEqual(2, customer.Notifications.Count);
        }

        [Test]
        [Category("Notifiable")]
        public void ClearNotifications()
        {
            var customer = new Customer();
            customer.Clear();
            Assert.True(customer.IsValid);
            Assert.AreEqual(0, customer.Notifications.Count);
        }
    }

    internal class Customer : Notifiable
    {
        public Customer()
        {
            Validate();
        }

        private void Validate()
        {
            AddNotification("Email", "Invalid Email");
            AddNotification("Phone", "Invalid Phone");
        }
    }
}