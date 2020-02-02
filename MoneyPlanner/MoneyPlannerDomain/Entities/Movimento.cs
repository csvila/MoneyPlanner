using MoneyPlannerDomain.Interfaces;
using System;

namespace MoneyPlannerDomain.Entities
{
    /// <summary>
    /// Estrutura básica de cada movimento
    /// </summary>
    public abstract class Movimento: IEntity
    {
        public bool Previsao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataRealizacao { get; set; }
        public Pessoa Responsavel { get; set; }
    }
}
