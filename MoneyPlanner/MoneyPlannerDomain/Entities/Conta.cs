using MoneyPlannerDomain.Interfaces;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Conta física ou virtual por onde circula o dinheiro.
    /// </summary>
    public class Conta: IEntity
    {
        public string Descricao { get; set; }
        public Pessoa Dono { get; set; }
    }
}
