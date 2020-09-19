using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Infra.Data.Context;
using CourtageCoin.Infra.Data.Repositories.Common;

namespace CourtageCoin.Infra.Data.Repositories
{
    public class PessoaFisicaRepository : RepositoryBase<PessoaFisica>, IPessoaFisicaRepository
    {
        private readonly SqlContext _context;
        public PessoaFisicaRepository(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
