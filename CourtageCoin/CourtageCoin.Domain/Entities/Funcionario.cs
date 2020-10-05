using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Funcionario
    {
        public int FUN_INT_ID { get; set; }
        public int FUN_INT_MATRICULA { get; set; }
        public string FUN_STR_NOME { get; set; }
        public int SET_INT_ID { get; set; }

        public virtual Setor Setor { get; set; }
        public virtual IEnumerable<Usuario> Usuarios { get; set; }
    }
}
