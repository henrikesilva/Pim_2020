using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly.Common;
using CourtageCoin.Domain.Interfaces.Repositories.Write.Common;
using CourtageCoin.Domain.Interfaces.Services.Common;
using CourtageCoin.Domain.Interfaces.Services.Write.Common;
using System;
using System.Collections.Generic;

namespace CourtageCoin.Domain.Services.Common
{
    public class ServiceBase<TEntity> : IDisposable, IWriteServiceBase<TEntity>, IReadOnlyServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        private readonly IBaseReadOnlyRepository<TEntity> _baseReadOnlyRepository;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase, IBaseReadOnlyRepository<TEntity> baseReadOnlyRepository)
        {
            _repositoryBase = repositoryBase;
            _baseReadOnlyRepository = baseReadOnlyRepository;
        }

        #region [WRITE]
        public void Adicionar(TEntity obj)
        {
            _repositoryBase.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repositoryBase.Atualizar(obj);
        }

        public void Remover(TEntity obj)
        {
            _repositoryBase.Remover(obj);
        }
        #endregion

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        #region [READ]
        public IEnumerable<TEntity> GetAll()
        {
            return _baseReadOnlyRepository.GetAll();
        }

        public TEntity GetByID(int id)
        {
            return _baseReadOnlyRepository.GetById(id);
        }
        #endregion
    }
}
