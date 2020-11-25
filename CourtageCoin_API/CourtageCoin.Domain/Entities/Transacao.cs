using System;

namespace CourtageCoin.Domain.Entities
{
    public class Transacao
    {
        public int TRA_INT_ID { get; set; }
        public int TRA_INT_COD { get; set; }
        public DateTime TRA_DATE_DATA { get; set; }
        public decimal TRA_DEC_VALOR { get; set; }
        public int CAR_INT_ID { get; set; }
        public int CLI_INT_ID { get; set; }

        public virtual Carteira Carteira { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
