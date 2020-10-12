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
    public class FuncionarioRepository : CourtageCoinContext, IFuncionarioRepository
    {
        public FuncionarioRepository(IConfiguration configuration) : base(configuration)
        { 
        }

        public void Add(Funcionario obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using(var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Execute(@"INSERT INTO
	                                                    FUNCIONARIO 
		                                                (FUN_STR_NOME)
                                                    VALUES
	                                                    (@FUN_STR_NOME)",
                                                    new {
                                                        FUN_STR_NOME = obj.FUN_STR_NOME,
                                                    });
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Funcionario> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using(var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Query<Funcionario>(@"SELECT   
	                                                                F.FUN_INT_ID,
	                                                                F.FUN_STR_NOME
                                                                FROM 
	                                                                FUNCIONARIO AS F");
                                                                                    
                    return funcionario;
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

        public Funcionario GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Query<Funcionario>(@"SELECT   
	                                                                F.FUN_INT_ID,
	                                                                F.FUN_STR_NOME
                                                                FROM 
	                                                                FUNCIONARIO AS F
                                                                WHERE F.FUN_INT_ID = @FUN_INT_ID", new { FUN_INT_ID = id }).FirstOrDefault();
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

        public void Update(Funcionario obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var funcionario = con.Execute(@"UPDATE
	                                                    FUNCIONARIO
                                                    SET
	                                                    FUN_STR_NOME = @FUN_STR_NOME
                                                    WHERE
	                                                    FUN_INT_ID = @FUN_INT_ID",
                                                    new
                                                    {
                                                        obj.FUN_INT_ID,
                                                        FUN_STR_NOME = obj.FUN_STR_NOME
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

        public void Remove(Funcionario obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
