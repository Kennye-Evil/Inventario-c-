namespace proyecto
{
    partial class Album
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboDisquera = new System.Windows.Forms.ComboBox();
            this.comboArtista = new System.Windows.Forms.ComboBox();
            this.comboTema = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnacionalidadd = new System.Windows.Forms.Button();
            this.btnArtista = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btndisquera = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.btnTema = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnalbum = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btndioma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Disquera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::proyecto.Properties.Resources.logout_icon_png_3;
            pictureBox2.Location = new System.Drawing.Point(14, 486);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(32, 33);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 200);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // comboDisquera
            // 
            this.comboDisquera.FormattingEnabled = true;
            this.comboDisquera.Location = new System.Drawing.Point(6, 88);
            this.comboDisquera.Name = "comboDisquera";
            this.comboDisquera.Size = new System.Drawing.Size(121, 21);
            this.comboDisquera.TabIndex = 60;
            this.comboDisquera.SelectedIndexChanged += new System.EventHandler(this.comboDisquera_SelectedIndexChanged);
            // 
            // comboArtista
            // 
            this.comboArtista.FormattingEnabled = true;
            this.comboArtista.Location = new System.Drawing.Point(156, 40);
            this.comboArtista.Name = "comboArtista";
            this.comboArtista.Size = new System.Drawing.Size(121, 21);
            this.comboArtista.TabIndex = 59;
            // 
            // comboTema
            // 
            this.comboTema.FormattingEnabled = true;
            this.comboTema.Location = new System.Drawing.Point(156, 89);
            this.comboTema.Name = "comboTema";
            this.comboTema.Size = new System.Drawing.Size(121, 21);
            this.comboTema.TabIndex = 58;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(131, 134);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(113, 53);
            this.btneliminar.TabIndex = 54;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 134);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(113, 53);
            this.btnagregar.TabIndex = 53;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(11, 118);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(200, 40);
            this.btninicio.TabIndex = 46;
            this.btninicio.Text = "INICIO";
            this.btninicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "SALIR DE SESION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.btninicio);
            this.panel2.Controls.Add(pictureBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnnacionalidadd);
            this.panel2.Controls.Add(this.btnArtista);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btndisquera);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.btnTema);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnalbum);
            this.panel2.Controls.Add(this.btnGenero);
            this.panel2.Controls.Add(this.btndioma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 526);
            this.panel2.TabIndex = 63;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnnacionalidadd
            // 
            this.btnnacionalidadd.Location = new System.Drawing.Point(11, 164);
            this.btnnacionalidadd.Name = "btnnacionalidadd";
            this.btnnacionalidadd.Size = new System.Drawing.Size(200, 40);
            this.btnnacionalidadd.TabIndex = 34;
            this.btnnacionalidadd.Text = "NACIONALIDAD";
            this.btnnacionalidadd.UseVisualStyleBackColor = true;
            this.btnnacionalidadd.Click += new System.EventHandler(this.btnnacionalidadd_Click);
            // 
            // btnArtista
            // 
            this.btnArtista.Location = new System.Drawing.Point(11, 348);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(200, 40);
            this.btnArtista.TabIndex = 38;
            this.btnArtista.Text = "ARTISTA";
            this.btnArtista.UseVisualStyleBackColor = true;
            this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sign Out";
            // 
            // btndisquera
            // 
            this.btndisquera.Location = new System.Drawing.Point(11, 210);
            this.btndisquera.Name = "btndisquera";
            this.btndisquera.Size = new System.Drawing.Size(200, 40);
            this.btndisquera.TabIndex = 35;
            this.btndisquera.Text = "DISQUERA";
            this.btndisquera.UseVisualStyleBackColor = true;
            this.btndisquera.Click += new System.EventHandler(this.btndisquera_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(11, 517);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // btnTema
            // 
            this.btnTema.Location = new System.Drawing.Point(11, 394);
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
            this.pictureBox1.Location = new System.Drawing.Point(11, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnalbum
            // 
            this.btnalbum.Location = new System.Drawing.Point(11, 440);
            this.btnalbum.Name = "btnalbum";
            this.btnalbum.Size = new System.Drawing.Size(200, 40);
            this.btnalbum.TabIndex = 33;
            this.btnalbum.Text = "ALBUM";
            this.btnalbum.UseVisualStyleBackColor = true;
            this.btnalbum.Click += new System.EventHandler(this.btnalbum_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.Location = new System.Drawing.Point(11, 256);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(200, 40);
            this.btnGenero.TabIndex = 36;
            this.btnGenero.Text = "GENERO";
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btndioma
            // 
            this.btndioma.Location = new System.Drawing.Point(11, 302);
            this.btndioma.Name = "btndioma";
            this.btndioma.Size = new System.Drawing.Size(200, 40);
            this.btndioma.TabIndex = 37;
            this.btndioma.Text = "IDIOMA";
            this.btndioma.UseVisualStyleBackColor = true;
            this.btndioma.Click += new System.EventHandler(this.btndioma_Click);
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 35);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Administracion de Albums";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dtpFecha);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Disquera);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnmodificar);
            this.panel4.Controls.Add(this.btneliminar);
            this.panel4.Controls.Add(this.comboDisquera);
            this.panel4.Controls.Add(this.btnagregar);
            this.panel4.Controls.Add(this.comboArtista);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.btnactualizar);
            this.panel4.Controls.Add(this.comboTema);
            this.panel4.Location = new System.Drawing.Point(228, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 211);
            this.panel4.TabIndex = 64;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(302, 42);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 68;
            this.label9.Text = "Id Seleccionado";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(439, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(43, 20);
            this.txtid.TabIndex = 67;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Tema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Artista";
            // 
            // Disquera
            // 
            this.Disquera.AutoSize = true;
            this.Disquera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disquera.Location = new System.Drawing.Point(3, 70);
            this.Disquera.Name = "Disquera";
            this.Disquera.Size = new System.Drawing.Size(62, 16);
            this.Disquera.TabIndex = 63;
            this.Disquera.Text = "Disquera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(250, 134);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(113, 53);
            this.btnmodificar.TabIndex = 55;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(488, 134);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(113, 53);
            this.btnactualizar.TabIndex = 52;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(231, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 256);
            this.panel3.TabIndex = 65;
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.Load += new System.EventHandler(this.Album_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboDisquera;
        private System.Windows.Forms.ComboBox comboArtista;
        private System.Windows.Forms.ComboBox comboTema;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnnacionalidadd;
        private System.Windows.Forms.Button btnArtista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndisquera;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnalbum;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btndioma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Disquera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}