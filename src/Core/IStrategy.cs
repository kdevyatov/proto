using System;
using CRM.Domain.Model;

namespace CRM.Core
{
    public interface IStrategy<T, N>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Func<T, N> Resolve(T entity);
    }
}