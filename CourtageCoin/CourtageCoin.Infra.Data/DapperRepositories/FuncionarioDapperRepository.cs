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
    public class FuncionarioDapperRepository : DapperContext, IFuncionarioReadOnlyRepository
    {
        public FuncionarioDapperRepository(IConfiguration configuration): base(configuration)
        {

        }
        public IEnumerable<Funcionario> GetAll()
        {
            var connectionString = this.GetConnection();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    var funcionario = con.Query<Funcionario>(@"SELECT * FROM Funcionario");
                    return funcionario;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Funcionario GetById(int id)
        {
            var connectionString = this.GetConnection();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    var funcionario = con.Query<Funcionario>("SELECT * FROM Funcionario WHERE Matricula = @id",
                        new { Matricula = id}).FirstOrDefault();

                    return funcionario;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
