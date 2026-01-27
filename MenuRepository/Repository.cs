using Dapper;
using MenuRepository.Interface;
using MenuRepository.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace MenuRepository
{
    public class Repository : IRepository
    {
        private readonly IConfiguration _config;

        public Repository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(
                _config.GetConnectionString("DefaultConnection"));
        }
    }
}
