using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Setor
    {
        public int SetorID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
