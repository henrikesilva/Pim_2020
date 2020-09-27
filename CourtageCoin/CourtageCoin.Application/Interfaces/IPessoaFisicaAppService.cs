using CourtageCoin.Application.DTO.Models;
using System.Collections.Generic;

namespace CourtageCoin.Application.Interfaces
{
    public interface IPessoaFisicaAppService
    {
        void Adicionar(PessoaFisicaDTO pessoa);
        PessoaFisicaDTO ObterPorId(int Id);
        IEnumerable<PessoaFisicaDTO> ObterTodos();
        void Atualizar(PessoaFisicaDTO pessoa);
        void Remover(PessoaFisicaDTO pessoa);
        void Dispose();
    }
}
