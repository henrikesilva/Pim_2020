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
    public class PerfilRepository : CourtageCoinContext, IPerfilRepository
    {
        public PerfilRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Add(Perfil obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var perfil = con.Execute(@"INSERT INTO PERFIL
	                                                        (PER_STR_NOME)
                                                        VALUES
	                                                        (PER_STR_NOME)",
                                                    new
                                                    {
                                                        PER_STR_NOME = obj.PER_STR_NOME
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

        public IEnumerable<Perfil> GetAll()
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var perfil = con.Query<Perfil>(@"SELECT   
	                                                    *
                                                    FROM 
	                                                    PERFIL");

                    return perfil;
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

        public Perfil GetById(int id)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var perfil = con.Query<Perfil>(@"SELECT   
	                                                        *
                                                        FROM 
	                                                        PERFIL
                                                        WHERE PER_INT_ID = @PER_INT_ID", new { PER_INT_ID = id }).FirstOrDefault();
                    return perfil;
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


        public void Update(Perfil obj)
        {
            try
            {
                var connectionString = this.GetConnection();
                using (var con = new SqlConnection(connectionString))
                {
                    var perfil = con.Execute(@"UPDATE
	                                                    PERFIL
                                                    SET
	                                                    PER_STR_NOME = @PER_STR_NOME
                                                    WHERE
	                                                    PER_INT_ID = @PER_INT_ID",
                                                    new
                                                    {
                                                        obj.PER_INT_ID,
                                                        PER_STR_NOME = obj.PER_STR_NOME
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
        public void Remove(Perfil obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
