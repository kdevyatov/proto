using System;
using System.Collections.Generic;

namespace CRM.Domain.Model
{

    public class Product : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ProductStatus Sttatus { get; set; } = ProductStatus.InStock;

        public ICollection<ProductStock> ProductStocks
        {
            get => default;
            set
            {
            }
        }

        public ProductStatus ProductStatus
        {
            get => default;
            set
            {
            }
        }

        public ProductCategory ProductCategory
        {
            get => default;
            set
            {
            }
        }

        public ProductStatus ProductStatus1
        {
            get => default;
            set
            {
            }
        }
    }
}
