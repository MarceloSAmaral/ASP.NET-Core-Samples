using System.Collections.Immutable;
using ToDoApp.CoreObjects.Models;

namespace ToDoApp.CoreObjects.RepositoryInterfaces
{
    public interface IToDoItemsRepository : IGenericRepository<ToDoItem, Guid>
    {
        ImmutableList<ToDoItem> GetByUserId(Guid userId);
    }
}
