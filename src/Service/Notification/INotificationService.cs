using CRM.Core;
using CRM.Domain.Model;

namespace CRM.Service.Notification
{
    public interface INotificationService
    {
        IStrategy<INotificaton> Strategy { get; set; }
        NotificationStatus Send(INotificaton notificaton);
    }
}