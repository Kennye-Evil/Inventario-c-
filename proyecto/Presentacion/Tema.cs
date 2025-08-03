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
using test2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto.Presentacion
{
    public partial class Tema : Form
    {
        public Tema()
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void Tema_Load(object sender, EventArgs e)
        {
            llenar_grid();
            ListaIdiomas();
            ListaArtistas();
            ListaGeneros();
           
            
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }


        private void btninicio_Click(object sender, EventArgs e)
        {
            Admin Inicio = new Admin();
            Inicio.Show();
            this.Hide();
        }

        private void btnnacionalidadd_Click(object sender, EventArgs e)
        {
            Nacionalidad Nacion = new Nacionalidad();
            Nacion.Show();
            this.Hide();
        }

        private void btndisquera_Click(object sender, EventArgs e)
        {
            Disquera Disq = new Disquera();
            Disq.Show();
            this.Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            Genero gen = new Genero();
            gen.Show();
            this.Hide();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            Artista arts = new Artista();
            arts.Show();
            this.Hide();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            Tema tem = new Tema();
            tem.Show();
            this.Hide();
        }

        private void btndioma_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma.Show();
            this.Hide();
        }

        private void btnalbum_Click(object sender, EventArgs e)
        {
            Album Album = new Album();
            Album.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTitulo.Text) || comboIdioma.SelectedValue == null || comboArtista.SelectedValue == null || comboGenero.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }


            int idTema = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Tema"].Value);


            int idIdioma = Convert.ToInt32(comboIdioma.SelectedValue);
            int idArtista = Convert.ToInt32(comboArtista.SelectedValue);
            int idGenero = Convert.ToInt32(comboGenero.SelectedValue);


            string consulta = "UPDATE Tema " +
                              "SET Titulo = @Titulo, id_Idioma = @idIdioma, id_Artista = @idArtista, id_Genero = @idGenero " +
                              "WHERE id_Tema = @idTema";

            try
            {

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@idIdioma", idIdioma);
                    cmd.Parameters.AddWithValue("@idArtista", idArtista);
                    cmd.Parameters.AddWithValue("@idGenero", idGenero);
                    cmd.Parameters.AddWithValue("@idTema", idTema);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Modificación realizada con éxito.");
                    llenar_grid(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
