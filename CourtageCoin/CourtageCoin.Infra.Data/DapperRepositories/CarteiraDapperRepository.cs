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
    public class CarteiraDapperRepository : DapperContext, ICarteiraReadOnlyRepository
    {
        public CarteiraDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Carteira> GetAll()
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var carteira = con.Query<Carteira>(@"SELECT * FROM CARTEIRA");
                    return carteira;
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

        public Carteira GetById(int id)
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var carteira = con.Query<Carteira>(@"SELECT * FROM CARTEIRA WHERE CarteiraID = @CarteiraID",
                        new { CartertaID = id}).FirstOrDefault();

                    return carteira;
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
