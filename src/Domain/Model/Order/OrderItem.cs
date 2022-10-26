using System;

namespace CRM.Domain.Model
{

    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid ProdcutId { get; set; }
        public decimal Price { get; set; }

        public Product Product
        {
            get => default;
            set
            {
            }
        }

        public OrderItemStatus OrderItemStatus
        {
            get => default;
            set
            {
            }
        }
    }
}
