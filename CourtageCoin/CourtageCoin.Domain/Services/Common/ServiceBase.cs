using CourtageCoin.Domain.Interfaces.Repositories.Common;
using CourtageCoin.Domain.Interfaces.Services.Common;
using CourtageCoin.Domain.Interfaces.Services.ReadOnly.Common;
using System;
using System.Collections.Generic;

namespace CourtageCoin.Domain.Services.Common
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity>, IReadOnlyServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _irepositoryBase;
        private readonly IBaseReadOnlyRepository<TEntity> _ibaseReadOnlyRepository;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase, IBaseReadOnlyRepository<TEntity> baseReadOnlyRepository)
        {
            _irepositoryBase = repositoryBase;
            _ibaseReadOnlyRepository = baseReadOnlyRepository;
        }

        #region Escrita
        public void Adicionar(TEntity obj)
        {
            _irepositoryBase.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _irepositoryBase.Remover(obj);
        }
        public void Remover(TEntity obj)
        {
            _irepositoryBase.Remover(obj);
        }

        #endregion
        #region Leitura
        public IEnumerable<TEntity> GetAll()
        {
            return _ibaseReadOnlyRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _ibaseReadOnlyRepository.GetById(id);
        }
        #endregion

        public void Dispose()
        {
            _irepositoryBase.Dispose();
        }
    }
}
