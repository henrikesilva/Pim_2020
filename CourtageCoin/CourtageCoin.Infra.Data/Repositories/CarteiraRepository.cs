using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Infra.Data.Context;
using CourtageCoin.Infra.Data.Repositories.Common;

namespace CourtageCoin.Infra.Data.Repositories
{
    public class CarteiraRepository : RepositoryBase<Carteira>, ICarteiraRepository
    {
        private readonly SqlContext _context;
        public CarteiraRepository(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
