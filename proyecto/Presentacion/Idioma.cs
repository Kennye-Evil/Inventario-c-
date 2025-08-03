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
    public partial class Idioma : Form
    {
        public Idioma()
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtIdioma.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtIdioma.Text = row.Cells["Descripcion"].Value.ToString();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

            Admin Inicio = new Admin();
            Inicio.Show();
            this.Hide();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            {
                // Verificar que el campo de texto no esté vacío
                if (string.IsNullOrEmpty(txtIdioma.Text))
                {
                    MessageBox.Show("Por favor, ingrese una nacionalidad.");
                    return;
                }

    
                int id_Idioma = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_Idioma"].Value);

    
                string consulta = "UPDATE Idioma SET Descripcion = @Descripcion WHERE id_Idioma = @id_Idioma";
                try
                {


    
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", txtIdioma.Text);
                        cmd.Parameters.AddWithValue("@id_Idioma", id_Idioma);

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

        private void Idioma_Load(object sender, EventArgs e)
        {
            llenar_grid();
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

        private void txtIdioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
