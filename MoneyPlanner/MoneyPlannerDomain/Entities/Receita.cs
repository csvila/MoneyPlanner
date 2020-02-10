using MoneyPlannerDomain.Interfaces;
using System.Collections.Generic;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Descritivo do tipo de receita, como salário
    /// </summary>
    public class Receita: IEntity
    {
        public int ReceitaId { get; set; }
        public string Descricao { get; set; }
        public IList<MovimentoDeEntrada> Entradas { get; }
    }
}
