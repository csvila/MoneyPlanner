using MoneyPlannerDomain.Entities;
using MoneyPlannerDomain.Interfaces.DomainServices;
using MoneyPlannerDomain.Interfaces.Repositories;

namespace MoneyPlannerDomain.DomainServices
{
    public class PessoaDomainSvc : ServiceBase<Pessoa>, IPessoaDomainSvc
    {
        private readonly IPessoaRepository repository;

        public PessoaDomainSvc(IPessoaRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
