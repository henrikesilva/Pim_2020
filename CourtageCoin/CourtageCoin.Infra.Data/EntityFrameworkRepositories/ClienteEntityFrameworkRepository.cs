using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.Write;
using CourtageCoin.Infra.Data.Contexto;
using CourtageCoin.Infra.Data.EntityFrameworkRepositories.Common;

namespace CourtageCoin.Infra.Data.EntityFrameworkRepositories
{
    public class ClienteEntityFrameworkRepository : RepositoryBase<Cliente>, IClienteWriteRepository
    {
        private readonly SqlContexto _sqlContexto;
        public ClienteEntityFrameworkRepository(SqlContexto sqlContexto) : base(sqlContexto)
        {
            _sqlContexto = sqlContexto;
        }
    }
}
