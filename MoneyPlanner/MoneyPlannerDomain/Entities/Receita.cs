using MoneyPlannerDomain.Interfaces;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Descritivo do tipo de receita, como salário
    /// </summary>
    public class Receita: IEntity
    {
        public string Descricao { get; set; }
        public Conta ContaDestino { get; set; }
    }
}
