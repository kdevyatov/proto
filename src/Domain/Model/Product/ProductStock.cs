using System;

namespace CRM.Domain.Model
{
    public class ProductStock
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Guid ProductId { get; set; }
        public int? Quantity { get; set; }
        public bool Infinite { get; set; } = true;
    }
}
