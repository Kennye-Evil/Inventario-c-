using proyecto.Presentacion;
using proyecto.Usuaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Administracion : Form
    {
        private int userRoleId;
        public Administracion()
        {
            InitializeComponent();
            this.userRoleId = userRoleId;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Administracion Administracion = new Administracion();
                this.Close();
                Administracion.Show();
            }
        }


        private void btnalbum_Click(object sender, EventArgs e)
        {
            UsuarioAlbum album = new UsuarioAlbum();
            album.Show();
            this.Hide();
        }

        private void btnnacionalidad_Click(object sender, EventArgs e)
        {
            UsuarioNacionalidad Nacionalidad = new UsuarioNacionalidad();
            Nacionalidad.Show();
            this.Hide();
        }

        private void btndisquera_Click(object sender, EventArgs e)
        {
            UsuarioDisquera Disquera = new UsuarioDisquera();
            Disquera.Show();
            this.Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {

            UsuarioGenero Genero = new UsuarioGenero();
            Genero.Show();
            this.Hide();
        }

        private void btndioma_Click(object sender, EventArgs e)
        {
            UsuarioIdioma Idioma = new UsuarioIdioma();
            Idioma.Show();
            this.Hide();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            UsuarioArtistas Artista = new UsuarioArtistas();
            Artista.Show();
            this.Hide();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
             UsuarioTema VentaTema= new UsuarioTema();
            VentaTema.Show();
            this.Hide();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Administracion Ventaadmin = new Administracion();
            Ventaadmin.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Administracion Administracion = new Administracion();
                this.Close();
                Administracion.Show();
            }
        }

        private void pictureboxpanel_Click(object sender, EventArgs e)
        {

        }
        private void SetPictureBoxOpacity(PictureBox pictureBox, float opacity)
        {

            if (opacity < 0.0f || opacity > 1.0f) throw new ArgumentOutOfRangeException(nameof(opacity));

            
            Image image = pictureBox.Image;

            if (image == null)
                return;

            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = opacity;

                ImageAttributes imgAttributes = new ImageAttributes();
                imgAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imgAttributes);
            }

            pictureBox.Image = bmp;
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            FormUtilities.HideModifyButton(this, userRoleId);

            SetPictureBoxOpacity(pictureBoxLogo, 0.4f);
        }
    }
}
