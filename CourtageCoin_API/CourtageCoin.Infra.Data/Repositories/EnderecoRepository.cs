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
    public class EnderecoRepository : CourtageCoinContext, IEnderecoRepository
    {
        public EnderecoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Add(Endereco obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var endereco = con.Execute(@"INSERT INTO ENDERECO
	                                                                (
		                                                                END_STR_RUA,
		                                                                END_STR_NUMERO,
		                                                                END_STR_BAIRRO,
		                                                                END_STR_CIDADE,
		                                                                END_STR_COMPLEMENTO,
		                                                                END_STR_ESTADO
	                                                                )
                                                                VALUES
	                                                                (
		                                                                @END_STR_RUA,
		                                                                @END_STR_NUMERO,
		                                                                @END_STR_BAIRRO,
		                                                                @END_STR_CIDADE,
		                                                                @END_STR_COMPLEMENTO,
		                                                                @END_STR_ESTADO
	                                                                )",
                                                    new
                                                    {
                                                        END_STR_RUA = obj.END_STR_RUA,
                                                        END_STR_NUMERO = obj.END_STR_NUMERO,
                                                        END_STR_BAIRRO = obj.END_STR_BAIRRO,
                                                        END_STR_CIDADE = obj.END_STR_CIDADE,
                                                        END_STR_COMPLEMENTO = obj.END_STR_COMPLEMENTO,
                                                        END_STR_ESTADO = obj.END_STR_ESTADO
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

        public IEnumerable<Endereco> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var endereco = con.Query<Endereco>(@"SELECT   
	                                                            *
                                                            FROM 
	                                                            ENDERECO");

                    return endereco;
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

        public Endereco GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var endereco = con.Query<Endereco>(@"SELECT   
	                                                            *
                                                            FROM 
	                                                            ENDERECO
                                                            WHERE END_INT_ID = @END_INT_ID",
                                                            new { END_INT_ID = id }).FirstOrDefault();

                    return endereco;
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


        public void Update(Endereco obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var endereco = con.Execute(@"UPDATE
	                                                    ENDERECO
                                                    SET
	                                                    END_STR_RUA = @END_STR_RUA,
		                                                END_STR_NUMERO = @END_STR_NUMERO,
		                                                END_STR_BAIRRO = @END_STR_BAIRRO,
		                                                END_STR_CIDADE = @END_STR_CIDADE,
		                                                END_STR_COMPLEMENTO = @END_STR_COMPLEMENTO,
		                                                END_STR_ESTADO = @END_STR_ESTADO
                                                    WHERE
	                                                    END_INT_ID = @END_INT_ID",
                                                    new
                                                    {
                                                        obj.END_INT_ID,
                                                        END_STR_RUA = obj.END_STR_RUA,
                                                        END_STR_NUMERO = obj.END_STR_NUMERO,
                                                        END_STR_BAIRRO = obj.END_STR_BAIRRO,
                                                        END_STR_CIDADE = obj.END_STR_CIDADE,
                                                        END_STR_COMPLEMENTO = obj.END_STR_COMPLEMENTO,
                                                        END_STR_ESTADO = obj.END_STR_ESTADO
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


        public void Remove(Endereco obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
