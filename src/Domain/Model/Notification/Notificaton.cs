using CRM.Core;

namespace CRM.Domain.Model
{

    public enum NotificationStatus
    {
        Draft, 
        Sent, 
        Cancelled, 
        Failed
    }

    public abstract class Notificaton : INotificaton
    {
        public NotificationStatus Status { get; set; } = NotificationStatus.Draft;
    }

    public class ClientNotificaton : Notificaton
    {

    }

    public class ManagerNotificaton : Notificaton
    {

    }
}