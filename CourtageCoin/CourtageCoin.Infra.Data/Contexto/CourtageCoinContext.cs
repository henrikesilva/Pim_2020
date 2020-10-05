using CourtageCoin.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace CourtageCoin.Infra.Data.Contexto
{
    public abstract class CourtageCoinContext : IDisposable
    {
        IConfiguration _configuration;

        public CourtageCoinContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("Connection").Value;
            return connection;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #region TESTE
        /*public CourtageCoinContext(DbContextOptions<CourtageCoinContext> options) : base(options) { }

        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasOne(u => u.Cliente)
                      .WithMany(c => c.Usuarios)
                      .HasForeignKey(u => u.CLI_INT_ID);

                entity.HasOne(u => u.Funcionario)
                      .WithMany(f => f.Usuarios)
                      .HasForeignKey(u => u.FUN_INT_ID);
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasOne(c => c.Estado)
                      .WithMany(e => e.Cidades)
                      .HasForeignKey(c => c.EST_INT_ID);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasOne(c => c.PessoaFisica)
                      .WithMany(p => p.Clientes)
                      .HasForeignKey(c => c.PEF_INT_ID);

                entity.HasOne(c => c.PessoaJuridica)
                      .WithMany(p => p.Clientes)
                      .HasForeignKey(c => c.PEJ_INT_ID);
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasOne(e => e.Cidade)
                      .WithMany(c => c.Enderecos)
                      .HasForeignKey(e => e.CID_INT_ID);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasOne(e => e.Pais)
                      .WithMany(p => p.Estados)
                      .HasForeignKey(e => e.PAI_INT_ID);
            });

            modelBuilder.Entity<PessoaFisica>(entity =>
            {
                entity.HasOne(p => p.Endereco)
                      .WithMany(e => e.PessoaFisicas)
                      .HasForeignKey(p => p.END_INT_ID);
            });

            modelBuilder.Entity<PessoaJuridica>(entity => 
            {
                entity.HasOne(p => p.Endereco)
                      .WithMany(e => e.PessoaJuridicas)
                      .HasForeignKey(p => p.END_INT_ID);
            });
        }*/
        #endregion
    }
}
