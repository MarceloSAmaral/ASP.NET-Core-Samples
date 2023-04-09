using System.Collections.Immutable;

namespace ToDoApp.CoreObjects.RepositoryInterfaces
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class
    {
        Task<ImmutableList<TEntity>> GetAllAsync();
        Task<TEntity> GetByKeyAsync(TKey pk);
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void Update(TEntity entityToUpdate);
        void UpdateRange(IEnumerable<TEntity> entitiesToUpdate);
        void Delete(TKey key);
    }
}
