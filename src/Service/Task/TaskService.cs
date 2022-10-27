using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using CRM;
using CRM.Core;
using CRM.Domain.Model;

namespace CRM2.Service.Task
{

    public class TaskService : ITaskService
    {
        IStrategy<ITask, Guid> Strategy { get; set; }

        public TaskService(IStrategy<ITask, Guid> strategy)
        {
            Strategy = strategy ?? 
                throw new ArgumentException(nameof(strategy));
        }

        public bool ChangeStatus(ITask task, TaskStatus status)
        {
            throw new NotImplementedException();
        }

        public bool Create(ITask task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ITask task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ITask Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ITask> GetAll(Expression<Func<ITask, bool>>? predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(ITask task)
        {
            throw new NotImplementedException();
        }
    }
}
