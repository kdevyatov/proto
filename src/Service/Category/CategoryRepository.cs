using CRM2.Core;
using CRM2.Domain.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRM2.Service.Category
{
    internal class CategoryRepository : IRepository<ICategory>
    {
        public void Add(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public ICategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategory> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategory> List(Expression<Func<ICategory, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(ICategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
