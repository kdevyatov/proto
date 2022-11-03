using CRM2.Domain.Model.Product;
using System;

namespace CRM.Domain.Model
{
    public class ProductCategory : IProductCategory
    {
        public Guid CategorytId { get; set; }
        public Guid ProductId { get; set; }
    }
}
