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
        /*public static List<string> GetSuppliers()
        {
            List<string> list = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT supplier FROM tovar WHERE supplier IS NOT NULL AND supplier != ''";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.ToString());
                    }
                }
            }
            return list;
        }*/

        public static List<string> GetCategories()
        {
            List<string> list = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT DISTINCT category FROM tovar WHERE category IS NOT NULL AND category != ''";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }
                }
            }
            return list;
        }
        public static List<string> GetManufacturers()
        {
            var list = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT DISTINCT manufacturer FROM tovar WHERE manufacturer IS NOT NULL AND manufacturer != ''";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(reader[0].ToString());
                }
            }
            return list;
        }
        public static bool IsArticleUnique(string article)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM tovar WHERE article = @article";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@article", article);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0;
                }
            }
        }
        public static bool IsProductInOrders(string article)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM order_items WHERE article = @article";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@article", article);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public static void AddProduct(Products product)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO tovar (article, name, unit, price, supplier, manufacturer, category, discount, stock_quantity, description, photo)
                                 VALUES (@article, @name, @unit, @price, @supplier, @manufacturer, @category, @discount, @stock, @description, @photo)";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@article", product.article);
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@unit", product.unit);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@supplier", product.supplier);
                    command.Parameters.AddWithValue("@manufacturer", product.manufacturer);
                    command.Parameters.AddWithValue("@category", product.category);
                    command.Parameters.AddWithValue("@discount", product.discount);
                    command.Parameters.AddWithValue("@stock", product.stockQuantity);
                    command.Parameters.AddWithValue("@description", product.description);
                    command.Parameters.AddWithValue("@photo", product.pathPhoto);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateProduct(Products product)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE tovar SET name=@name, unit=@unit, price=@price, supplier=@supplier, 
                                 manufacturer=@manufacturer, category=@category, discount=@discount, 
                                 stock_quantity=@stock, description=@description, photo=@photo 
                                 WHERE article=@article";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@article", product.article);
                    command.Parameters.AddWithValue("@name", product.name);
                    command.Parameters.AddWithValue("@unit", product.unit);
                    command.Parameters.AddWithValue("@price", product.price);
                    command.Parameters.AddWithValue("@supplier", product.supplier);
                    command.Parameters.AddWithValue("@manufacturer", product.manufacturer);
                    command.Parameters.AddWithValue("@category", product.category);
                    command.Parameters.AddWithValue("@discount", product.discount);
                    command.Parameters.AddWithValue("@stock", product.stockQuantity);
                    command.Parameters.AddWithValue("@description", product.description);
                    command.Parameters.AddWithValue("@photo", product.pathPhoto);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteProduct(string article)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tovar WHERE article = @article";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@article", article);
                    command.ExecuteNonQuery();
                }
            }
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
