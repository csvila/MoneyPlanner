using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;
using System;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class CategoriaGastosMap : IEntityTypeConfiguration<CategoriaGastos>
    {
        public void Configure(EntityTypeBuilder<CategoriaGastos> builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(x => x.CategoriaGastosId);
            builder.Property(x => x.DataCadastro).HasColumnType("smalldatetime").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Descricao).HasMaxLength(150).IsRequired();
            builder.HasMany(x => x.Gastos);
        }
    }
}
