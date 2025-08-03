using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = SQLCONTROL.Login(txtusuario.Text, txtpass.Text);

            if (result == 1)
            {
                using (SqlConnection conexion = new SqlConnection("Tu base"))
                {
                    string query = "SELECT id_rol FROM Usuarios WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre_usuario", txtusuario.Text);
                        command.Parameters.AddWithValue("@contraseña", txtpass.Text);
                        conexion.Open();
                        var resulta = command.ExecuteScalar();

                        if (resulta != null)
                        {
                            int id_rol = Convert.ToInt32(resulta);
                            if (id_rol == 1)
                            {
                                // administrador
                                MessageBox.Show("Inicio de sesión exitoso como administrador");
                                Admin admin = new Admin();
                                admin.Show();
                                this.Hide();
                            }
                            else if (id_rol == 2)
                            {
                                // gerente
                                MessageBox.Show("Inicio de sesión exitoso como Empleado");
                                User user = new User();
                                user.Show();
                                this.Hide();
                            }
                        
                            else
                            {
                                MessageBox.Show("Inicio de sesión exitoso");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                        }
                    }
                }
            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
