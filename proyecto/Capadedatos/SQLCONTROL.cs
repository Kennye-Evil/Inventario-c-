using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace proyecto
{
    internal class SQLCONTROL
    {
        private static readonly string connectionString = "Tu base";

        public static int Login(string nombre_usuario, string contraseña)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("sploginn", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            return dr.GetInt32(0);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return -1;
        }
    }
}

        