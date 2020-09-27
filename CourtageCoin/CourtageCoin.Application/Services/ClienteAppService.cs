using AutoMapper;
using CourtageCoin.Application.DTO.Models;
using CourtageCoin.Application.Interfaces;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CourtageCoin.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        #region [ESCRITA]
        public void Adicionar(ClienteDTO cliente)
        {
            _clienteService.Adicionar(_mapper.Map<Cliente>(cliente));
        }

        public void Atualizar(ClienteDTO cliente)
        {
            _clienteService.Remover(_mapper.Map<Cliente>(cliente));
        }

        public void Remover(ClienteDTO cliente)
        {
            _clienteService.Remover(_mapper.Map<Cliente>(cliente));
        }
        #endregion

        #region [CONSULTA]
        public ClienteDTO ObterPorId(int Id)
        {
            return _mapper.Map<ClienteDTO>(_clienteService.GetByID(Id));
        }

        public IEnumerable<ClienteDTO> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ClienteDTO>>(_clienteService.GetAll());
        }
        #endregion

        public void Dispose()
        {
            _clienteService.Dispose();
        }
    }
}
