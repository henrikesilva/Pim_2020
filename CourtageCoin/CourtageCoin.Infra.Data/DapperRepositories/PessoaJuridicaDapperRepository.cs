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
    public class PessoaJuridicaDapperRepository : DapperContext, IPessoaJuridicaReadOnlyRepository
    {
        public PessoaJuridicaDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<PessoaJuridica> GetAll()
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var pessoaJuridica = con.Query<PessoaJuridica>(@"SELECT * FROM PESSOA_JURIDICA");
                    return pessoaJuridica;
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

        public PessoaJuridica GetById(int id)
        {
            var connectionString = this.GetConnection();
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    var pessoaJuridica = con.Query<PessoaJuridica>(@"SELECT * FROM PESSOA_JURIDICA WHERE PessoaJuridicaID = @PessoaJuridicaID",
                        new { PessoaJuridicaID = id }).FirstOrDefault();

                    return pessoaJuridica;
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
