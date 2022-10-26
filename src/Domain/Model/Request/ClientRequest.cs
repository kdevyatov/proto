namespace CRM.Domain.Model
{

    public abstract class ClientRequest : IClientRequest
    {
        public ClientRequestType Type { get; set; }
    }
}
