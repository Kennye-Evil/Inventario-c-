using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using proyecto;

namespace test2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
                            else if (id_rol == 3)
                            {
                                // Empleado
                                MessageBox.Show("Inicio de sesión exitoso como Empleado");
                                Administracion user = new Administracion();
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

        private void login_Load(object sender, EventArgs e)
        {
        
        }


    }
  }
    