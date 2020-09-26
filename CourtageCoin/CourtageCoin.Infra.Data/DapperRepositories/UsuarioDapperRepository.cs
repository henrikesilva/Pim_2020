using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Infra.Data.Contexto;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CourtageCoin.Infra.Data.DapperRepositories
{
    public class UsuarioDapperRepository : DapperContext, IUsuarioReadOnlyRepository
    {
        public UsuarioDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Usuario> GetAll()
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Query<Usuario>(@"SELECT * FROM USUARIO");
                    return usuario;
                }
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

        public Usuario GetById(int id)
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Query<Usuario>(@"SELECT * FROM USUARIO WHERE UsuarioID = @UsuarioID",
                        new { UsuarioID = id }).FirstOrDefault();

                    return usuario;
                }
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
