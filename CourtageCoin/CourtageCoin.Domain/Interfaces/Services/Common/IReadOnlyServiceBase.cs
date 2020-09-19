using System.Collections.Generic;

namespace CourtageCoin.Domain.Interfaces.Services.Common
{
    public interface IReadOnlyServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
