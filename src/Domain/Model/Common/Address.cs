namespace CRM.Domain.Model
{
    public class Address
    {
        public string Name { get; set; }

        public AddressType AddressType
        {
            get => default;
            set
            {
            }
        }
    }
}
