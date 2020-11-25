using AutoMapper;
using CourtageCoin.Application.Interface;
using CourtageCoin.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CourtageCoin.Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private readonly IMapper _mapper;
        public AppServiceBase(IServiceBase<TEntity> serviceBase, IMapper mapper)
        {
            _serviceBase = serviceBase;
            _mapper = mapper;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(_mapper.Map<TEntity>(obj));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _mapper.Map<IEnumerable<TEntity>>(_serviceBase.GetAll());
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
