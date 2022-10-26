﻿using CRM.Core;
using CRM.Domain.Model;

namespace CRM.Service.Notification
{

    public class NotificationService : INotificationService
    {
        public IStrategy<INotificaton> Strategy { get; set; }

        public NotificationService(IStrategy<INotificaton> strategy)
        {
            Strategy = strategy;
        }

        public NotificationStatus Send(INotificaton notificaton)
        {
            return (NotificationStatus) 
                Strategy.Resolve(notificaton)?.Invoke(notificaton);
        }
    }
}