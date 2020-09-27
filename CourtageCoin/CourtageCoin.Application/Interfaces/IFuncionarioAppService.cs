using CourtageCoin.Application.DTO.Models;
using System.Collections.Generic;

namespace CourtageCoin.Application.Interfaces
{
    public interface IFuncionarioAppService
    {
        void Adicionar(FuncionarioDTO funcionario);
        FuncionarioDTO ObterPorId(int Id);
        IEnumerable<FuncionarioDTO> ObterTodos();
        void Atualizar(FuncionarioDTO funcionario);
        void Remover(FuncionarioDTO funcionario);
        void Dispose();
    }
}
