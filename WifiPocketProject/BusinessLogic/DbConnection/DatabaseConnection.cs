using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace BusinessLogic.DbConnection
{
 

    public static class DatabaseConnection
    {
        private static readonly string _connectionString;

        // Static constructor to initialize the connection string once
        static DatabaseConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnection"]?.ConnectionString
                                ?? throw new InvalidOperationException("Database connection string is missing in App.config.");
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        public static string GetConnectionString()
        {
            return _connectionString;
        }

        /// <summary>
        /// Creates and returns a new SqlConnection instance.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }

}
