using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Infra.Data.Contexto;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourtageCoin.Infra.Data.Repositories
{
    public class UsuarioRepository : CourtageCoinContext,/*RepositoryBase<Usuario>,*/ IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
            
        }

        public void Add(Usuario obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using(var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Query<Usuario>(@"SELECT * FROM USUARIO");

                    return usuario;
                }
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

        public Usuario GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Usuario obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
