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
    public class PessoaFisicaDapperRepository : DapperContext, IPessoaFisicaReadOnlyRepository
    {
        public PessoaFisicaDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<PessoaFisica> GetAll()
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var pessoaFisica = con.Query<PessoaFisica>(@"SELECT * FROM PESSOA_FISICA");
                    return pessoaFisica;
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

        public PessoaFisica GetById(int id)
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var pessoaFisica = con.Query<PessoaFisica>(@"SELECT * FROM PESSOA_FISICA WHERE PessoaFisicaID = @PessoaFisicaID",
                        new { PessoaFisicaID = id }).FirstOrDefault();

                    return pessoaFisica;
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
