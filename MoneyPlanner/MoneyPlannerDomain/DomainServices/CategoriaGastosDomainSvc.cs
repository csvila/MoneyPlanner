using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class CategoriaGastosDomainSvc : ServiceBase<CategoriaGastos>, ICategoriaGastosDomainSvc
    {
        private readonly ICategoriaGastosRepository repository;

        public CategoriaGastosDomainSvc(ICategoriaGastosRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
