using System;

namespace FlyGon.Notifications.HowToUse
{
    class Customer : Notifiable
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer() { }

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddNotification(new Notification("Name", "Invalid name"));
            if (string.IsNullOrEmpty(Surname))
                AddNotification(new Notification("Surname", "Invalid surname"));
        }
    }

    static class Program
    {
        static void Main()
        {            
            var customer = new Customer("Name", "Surname");
            customer.Validate();
            Console.WriteLine($"Customer validation - " +
                $"IsValid: {customer.IsValid}, " +
                $"Notifications: {customer.Notifications.Count}");

            customer = new Customer();
            customer.Validate();
            Console.WriteLine($"Customer validation - " +
                $"IsInvalid: {customer.IsInvalid}, " +
                $"Notifications: {customer.Notifications.Count}, " +
                $"Notifications message: {customer.NotificationsMessage()}");
        }
    }
}