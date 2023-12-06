using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Sql.setting;
using System.Threading.Tasks;

namespace Database.Sql
{
    internal class DatabaseConnect
    {
        public static MySqlConnection Connection = null;
        private string Host { get; }
        private string User { get; }
        private string Database { get; }
        private string Password { get; }
        public DatabaseConnect()
        {
            Host = Setting._Setting.Host;
            User = Setting._Setting.Username;
            Password = Setting._Setting.Password;
            Database = Setting._Setting.Database;
        }
        internal static void InitConnection()
        {
            if (Connection != null)
            {
                Connection.Close();
                Console.WriteLine("[MYSQL] STOP");
                return;
            }
            Console.WriteLine("[MYSQL] LOADING...");
            DatabaseConnect sql = new DatabaseConnect();
            string connect = $"SERVER={sql.Host}; UID={sql.User}; DATABASE={sql.Database}; PASSWORD={sql.Password}";
            Connection = new MySqlConnection(connect);
            try
            {
                Connection.Open();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[MYSQL] Success");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[MYSQL] ERROR");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
