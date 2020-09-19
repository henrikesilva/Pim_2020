using System.Collections.Generic;

namespace CourtageCoin.Domain.Interfaces.Repositories.ReadOnly.Common
{
    public interface IBaseReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
