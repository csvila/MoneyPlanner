using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class CentroDeCustosDomainSvc : ServiceBase<CentroDeCusto>, ICentroDeCustosDomainSvc
    {
        private readonly ICentroDeCustosRepository repository;

        public CentroDeCustosDomainSvc(ICentroDeCustosRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
