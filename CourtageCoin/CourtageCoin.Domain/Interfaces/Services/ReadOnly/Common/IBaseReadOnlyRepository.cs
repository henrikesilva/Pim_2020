using System.Collections.Generic;

namespace CourtageCoin.Domain.Interfaces.Services.ReadOnly.Common
{
    public interface IBaseReadOnlyRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
