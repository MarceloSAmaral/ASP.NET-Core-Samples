using ToDoApp.CoreObjects.Models;

namespace ToDoApp.CoreObjects.ServiceInterfaces
{
    public interface IUsersApplication
    {
        Task<User> GetUserByIdAsync(Guid id);
    }
}
