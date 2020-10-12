using System;

namespace CourtageCoin.Application.DTO.EntitiesDTO
{
    public class TransacaoDTO
    {
        public int TRA_INT_ID { get; set; }
        public int TRA_INT_COD { get; set; }
        public DateTime TRA_DATE_DATA { get; set; }
        public CarteiraDTO CarteiraDTO { get; set; }
        public ClienteDTO  ClienteDTO { get; set; }
    }
}
