using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba1
{
    internal class DatabaseHelper
    {
        private string connectionString = @"Data Source=LORDREVAN\SQLEXPRESS; Initial Catalog=buku_tamu;Integrated Security=true";

        public bool isUsernameExist(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = $"SELECT COUNT(*) FROM admin WHERE username=@Username";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public User getUserByUsername(string username)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM admin WHERE username=@Username";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                username = reader.GetString(1),
                                id = reader.GetString(0),
                                name = reader.GetString(2),
                                password = reader.GetString(3),
                                contact = reader.GetString(4),
                            };
                            return user;
                        }
                    }

                }
            }
            return null;
        }

    }
}
