using FlyGon.Notifications.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlyGon.Notifications
{
    /// <summary>
    /// Base class to make other classes notifiable.
    /// </summary>
    /// <remarks>
    /// Use through inheritance to make other classes notifiable. 
    /// It has useful properties in the validation/notification context.
    /// </remarks>
    public abstract class Notifiable : INotifiable
    {
        /// <summary>
        /// List of notifications.
        /// </summary>
        public IReadOnlyCollection<Notification> Notifications { get => _notifications.ToArray(); }
        private readonly List<Notification> _notifications = new List<Notification>();

        /// <summary>
        /// When invalid, it returns true. If not, false.
        /// </summary>
        public bool IsInvalid { get => Notifications.Any(); }

        /// <summary>
        /// When valid, it returns false. If not, true.
        /// </summary>
        public bool IsValid { get => !IsInvalid; }

        /// <summary>
        /// Add a notification.
        /// </summary>
        /// <param name="property">Validated property type.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to send a type and message as parameters.
        /// </remarks>
        protected void AddNotification(Type property, string message) =>
            _notifications.Add(new Notification(property?.Name, message));

        /// <summary>
        /// Add a notification.
        /// </summary>
        /// <param name="property">Validated property name.</param>
        /// <param name="message">Custom error message.</param>
        /// <remarks>
        /// Use when you want to send a property name and message as parameters.
        /// </remarks>
        protected void AddNotification(string property, string message) =>
            _notifications.Add(new Notification(property, message));

        /// <summary>
        /// Add a notification.
        /// </summary>
        /// <param name="notification">Configured notification.</param>
        /// <remarks>
        /// Use when you want to send a notification as a parameter.
        /// </remarks>
        protected void AddNotification(Notification notification)
        {
            if (notification != null)
                _notifications.Add(notification);
        }

        /// <summary>
        /// Add notifications list.
        /// </summary>
        /// <param name="notifications">List of configured notifications.</param>
        /// <remarks>
        /// Use when you want to send a notifications list as a parameter.
        /// </remarks>
        protected void AddNotifications(IEnumerable<Notification> notifications) =>
            _notifications.AddRange(notifications.Where(notification => notification != null));

        /// <summary>
        /// Add notifications list.
        /// </summary>
        /// <param name="notifications">List of configured notifications.</param>
        /// <remarks>
        /// Use when you want to send a notifications list as a parameter.
        /// </remarks>
        protected void AddNotifications(ICollection<Notification> notifications) =>
            _notifications.AddRange(notifications.Where(notification => notification != null));

        /// <summary>
        /// Add notifications list.
        /// </summary>
        /// <param name="notifications">List of configured notifications.</param>
        /// <remarks>
        /// Use when you want to send a notifications list as a parameter.
        /// </remarks>
        protected void AddNotifications(IReadOnlyCollection<Notification> notifications) =>
            _notifications.AddRange(notifications.Where(notification => notification != null));

        /// <summary>
        /// Add notifications list.
        /// </summary>
        /// <param name="notifiable">Notifiable class with configured notification list.</param>
        /// <remarks>
        /// Use when you want to send a notifiable class that takes the notification list as a parameter.
        /// </remarks>
        protected void AddNotifications(Notifiable notifiable) =>
            AddNotifications(notifiable.Notifications);

        /// <summary>
        /// Get the list of notifications formatted in string.
        /// </summary>
        /// <remarks>
        /// Use when you want to get the list of notifications formatted in string.
        /// </remarks>
        public string NotificationsMessage() =>
            string.Join("; ", Notifications
                .Select(notification => notification.Property + ": " + notification.Message)) + ";";

        /// <summary>
        /// Clear notifications list.
        /// </summary>
        /// <remarks>
        /// Use when you want to clear the notification list. 
        /// Do this when you want to validate your class again.
        /// </remarks>
        public void Clear() =>
            _notifications.Clear();
    }
}