using CRM2.Domain.Model.Product;
using System;

namespace CRM.Domain.Model
{
    public class Category : ICategory
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
