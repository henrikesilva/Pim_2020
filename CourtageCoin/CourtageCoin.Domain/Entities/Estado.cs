using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Estado
    {
        public int EST_INT_ID { get; set; }
        public string EST_STR_DESC { get; set; }
        public string EST_STR_SIGLA { get; set; }
        public int PAI_INT_ID { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual IEnumerable<Cidade> Cidades { get; set; }
    }
}
