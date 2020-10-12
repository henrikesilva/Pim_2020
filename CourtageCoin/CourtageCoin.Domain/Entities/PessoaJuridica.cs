using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class PessoaJuridica
    {
        public int PEJ_INT_ID { get; set; }
        public string PEJ_STR_CNPJ { get; set; }
        public int PEJ_INT_IE { get; set; }
        public int PEJ_INT_IM { get; set; }
        public string PEJ_STR_RAZAO_SOCIAL { get; set; }
        public int END_INT_ID { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual IEnumerable<Cliente> Clientes { get; set; }
    }
}
