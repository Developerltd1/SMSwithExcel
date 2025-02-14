using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DbConnection;
using Dapper;
using Domain;

namespace BusinessLogic.DapperCode
{
    public class DapperRepo
    {
        string connectionString = DatabaseConnection.GetConnectionString();
        public DapperRepo()
        {
            connectionString = DatabaseConnection.GetConnectionString();
        }
        public IEnumerable<T> ExecuteList<T>(string storedProcedureName, object parameters = null, CommandTypeEnum commandTypeEnum = CommandTypeEnum.Text)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                 connection.Open();

                return  connection.Query<T>(
                    storedProcedureName,
                    parameters,
                    commandType: commandTypeEnum == CommandTypeEnum.StoredProcedure
                        ? CommandType.StoredProcedure
                        : CommandType.Text
                );
            }
        }

        public T ExecuteScalar<T>(string command, object parameters = null, CommandTypeEnum commandTypeEnum = CommandTypeEnum.Text)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open(); // ✅ Corrected: Synchronous open

                if (parameters == null) // ✅ Ensure parameters are not null
                {
                    throw new ArgumentNullException(nameof(parameters), "Parameters object cannot be null.");
                }

                return connection.ExecuteScalar<T>(
                    command,
                    parameters,
                    commandType: commandTypeEnum == CommandTypeEnum.StoredProcedure
                        ? CommandType.StoredProcedure
                        : CommandType.Text
                );
            }
        }





        public async Task<T> ExecuteSingleObjectStoredProcedureAsync<T>(string storedProcedureName, object parameters = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                return await connection.QuerySingleOrDefaultAsync<T>(
                    storedProcedureName,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }


        public async Task ExecuteStoredProcedureNonQueryAsync(string storedProcedureName, object parameters = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                await connection.ExecuteAsync(
                    storedProcedureName,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task<T> InsertAsync<T>(string command, object parameters, CommandTypeEnum commandTypeEnum)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    var result = await connection.ExecuteScalarAsync<T>(
                        command,
                        parameters,
                        commandType: commandTypeEnum == CommandTypeEnum.StoredProcedure
                            ? CommandType.StoredProcedure
                            : CommandType.Text
                    );

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while executing insert command", ex);
            }
        }

        public T Insert<T>(string command, object parameters, CommandTypeEnum commandTypeEnum)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // ✅ Open the connection synchronously

                    var result = connection.ExecuteScalar<T>(
                        command,
                        parameters,
                        commandType: commandTypeEnum == CommandTypeEnum.StoredProcedure
                            ? CommandType.StoredProcedure
                            : CommandType.Text
                    );

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while executing insert command", ex);
            }
        }



        //public async Task<PagedResult<T>> GetPagedAsync<T>(string storedProcedure, object parameters)
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();

        //        var result = await connection.QueryAsync<T>(
        //            storedProcedure,
        //            parameters,
        //            commandType: CommandType.StoredProcedure
        //        );
        //        var totalRowCount = 0;

        //        return new PagedResult<T>(result, totalRowCount);
        //    }
        //}

    }

}

//}
