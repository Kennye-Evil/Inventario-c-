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
    public partial class UsuarioTema : Form
    {
        public UsuarioTema()
        {
            InitializeComponent();
        }
        private SqlConnection conexion = new SqlConnection("Tu base");
        private void llenar_grid()
        {

            string consulta = "SELECT t.id_Tema, t.Titulo, i.Descripcion AS Idioma, a.Nombre AS Artista, g.Descripcion AS Genero " +
"FROM Tema t " +
"JOIN Idioma i ON t.id_Idioma = i.id_Idioma " +
"JOIN Artistas a ON t.id_Artista = a.id_Artista " +
"JOIN Genero g ON t.id_Genero = g.id_Genero";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ListaIdiomas()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboIdioma.DataSource = objnacionalidad.ListaIdiomas();
            comboIdioma.DisplayMember = "Descripcion";
            comboIdioma.ValueMember = "id_Idioma";
        }
        private void ListaGeneros()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboGenero.DataSource = objnacionalidad.ListaGeneros();
            comboGenero.DisplayMember = "Descripcion";
            comboGenero.ValueMember = "id_Genero";
        }
        private void ListaArtistas()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboArtista.DataSource = objnacionalidad.ListaArtistas();
            comboArtista.DisplayMember = "Nombre";
            comboArtista.ValueMember = "id_Artista";
        }
        private void UsuarioTema_Load(object sender, EventArgs e)
        {
            llenar_grid();
            ListaIdiomas();
            ListaArtistas();
            ListaGeneros();
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_Tema = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Tema"].Value);
                txtTitulo.Text = dataGridView1.SelectedCells[0].Value.ToString();

                try
                {
                    conexion.Open();

                    // Verifica si el tema está en la tabla Album
                    string checkAlbum = "SELECT COUNT(*) FROM Album WHERE id_Tema=@id_Tema";
                    SqlCommand cmdCheckAlbum = new SqlCommand(checkAlbum, conexion);
                    cmdCheckAlbum.Parameters.AddWithValue("@id_Tema", id_Tema);
                    int countAlbum = (int)cmdCheckAlbum.ExecuteScalar();
                    if (countAlbum > 0)
                    {
                        MessageBox.Show("Primero debes eliminar el tema del campo Album.");
                        return;
                    }

                    // Si pasa la verificación, elimina el tema
                    string baja = "DELETE FROM Tema WHERE id_Tema=@id_Tema";
                    SqlCommand cmdDel = new SqlCommand(baja, conexion);
                    cmdDel.Parameters.AddWithValue("@id_Tema", id_Tema);
                    cmdDel.ExecuteNonQuery();
                    MessageBox.Show("Tema eliminado.");
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
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Tema (Titulo, id_Idioma, id_Artista, id_Genero) VALUES (@Titulo, @id_Idioma, @id_Artista, @id_Genero)", conexion);
                altas.Parameters.AddWithValue("@Titulo", txtTitulo.Text);


                int Idioma = (int)comboIdioma.SelectedValue;
                altas.Parameters.AddWithValue("@id_idioma", Idioma);

                int Artista = (int)comboArtista.SelectedValue;
                altas.Parameters.AddWithValue("@id_Artista", Artista);

                int Genero = (int)comboGenero.SelectedValue;
                altas.Parameters.AddWithValue("@id_Genero", Genero);

                altas.ExecuteNonQuery();
                altas.Dispose();
                MessageBox.Show("Tema agregad@");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT id_Tema FROM Tema";
            SqlCommand command = new SqlCommand(query, conexion);
            conexion.Open();
            var result = command.ExecuteScalar();
            try
            {
                txtTitulo.Text = dataGridView1.SelectedCells[1].Value.ToString();
                comboIdioma.Text = dataGridView1.SelectedCells[2].Value.ToString();
                comboArtista.Text = dataGridView1.SelectedCells[3].Value.ToString();
                comboGenero.Text = dataGridView1.SelectedCells[4].Value.ToString();


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
    }
}
