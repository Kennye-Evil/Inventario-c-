using proyecto.Presentacion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using test2;

namespace proyecto
{
    public partial class Nacionalidad : Form
    {
        private SqlConnection conexion = new SqlConnection("Tu base");



        public Nacionalidad()
        {
            InitializeComponent();
        }

        private void llenar_grid()
        {
            string consulta = "SELECT * FROM Nacionalidad";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtNacionalidad.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtNacionalidad.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void Nacionalidad_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Admin Inicio = new Admin();
            Inicio.Show();
            this.Hide();
        }

        private void btnalbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.Show();
            this.Hide();
        }

        private void btnnacionalidad_Click(object sender, EventArgs e)
        {
            Nacionalidad Nacionalidad = new Nacionalidad();
            Nacionalidad.Show();
            this.Hide();
        }

        private void btndisquera_Click(object sender, EventArgs e)
        {
            Disquera Disquera = new Disquera();
            Disquera.Show();
            this.Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {

            Genero Genero = new Genero();
            Genero.Show();
            this.Hide();
        }

        private void btndioma_Click(object sender, EventArgs e)
        {
            Idioma Idioma = new Idioma();
            Idioma.Show();
            this.Hide();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            Artista Artista = new Artista();
            Artista.Show();
            this.Hide();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            Tema VentaTema = new Tema();
            VentaTema.Show();
            this.Hide();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Admin Ventaadmin = new Admin();
            Ventaadmin.Show();
            this.Hide();
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
            {
                // Verificar que el campo de texto no esté vacío
                if (string.IsNullOrEmpty(txtNacionalidad.Text))
                {
                    MessageBox.Show("Por favor, ingrese una nacionalidad.");
                    return;
                }

    
                int idNacionalidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_nacionalidad"].Value);

    
                string consulta = "UPDATE Nacionalidad SET Descripcion = @Descripcion WHERE id_nacionalidad = @id_nacionalidad";
                try
                {

                

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", txtNacionalidad.Text);
                    cmd.Parameters.AddWithValue("@id_nacionalidad", idNacionalidad);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                        MessageBox.Show("Modificacion realizada con exito");
                        llenar_grid();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show("Ingrese un ID o nombres validos");

                }

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
