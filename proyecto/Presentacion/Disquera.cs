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

namespace proyecto
{
    public partial class Disquera : Form
    {
        private SqlConnection conexion = new SqlConnection("Tu base");

        public Disquera()
        {
            InitializeComponent();
        }
        private void llenar_grid()
        {
            string consulta = "SELECT * FROM Disquera";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand altas = new SqlCommand("INSERT INTO Disquera (Descripcion) VALUES (@Descripcion)", conexion);
            altas.Parameters.AddWithValue("@Descripcion", txtDisquera.Text);
            altas.ExecuteNonQuery();
            altas.Dispose();
            conexion.Close();

            llenar_grid();
            MessageBox.Show("Nacionalidad agregada");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_Disquera = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Disquera"].Value);

                try
                {
                    conexion.Open();

                    // Verificar si la disquera está en uso
                    string verificaUso = "SELECT COUNT(*) FROM Album WHERE id_Disquera = @id_Disquera";
                    SqlCommand cmdVerifica = new SqlCommand(verificaUso, conexion);
                    cmdVerifica.Parameters.AddWithValue("@id_Disquera", id_Disquera);
                    int count = (int)cmdVerifica.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si hay registros en la tabla Album que referencian la disquera, no se puede eliminar
                        MessageBox.Show("No se puede eliminar la disquera porque está en uso en la tabla Album.");
                    }
                    else
                    {
                        // La disquera no está en uso, se puede eliminar
                        string baja = "DELETE FROM Disquera WHERE id_Disquera=@id_Disquera";
                        SqlCommand cmdDel = new SqlCommand(baja, conexion);
                        cmdDel.Parameters.AddWithValue("@id_Disquera", id_Disquera);
                        cmdDel.ExecuteNonQuery();
                        cmdDel.Dispose();
                        MessageBox.Show("Disquera eliminada");
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones SQL, por si ocurre algún error inesperado
                    MessageBox.Show("Ocurrió un error al intentar eliminar la disquera: " + ex.Message);
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


        private void Disquera_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtDisquera.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Admin Inicio = new Admin();
            Inicio.Show();
            this.Hide();
        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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
            Album ventaalbum = new Album();
            ventaalbum.Show();
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
                if (string.IsNullOrEmpty(txtDisquera.Text))
                {
                    MessageBox.Show("Por favor, ingrese una nacionalidad.");
                    return;
                }

    
                int idNacionalidad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Disquera"].Value);

    
                string consulta = "UPDATE Disquera SET Descripcion = @Descripcion WHERE id_Disquera = @id_Disquera";
                try
                {


    
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", txtDisquera.Text);
                        cmd.Parameters.AddWithValue("@id_Disquera", idNacionalidad);

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
    }
    }
