using System.ComponentModel.DataAnnotations;

namespace BlazorKanbanLite.Models
{
    public enum TaskStatus { ToDo, InProgress, Done}
    public class TaskItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = "";
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
    }
}
