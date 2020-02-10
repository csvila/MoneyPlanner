using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(c => c.ContaId);
            builder.Property(c => c.Descricao);
            builder.Property(c => c.Dono);
            builder.HasMany(c => c.Entradas).WithOne(x => x.Conta);
            builder.HasMany(c => c.Saidas).WithOne(x => x.Conta);
        }
    }
}
