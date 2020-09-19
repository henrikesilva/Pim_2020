using CourtageCoin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourtageCoin.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        //MAPEAMENTO DAS ENTIDADES DA API
        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Relatorio> Relatorio { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        //MAPEAMENTO DE RELACIONAMENTOS DAS ENTIDADES
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //MAPEAMENTO DA TABELA USUARIO
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasOne(d => d.cliente)
                      .WithMany(u => u.usuario)
                      .HasForeignKey(d => d.ClienteId);

                entity.HasOne(d => d.funcionario)
                      .WithMany(f => f.usuario)
                      .HasForeignKey(d => d.FuncionarioId);
            });
        }

    }
}
