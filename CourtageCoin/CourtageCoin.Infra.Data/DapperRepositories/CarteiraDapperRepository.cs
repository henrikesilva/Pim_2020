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
    public class CarteiraDapperRepository : DapperContext, ICarteiraReadOnlyRepository
    {
        public CarteiraDapperRepository(IConfiguration configuration) : base(configuration)
        {

        }
        public Carteira ConsultarAtivo(string Nome)
        {
            var connectionString = this.GetConnection();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    var carteira = con.Query<Carteira>("Select * FROM Carteira Where NomeAtivo = @Nome",
                    new { NomeAtivo = Nome }).FirstOrDefault();

                    return carteira;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Carteira> GetAll()
        {
            var connectionString = this.GetConnection();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    var carteira = con.Query<Carteira>(@"SELECT * FROM Carteira");
                    return carteira;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Carteira GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
