using System.Collections.Generic;

namespace CRM.Domain.Model
{


    public class ClientSupportRequest : ClientRequest
    {
        public ICollection<Comment> Comments { get; set; }
        public ClientRequestType ClientRequestType
        {
            get => default;
            set
            {
            }
        }

        public ClientRequestStatus ClientRequestStatus
        {
            get => default;
            set
            {
            }
        }


    }
}
