using MySql.Data.MySqlClient;

namespace TodoLoginApp
{
    public class Database
    {
        private static string connectionString =
            "server=localhost;database=todo_login_app;uid=root;pwd=rootroot;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}