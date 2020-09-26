using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>
    {
        private readonly IClienteWriteRepository _clienteWriteRepository;
        private readonly IClienteReadOnlyRepository _clienteReadOnlyRepository;

        public ClienteService(IClienteWriteRepository clienteWriteRepository, IClienteReadOnlyRepository clienteReadOnlyRepository)
            : base(clienteWriteRepository, clienteReadOnlyRepository)
        {
            _clienteWriteRepository = clienteWriteRepository;
            _clienteReadOnlyRepository = clienteReadOnlyRepository;
        }
    }
}
