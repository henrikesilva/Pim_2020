namespace CourtageCoin.Services.DTO.Models
{
    public class CarteiraDTO
    {
        public int NumeroCarteira { get; set; }
        public string NomeAtivo { get; set; }
        public int Valor { get; set; }
        public ClienteDTO Cliente { get; set; }
    }
}
