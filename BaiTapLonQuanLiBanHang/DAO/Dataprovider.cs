using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonQuanLiBanHang
{
    public class Dataprovider
    {
        private static Dataprovider instance;
        string connectionString = "Data Source=BLACKPINK\\SQLEXPRESS;Initial Catalog=QuanLiBanHangTapHoa;Integrated Security=True;Encrypt=False";

        public static Dataprovider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Dataprovider();
                }
                return instance;
            }
            private set => Dataprovider.instance = value;
        }

        public DataTable excuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameter != null)
                    {
                        string[] values = query.Split(' ');
                        int i = 0;
                        foreach (string item in values)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    return data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public int ExecuteNonQuery(string sql, object[] parameter)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameter != null)
                        {
                            string[] list = sql.Split(' ');
                            int i = 0;
                            foreach (string item in list)
                            {
                                if (item.Contains("@"))
                                {
                                    cmd.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        data = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    // You might want to throw the exception or handle it in a different way based on your requirement.
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                return data;
            }
        }

        public object ExcuteScalar(string sql, object[] parameter=null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (parameter != null)
                        {
                            string[] list = sql.Split(' ');
                            int i = 0;
                            foreach (string item in list)
                            {
                                if (item.Contains("@"))
                                {
                                    cmd.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        data = cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred: " + ex.Message);
                    // Handle the exception as needed.
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                return data;
            }
        }
    }
}