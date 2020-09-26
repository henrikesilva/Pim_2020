using Microsoft.Extensions.Configuration;
using System;

namespace CourtageCoin.Infra.Data.Contexto
{
    public abstract class DapperContext : IDisposable
    {
        IConfiguration _configuration;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("Connection").Value;
            return connection;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
