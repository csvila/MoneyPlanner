using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class ContaDomainSvc : ServiceBase<Conta>, IContaDomainSvc
    {
        private readonly IContaRepository repository;

        public ContaDomainSvc(IContaRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
