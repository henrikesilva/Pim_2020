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
    public class UsuarioRepository : CourtageCoinContext, IUsuarioRepository
    {
        public UsuarioRepository(IConfiguration configuration) : base(configuration)
        {
            
        }

        public void Add(Usuario obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using(var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Execute(@"INSERT INTO
	                                                USUARIO 
	                                                (USU_STR_LOGIN, USU_STR_SENHA, USU_INT_TELEFONE, 
	                                                USU_STR_EMAIL, USU_DATA_CADASTRO, FUN_INT_ID, CLI_INT_ID)
                                                VALUES
	                                                (@USU_STR_LOGIN, @USU_STR_SENHA, @USU_INT_TELEFONE,
	                                                @USU_STR_EMAIL, @USU_DATA_CADASTRO, 
	                                                @FUN_INT_ID, @CLI_INT_ID)",
                                                new { 
                                                    USU_STR_LOGIN = obj.USU_STR_LOGIN, 
                                                    USU_STR_SENHA = obj.USU_STR_SENHA,
                                                    USU_INT_TELEFONE = obj.USU_INT_TELEFONE,
                                                    USU_STR_EMAIL = obj.USU_STR_EMAIL,
                                                    USU_DATA_CADASTRO = obj.USU_DATA_CADASTRO,
                                                    FUN_INT_ID = obj.FUN_INT_ID,
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

        public IEnumerable<Usuario> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using(var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Query<Usuario, Funcionario, Cliente, Usuario>(@"SELECT
	                                                        U.USU_INT_ID,
	                                                        U.USU_STR_LOGIN,
	                                                        U.USU_STR_EMAIL,
	                                                        U.USU_INT_TELEFONE,
	                                                        U.USU_DATA_CADASTRO,
	                                                        U.FUN_INT_ID,
	                                                        F.FUN_STR_NOME,
	                                                        U.CLI_INT_ID
                                                        FROM 
	                                                        USUARIO AS U
	                                                        INNER JOIN FUNCIONARIO AS F ON F.FUN_INT_ID = U.FUN_INT_ID
	                                                        INNER JOIN CLIENTE AS C ON C.CLI_INT_ID = U.CLI_INT_ID",
                                                            (Usuario, Funcionario, Cliente) =>
                                                            {
                                                                Usuario.Funcionario = Funcionario;
                                                                Usuario.Cliente = Cliente;

                                                                return Usuario;
                                                            }, splitOn: "USU_INT_ID, FUN_INT_ID, CLI_INT_ID");

                    return usuario;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Usuario Login(string login, string senha)
        {
            try
            {
                var connectionString = this.GetConnection();
                using(var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Query<Usuario>(@"SELECT 
                                                            *
                                                       FROM 
                                                            USUARIO
                                                       WHERE
                                                            USU_STR_LOGIN = @USU_STR_LOGIN AND USU_STR_SENHA = @USU_STR_SENHA",
                                                     new { USU_STR_LOGIN = login, USU_STR_SENHA = senha}).FirstOrDefault();
                    return usuario;
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

        public Usuario GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Query<Usuario, Funcionario, Cliente, Usuario>(@"SELECT
	                                                        U.USU_INT_ID,
	                                                        U.USU_STR_LOGIN,
	                                                        U.USU_STR_EMAIL,
	                                                        U.USU_INT_TELEFONE,
	                                                        U.USU_DATA_CADASTRO,
	                                                        U.FUN_INT_ID,
	                                                        F.FUN_STR_NOME,
	                                                        U.CLI_INT_ID
                                                        FROM 
	                                                        USUARIO AS U
	                                                        INNER JOIN FUNCIONARIO AS F ON F.FUN_INT_ID = U.FUN_INT_ID
	                                                        INNER JOIN CLIENTE AS C ON C.CLI_INT_ID = U.CLI_INT_ID
                                                       WHERE
                                                            U.USU_INT_ID = @USU_INT_ID",
                                                            (Usuario, Funcionario, Cliente) =>
                                                            {
                                                                Usuario.Funcionario = Funcionario;
                                                                Usuario.Cliente = Cliente;

                                                                return Usuario;
                                                            }, 
                                                            new { USU_INT_ID = id}, splitOn: "USU_INT_ID, FUN_INT_ID, CLI_INT_ID")
                                                            .FirstOrDefault();

                    return usuario;
                    
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

        public void Update(Usuario obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var usuario = con.Execute(@"UPDATE
	                                                USUARIO
                                                SET
	                                                USU_STR_LOGIN = @USU_STR_LOGIN,
	                                                USU_STR_SENHA = @USU_STR_SENHA,
	                                                USU_INT_TELEFONE = @USU_INT_TELEFONE,
	                                                USU_STR_EMAIL = @USU_STR_EMAIL,
	                                                USU_DATA_CADASTRO = @USU_DATA_CADASTRO, 
	                                                FUN_INT_ID = @FUN_INT_ID,
	                                                CLI_INT_ID = @CLI_INT_ID
                                                WHERE
	                                                USU_INT_ID = @USU_INT_ID",
                                                new
                                                {
                                                    obj.USU_INT_ID,
                                                    USU_STR_LOGIN = obj.USU_STR_LOGIN,
                                                    USU_STR_SENHA = obj.USU_STR_SENHA,
                                                    USU_INT_TELEFONE = obj.USU_INT_TELEFONE,
                                                    USU_STR_EMAIL = obj.USU_STR_EMAIL,
                                                    USU_DATA_CADASTRO = obj.USU_DATA_CADASTRO,
                                                    FUN_INT_ID = obj.FUN_INT_ID,
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

        public void Remove(Usuario obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
