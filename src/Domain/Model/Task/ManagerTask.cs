using System;

namespace CRM.Domain.Model
{
    public class ManagerTask
    {
        public Guid ManagerId { get; set; }
        public Guid TaskId { get; set; }
    }
}