using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Pais
    {
        public int PAI_INT_ID { get; set; }
        public string PAI_STR_DESC { get; set; }
        public string PAI_STR_SIGLA { get; set; }
        
        public virtual IEnumerable<Estado> Estados { get; set; }
    }
}
