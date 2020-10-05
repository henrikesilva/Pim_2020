using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Setor
    {
        public int SET_INT_ID { get; set; }
        public string SET_STR_NOME { get; set; }

        public virtual IEnumerable<Funcionario> Funcionarios { get; set; }
    }
}
