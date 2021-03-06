using DM.Shared.Core.Aggregates;
using DM.Shared.Core.Entities;
using EntityFrameworkCore.CommonTools;

namespace DM.Shared.Core.Repositories
{
    public interface ISearchable<TEntity> 
        where TEntity : class, IEntity, IAggregateRoot
    {
        TEntity? First(ISpecification<TEntity> criteria);
        Task<TEntity?> FirstAsync(ISpecification<TEntity> criteria);
    }
}
