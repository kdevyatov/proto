namespace CRM.Domain.Model
{

    /// <summary>
    /// email, phone, skype
    /// </summary>
    public class Contact
    {
        public ContactType Type { get; set; }

        public ContactType ContactType
        {
            get => default;
            set
            {
            }
        }
    }
}