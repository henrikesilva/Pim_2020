using System;
using System.Collections.Generic;

namespace CourtageCoin.Domain.Entities
{
    public class Cliente
    {
        public int CLI_INT_ID { get; set; }
        public string CLI_STR_NOME { get; set; }
        public string CLI_STR_CPF { get; set; }
        public DateTime CLI_DATE_NASCIMENTO { get; set; }
        public int END_INT_ID { get; set; }

        public Endereco Endereco { get; set; }
    }
}
