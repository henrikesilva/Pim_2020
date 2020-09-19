using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Perfil { get; set; }
        
        public virtual Relatorio Relatorio { get; set; }
        public virtual ICollection<Usuario> usuario { get; set; }
    }
}
