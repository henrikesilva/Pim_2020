namespace CourtageCoin.Domain.Entities
{
    public class Cidade
    {
        public int CidadeID { get; set; }
        public string Descricao { get; set; }
        public int EstadoID { get; set; }

        public Estado Estado { get; set; }
    }
}
