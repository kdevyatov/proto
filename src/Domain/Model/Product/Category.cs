using System;

namespace CRM.Domain.Model
{
    public class Category
    {
        public Guid Id { get; set; }

        public ProductCategory ProductCategory
        {
            get => default;
            set
            {
            }
        }
    }
}
