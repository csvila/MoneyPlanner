using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class CentroDeCustoMap : IEntityTypeConfiguration<CentroDeCusto>
    {
        public void Configure(EntityTypeBuilder<CentroDeCusto> builder)
        {
            builder.HasKey(x => x.CentroDeCustoId);
            builder.Property(x => x.Descricao).HasMaxLength(50);
            builder.Property(x => x.SaldoPrevisto);
            builder.HasMany(x => x.Gastos);
        }
    }
}
