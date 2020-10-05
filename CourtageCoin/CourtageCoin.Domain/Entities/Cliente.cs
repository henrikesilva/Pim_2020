using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Cliente
    {
        public int CLI_INT_ID { get; set; }
        public int PEF_INT_ID { get; set; }
        public int PEJ_INT_ID { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual IEnumerable<Usuario> Usuarios { get; set; }
    }
}
