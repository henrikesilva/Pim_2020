namespace CourtageCoin.Application.DTO.Models
{
    public class PessoaFisicaDTO
    {
        public int PessoaFisicaID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNacimento { get; set; }
        public int EnderecoID { get; set; }
    }
}
