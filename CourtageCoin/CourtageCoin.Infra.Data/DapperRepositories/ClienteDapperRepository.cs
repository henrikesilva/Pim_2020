using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories.ReadOnly;
using CourtageCoin.Infra.Data.Context;
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
            using(var con = new SqlConnection(connectionString))
            {
                try
                {
                    var cliente = con.Query<Cliente>(@"SELECT * FROM Cliente");

                    return cliente;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Cliente GetById(int id)
        {
            var connectionString = this.GetConnection();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    var cliente = con.Query<Cliente>("Select * FROM Cliente WHERE CodigoCliente = @id",
                    new { CodigoCliente = id }).FirstOrDefault();

                    return cliente;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                
            }

        }
    }
}
