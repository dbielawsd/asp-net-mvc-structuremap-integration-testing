using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using AspNetMvcStructureMapIntegrationTesting.Retrievers.Interfaces;
using Dapper;

namespace AspNetMvcStructureMapIntegrationTesting.Retrievers
{
    public class DataRetriever : IDataRetriever
    {
        private readonly IConfigurationRetriever _configRetriever;

        private IDbConnection GetConnection()
        {
            var connectionString = _configRetriever.ConnectionString;
            return new SqlConnection(connectionString);
        }

        public DataRetriever(IConfigurationRetriever configRetriever)
        {
            _configRetriever = configRetriever;
        }

        public string Retrieve()
        {
            var sql =
                @"select DataColumn
                  from Dummy";

            var parameters = new {};

            using (var connection = GetConnection())
            {
                var result = connection.Query<String>(sql, parameters).ToList();
                return result.Any() ? result.First() : default(dynamic);
            }
        }
    }
}