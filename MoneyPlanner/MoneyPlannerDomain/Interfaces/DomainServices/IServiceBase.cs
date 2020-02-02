using System.Collections.Generic;

namespace MoneyPlannerDomain.Interfaces.DomainServices
{
    public interface IServiceBase<TEntity> where TEntity : IEntity
    {
        void Add(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity item);
        void Remove(TEntity item);
        void Dispose();
    }
}
