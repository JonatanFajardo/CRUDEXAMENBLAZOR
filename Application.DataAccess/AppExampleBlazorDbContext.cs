using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.DataAccess
{
    public class AppExampleBlazorDbContext : DbContext
    {

        private readonly static string _ConnectString = Environment.GetEnvironmentVariable("crudblazor2");
        //private readonly static string _ConnectString = @"Data Source=JOHN-EB\SQLEXPRESS;Initial Catalog=DBEXAMEN;Integrated Security=True";
        public static string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_ConnectString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString()
        {
            var connString = new SqlConnectionStringBuilder()
            {
                ConnectionString = _ConnectString
            };
            ConnectionString = connString.ConnectionString;
        }
    }
}
