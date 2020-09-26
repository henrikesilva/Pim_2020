namespace CourtageCoin.Domain.Entities
{
    public class Carteira
    {
        public int CarteiraID { get; set; }
        public int NumeroCarteira { get; set; }
        public string NomeAtivo { get; set; }
        public int Valor { get; set; }
        public int ClienteID { get; set; }


        public Cliente Cliente { get; set; }
    }
}
