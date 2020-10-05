namespace CourtageCoin.Domain.Entities
{
    public class EnderecoDTO
    {
        public int END_INT_ID { get; set; }
        public string EST_DTR_LOGRADOURO { get; set; }
        public string EST_STR_NUMERO { get; set; }
        public string EST_STR_BAIRRO { get; set; }
        public string EST_STR_COMPLEMENTO { get; set; }
        public int CID_INT_ID { get; set; }

        public virtual CidadeDTO Cidade { get; set; }
    }
}
