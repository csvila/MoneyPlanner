using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class GastoMap : IEntityTypeConfiguration<Gasto>
    {
        public void Configure(EntityTypeBuilder<Gasto> builder)
        {
            builder.HasKey(x => x.GastoId);
            builder.Property(x => x.Descricao).HasMaxLength(30);
            builder.Property(x => x.Compartilhavel);
        }
    }
}
