using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Domain.Interfaces.Services;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly;
using CourtageCoin.Domain.Services.Common;

namespace CourtageCoin.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _iclienteRepository;
        private readonly IClienteReadOnlyRepository _iclienteReadOnlyRepository;

        public ClienteService(IClienteRepository clienteRepository ,IClienteReadOnlyRepository clienteReadOnlyRepository) : base(clienteRepository ,clienteReadOnlyRepository)
        {
            _iclienteRepository = clienteRepository;
            _iclienteReadOnlyRepository = clienteReadOnlyRepository;
        }
    }
}
