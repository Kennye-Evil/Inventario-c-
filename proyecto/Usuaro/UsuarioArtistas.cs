using proyecto.Capadedatos;
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
    public partial class UsuarioArtistas : Form
    {
        private SqlConnection conexion = new SqlConnection("Tu base");

        public UsuarioArtistas()
        {
            InitializeComponent();
        }
        private void llenar_grid()
        {
            string consulta = "SELECT a.id_Artista, a.Nombre, a.Descripcion AS DescripcionArtista, n.Descripcion AS Nacionalidad " +
                      "FROM Artistas a " +
                      "JOIN Nacionalidad n ON a.id_nacionalidad = n.id_nacionalidad;";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Artistas (Descripcion, Nombre, id_nacionalidad) VALUES (@Descripcion, @Nombre, @id_nacionalidad)", conexion);
                altas.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                altas.Parameters.AddWithValue("@Nombre", txtNombre.Text);


                int idNacionalidad = (int)comboNacionalidad.SelectedValue;
                altas.Parameters.AddWithValue("@id_nacionalidad", idNacionalidad);

                altas.ExecuteNonQuery();
                altas.Dispose();
                MessageBox.Show("Artista agregad@");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
                llenar_grid();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_artista = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Artista"].Value);
                txtNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();

                try
                {
                    conexion.Open();


                    string checkAlbum = "SELECT COUNT(*) FROM Album WHERE id_Artista=@id_Artista";
                    SqlCommand cmdCheckAlbum = new SqlCommand(checkAlbum, conexion);
                    cmdCheckAlbum.Parameters.AddWithValue("@id_Artista", id_artista);
                    int countAlbum = (int)cmdCheckAlbum.ExecuteScalar();
                    if (countAlbum > 0)
                    {
                        MessageBox.Show("Primero debes eliminar el artista del campo Album.");
                        return;
                    }


                    string checkTema = "SELECT COUNT(*) FROM Tema WHERE id_Artista=@id_Artista";
                    SqlCommand cmdCheckTema = new SqlCommand(checkTema, conexion);
                    cmdCheckTema.Parameters.AddWithValue("@id_Artista", id_artista);
                    int countTema = (int)cmdCheckTema.ExecuteScalar();
                    if (countTema > 0)
                    {
                        MessageBox.Show("Primero debes eliminar el artista del campo Tema.");
                        return;
                    }


                    string baja = "DELETE FROM Artistas WHERE id_Artista=@id_Artista";
                    SqlCommand cmdDel = new SqlCommand(baja, conexion);
                    cmdDel.Parameters.AddWithValue("@id_Artista", id_artista);
                    cmdDel.ExecuteNonQuery();
                    MessageBox.Show("Artista eliminado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
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
            string query = "SELECT id_Artista FROM Artistas";
            SqlCommand command = new SqlCommand(query, conexion);
            conexion.Open();
            var result = command.ExecuteScalar();
            try
            {

                txtDescripcion.Text = dataGridView1.SelectedCells[2].Value.ToString();
                txtNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();


            }

            catch (Exception ex)
            {
                MessageBox.Show("No se puede visualizar " + ex.ToString());
            }
            conexion.Close();
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

        private void UsuarioArtistas_Load(object sender, EventArgs e)
        {
            llenar_grid();
            ListaNacionalidades();
            
        }
        private void ListaNacionalidades()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboNacionalidad.DataSource = objnacionalidad.ListaNacionalidades();
            comboNacionalidad.DisplayMember = "Descripcion";
            comboNacionalidad.ValueMember = "id_Nacionalidad";
        }
    }
}
