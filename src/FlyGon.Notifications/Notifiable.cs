using FlyGon.Notifications.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace FlyGon.Notifications
{
    public abstract class Notifiable : INotifiable
    {
        public IReadOnlyCollection<Notification> Notifications { get => _notifications.ToArray(); }
        private readonly List<Notification> _notifications = new List<Notification>();

        public bool IsInvalid { get => Notifications.Any(); }
        public bool IsValid { get => !IsInvalid; }

        protected void AddNotification(Notification notification)
        {
            if (notification != null)
                _notifications.Add(notification);
        }

        protected void AddNotifications(IEnumerable<Notification> notifications)
        {
            foreach (var notification in notifications)
                AddNotification(notification);
        }

        public string NotificationsMessage() =>
            string.Join("; ", Notifications.Select(x => x.Property + ": " + x.Message)) + ";";

        public void Clear() =>
            _notifications.Clear();
    }
}