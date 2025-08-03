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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto
{
    public partial class Album : Form
    {
        private SqlConnection conexion = new SqlConnection("Tu base");

        public Album()
        {
            InitializeComponent();
        }
        private void llenar_grid(){
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




        private void Album_Load(object sender, EventArgs e)
        {

            llenar_grid();
            CargarArtistas();
            CargarDisquera();
            CargarTema();


        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();
           
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


        private void comboDisquera_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            Album Album = new Album();
            Album.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || comboDisquera.SelectedValue == null || comboArtista.SelectedValue == null || comboTema.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }


            int idAlbum = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Album"].Value);


            int idDisquera = Convert.ToInt32(comboDisquera.SelectedValue);
            int idArtista = Convert.ToInt32(comboArtista.SelectedValue);
            int idTema = Convert.ToInt32(comboTema.SelectedValue);


            string consulta = "UPDATE Album " +
                              "SET Nombre = @Nombre, id_Disquera = @id_Disquera, id_Artista = @id_Artista, id_Tema = @id_Tema, Fecha = @Fecha " +
                              "WHERE id_Album = @id_Album";

            try
            {

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@id_Disquera", idDisquera);
                    cmd.Parameters.AddWithValue("@id_Artista", idArtista);
                    cmd.Parameters.AddWithValue("@id_Tema", idTema);
                    cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date); 
                    cmd.Parameters.AddWithValue("@id_Album", idAlbum);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
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

        private void btn(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || comboDisquera.SelectedValue == null || comboArtista.SelectedValue == null || comboTema.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }


            int idAlbum = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Album"].Value);


            int idDisquera = Convert.ToInt32(comboDisquera.SelectedValue);
            int idArtista = Convert.ToInt32(comboArtista.SelectedValue);
            int idTema = Convert.ToInt32(comboTema.SelectedValue);


            string consulta = "UPDATE Album " +
                              "SET Nombre = @Nombre, id_Disquera = @id_Disquera, id_Artista = @id_Artista, id_Tema = @id_Tema, Fecha = @Fecha " +
                              "WHERE id_Album = @id_Album";

            try
            {

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@id_Disquera", idDisquera);
                    cmd.Parameters.AddWithValue("@id_Artista", idArtista);
                    cmd.Parameters.AddWithValue("@id_Tema", idTema);
                    cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@id_Album", idAlbum);

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


    }

}
