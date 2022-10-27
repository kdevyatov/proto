using System;
using CRM.Domain.Model;

namespace CRM.Core
{
    public interface IStrategy<T, N>
    {
        Func<T, N> Resolve(T entity);
    }
}