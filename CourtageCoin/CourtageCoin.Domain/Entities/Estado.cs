using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public int PaisID { get; set; }

        public Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
