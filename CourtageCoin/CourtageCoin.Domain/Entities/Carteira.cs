namespace CourtageCoin.Domain.Entities
{
    public class Carteira
    {
        public int NumeroCarteira { get; set; }
        public string NomeAtivo { get; set; }
        public int Valor { get; set; }
        public Cliente cliente { get; set; }
    }
}
