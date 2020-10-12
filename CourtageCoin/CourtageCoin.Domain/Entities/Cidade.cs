using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Cidade
    {
        public int CID_INT_ID { get; set; }
        public string CID_STR_DESC { get; set; }

        public virtual IEnumerable<Endereco> Enderecos { get; set; }
    }
}
