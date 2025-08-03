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
    public partial class UsuarioIdioma : Form
    {
        public UsuarioIdioma()
        {
            InitializeComponent();
        }
        private SqlConnection conexion = new SqlConnection("Tu base");
        private void llenar_grid()
        {
            string consulta = "SELECT * FROM Idioma";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void UsuarioIdioma_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            SqlCommand altas = new SqlCommand("INSERT INTO Idioma (Descripcion) VALUES (@Descripcion)", conexion);
            altas.Parameters.AddWithValue("@Descripcion", txtIdioma.Text);
            altas.ExecuteNonQuery();
            altas.Dispose();
            conexion.Close();

            llenar_grid();
            MessageBox.Show("Idioma agregado");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_Idioma = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Idioma"].Value);

                try
                {
                    conexion.Open();
                    string baja = "DELETE FROM Idioma WHERE id_Idioma=@id_Idioma";
                    SqlCommand cmdDel = new SqlCommand(baja, conexion);
                    cmdDel.Parameters.AddWithValue("@id_Idioma", id_Idioma);
                    cmdDel.ExecuteNonQuery();
                    cmdDel.Dispose();
                    MessageBox.Show("Idioma eliminado");
                }
                catch (SqlException ex)
                {

                    if (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede eliminar el idioma porque está en uso en otra parte del sistema.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el idioma: " + ex.Message);
                    }
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

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
