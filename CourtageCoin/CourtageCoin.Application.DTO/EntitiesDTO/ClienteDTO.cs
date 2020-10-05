using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }
        public int PessoaFisicaId { get; set; }
        public int PessoaJuridicaId { get; set; }

        public virtual PessoaFisicaDTO PessoaFisica { get; set; }
        public virtual PessoaJuridicaDTO PessoaJuridica { get; set; }
        public virtual IEnumerable<UsuarioDTO> Usuarios { get; set; }
    }
}
