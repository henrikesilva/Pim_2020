using CourtageCoin.Domain.Entities;
using CourtageCoin.Domain.Interfaces.Repositories;
using CourtageCoin.Infra.Data.Contexto;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CourtageCoin.Infra.Data.Repositories
{
    public class TransacaoRepository : CourtageCoinContext, ITransacaoRepository
    {
        public TransacaoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Add(Transacao obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var transacao = con.Execute(@"INSERT INTO 
                                                            TRANSACAO
	                                                        (
		                                                        TRA_INT_COD,
		                                                        TRA_DATE_DATA,
		                                                        TRA_DEC_VALOR,
                                                                CLI_INT_ID,
		                                                        CAR_INT_ID
	                                                        )
                                                        VALUES
	                                                        (
		                                                        @TRA_INT_COD,
		                                                        @TRA_DATE_DATA,
		                                                        @TRA_DEC_VALOR,
                                                                @CLI_INT_ID,
		                                                        @CAR_INT_ID
	                                                        )",
                                                    new
                                                    {
                                                        TRA_INT_COD = obj.TRA_INT_COD,
                                                        TRA_DATE_DATA = obj.TRA_DATE_DATA,
                                                        TRA_DEC_VALOR = obj.TRA_DEC_VALOR,
                                                        CLI_INT_ID = obj.CLI_INT_ID,
                                                        CAR_INT_ID = obj.CAR_INT_ID

                                                    });
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

        public IEnumerable<Transacao> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var transacao = con.Query<Transacao>(@"SELECT 
	                                                            T.TRA_INT_ID,
	                                                            T.TRA_INT_COD,
	                                                            T.TRA_DEC_VALOR,
	                                                            T.TRA_DATE_DATA,
	                                                            CLI.CLI_STR_NOME,
	                                                            CAR.CAR_INT_ID
                                                            FROM	
	                                                            TRANSACAO AS T
	                                                            INNER JOIN CLIENTE AS CLI ON CLI.CLI_INT_ID = T.CLI_INT_ID
	                                                            INNER JOIN CARTEIRA AS CAR ON CAR.CAR_INT_ID = T.CAR_INT_ID");

                    return transacao;
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

        public Transacao GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var transacao = con.Query<Transacao>(@"SELECT 
	                                                            T.TRA_INT_ID,
	                                                            T.TRA_INT_COD,
	                                                            T.TRA_DEC_VALOR,
	                                                            T.TRA_DATE_DATA,
	                                                            CLI.CLI_STR_NOME,
	                                                            CAR.CAR_INT_ID
                                                            FROM	
	                                                            TRANSACAO AS T
	                                                            INNER JOIN CLIENTE AS CLI ON CLI.CLI_INT_ID = T.CLI_INT_ID
	                                                            INNER JOIN CARTEIRA AS CAR ON CAR.CAR_INT_ID = T.CAR_INT_ID
                                                            WHERE
                                                                T.TRA_INT_ID = @TRA_INT_ID", new { TRA_INT_ID = id }).FirstOrDefault();

                    return transacao;
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


        public void Update(Transacao obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Execute(@"UPDATE
	                                                    TRANSACAO
                                                    SET
	                                                    TRA_INT_COD = @TRA_INT_COD,
		                                                TRA_DATE_DATA = @TRA_DATE_DATA,
		                                                TRA_DEC_VALOR = @TRA_DEC_VALOR,
                                                        CLI_INT_ID = @CLI_INT_ID,
		                                                CAR_INT_ID = @CAR_INT_ID
                                                    WHERE
	                                                    TRA_INT_ID = @TRA_INT_ID",
                                                    new
                                                    {
                                                        obj.TRA_INT_ID,
                                                        TRA_INT_COD = obj.TRA_INT_COD,
                                                        TRA_DATE_DATA = obj.TRA_DATE_DATA,
                                                        TRA_DEC_VALOR = obj.TRA_DEC_VALOR,
                                                        CLI_INT_ID = obj.CLI_INT_ID,
                                                        CAR_INT_ID = obj.CAR_INT_ID
                                                    });
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
        public void Remove(Transacao obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
