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
    public partial class UsuarioAlbum : Form
    {
        private SqlConnection conexion = new SqlConnection("Tu base");

        public UsuarioAlbum()
        {
            InitializeComponent();
        }
        private void llenar_grid()
        {
            string consulta =
                "SELECT al.id_Album, al.Nombre, d.Descripcion AS Disquera, a.Nombre AS Artista, t.Titulo AS Tema, al.Fecha " +
            "FROM Album al " +
                "JOIN Disquera d ON al.id_Disquera = d.id_Disquera " +
            "JOIN Artistas a ON al.id_Artista = a.id_Artista " +
                "JOIN Tema t ON al.id_Tema = t.id_Tema";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void CargarArtistas()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboArtista.DataSource = objnacionalidad.ListaArtistas();
            comboArtista.DisplayMember = "Nombre";
            comboArtista.ValueMember = "id_Artista";
        }
        private void CargarDisquera()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboDisquera.DataSource = objnacionalidad.ListaCargarDisqueraAlbum();
            comboDisquera.DisplayMember = "Descripcion";
            comboDisquera.ValueMember = "id_Disquera";
        }
        private void CargarTema()
        {
            nacionalidades objnacionalidad = new nacionalidades();
            comboTema.DataSource = objnacionalidad.ListaCargarTemaAlbum();
            comboTema.DisplayMember = "Titulo";
            comboTema.ValueMember = "id_Tema";
        }

        private void UsuarioAlbum_Load(object sender, EventArgs e)
        {

            llenar_grid();
            CargarArtistas();
            CargarDisquera();
            CargarTema();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Album (Nombre, id_Disquera, id_Artista, id_Tema, Fecha) VALUES (@Nombre, @id_Disquera, @id_Artista, @id_Tema, @Fecha)", conexion);
                altas.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                altas.Parameters.AddWithValue("@Nombre", txtNombre.Text);


                int idDisquera = (int)comboDisquera.SelectedValue;
                altas.Parameters.AddWithValue("@id_Disquera", idDisquera);


                int idArtista = (int)comboArtista.SelectedValue;
                altas.Parameters.AddWithValue("@id_Artista", idArtista);


                int idTema = (int)comboTema.SelectedValue;
                altas.Parameters.AddWithValue("@id_Tema", idTema);

                altas.ExecuteNonQuery();
                altas.Dispose();
                MessageBox.Show("Álbum agregado");
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
                int id_Album;
                bool parseResult = int.TryParse(dataGridView1.SelectedRows[0].Cells["id_Album"].Value.ToString(), out id_Album);

                if (parseResult)
                {
                    try
                    {
                        conexion.Open();
                        string baja = "DELETE FROM Album WHERE id_Album = @id_Album";
                        SqlCommand cmdDel = new SqlCommand(baja, conexion);
                        cmdDel.Parameters.AddWithValue("@id_Album", id_Album);
                        int rowsAffected = cmdDel.ExecuteNonQuery();
                        cmdDel.Dispose();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Álbum eliminado");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el álbum para eliminar.");
                        }
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
                    MessageBox.Show("El ID del álbum no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {

                    txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["id_Album"].Value.ToString();
                    txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    comboDisquera.Text = dataGridView1.Rows[e.RowIndex].Cells["Disquera"].Value.ToString();
                    comboArtista.Text = dataGridView1.Rows[e.RowIndex].Cells["Artista"].Value.ToString();
                    comboTema.Text = dataGridView1.Rows[e.RowIndex].Cells["Tema"].Value.ToString();
                    dtpFecha.Text = dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
