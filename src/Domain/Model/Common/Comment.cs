using System;

namespace CRM.Domain.Model
{
    public interface IComment
    {

    }

    public class Comment : IComment
    {
        public Guid Id { get; set; }
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// сущность - владелец комментария, комментарий, согласно данной логике может принадлежать 
        /// любой сущности в системе
        /// </summary>
        public Guid OwningUnitId { get; set; } 
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public Guid ManagerId { get; set; }
    }
}