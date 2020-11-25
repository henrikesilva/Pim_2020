namespace CourtageCoin.Domain.Entities
{
    public class Carteira
    {
        public int CAR_INT_ID { get; set; }
        public string CAR_STR_NOME_ATIVO { get; set; }
        public int CAR_DEC_VALOR { get; set; }
        public decimal CAR_DEC_SALDO { get; set; }
        public int CLI_INT_ID { get; set; }

        public Cliente Cliente { get; set; }
    }
}
