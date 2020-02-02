namespace MoneyPlannerDomain.Entities
{
    public class MovimentoDeSaida:Movimento
    {
        public Gasto Despesa { get; set; }
        public CentroDeCusto CentroDeCusto { get; set; }
        public Conta Conta { get; set; }
    }
}
