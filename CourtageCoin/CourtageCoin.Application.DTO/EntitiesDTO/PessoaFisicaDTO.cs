using System;

namespace CourtageCoin.Application.DTO.EntitiesDTO
{
    public class PessoaFisicaDTO
    {
        public int PEF_INT_ID { get; set; }
        public string PEF_STR_NOME { get; set; }
        public string PEF_STR_CPF { get; set; }
        public DateTime PEF_DATA_NASCIMENTO { get; set; }
        public int END_INT_ID { get; set; }

        public virtual EnderecoDTO Endereco { get; set; }
    }
}
