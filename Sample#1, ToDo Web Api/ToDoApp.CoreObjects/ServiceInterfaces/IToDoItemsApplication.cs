using ToDoApp.CoreObjects.Models;

namespace ToDoApp.CoreObjects.ServiceInterfaces
{
    public interface IToDoItemsApplication
    {
        Task CompleteToDoItemAsync(User currentUser, Guid toDoItemId);
        Task CreateToDoItemAsync(User currentUser, ToDoItem toDoItem);
        Task DeleteToDoItemAsync(User currentUser, Guid toDoItemId);
        Task UpdateToDoItemAsync(User currentUser, ToDoItem toDoItem);
        Task<ToDoItem> GetItemByIdAsync(User currentUser, Guid toDoItemId);
        IEnumerable<ToDoItem> GetItems(User currentUser);
    }
}
