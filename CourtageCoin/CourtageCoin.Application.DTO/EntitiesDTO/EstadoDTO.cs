namespace CourtageCoin.Domain.Entities
{
    public class EstadoDTO
    {
        public int EST_INT_ID { get; set; }
        public string EST_STR_DESC { get; set; }
        public string EST_STR_SIGLA { get; set; }
        public int PAI_INT_ID { get; set; }

        public virtual PaisDTO Pais { get; set; }
    }
}
