using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Lib
{
    public class Database
    {
        private static string connectionString = "Server=127.0.0.1; Database=shop;UserId=root;Password=vertrigo;Port=3306;Charset=utf8 ";

       /* public static List<string> GetAllLogins()
        {
            List<string> logins = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT login FROM users";
                MySqlCommand command = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        logins.Add(reader.GetString("login"));
                    }
                }
                return logins;
            }
        }*/
        public static User Authorization(string login, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT id, full_name, login, password, role FROM users WHERE login = @login AND password = @password";
                MySqlCommand command = new MySqlCommand( sql, conn);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User()
                        {
                            id = reader.GetInt32("id"),
                            fio = reader.GetString("full_name"),
                            login = reader.GetString("login"),
                            password = reader.GetString("password"),
                            role = reader.GetString("role")
                        };
                    }
                }
                return null;
            }
        }
        public static List<Products> GetAllProducts()
        {
            List<Products> products = new List<Products>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT article, name, unit, price, supplier, manufacturer, category, discount, stock_quantity, description, photo
                               FROM tovar";
                MySqlCommand command = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Products()
                        {
                            article = reader.GetString("article"),
                            name = reader.GetString("name"),
                            unit = reader.GetString("unit"),
                            price = reader.GetDouble("price"),
                            supplier = reader.GetString("supplier"),
                            manufacturer = reader.GetString("manufacturer"),
                            category = reader.GetString("category"),
                            discount = reader.GetDouble("discount"),
                            stockQuantity = reader.GetInt32("stock_quantity"),
                            description = reader.GetString("description"),
                            pathPhoto = reader.GetString("photo")
                        });
                    }
                }
            }
            return products;
        }
       /* public static List<Orders> GetAllOrders()
        {
            List <Orders> orders = new List<Orders>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

            }
        }*/
    }
}
