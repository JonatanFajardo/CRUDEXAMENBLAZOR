using Application.DataAccess;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Logic.Repositories
{
    public class BaseRepository
    {
        public static async Task<IEnumerable<T>> SelectAll<T>(string sqlQuery)
        {
            using (var database = new SqlConnection(AppExampleBlazorDbContext.ConnectionString))
            {
                var result = await database.QueryAsync<T>(sqlQuery, commandType: CommandType.StoredProcedure);
                if (result == null && result.Count() > 0)
                {
                }
                database.Close();
                database.Dispose();
                return result;
            }
        }

        public static async Task<IEnumerable<T>> SelectById<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var database = new SqlConnection(AppExampleBlazorDbContext.ConnectionString))
            {
                var result = await database.QueryAsync<T>(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                if (result == null && result.Count() > 0)
                {
                }
                database.Close();
                database.Dispose();
                return result;
            }
        }

        public static async Task<bool> Update(string sqlQuery, DynamicParameters parameters)
        {
            bool resultSql = true;
            using (var database = new SqlConnection(AppExampleBlazorDbContext.ConnectionString))
            {
                database.Open();
                //using (var transaction = database.BeginTransaction())
                //{
                //try
                //{
                var result = await database.QueryAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                if (result.Count() != 0)
                {
                    return true;
                }

                resultSql = false;

                //transaction.Commit();
                database.Close();
                database.Dispose();
                return resultSql;
                //}
                //catch (Exception error)
                //{
                //    transaction.Rollback();
                //    database.Close();
                //    database.Dispose();
                //    return resultSql;
                //}
                //}
            }
        }
        public static async Task<bool> Insert(string sqlQuery, DynamicParameters parameters)
        {
            bool resultSql = true;
            using (var database = new SqlConnection(AppExampleBlazorDbContext.ConnectionString))
            {
                database.Open();
                var result = await database.QueryAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                if (result.Count() != 0)
                {

                }
                resultSql = false;
                database.Close();
                database.Dispose();
                return resultSql;
            }
        }

        public static async Task<T> Find<T>(string sqlQuery, DynamicParameters parameters)
        {
            using (var database = new SqlConnection(AppExampleBlazorDbContext.ConnectionString))
            {
                var result = await database.QueryFirstOrDefaultAsync<T>(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                database.Close();
                database.Dispose();
                return result;
            }
        }

        public static async Task<T> Detail<T>(string sqlQuery, DynamicParameters parameters)
        {

            return default(T);

        }

        public static async Task<Boolean> Delete(string sqlQuery, DynamicParameters parameters)
        {
            bool resultSql = true;
            using (var database = new SqlConnection(AppExampleBlazorDbContext.ConnectionString))
            {
                database.Open();
                var result = await database.QueryAsync(sqlQuery, parameters, commandType: CommandType.StoredProcedure);
                if (result.Count() != 0)
                {

                }
                resultSql = false;
                database.Close();
                database.Dispose();
                return resultSql;
            }
        }
    }
}