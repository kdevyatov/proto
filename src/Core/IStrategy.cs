using System;
using CRM.Domain.Model;

namespace CRM.Core
{
    public interface IStrategy<T>
    {
        Func<T, NotificationStatus> Resolve(T notification);
    }
}