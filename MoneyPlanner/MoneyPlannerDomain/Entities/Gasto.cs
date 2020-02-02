using MoneyPlannerDomain.Interfaces;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Descritivo do tipo de gasto, como parcela do apartamento ou cinema
    /// </summary>
    public class Gasto: IEntity
    {
        public string Descricao { get; set; }
        public bool Compartilhavel { get; set; }
    }
}
