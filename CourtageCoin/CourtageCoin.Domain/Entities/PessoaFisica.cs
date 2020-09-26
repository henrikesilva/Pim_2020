using System;
using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class PessoaFisica
    {
        public int PessoaFisicaID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNacimento { get; set; }
        public int EnderecoID { get; set; }

        public Endereco Endereco { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
