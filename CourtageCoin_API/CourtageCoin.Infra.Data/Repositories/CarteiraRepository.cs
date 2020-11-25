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
    public class CarteiraRepository : CourtageCoinContext, ICarteiraRepository
    {
        public CarteiraRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Add(Carteira obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var carteira = con.Execute(@"INSERT INTO CARTEIRA
	                                                (
                                                        CAR_INT_ID,
                                                        CAR_STR_NOME_ATIVO,
                                                        CAR_DEC_VALOR,
                                                        CAR_DEC_SALDO, 
                                                        CLI_INT_ID
                                                    )
                                                VALUES
	                                                (
                                                        @CAR_INT_ID,
                                                        @CAR_STR_NOME_ATIVO,
                                                        @CAR_DEC_VALOR,
                                                        @CAR_DEC_SALDO, 
                                                        @CLI_INT_ID
                                                    )",
                                                    new
                                                    {
                                                        CAR_STR_NOME_ATIVO = obj.CAR_STR_NOME_ATIVO,
                                                        CAR_DEC_VALOR = obj.CAR_DEC_VALOR,
                                                        CAR_DEC_SALDO = obj.CAR_DEC_SALDO,
                                                        CLI_INT_ID = obj.CLI_INT_ID
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

        public IEnumerable<Carteira> GetAll()
        {

            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var carteira = con.Query<Carteira>(@"SELECT 
	                                                        C.CAR_INT_ID,
	                                                        C.CAR_STR_NOME_ATIVO,
	                                                        C.CAR_DEC_VALOR,
	                                                        C.CAR_DEC_SALDO,
	                                                        CLI.CLI_STR_NOME
                                                        FROM	
	                                                        CARTEIRA AS C
	                                                        INNER JOIN CLIENTE AS CLI ON CLI.CLI_INT_ID = C.CLI_INT_ID");

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

        public Carteira GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var carteira = con.Query<Carteira, Cliente, Carteira>(@"SELECT 
	                                                        C.CAR_INT_ID,
	                                                        C.CAR_STR_NOME_ATIVO,
	                                                        C.CAR_DEC_VALOR,
	                                                        C.CAR_DEC_SALDO,
                                                            C.CLI_INT_ID,
	                                                        CLI.CLI_STR_NOME
                                                        FROM	
	                                                        CARTEIRA AS C
	                                                        INNER JOIN CLIENTE AS CLI ON CLI.CLI_INT_ID = C.CLI_INT_ID
                                                        WHERE
                                                            C.CLI_INT_ID = @CLI_INT_ID", 
                                                            (Carteira, Cliente) =>
                                                            {
                                                                Carteira.Cliente = Cliente;

                                                                return Carteira;
                                                            }, new { CLI_INT_ID = id }, splitOn: "CAR_INT_ID, CLI_INT_ID").FirstOrDefault();
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

        public void Update(Carteira obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var carteira = con.Execute(@"UPDATE
	                                                    FUNCIONARIO
                                                    SET
                                                        CAR_STR_NOME_ATIVO = @CAR_STR_NOME_ATIVO,
                                                        CAR_DEC_VALOR = @CAR_DEC_VALOR,
                                                        CAR_DEC_SALDO = @CAR_DEC_SALDO, 
                                                        CLI_INT_ID = @CLI_INT_ID
                                                    WHERE
	                                                    FUN_INT_ID = @FUN_INT_ID",
                                                    new
                                                    {
                                                        obj.CAR_INT_ID,
                                                        CAR_STR_NOME_ATIVO = obj.CAR_STR_NOME_ATIVO,
                                                        CAR_DEC_VALOR = obj.CAR_DEC_VALOR,
                                                        CAR_DEC_SALDO = obj.CAR_DEC_SALDO,
                                                        CLI_INT_ID = obj.CLI_INT_ID
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
        public void Remove(Carteira obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
