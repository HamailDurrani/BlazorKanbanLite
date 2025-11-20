using BlazorKanbanLite.Models;
using TaskStatus = BlazorKanbanLite.Models.TaskStatus;

namespace BlazorKanbanLite.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _items = new();
        public event Action? OnChange;

        //public TaskService()
        //{
        //    _items.Add(new TaskItem { Title = "Shopping" });
        //    _items.Add(new TaskItem { Title = "Buy a Car", Status = TaskStatus.InProgress });
        //    _items.Add(new TaskItem { Title = "Pay a Bill", Status = TaskStatus.Done });
        //}

        public IReadOnlyList<TaskItem> GetAll() => _items.ToList();

        public IEnumerable<TaskItem> GetByStatus(TaskStatus status) =>
            _items.Where(t => t.Status == status);

        public TaskItem Create(TaskItem item)
        {
            _items.Add(item);
            Notify();
            return item;
        }

        public void Update(TaskItem item)
        {
            var index = _items.FindIndex(i => i.Id == item.Id);
            if (index != -1)
                _items[index] = item;

            Notify();
        }

        
        public void Delete(TaskItem item)
        {
            _items.RemoveAll(t => t.Id == item.Id);
            Notify();
        }

        void Notify() => OnChange?.Invoke();
    }
}
