using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class FuncionarioDTO
    {
        public int FUN_INT_ID { get; set; }
        public int FUN_INT_MATRICULA { get; set; }
        public string FUN_STR_NOME { get; set; }
        public int SET_INT_ID { get; set; }

        public virtual SetorDTO Setor { get; set; }
        public virtual IEnumerable<UsuarioDTO> Usuarios { get; set; }
    }
}
