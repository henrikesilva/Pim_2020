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
		                                                    (FUN_INT_MATRICULA, 
		                                                    FUN_STR_NOME,
		                                                    SET_INT_ID)
                                                    VALUES
	                                                    (@FUN_INT_MATRICULA, 
		                                                    @FUN_STR_NOME,
		                                                    @SET_INT_ID)",
                                                    new {
                                                        FUN_INT_MATRICULA = obj.FUN_INT_MATRICULA,
                                                        FUN_STR_NOME = obj.FUN_STR_NOME,
                                                        SET_INT_ID = obj.SET_INT_ID
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
                    var funcionario = con.Query<Funcionario, Setor, Funcionario>(@"SELECT   
	                                                                                    F.FUN_INT_ID,
	                                                                                    F.FUN_INT_MATRICULA,
	                                                                                    F.FUN_STR_NOME,
	                                                                                    F.SET_INT_ID,
	                                                                                    S.SET_STR_NOME
                                                                                    FROM 
	                                                                                    FUNCIONARIO AS F
	                                                                                    INNER JOIN SETOR AS S ON S.SET_INT_ID = F.SET_INT_ID", 
                                                                                    (Funcionario, Setor) => 
                                                                                    {
                                                                                        Funcionario.Setor = Setor;

                                                                                        return Funcionario;
                                                                                    }, splitOn: "FUN_INT_ID, SET_INT_ID");
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
                    var funcionario = con.Query<Funcionario, Setor, Funcionario>(@"SELECT   
	                                                                                    F.FUN_INT_ID,
	                                                                                    F.FUN_INT_MATRICULA,
	                                                                                    F.FUN_STR_NOME,
	                                                                                    F.SET_INT_ID,
	                                                                                    S.SET_STR_NOME
                                                                                    FROM 
	                                                                                    FUNCIONARIO AS F
	                                                                                    INNER JOIN SETOR AS S ON S.SET_INT_ID = F.SET_INT_ID
                                                                                    WHERE F.FUN_INT_ID = @FUN_INT_ID",
                                                                                    (Funcionario, Setor) =>
                                                                                    {
                                                                                        Funcionario.Setor = Setor;

                                                                                        return Funcionario;
                                                                                    }, new { FUN_INT_ID = id }, splitOn: "FUN_INT_ID, SET_INT_ID").FirstOrDefault();
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
	                                                    FUN_INT_MATRICULA = @FUN_INT_MATRICULA,
	                                                    FUN_STR_NOME = @FUN_STR_NOME,
	                                                    SET_INT_ID = @SET_INT_ID
                                                    WHERE
	                                                    FUN_INT_ID = @FUN_INT_ID",
                                                    new
                                                    {
                                                        obj.FUN_INT_ID,
                                                        FUN_INT_MATRICULA = obj.FUN_INT_MATRICULA,
                                                        FUN_STR_NOME = obj.FUN_STR_NOME,
                                                        SET_INT_ID = obj.SET_INT_ID
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
