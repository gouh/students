using System.Collections.Generic;
using System.Linq;
using Dapper;
using MySqlConnector;

namespace students.database
{
    public class MySQLConnection
    {
        private static string LoadConnectionString()
        {
            return "server=127.0.0.1;uid=root;pwd=root;database=school";
        }

        public static List<T> ExecuteQueryStatement<T>(string queryStatement)
        {
            using (var conn = new MySqlConnection(LoadConnectionString()))
            {
                return conn.Query<T>(queryStatement).ToList();
            }
        }
        
        public static void ExecuteStatement(string insertStatement)
        {
            using(var conn = new MySqlConnection(LoadConnectionString()))
            {
                conn.Execute(insertStatement);
            }
        }
    }
}