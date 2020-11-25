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
    public class ClienteRepository : CourtageCoinContext, IClienteRepository
    {
        public ClienteRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Add(Cliente obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var cliente = con.Execute(@"INSERT INTO CLIENTE
	                                                    (
		                                                    CLI_STR_NOME,
		                                                    CLI_STR_CPF,
		                                                    CLI_DATE_NASCIMENTO,
                                                            END_INT_ID
	                                                    )
                                                    VALUES
	                                                    (
		                                                    @CLI_STR_NOME,
		                                                    @CLI_STR_CPF,
		                                                    @CLI_DATE_NASCIMENTO,
                                                            @END_INT_ID
	                                                    )",
                                                    new
                                                    {
                                                        CLI_STR_NOME = obj.CLI_STR_NOME,
                                                        CLI_STR_CPF = obj.CLI_STR_CPF,
                                                        CLI_DATE_NASCIMENTO = obj.CLI_DATE_NASCIMENTO,
                                                        END_INT_ID = obj.END_INT_ID
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

        public IEnumerable<Cliente> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var cliente = con.Query<Cliente>(@"SELECT 
	                                                        C.CLI_INT_ID,
	                                                        C.CLI_STR_NOME,
	                                                        C.CLI_STR_CPF,
	                                                        C.CLI_DATE_NASCIMENTO,
	                                                        E.END_INT_ID,
	                                                        E.END_STR_RUA
                                                        FROM	
	                                                        CLIENTE AS C
	                                                        INNER JOIN ENDERECO AS E ON E.END_INT_ID = C.END_INT_ID");

                    return cliente;
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

        public Cliente GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var cliente = con.Query<Cliente, Endereco, Cliente>(@"SELECT 
	                                                        *
                                                        FROM	
	                                                        CLIENTE AS C
	                                                        INNER JOIN ENDERECO AS E ON E.END_INT_ID = C.END_INT_ID
                                                        WHERE 
                                                            C.CLI_INT_ID = @CLI_INT_ID", 
                                                        (Cliente, Endereco) =>
                                                        {
                                                            Cliente.Endereco = Endereco;

                                                            return Cliente;
                                                        },
                                                        new { CLI_INT_ID = id }, splitOn: "CLI_INT_ID, END_INT_ID")
                                                        .FirstOrDefault();
                    return cliente;
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


        public void Update(Cliente obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Execute(@"UPDATE
	                                                    CLIENTE
                                                    SET
	                                                    CLI_STR_NOME = @CLI_STR_NOME,
		                                                CLI_STR_CPF = @CLI_STR_CPF,
		                                                CLI_DATE_NASCIMENTO = @CLI_DATE_NASCIMENTO,
                                                        END_INT_ID = @END_INT_ID
                                                    WHERE
	                                                    CLI_INT_ID = @CLI_INT_ID",
                                                    new
                                                    {
                                                        obj.CLI_INT_ID,
                                                        CLI_STR_NOME = obj.CLI_STR_NOME,
                                                        CLI_STR_CPF = obj.CLI_STR_CPF,
                                                        CLI_DATE_NASCIMENTO = obj.CLI_DATE_NASCIMENTO,
                                                        END_INT_ID = obj.END_INT_ID
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
        public void Remove(Cliente obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
