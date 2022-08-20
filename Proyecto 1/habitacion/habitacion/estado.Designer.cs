namespace habitacion
{
    partial class estado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estado));
            this.consulta = new System.Windows.Forms.DataGridView();
            this.todas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipos = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.hora_exacta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.disponible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // consulta
            // 
            this.consulta.AllowUserToAddRows = false;
            this.consulta.AllowUserToDeleteRows = false;
            this.consulta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consulta.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.consulta.Location = new System.Drawing.Point(131, 53);
            this.consulta.Name = "consulta";
            this.consulta.ReadOnly = true;
            this.consulta.Size = new System.Drawing.Size(570, 230);
            this.consulta.TabIndex = 0;
            this.consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consulta_CellClick);
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            this.consulta.DoubleClick += new System.EventHandler(this.consulta_DoubleClick);
            // 
            // todas
            // 
            this.todas.AutoSize = true;
            this.todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todas.Location = new System.Drawing.Point(503, 5);
            this.todas.Name = "todas";
            this.todas.Size = new System.Drawing.Size(68, 17);
            this.todas.TabIndex = 2;
            this.todas.Text = "TODAS";
            this.todas.UseVisualStyleBackColor = true;
            this.todas.CheckedChanged += new System.EventHandler(this.todas_CheckedChanged);
            this.todas.Click += new System.EventHandler(this.todas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Habitacion";
            // 
            // tipos
            // 
            this.tipos.FormattingEnabled = true;
            this.tipos.Location = new System.Drawing.Point(354, 6);
            this.tipos.Name = "tipos";
            this.tipos.Size = new System.Drawing.Size(121, 21);
            this.tipos.TabIndex = 4;
            this.tipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipos_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 289);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Blue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 321);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 26);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Green;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(12, 257);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(30, 26);
            this.textBox4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "LEYENDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LIMPIEZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "RESERVADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DISPONIBLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "OCUPADA";
            // 
            // hora
            // 
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 30000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // tiempo1
            // 
            this.tiempo1.Interval = 500;
            this.tiempo1.Tick += new System.EventHandler(this.tiempo1_Tick);
            // 
            // hora_exacta
            // 
            this.hora_exacta.AutoSize = true;
            this.hora_exacta.Location = new System.Drawing.Point(10, 9);
            this.hora_exacta.Name = "hora_exacta";
            this.hora_exacta.Size = new System.Drawing.Size(0, 13);
            this.hora_exacta.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.ggg;
            this.pictureBox1.Location = new System.Drawing.Point(13, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // salir
            // 
            this.salir.BackgroundImage = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(596, 301);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(109, 52);
            this.salir.TabIndex = 5;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::habitacion.Properties.Resources._1354036530_Zoom_Out_01;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(366, 301);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(109, 52);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "CAMBIAR ESTADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackgroundImage = global::habitacion.Properties.Resources.images__6_;
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.Location = new System.Drawing.Point(481, 301);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(109, 52);
            this.actualizar.TabIndex = 18;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // disponible
            // 
            this.disponible.AutoSize = true;
            this.disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponible.Location = new System.Drawing.Point(503, 28);
            this.disponible.Name = "disponible";
            this.disponible.Size = new System.Drawing.Size(108, 17);
            this.disponible.TabIndex = 19;
            this.disponible.Text = "DISPONIBLES";
            this.disponible.UseVisualStyleBackColor = true;
            this.disponible.CheckedChanged += new System.EventHandler(this.disponible_CheckedChanged);
            // 
            // estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 358);
            this.Controls.Add(this.disponible);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hora_exacta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.tipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todas);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "estado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADO";
            this.Load += new System.EventHandler(this.estado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView consulta;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.CheckBox todas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipos;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Timer tiempo1;
        private System.Windows.Forms.Label hora_exacta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.CheckBox disponible;
    }
}