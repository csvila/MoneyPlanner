using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.HasKey(x => x.ReceitaId);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(35);
            builder.HasMany(x => x.Entradas).WithOne(c => c.Receita);
        }
    }
}
