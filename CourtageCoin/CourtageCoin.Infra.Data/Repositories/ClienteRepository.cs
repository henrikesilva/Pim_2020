using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Infra.Data.Context;
using CourtageCoin.Infra.Data.Repositories.Common;

namespace CourtageCoin.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        private readonly SqlContext _context;
        public ClienteRepository(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
