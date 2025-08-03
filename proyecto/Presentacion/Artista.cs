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
using proyecto.Capadedatos;
using proyecto.Presentacion;
using test2;

namespace proyecto
{
    public partial class Artista : Form
    {
        public Artista()
        {
            InitializeComponent();
        }

        private SqlConnection conexion = new SqlConnection("Tu base");

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



        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_grid();
        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Artista_Load(object sender, EventArgs e)
        {
            ListaNacionalidades();
            llenar_grid();
        }

        private void ListaNacionalidades()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboNacionalidad.DataSource = objnacionalidad.ListaNacionalidades();
            comboNacionalidad.DisplayMember = "Descripcion";
            comboNacionalidad.ValueMember = "id_Nacionalidad";
        }
 private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            Album album = new Album();
            album.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || comboNacionalidad.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }


            int idArtista = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Artista"].Value);


            int idNacionalidad = Convert.ToInt32(comboNacionalidad.SelectedValue);


            string consulta = "UPDATE Artistas " +
                              "SET Nombre = @Nombre, Descripcion = @Descripcion, id_nacionalidad = @idNacionalidad " +
                              "WHERE id_Artista = @idArtista";

            try
            {

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@idNacionalidad", idNacionalidad);
                    cmd.Parameters.AddWithValue("@idArtista", idArtista);

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
