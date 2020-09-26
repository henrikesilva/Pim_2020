using System;

namespace CourtageCoin.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public int FuncionarioID { get; set; }
        public int ClienteID { get; set; }

        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
    }
}
