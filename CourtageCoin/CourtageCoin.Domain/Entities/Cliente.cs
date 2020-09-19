using System;
using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public virtual ICollection<Usuario> usuario { get; set; }
        public Relatorio relatorio { get; set; }
        public Carteira carteira { get; set; }
    }
}
