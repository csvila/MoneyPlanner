using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class GastoDomainSvc : ServiceBase<Gasto>, IGastoDomainSvc
    {
        private readonly IGastoRepository repository;

        public GastoDomainSvc(IGastoRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
