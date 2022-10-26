namespace CRM.Domain.Model
{

    public class Order : IOrder
    {
        public System.Collections.Generic.ICollection<OrderItem> Items { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.New;
        public OrderStatus OrderStatus
        {
            get => default;
            set
            {
            }
        }


        public void SetStatus(OrderStatus _status)
        {
            this.Status = _status;
        }
    }
}
