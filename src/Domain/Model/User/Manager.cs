using System.Collections.Generic;

namespace CRM.Domain.Model
{
    public class Manager : IdentityUser
    {
        public ICollection<CRM.Domain.Model.Task> Tasks { get; set; }
        public ICollection<ManagerNotificaton> Notificatons { get; set; }
        public ICollection<Role> Roles { get; set; }

        public Order Order
        {
            get => default;
            set
            {
            }
        }
    }
}
