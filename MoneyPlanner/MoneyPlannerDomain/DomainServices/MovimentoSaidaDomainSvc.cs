using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class MovimentoSaidaDomainSvc : ServiceBase<MovimentoDeSaida>, IMovimentoSaidaDomainSvc
    {
        private readonly IMovimentoSaidaRepository repository;

        public MovimentoSaidaDomainSvc(IMovimentoSaidaRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
