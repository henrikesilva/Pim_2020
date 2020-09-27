using System;

namespace CourtageCoin.Application.DTO.Models
{
    public class UsuarioDTO
    {
        public int UsuarioID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public int FuncionarioID { get; set; }
        public int ClienteID { get; set; }

        public FuncionarioDTO FuncionarioDTO { get; set; }
        public ClienteDTO ClienteDTO { get; set; }
    }
}
