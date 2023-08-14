using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    class UserController
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

        public bool searchDataUser(DataGridView dataGridView, string search)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM admin WHERE username LIKE @Search or user_id LIKE @Search or name LIKE @Search or contact LIKE @search";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Search","%" + search + "%");
                        int count = (int)command.ExecuteScalar();
                        if(count > 0)
                        {
                            using(SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                            {
                                DataTable dataTable = new DataTable();
                                dataAdapter.Fill(dataTable);
                                dataGridView.DataSource = dataTable;
                                dataGridView.AutoResizeColumns();
                                dataGridView.AutoResizeRows();
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                return true;
                            }
                        }
                    }
                }catch(Exception ex)
                {
                    return false;
                }
            }
            return false;
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

        public bool displayUserData(DataGridView dataGridView)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if(dataGridView != null)
                {
                    string query = "SELECT * FROM admin";
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            return true;
                        }
                    }catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool createNewUser(string userId, string username, string password, string name, string contact = null)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if(userId != null &&  username != null && password != null && name != null)
                {
                    if (!isUsernameExist(username))
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                        string query = $"INSERT INTO admin VALUES (@UserId, @Username, @Name, @Password, @Contact)";
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@UserId", userId);
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", hashedPassword);
                                command.Parameters.AddWithValue("@Name", name);
                                command.Parameters.AddWithValue("@Contact", contact);
                                command.ExecuteNonQuery();
                                return true;
                            }
                        }catch (Exception ex)
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        public bool updateUser(string userId, string username, string name, string contact)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if(userId != null && username != null && name != null)
                {
                    if (!isUsernameExist(username))
                    {
                        string query = "UPDATE admin SET username=@Username, name=@Name, contact=@Contact WHERE user_id=@UserId";
                        try
                        {
                            using(SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Name", name);
                                command.Parameters.AddWithValue("@Contact", contact);
                                command.Parameters.AddWithValue("@UserId", userId);
                                command.ExecuteNonQuery();
                                return true;
                            }
                        }catch(Exception ex)
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        public bool deleteUser(string userId)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if(userId != null)
                {
                    string query = "DELETE FROM admin WHERE user_id=@userId";
                    try
                    {
                        using(SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userId", userId);
                            command.ExecuteNonQuery();
                            return true;
                        }
                    }catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

    }
}
