using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Pais
    {
        public int PaisID { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}
