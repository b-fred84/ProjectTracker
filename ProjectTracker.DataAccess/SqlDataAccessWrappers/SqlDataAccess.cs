using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProjectTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.SqlDataAccessWrappers
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string sqlQuery, U parameters, string connectionString = "ProjectTrackerConnectionString")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionString));

            return await connection.QueryAsync<T>(sqlQuery, parameters);
        }

        public async Task SaveDataAsync<T>(string sqlQuery, T parameters, string connectionString = "ProjectTrackerConnectionString")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionString));

            await connection.ExecuteAsync(sqlQuery, parameters);
        }
    }
}
