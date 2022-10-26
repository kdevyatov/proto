using System;

namespace CRM.Domain.Model
{

    public class Attachment
    {
        public Guid Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }

        public AttachmentType Type { get; set; }

        public AttachmentType DocumentType
        {
            get => default;
            set
            {
            }
        }

        public AttachmentType AttachmentType
        {
            get => default;
            set
            {
            }
        }
    }
}
