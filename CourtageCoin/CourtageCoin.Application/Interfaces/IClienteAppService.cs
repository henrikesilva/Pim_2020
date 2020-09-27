using CourtageCoin.Application.DTO.Models;
using System.Collections.Generic;

namespace CourtageCoin.Application.Interfaces
{
    public interface IClienteAppService
    {
        void Adicionar(ClienteDTO cliente);
        ClienteDTO ObterPorId(int Id);
        IEnumerable<ClienteDTO> ObterTodos();
        void Atualizar(ClienteDTO cliente);
        void Remover(ClienteDTO cliente);
        void Dispose();
    }
}
