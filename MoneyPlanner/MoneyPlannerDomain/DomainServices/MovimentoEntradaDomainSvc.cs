using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class MovimentoEntradaDomainSvc : ServiceBase<MovimentoDeEntrada>, IMovimentoEntradaDomainSvc
    {
        private readonly IMovimentoEntradaRepository repository;

        public MovimentoEntradaDomainSvc(IMovimentoEntradaRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
