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
    public class FuncionarioDapperRepository : DapperContext, IFuncionarioReadOnlyRepository
    {
        public FuncionarioDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Funcionario> GetAll()
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Query<Funcionario>(@"SELECT * FROM FUNCIONARIO");
                    return funcionario;
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

        public Funcionario GetById(int id)
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Query<Funcionario>(@"SELECT * FROM FUNCIONARIO WHERE FuncionarioID = @FuncionarioID",
                        new { FuncionarioID = id }).FirstOrDefault();

                    return funcionario;
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
