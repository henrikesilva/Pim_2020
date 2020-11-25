using System;

namespace CourtageCoin.Application.DTO.EntitiesDTO
{
    public class TransacaoDTO
    {
        public int TRA_INT_ID { get; set; }
        public int TRA_INT_COD { get; set; }
        public DateTime TRA_DATE_DATA { get; set; }
        public decimal TRA_DEC_VALOR { get; set; }
        public int CAR_INT_ID { get; set; }
        public int CLI_INT_ID { get; set; }

        public virtual CarteiraDTO Carteira { get; set; }
        public virtual ClienteDTO Cliente { get; set; }
    }
}
