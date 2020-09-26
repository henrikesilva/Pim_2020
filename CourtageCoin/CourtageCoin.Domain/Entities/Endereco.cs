using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoID { get; set; }
        public string Logadouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int CidadeID { get; set; }


        public Cidade Cidade { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisica { get; set; }
        public virtual ICollection<PessoaJuridica> PessoaJuridica { get; set; }
    }
}
