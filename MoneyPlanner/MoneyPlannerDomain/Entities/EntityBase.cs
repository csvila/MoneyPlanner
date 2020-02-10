using MoneyPlannerDomain.Interfaces;
using MoneyPlannerDomain.Interfaces.DomainServices;
using System;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    public abstract class EntityBase<TEntity> : IDisposable where TEntity : IEntity
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public DateTime DataCadastro { get; set; }

        public EntityBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity item)
        {
            _serviceBase.Add(item);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity item)
        {
            _serviceBase.Update(item);
        }

        public void Remove(TEntity item)
        {
            _serviceBase.Remove(item);
        }

        public void Dispose() => _serviceBase.Dispose();
    }
}
