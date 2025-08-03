namespace proyecto.Usuaro
{
    partial class UsuarioArtistas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox2;
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNacionalidad = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnnacionalidadd = new System.Windows.Forms.Button();
            this.btnArtista = new System.Windows.Forms.Button();
            this.btndisquera = new System.Windows.Forms.Button();
            this.btnTema = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnalbum = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btndioma = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::proyecto.Properties.Resources.logout_icon_png_3;
            pictureBox2.Location = new System.Drawing.Point(10, 478);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(32, 33);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nacionalidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Descripcion";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(231, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 256);
            this.panel3.TabIndex = 47;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 200);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboNacionalidad);
            this.panel4.Controls.Add(this.txtDescripcion);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.btnconsulta);
            this.panel4.Controls.Add(this.btnagregar);
            this.panel4.Controls.Add(this.btneliminar);
            this.panel4.Location = new System.Drawing.Point(231, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 211);
            this.panel4.TabIndex = 48;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre";
            // 
            // comboNacionalidad
            // 
            this.comboNacionalidad.FormattingEnabled = true;
            this.comboNacionalidad.Location = new System.Drawing.Point(253, 64);
            this.comboNacionalidad.Name = "comboNacionalidad";
            this.comboNacionalidad.Size = new System.Drawing.Size(121, 21);
            this.comboNacionalidad.TabIndex = 40;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(485, 131);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(113, 53);
            this.btnconsulta.TabIndex = 33;
            this.btnconsulta.Text = "Actualizar ";
            this.btnconsulta.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(16, 131);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(113, 53);
            this.btnagregar.TabIndex = 34;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(135, 131);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(113, 53);
            this.btneliminar.TabIndex = 35;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1079, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 16);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 35);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(606, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administracion de Artistas";
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(11, 104);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(200, 40);
            this.btninicio.TabIndex = 46;
            this.btninicio.Text = "INICIO";
            this.btninicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.btninicio);
            this.panel2.Controls.Add(pictureBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnnacionalidadd);
            this.panel2.Controls.Add(this.btnArtista);
            this.panel2.Controls.Add(this.btndisquera);
            this.panel2.Controls.Add(this.btnTema);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnalbum);
            this.panel2.Controls.Add(this.btnGenero);
            this.panel2.Controls.Add(this.btndioma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 526);
            this.panel2.TabIndex = 46;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "SALIR DE SESION";
            // 
            // btnnacionalidadd
            // 
            this.btnnacionalidadd.Location = new System.Drawing.Point(11, 150);
            this.btnnacionalidadd.Name = "btnnacionalidadd";
            this.btnnacionalidadd.Size = new System.Drawing.Size(200, 40);
            this.btnnacionalidadd.TabIndex = 34;
            this.btnnacionalidadd.Text = "NACIONALIDAD";
            this.btnnacionalidadd.UseVisualStyleBackColor = true;
            this.btnnacionalidadd.Click += new System.EventHandler(this.btnnacionalidadd_Click);
            // 
            // btnArtista
            // 
            this.btnArtista.Location = new System.Drawing.Point(11, 334);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(200, 40);
            this.btnArtista.TabIndex = 38;
            this.btnArtista.Text = "ARTISTA";
            this.btnArtista.UseVisualStyleBackColor = true;
            this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click);
            // 
            // btndisquera
            // 
            this.btndisquera.Location = new System.Drawing.Point(11, 196);
            this.btndisquera.Name = "btndisquera";
            this.btndisquera.Size = new System.Drawing.Size(200, 40);
            this.btndisquera.TabIndex = 35;
            this.btndisquera.Text = "DISQUERA";
            this.btndisquera.UseVisualStyleBackColor = true;
            this.btndisquera.Click += new System.EventHandler(this.btndisquera_Click);
            // 
            // btnTema
            // 
            this.btnTema.Location = new System.Drawing.Point(11, 380);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(200, 40);
            this.btnTema.TabIndex = 39;
            this.btnTema.Text = "TEMA";
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyecto.Properties.Resources.tuntoweLogo23;
            this.pictureBox1.Location = new System.Drawing.Point(11, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnalbum
            // 
            this.btnalbum.Location = new System.Drawing.Point(11, 426);
            this.btnalbum.Name = "btnalbum";
            this.btnalbum.Size = new System.Drawing.Size(200, 40);
            this.btnalbum.TabIndex = 33;
            this.btnalbum.Text = "ALBUM";
            this.btnalbum.UseVisualStyleBackColor = true;
            this.btnalbum.Click += new System.EventHandler(this.btnalbum_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.Location = new System.Drawing.Point(11, 242);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(200, 40);
            this.btnGenero.TabIndex = 36;
            this.btnGenero.Text = "GENERO";
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btndioma
            // 
            this.btndioma.Location = new System.Drawing.Point(11, 288);
            this.btndioma.Name = "btndioma";
            this.btndioma.Size = new System.Drawing.Size(200, 40);
            this.btndioma.TabIndex = 37;
            this.btndioma.Text = "IDIOMA";
            this.btndioma.UseVisualStyleBackColor = true;
            this.btndioma.Click += new System.EventHandler(this.btndioma_Click);
            // 
            // UsuarioArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioArtistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioArtistas";
            this.Load += new System.EventHandler(this.UsuarioArtistas_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNacionalidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnnacionalidadd;
        private System.Windows.Forms.Button btnArtista;
        private System.Windows.Forms.Button btndisquera;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnalbum;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btndioma;
    }
}