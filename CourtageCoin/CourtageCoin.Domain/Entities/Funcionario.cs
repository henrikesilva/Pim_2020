using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int SetorID { get; set; }

        public Setor Setor { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
