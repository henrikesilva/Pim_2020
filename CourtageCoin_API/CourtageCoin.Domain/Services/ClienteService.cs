using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;

namespace CourtageCoin.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
