﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    internal class IdGenerator
    {
        /*public string idGenerator(string connectionString, string table, string extension)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string sql = $"SELECT COUNT(*) FROM {table}";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        //cmd.Parameters.AddWithValue("@Table", table);
                        int count = (int)cmd.ExecuteScalar();
                        string id = $"{extension}-{count + 1:D6}";
                        return id;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }*/

        public string idGenerator(string connectionString, string table, string extension, string primaryKey) 
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql1 = $"SELECT COUNT({primaryKey}) from {table}";
                string sql2 = $"SELECT TOP 1 {primaryKey} from {table} order by {primaryKey} desc";
                try
                {
                    using(SqlCommand command = new SqlCommand(sql1, connection))
                    {
                        //figure out with empty table
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            using(SqlCommand comm = new SqlCommand(sql2, connection))
                            {
                                string lastPrimary = (string)comm.ExecuteScalar();
                                int lastNumber = int.Parse(new string(lastPrimary.Where(char.IsDigit).ToArray()));
                                string id = $"{extension}-{lastNumber + 1:D6}";
                                return id;
                            }
                        }
                        else
                        {
                            string id = $"{extension}-{1:D6}";
                            return id;
                        }
                    }
                }catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
