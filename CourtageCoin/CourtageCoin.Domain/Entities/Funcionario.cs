using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Funcionario
    {
        public int FUN_INT_ID { get; set; }
        public string FUN_STR_NOME { get; set; }
        
        public virtual IEnumerable<Usuario> Usuarios { get; set; }
    }
}
