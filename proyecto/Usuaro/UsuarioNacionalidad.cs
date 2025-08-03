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

namespace proyecto.Usuaro
{
    public partial class UsuarioNacionalidad : Form
    {
        public UsuarioNacionalidad()
        {
            InitializeComponent();
        }
        private SqlConnection conexion = new SqlConnection("Tu base");

        private void btnagregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand altas = new SqlCommand("INSERT INTO Nacionalidad (Descripcion) VALUES (@Descripcion)", conexion);
            altas.Parameters.AddWithValue("@Descripcion", txtNacionalidad.Text);
            altas.ExecuteNonQuery();
            altas.Dispose();
            conexion.Close();

            llenar_grid();
            MessageBox.Show("Nacionalidad agregada");
        }
        private void llenar_grid()
        {
            string consulta = "SELECT * FROM Nacionalidad";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_nacionalidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_nacionalidad"].Value);

                try
                {
                    conexion.Open();

                    // Verificar si la nacionalidad está en uso
                    string verificaUso = "SELECT COUNT(*) FROM Artistas WHERE id_nacionalidad = @id_nacionalidad";
                    SqlCommand cmdVerifica = new SqlCommand(verificaUso, conexion);
                    cmdVerifica.Parameters.AddWithValue("@id_nacionalidad", id_nacionalidad);
                    int count = (int)cmdVerifica.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si hay registros en la tabla Artistas que referencian la nacionalidad, no se puede eliminar
                        MessageBox.Show("No se puede eliminar la nacionalidad porque está en uso en la tabla Artistas.");
                    }
                    else
                    {
                        // La nacionalidad no está en uso, se puede eliminar
                        string baja = "DELETE FROM Nacionalidad WHERE id_nacionalidad=@id_nacionalidad";
                        SqlCommand cmdDel = new SqlCommand(baja, conexion);
                        cmdDel.Parameters.AddWithValue("@id_nacionalidad", id_nacionalidad);
                        cmdDel.ExecuteNonQuery();
                        cmdDel.Dispose();
                        MessageBox.Show("Nacionalidad eliminada");
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones SQL, por si ocurre algún error inesperado
                    MessageBox.Show("Ocurrió un error al intentar eliminar la nacionalidad: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                    llenar_grid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtNacionalidad.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void UsuarioNacionalidad_Load(object sender, EventArgs e)
        {
            llenar_grid();

        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {

            llenar_grid();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {

            UsuarioMenu usuario = new UsuarioMenu();
            usuario.Show();
            this.Hide();
        }

        private void btnnacionalidadd_Click(object sender, EventArgs e)
        {
            UsuarioNacionalidad usuario = new UsuarioNacionalidad();
            usuario.Show();
            this.Hide();
        }

        private void btndisquera_Click(object sender, EventArgs e)
        {
            UsuarioDisquera usuario = new UsuarioDisquera();
            usuario.Show();
            this.Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            UsuarioGenero usuario = new UsuarioGenero();
            usuario.Show();
            this.Hide();
        }

        private void btndioma_Click(object sender, EventArgs e)
        {
            UsuarioIdioma usuario = new UsuarioIdioma();
            usuario.Show();
            this.Hide();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            UsuarioArtistas usuario = new UsuarioArtistas();
            usuario.Show();
            this.Hide();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            UsuarioTema usuario = new UsuarioTema();
            usuario.Show();
            this.Hide();
        }

        private void btnalbum_Click(object sender, EventArgs e)
        {
            UsuarioAlbum usuario = new UsuarioAlbum();
            usuario.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
