using MoneyPlannerDomain.Interfaces;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Agrupamento macro das movimentações. Podem ser criads centros de custo temporários, como para uma festa
    /// </summary>
    public class CentroDeCusto: IEntity
    {
        public string Descricao { get; set; }
        public decimal SaldoPrevisto { get; set; }
        public IList<Gasto> Gastos { get; }
    }
}
