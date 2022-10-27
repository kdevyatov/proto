using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Domain.Model
{
    public class Task : AbstractTask
    {
        public Guid Id { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<ManagerTask> Tasks { get; set; }
        /// <remarks></remarks>
        public ClientSupportRequest ClientSupportRequest
        {
            get => default;
            set
            {
            }
        }
    }
}