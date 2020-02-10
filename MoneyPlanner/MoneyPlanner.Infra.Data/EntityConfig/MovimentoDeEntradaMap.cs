using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class MovimentoDeEntradaMap : IEntityTypeConfiguration<MovimentoDeEntrada>
    {
        public void Configure(EntityTypeBuilder<MovimentoDeEntrada> builder)
        {
            builder.HasKey(x => x.MovimentoId);
            builder.Property(x => x.DataRealizacao).IsRequired();
            builder.Property(x => x.Previsao).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.HasOne(x => x.Receita).WithMany(c => c.Entradas).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Responsavel).WithMany(c => c.MovimentosEntrada).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
