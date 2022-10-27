using System.Linq.Expressions;
using CRM.Domain.Model;

namespace CRM2.Service.Task
{
    public interface ITaskService
    {
        bool Create(ITask task);
        ITask Get(Guid id);
        ICollection<ITask> GetAll(Expression<Func<ITask, bool>>? predicate);
        bool Update(ITask task);
        bool Delete(ITask task);
        bool Delete(Guid id);
        bool ChangeStatus(ITask task, TaskStatus status);
    }
}
