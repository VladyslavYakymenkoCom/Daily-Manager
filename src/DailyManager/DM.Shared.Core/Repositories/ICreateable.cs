using DM.Shared.Core.Aggregates;
using DM.Shared.Core.Entities;

namespace DM.Shared.Core.Repositories
{
    public interface ICreateable<TEntity> 
        where TEntity : class, IEntity, IAggregateRoot
    {
        TEntity Create(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity);
    }
}
