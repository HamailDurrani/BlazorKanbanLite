using BlazorKanbanLite.Models;
using TaskStatus = BlazorKanbanLite.Models.TaskStatus;

namespace BlazorKanbanLite.Services
{
    public interface ITaskService
    {
        IReadOnlyList<TaskItem> GetAll();
        IEnumerable<TaskItem> GetByStatus(TaskStatus status);
        TaskItem Create(TaskItem item);
        void Update(TaskItem item);
        void Delete(TaskItem id);

        event Action? OnChange;
    }
}
