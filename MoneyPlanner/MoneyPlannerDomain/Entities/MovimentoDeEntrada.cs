namespace MoneyPlannerDomain.Entities
{
    public class MovimentoDeEntrada : Movimento
    {
        public Receita Receita { get; set; }
    }
}
