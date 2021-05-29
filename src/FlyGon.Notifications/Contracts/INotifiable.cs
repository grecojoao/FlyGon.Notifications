using System.Collections.Generic;

namespace FlyGon.Notifications.Contracts
{
    internal interface INotifiable
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool IsInvalid { get; }
        bool IsValid { get; }
        string NotificationsMessage();
    }
}