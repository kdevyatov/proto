using System;
using System.Collections.Generic;
using System.Text;

namespace CRM2.Domain.Model.Product
{
    internal interface IProductCategory
    {
        public Guid CategorytId { get; set; }
        public Guid ProductId { get; set; }
    }
}
