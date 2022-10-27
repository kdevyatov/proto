using System;
using CRM.Core;
using CRM.Domain.Model;

namespace CRM.Service.Notification
{
    public class NotificationStrategy : IStrategy<INotificaton, NotificationStatus>
    {
        public Func<INotificaton, NotificationStatus> Resolve(INotificaton notification)
        {
            return (notificaton) => {
                Console.WriteLine($"Send it anywkere...");
                notification.Status = NotificationStatus.Sent;
                return notification.Status;
            };
        }
    }
}