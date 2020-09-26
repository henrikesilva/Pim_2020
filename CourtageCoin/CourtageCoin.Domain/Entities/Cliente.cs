using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public int PessoaFisicaID { get; set; }
        public int PessoaJuridicaID { get; set; }

        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }

        public virtual ICollection<Carteira> Carteiras { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
