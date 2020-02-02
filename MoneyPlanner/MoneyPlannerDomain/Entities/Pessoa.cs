using MoneyPlannerDomain.Interfaces;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Pessoa que pode Gastar ou Receber
    /// </summary>
    public class Pessoa: IEntity
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public IList<Conta> Contas { get; }
        public IList<Movimento> Movimentos { get; }
    }
}
