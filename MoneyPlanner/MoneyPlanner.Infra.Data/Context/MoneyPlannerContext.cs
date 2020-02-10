using Microsoft.EntityFrameworkCore;
using MoneyPlannerDomain.Entities;
using System.Reflection;

namespace MoneyPlanner.Infra.Data.Context
{
    public class MoneyPlannerContext : DbContext
    {
        public MoneyPlannerContext(DbContextOptions<MoneyPlannerContext> options) : base(options) { }

        public DbSet<CategoriaGastos> CategoriasGastos { get; set; }
        public DbSet<CentroDeCusto> CentrosDeCusto { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<MovimentoDeEntrada> Entradas { get; set; }
        public DbSet<MovimentoDeSaida> Saidas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Receita> Receitas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties()
            //    .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //    .Configure(p => p.IsKey());

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasColumnType("varchar"));

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasMaxLength(100));
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
