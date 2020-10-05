using System;
using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class PessoaFisica
    {
        public int PEF_INT_ID { get; set; }
        public string PEF_STR_NOME { get; set; }
        public string PEF_STR_CPF { get; set; }
        public DateTime PEF_DATE_NASCIMENTO { get; set; }
        public int END_INT_ID { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual IEnumerable<Cliente> Clientes { get; set; }
    }
}
