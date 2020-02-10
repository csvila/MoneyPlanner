using MoneyPlannerDomain.Interfaces;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Descritivo do tipo de gasto, como parcela do apartamento ou cinema
    /// </summary>
    public class Gasto: IEntity
    {
        public int GastoId { get; set; }
        public string Descricao { get; set; }
        public bool Compartilhavel { get; set; }
        public IList<MovimentoDeSaida> Saidas { get; }
    }
}
