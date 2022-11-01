using CRM2.Core;
using System;
using System.Collections.Generic;
using System.Text;
using CRM2.Domain.Model;
using System.Linq.Expressions;

namespace CRM2.Service.Category
{
    public class CategoryRepository : IRepository<ICategory>
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
