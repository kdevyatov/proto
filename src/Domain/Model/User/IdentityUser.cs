using System;
using System.Collections.Generic;

namespace CRM.Domain.Model
{
    public abstract class IdentityUser : IIdentityUser
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }

        public ICollection<Contact> Contacts { get; set; }

        public Gender Gender1
        {
            get => default;
            set
            {
            }
        }
    }
}
