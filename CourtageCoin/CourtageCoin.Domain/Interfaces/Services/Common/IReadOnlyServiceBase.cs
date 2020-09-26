using System.Collections.Generic;

namespace CourtageCoin.Domain.Interfaces.Services.Common
{
    public interface IReadOnlyServiceBase<TEntity> where TEntity : class
    {
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
    }
}
