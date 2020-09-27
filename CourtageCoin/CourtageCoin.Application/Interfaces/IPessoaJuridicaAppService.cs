using CourtageCoin.Application.DTO.Models;
using System.Collections.Generic;

namespace CourtageCoin.Application.Interfaces
{
    public interface IPessoaJuridicaAppService
    {
        void Adicionar(PessoaJuridicaDTO pessoa);
        PessoaJuridicaDTO ObterPorId(int Id);
        IEnumerable<PessoaJuridicaDTO> ObterTodos();
        void Atualizar(PessoaJuridicaDTO pessoa);
        void Remover(PessoaJuridicaDTO pessoa);
        void Dispose();
    }
}
