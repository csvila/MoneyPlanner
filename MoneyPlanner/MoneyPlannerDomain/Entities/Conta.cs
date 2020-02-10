using MoneyPlannerDomain.Interfaces;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Conta física ou virtual por onde circula o dinheiro.
    /// </summary>
    public class Conta: IEntity
    {
        public int ContaId { get; set; }
        public string Descricao { get; set; }
        public Pessoa Dono { get; set; }
        public IList<MovimentoDeEntrada> Entradas { get; }
        public IList<MovimentoDeSaida> Saidas { get; }
    }
}
