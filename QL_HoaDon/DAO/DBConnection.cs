using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QL_HoaDon.DAO
{
    class DBConnection
    {
        //Chuỗi kết nối
        private static String _connectionString = @"Data Source=.;Initial Catalog=QuanLyHoaDon;Integrated Security=True";
        //ExecuteQuery : Select
        //public static DataTable ExecuteQuery(String sql)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection connect = new SqlConnection(_connectionString);
        //    connect.Open();
        //    SqlCommand command = connect.CreateCommand();
        //    command.CommandText = sql;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connect.Close();
        //    return dt;
        //}
        public static DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        //ExecuteNonQuery: Insert, Update, Delete
        public static bool ExecuteNonQuery(String sql)
        {
            bool kq;
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            connect.Close();
            return kq;
        }


    }
}
