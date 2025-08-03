using proyecto.Capadedatos;
using proyecto.Presentacion;
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
using test2;

namespace proyecto
{
    public partial class Admin : Form
    {
        private SqlConnection conexion = new SqlConnection("Tu base");

        public Admin()
        {
            InitializeComponent();
        }
        private void llenar_grid()
        {
            string consulta = "SELECT u.id_usuario, u.nombre_usuario, u.contraseña, r.nombre_rol " +
                "FROM Usuarios u " +
                "JOIN Roles r ON u.id_rol = r.id_rol";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            llenar_grid();
            LiListaCargarUsuarios();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string query = "SELECT id_rol FROM Usuarios";
            SqlCommand command = new SqlCommand(query, conexion);
            conexion.Open();
            var result = command.ExecuteScalar();
            try
            {
                txtid.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txtNombe.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtPass.Text = dataGridView1.SelectedCells[2].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedCells[3].Value.ToString();
                
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se puede visualizar " + ex.ToString());
            }
            conexion.Close();
        }



        private void LiListaCargarUsuarios()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboBox1.DataSource = objnacionalidad.ListaCargarUsuarios();
            comboBox1.DisplayMember = "nombre_rol";
            comboBox1.ValueMember = "id_rol";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin Inicio = new Admin();
            Inicio.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text))
            {
                MessageBox.Show("Seleccione un usuario para modificar.");
                return;
            }

            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand("UPDATE Usuarios SET nombre_usuario=@nombre_usuario, contraseña=@contraseña, id_rol=@id_rol WHERE id_usuario=@id_usuario", conexion);

                comando.Parameters.AddWithValue("@nombre_usuario", txtNombe.Text);
                comando.Parameters.AddWithValue("@contraseña", txtPass.Text);
                comando.Parameters.AddWithValue("@id_rol", Convert.ToInt32(comboBox1.SelectedValue));
                comando.Parameters.AddWithValue("@id_usuario", Convert.ToInt32(txtid.Text));

                comando.ExecuteNonQuery();
                llenar_grid();
                MessageBox.Show("Modificación realizada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            conexion.Open();


            SqlCommand altas = new SqlCommand("insert into Usuarios(nombre_usuario,contraseña,id_rol)" + "values (@nombre_usuarios, @contraseña, @id_rol)", conexion);

            altas.Parameters.AddWithValue("nombre_usuarios",txtNombe.Text);
            altas.Parameters.AddWithValue("contraseña", txtPass.Text);
            int id_rol = (int)comboBox1.SelectedValue;
            altas.Parameters.AddWithValue("@id_rol", id_rol);

            altas.ExecuteNonQuery();

            llenar_grid();



            MessageBox.Show("Empleado dado de alta");

            conexion.Close();
        }

        private void btnconsulta_Click_1(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_Usuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_usuario"].Value);

                conexion.Open();
                string baja = "DELETE FROM Usuarios WHERE id_usuario=@id_usuario";
                SqlCommand cmdDel = new SqlCommand(baja, conexion);
                cmdDel.Parameters.AddWithValue("@id_usuario", id_Usuario);
                cmdDel.ExecuteNonQuery();
                cmdDel.Dispose();
                conexion.Close();

                llenar_grid();
                MessageBox.Show("Usuario eliminada");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
            this.Hide();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                login ventanaLogin = new login();
                this.Close();
                ventanaLogin.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
