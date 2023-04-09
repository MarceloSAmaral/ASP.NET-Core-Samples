namespace ToDoApp.CoreObjects.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string ItemContent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Completed { get; set; }
        public DateTime? CompletedAt { get; set; }

    }
}
