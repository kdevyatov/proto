using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRM2.Core
{
    public interface IRepository<T> 
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
