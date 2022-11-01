using CRM.Core;
using CRM.Domain.Model;
using System;

namespace CRM2.Service.Task
{
    public class TaskManagerSelectionStrategy : IStrategy<ITask, Guid?>
    {
        public Func<ITask, Guid?> Resolve(ITask entity)
        {
            return (entity) => {
                // return selected manager id or Guid.Empty value
                return Guid.NewGuid();
            };
        }
    }
}
