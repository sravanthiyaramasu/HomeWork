using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Atea.Homework.API
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public async Task<Entity> SaveDataToDb(Entity entity)
        {
            await SaveDataUsingDapper(entity);
            return entity;
        }

        private async Task<Entity> SaveDataUsingDapper(Entity entity)
        {
            String _connectionString = "Server=[server_name];Database=[database_name];Trusted_Connection=true";
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new { FirstArgument = entity.firstArgument, SecondArgument = entity.secondArgument, Sum = entity.sum };
                await connection.OpenAsync();
                var sqlStatement = @"
                INSERT INTO [dbo].[HomeWork] 
                (FirstArgument
                ,SecondArgument
                ,Sum
                )
                VALUES (@FirstArgument
                ,@SecondArgument
                ,@Sum
                )";
                await connection.ExecuteAsync(sqlStatement, parameters);
            }

            return entity;

        }
    }
}
