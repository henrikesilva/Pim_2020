using System;

namespace CourtageCoin.Services.DTO.Models
{
    public class ClienteDTO
    {
        public int CodigoCliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public UsuarioDTO Usuario { get; set; }
        public CarteiraDTO Carteira { get; set; }
        public RelatorioDTO Relatorio { get; set; }
    }
}
