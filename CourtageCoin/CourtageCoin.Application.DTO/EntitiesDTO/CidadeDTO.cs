namespace CourtageCoin.Domain.Entities
{
    public class CidadeDTO
    {
        public int CID_INT_ID { get; set; }
        public string CID_STR_DESC { get; set; }
        public int EST_INT_ID { get; set; }

        public virtual EstadoDTO Estado { get; set; }
    }
}
