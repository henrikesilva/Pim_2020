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
    public class ClienteDapperRepository : DapperContext, IClienteReadOnlyRepository
    {
        public ClienteDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Cliente> GetAll()
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var cliente = con.Query<Cliente>(@"SELECT * FROM CLIENTE");
                    return cliente;
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

        public Cliente GetById(int id)
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var cliente = con.Query<Cliente>(@"SELECT * FROM CLIENTE WHERE ClienteID = @ClienteID",
                        new { ClienteID = id }).FirstOrDefault();

                    return cliente;
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
