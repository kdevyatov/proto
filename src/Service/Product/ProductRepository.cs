using CRM2.Core;
using CDM = CRM.Domain.Model;
using System;
using System.Collections.Generic;


namespace CRM2.Service.Product
{
    public class ProductRepository : IRepository<CDM.IProduct>
    {
        public void Add(CDM.IProduct entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CDM.IProduct entity)
        {
            throw new NotImplementedException();
        }

        public CDM.IProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CDM.IProduct> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CDM.IProduct> List(System.Linq.Expressions.Expression<Func<CDM.IProduct, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(CDM.IProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
