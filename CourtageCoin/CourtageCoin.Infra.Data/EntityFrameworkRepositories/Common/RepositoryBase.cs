using CourtageCoin.Domain.Interfaces.Repositories.Write.Common;
using CourtageCoin.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace CourtageCoin.Infra.Data.EntityFrameworkRepositories.Common
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        public readonly SqlContexto _sqlContexto;
        public RepositoryBase(SqlContexto sqlContexto)
        {
            _sqlContexto = sqlContexto;
        }

        public virtual void Adicionar(TEntity obj)
        {
            try
            {
                _sqlContexto.Set<TEntity>().Add(obj);
                _sqlContexto.SaveChanges();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Atualizar(TEntity obj)
        {
            try
            {
                _sqlContexto.Entry(obj).State = EntityState.Modified;
                _sqlContexto.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remover(TEntity obj)
        {
            try
            {
                _sqlContexto.Set<TEntity>().Remove(obj);
                _sqlContexto.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Dispose()
        {
            try
            {
                _sqlContexto.Dispose();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
