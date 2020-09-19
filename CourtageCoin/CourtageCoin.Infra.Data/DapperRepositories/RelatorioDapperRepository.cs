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
    class RelatorioDapperRepository : DapperContext, IRelatorioReadOnlyRepository
    {
        public RelatorioDapperRepository(IConfiguration configuration) : base (configuration)
        {
        }

        public IEnumerable<Relatorio> GetAll()
        {
            var conectiorString = this.GetConnection();
            using(var con = new SqlConnection(conectiorString))
            {
                try
                {
                    var relatorio = con.Query<Relatorio>(@"SELECT * FROM Relatorio");
                    return relatorio;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Relatorio GetById(int id)
        {
            var conectiorString = this.GetConnection();
            using (var con = new SqlConnection(conectiorString))
            {
                try
                {
                    var relatorio = con.Query<Relatorio>("SELECT * FROM Relatorio WHERE CodigoRelatorio = @id",
                        new {CodigoRelatorio = id }).FirstOrDefault();
                    return relatorio;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
