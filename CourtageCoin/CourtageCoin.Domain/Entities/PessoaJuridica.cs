using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class PessoaJuridica
    {
        public int PessoaJuridicaID { get; set; }
        public string CNPJ { get; set; }
        public int InscricaoMunicipal { get; set; }
        public int InscricaoEstadual { get; set; }
        public string RazaoSocial { get; set; }
        public int EnderecoID { get; set; }

        public Endereco Endereco { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
