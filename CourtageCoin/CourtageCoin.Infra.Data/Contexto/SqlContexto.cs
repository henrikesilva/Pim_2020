using CourtageCoin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourtageCoin.Infra.Data.Contexto
{
    public class SqlContexto : DbContext
    {
        public SqlContexto(DbContextOptions<SqlContexto> options) : base(options)
        {

        }

        public DbSet<Carteira> Carteira { get; set; }
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

            //MAPEAMENTO TABELA CARTEIRA
            modelBuilder.Entity<Carteira>(entity =>
            {
                entity.HasOne(c => c.Cliente)
                      .WithMany(p => p.Carteiras)
                      .HasForeignKey(c => c.ClienteID);
            });

            //MAPEAMENTO TABELA CLIENTE
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasOne(c => c.PessoaFisica)
                      .WithMany(p => p.Clientes)
                      .HasForeignKey(c => c.PessoaFisicaID);

                entity.HasOne(c => c.PessoaJuridica)
                      .WithMany(p => p.Clientes)
                      .HasForeignKey(c => c.PessoaJuridicaID);
            });

            //MAPEAMENTO TABELA PESSOA FISICA
            modelBuilder.Entity<PessoaFisica>(entity =>
            {
                entity.HasOne(p => p.Endereco)
                      .WithMany(e => e.PessoaFisica)
                      .HasForeignKey(p => p.EnderecoID);
            });
            
            //MAPEAMENTO TABELA PESSOA JURIDICA
            modelBuilder.Entity<PessoaJuridica>(entity =>
            {
                entity.HasOne(p => p.Endereco)
                      .WithMany(e => e.PessoaJuridica)
                      .HasForeignKey(p => p.EnderecoID);
            });

            //MAPEAMENTO TABELA CIDADE
            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasOne(c => c.Estado)
                      .WithMany(e => e.Cidades)
                      .HasForeignKey(c => c.EstadoID);
            });

            //MAPEAMENTO TABELA ESTADOS
            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasOne(e => e.Pais)
                      .WithMany(p => p.Estados)
                      .HasForeignKey(e => e.PaisID);
            });

            //MAPEAMENTO TABELA FUNCIONARIO
            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasOne(f => f.Setor)
                      .WithMany(s => s.Funcionarios)
                      .HasForeignKey(f => f.SetorID);
            });

            //MAPEAMENTO DA TABELA USUARIO
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasOne(u => u.Funcionario)
                      .WithMany(f => f.Usuarios)
                      .HasForeignKey(u => u.FuncionarioID);

                entity.HasOne(u => u.Cliente)
                      .WithMany(c => c.Usuarios)
                      .HasForeignKey(u => u.ClienteID);
            });
        }
    }
}
