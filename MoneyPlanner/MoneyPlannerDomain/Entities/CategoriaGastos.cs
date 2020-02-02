using MoneyPlannerDomain.Interfaces;
using MoneyPlannerDomain.Interfaces.DomainServices;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Categoria dos gstos, como moradia e educação
    /// </summary>
    public class CategoriaGastos : EntityBase<CategoriaGastos>, IEntity
    {
        public CategoriaGastos(IServiceBase<CategoriaGastos> serviceBase) : base(serviceBase)
        {
        }

        public string Descricao { get; set; }
        public IList<Gasto> Gastos { get; }
    }
}
