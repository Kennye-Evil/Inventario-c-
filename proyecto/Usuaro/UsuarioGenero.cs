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
    public partial class UsuarioGenero : Form
    {
        public UsuarioGenero()
        {
            InitializeComponent();
        }
        private SqlConnection conexion = new SqlConnection("Tu base");

        private void llenar_grid()
        {
            string consulta = "SELECT * FROM Genero";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void UsuarioGenero_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtGenero.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand altas = new SqlCommand("INSERT INTO Genero (Descripcion) VALUES (@Descripcion)", conexion);
            altas.Parameters.AddWithValue("@Descripcion", txtGenero.Text);
            altas.ExecuteNonQuery();
            altas.Dispose();
            conexion.Close();

            llenar_grid();
            MessageBox.Show("Genero agregado");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_Genero = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Genero"].Value);

                try
                {
                    using (SqlConnection conexion = new SqlConnection("Tu base"))
                    {
                        conexion.Open();

                        // Verificar si el género está en uso
                        string verificaUso = "SELECT COUNT(*) FROM Tema WHERE id_Genero = @id_Genero";
                        using (SqlCommand cmdVerifica = new SqlCommand(verificaUso, conexion))
                        {
                            cmdVerifica.Parameters.AddWithValue("@id_Genero", id_Genero);
                            int count = (int)cmdVerifica.ExecuteScalar();

                            if (count > 0)
                            {
                                // Si hay registros en la tabla Tema que referencian el género, no se puede eliminar
                                MessageBox.Show("No se puede eliminar el género porque está en uso en la tabla Tema.");
                            }
                            else
                            {
                                // El género no está en uso, se puede eliminar
                                string baja = "DELETE FROM Genero WHERE id_Genero=@id_Genero";
                                using (SqlCommand cmdDel = new SqlCommand(baja, conexion))
                                {
                                    cmdDel.Parameters.AddWithValue("@id_Genero", id_Genero);
                                    cmdDel.ExecuteNonQuery();
                                    MessageBox.Show("Género eliminado");
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones SQL, por si ocurre algún error inesperado
                    MessageBox.Show("Ocurrió un error al intentar eliminar el género: " + ex.Message);
                }
                finally
                {
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
