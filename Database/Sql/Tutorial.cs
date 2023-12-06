using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Sql.setting;
using MySql.Data.MySqlClient;

namespace Database.Sql
{
    // cú pháp insert : "INSERT INTO [TÊN DATABASE](TÊN KHÓA,...) VALUES (@[TÊN VALUE],....)"
    // cú pháp select : "SELECT [*/Tên khóa] FROM [TEN DATABSE] "
    // cú pháp update : "UPDATE [TÊN DATABSE] SET [KHÓA]=@[VALUES],...."
    // cú pháp delete : "DELETE FROM [TÊN DATABASE] WHERE [TÊN KHÓA(Chính)]"



    internal class Data
    {
        static void Insert()
        {
            try
            {
                Console.WriteLine("Nhap ten can them: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap dia chi:");
                string address = Console.ReadLine();
                var conmmand = DatabaseConnect.Connection.CreateCommand();
                conmmand.CommandText = "INSERT INTO student(name,address) VALUES (@name,@address)";
                conmmand.Parameters.AddWithValue("name", name);
                conmmand.Parameters.AddWithValue("address", address);
                conmmand.ExecuteNonQuery();
                Console.WriteLine("[MYSQL] SUSS");
            }
            catch (Exception e)
            {
                Console.WriteLine("[MYSQL] ERROR");
                Console.WriteLine(e);
            }
        }
        static void Update()
        {
            try
            {
                Console.WriteLine("Nhap id can update ten: ");
                string id = Console.ReadLine();
                Console.WriteLine("Nhap ten can sua: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap dia chi:");
                string address = Console.ReadLine();
                var conmmand = DatabaseConnect.Connection.CreateCommand();
                conmmand.CommandText = "UPDATE student SET name=@name,address=@address WHERE id=@id";
                conmmand.Parameters.AddWithValue("id", id);
                conmmand.Parameters.AddWithValue("name", name);
                conmmand.Parameters.AddWithValue("address", address);
                conmmand.ExecuteNonQuery();
                Console.WriteLine("[MYSQL] SUSS");
            }
            catch (Exception e)
            {
                Console.WriteLine("[MYSQL] ERROR");
                Console.WriteLine(e);
            }
        }
        static void Select()
        {
            try
            {
                Console.WriteLine("Nhap id can lay: ");
                string id = Console.ReadLine();
                string name = "";
                string address = "";
                var conmmand = DatabaseConnect.Connection.CreateCommand();
                conmmand.CommandText = "SELECT * FROM student WHERE id=@id";
                conmmand.Parameters.AddWithValue("id", id);
                using (MySqlDataReader reader = conmmand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        name = reader.GetString("name");
                        address = reader.GetString("address");
                        reader.Close();
                    }
                }
                Console.WriteLine("[MYSQL] SUSS");
                Console.WriteLine($"{name} {address}");
            }
            catch (Exception e)
            {
                Console.WriteLine("[MYSQL] ERROR");
                Console.WriteLine(e);
            }
        }
        static void Delete()
        {
            try
            {
                Console.WriteLine("Nhap id can xoa: ");
                string id = Console.ReadLine();
                var conmmand = DatabaseConnect.Connection.CreateCommand();
                conmmand.CommandText = "DELETE FROM student WHERE id=@id";
                conmmand.Parameters.AddWithValue("id", id);
                conmmand.ExecuteNonQuery();
                Console.WriteLine("[MYSQL] SUSS");

            }
            catch (Exception e)
            {
                Console.WriteLine("[MYSQL] ERROR");
                Console.WriteLine(e);
            }
        }
    }
}
