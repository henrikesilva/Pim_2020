namespace CourtageCoin.Application.DTO.Models
{
    public class PessoaJuridicaDTO
    {
        public int PessoaJuridicaID { get; set; }
        public string CNPJ { get; set; }
        public int InscricaoMunicipal { get; set; }
        public int InscricaoEstadual { get; set; }
        public string RazaoSocial { get; set; }
        public int EnderecoID { get; set; }
    }
}
