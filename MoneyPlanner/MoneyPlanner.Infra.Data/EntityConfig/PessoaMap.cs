using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyPlannerDomain.Entities;

namespace MoneyPlanner.Infra.Data.EntityConfig
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.Cpf);
            builder.Property(x => x.Nome);
            builder.HasMany(x => x.Contas).WithOne(c => c.Dono);
            builder.HasMany(x => x.MovimentosEntrada).WithOne(c => c.Responsavel);
            builder.HasMany(x => x.MovimentosSaida).WithOne(c => c.Responsavel);
        }
    }
}
