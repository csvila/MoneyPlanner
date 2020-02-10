using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class MovimentoDeSaidaMap : IEntityTypeConfiguration<MovimentoDeSaida>
    {
        public void Configure(EntityTypeBuilder<MovimentoDeSaida> builder)
        {
            builder.HasKey(x => x.MovimentoId);
            builder.Property(x => x.DataRealizacao).IsRequired();
            builder.Property(x => x.Previsao).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.HasOne(x => x.Despesa).WithMany(c => c.Saidas).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Responsavel).WithMany(c => c.MovimentosSaida).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
