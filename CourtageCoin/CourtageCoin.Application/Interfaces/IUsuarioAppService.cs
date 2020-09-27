using CourtageCoin.Application.DTO.Models;
using System.Collections.Generic;

namespace CourtageCoin.Application.Interfaces
{
    public interface IUsuarioAppService
    {
        void Adicionar(UsuarioDTO usuario);
        UsuarioDTO ObterPorId(int Id);
        IEnumerable<UsuarioDTO> ObterTodos();
        void Atualizar(UsuarioDTO usuario);
        void Remover(UsuarioDTO usuario);
        void Dispose();
    }
}
