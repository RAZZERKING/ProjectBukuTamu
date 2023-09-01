using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    internal class GuestController
    {
        private string connectionString = @"Data Source=DESKTOP-O05793E\SQLEXPRESS; Initial Catalog=buku_tamu;Integrated Security=true";

        public Guest getGuestData(string id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM guest WHERE guest_id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Guest guest = new Guest
                            {
                                id = reader.GetString(reader.GetOrdinal("guest_id")),
                                name = reader.GetString(reader.GetOrdinal("name")),
                                instansi = reader.GetString(reader.GetOrdinal("instansi")),
                                contact = reader.GetString(reader.GetOrdinal("contact")),
                                date = reader.GetDateTime(reader.GetOrdinal("date")).ToString(), // Assuming date is stored as DateTime
                                keperluan = reader.GetString(reader.GetOrdinal("keperluan")),
                                penerimaTamu = reader.GetString(reader.GetOrdinal("penerima_tamu")),
                                foto = reader.GetString(reader.GetOrdinal("foto")),
                            };
                            return guest;
                        }
                    }
                }
            }

            return null;
        }


        public bool displayGuestData(DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if(dataGridView != null)
                {
                    string query = "SELECT guest_id, name, date FROM guest";
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

        public bool searchDataGuest(DataGridView dataGridView, string search)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM admin WHERE id LIKE @Search or name LIKE @Search or instansi LIKE @Search or date LIKE @Search or contact LIKE @Search or keperluan LIKE @Search or penerimaTamu LIKE @Search";
                try
                {
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
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

        public bool createNewGuest(string name, string instansi, string contact, string date, string keperluan, string penerimaTamu, string foto)
        { 
            IdGenerator idGenerator = new IdGenerator();
            string id = idGenerator.idGenerator(connectionString, "guest", "G", "guest_id");
            using(SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                if (id != null && name != null && instansi != null && contact != null && date != null && keperluan != null && penerimaTamu != null && foto != null)
                {
                    string query = "INSERT INTO guest VALUES (@Id, @Name, @Instansi, @Contact, @Date, @Keperluan, @PenerimaTamu, @Foto)";
                    try
                    {
                        using(SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Instansi", instansi);
                            command.Parameters.AddWithValue("@Contact", contact);
                            command.Parameters.AddWithValue("@Date", date);
                            command.Parameters.AddWithValue("@Keperluan", keperluan);
                            command.Parameters.AddWithValue("@PenerimaTamu", penerimaTamu);
                            command.Parameters.AddWithValue("@Foto", foto);
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

        public bool deleteGuestData(string id)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection .Open();
                string query = "DELETE FROM guest where id=@Id";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
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
}
