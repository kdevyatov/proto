using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Model
{
    public class Role
    {
        public string Name { get; set; }
    }


    public class Client : IdentityUser
    {
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Attachment> Documents { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<ClientNotificaton> Notificatons { get; set; }
        public ICollection<ClientSupportRequest> SupportRequests { get; set;  }
        public ICollection<Role> Roles { get; set; }
    }

    public interface IRepository<T>
    {
        T Get(Guid id);
        T Update(T entity);
        Guid Create(T entity);
    }

    public class ManagerRepository : IRepository<Manager>
    {
        public Guid Create(Manager entity)
        {
            throw new NotImplementedException();
        }

        public Manager Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Manager Update(Manager entity)
        {
            throw new NotImplementedException();
        }
    }
}
