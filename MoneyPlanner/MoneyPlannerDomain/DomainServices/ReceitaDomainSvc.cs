using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class ReceitaDomainSvc : ServiceBase<Receita>, IReceitaDomainSvc
    {
        private readonly IReceitaRepository repository;

        public ReceitaDomainSvc(IReceitaRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
