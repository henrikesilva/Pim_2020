using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteService clienteService, IMapper mapper) : base(clienteService, mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }
    }
}
