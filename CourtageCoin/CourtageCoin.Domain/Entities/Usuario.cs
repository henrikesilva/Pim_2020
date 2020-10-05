using System;

namespace CourtageCoin.Domain.Entities
{
    public class Usuario
    {
        public int USU_INT_ID { get; set; }
        public string USU_STR_LOGIN { get; set; }
        public string USU_STR_SENHA { get; set; }
        public int USU_INT_TELEFONE { get; set; }
        public string USU_STR_EMAIL { get; set; }
        public DateTime USU_DATA_CADASTRO { get; set; }
        public int FUN_INT_ID { get; set; }
        public int CLI_INT_ID { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
