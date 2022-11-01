using System;
using System.Collections.Generic;
using System.Text;

namespace CRM2.Domain.Model.Product
{
    public interface IProductCategory
    {
        public Guid CategorytId { get; set; }
        public Guid ProductId { get; set; }
    }
}
