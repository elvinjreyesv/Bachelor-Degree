namespace habitacion
{
    partial class habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(habitacion));
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.ComboBox();
            this.codhab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.descriptem = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.descriphab = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.codest = new System.Windows.Forms.ComboBox();
            this.codtipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.descripcion.FormattingEnabled = true;
            this.descripcion.Location = new System.Drawing.Point(200, 106);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(121, 21);
            this.descripcion.TabIndex = 4;
            this.descripcion.SelectedIndexChanged += new System.EventHandler(this.descripcion_SelectedIndexChanged);
            this.descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcion_KeyPress);
            this.descripcion.Validating += new System.ComponentModel.CancelEventHandler(this.descripcion_Validating);
            this.descripcion.Validated += new System.EventHandler(this.descripcion_Validated);
            // 
            // codhab
            // 
            this.codhab.Location = new System.Drawing.Point(70, 19);
            this.codhab.Name = "codhab";
            this.codhab.Size = new System.Drawing.Size(100, 20);
            this.codhab.TabIndex = 1;
            this.codhab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codhab_KeyPress);
            this.codhab.Validating += new System.ComponentModel.CancelEventHandler(this.codhab_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tematica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo de Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codigo";
            // 
            // estado
            // 
            this.estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(123, 170);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(121, 21);
            this.estado.TabIndex = 7;
            this.estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estado_KeyPress);
            this.estado.Validating += new System.ComponentModel.CancelEventHandler(this.estado_Validating);
            this.estado.Validated += new System.EventHandler(this.estado_Validated);
            // 
            // descriptem
            // 
            this.descriptem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descriptem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.descriptem.FormattingEnabled = true;
            this.descriptem.Location = new System.Drawing.Point(80, 138);
            this.descriptem.Name = "descriptem";
            this.descriptem.Size = new System.Drawing.Size(121, 21);
            this.descriptem.TabIndex = 5;
            this.descriptem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptem_KeyPress);
            this.descriptem.Validated += new System.EventHandler(this.descriptem_Validated);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(66, 75);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 3;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            this.precio.Validated += new System.EventHandler(this.precio_Validated);
            // 
            // descriphab
            // 
            this.descriphab.Location = new System.Drawing.Point(101, 47);
            this.descriphab.Name = "descriphab";
            this.descriphab.Size = new System.Drawing.Size(100, 20);
            this.descriphab.TabIndex = 2;
            this.descriphab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriphab_KeyPress);
            this.descriphab.Validated += new System.EventHandler(this.descriphab_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.ddd;
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(84, 217);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 33);
            this.nuevo.TabIndex = 9;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(165, 217);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 33);
            this.eliminar.TabIndex = 10;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // consultar
            // 
            this.consultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.consultar.Location = new System.Drawing.Point(246, 217);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 33);
            this.consultar.TabIndex = 11;
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(327, 217);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 33);
            this.salir.TabIndex = 12;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(3, 217);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 33);
            this.salvar.TabIndex = 8;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // codest
            // 
            this.codest.FormattingEnabled = true;
            this.codest.Location = new System.Drawing.Point(73, 170);
            this.codest.Name = "codest";
            this.codest.Size = new System.Drawing.Size(44, 21);
            this.codest.TabIndex = 6;
            this.codest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codest_KeyPress);
            this.codest.Validating += new System.ComponentModel.CancelEventHandler(this.codest_Validating);
            // 
            // codtipo
            // 
            this.codtipo.FormattingEnabled = true;
            this.codtipo.Location = new System.Drawing.Point(146, 107);
            this.codtipo.Name = "codtipo";
            this.codtipo.Size = new System.Drawing.Size(48, 21);
            this.codtipo.TabIndex = 18;
            this.codtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codtipo_KeyPress);
            this.codtipo.Validating += new System.ComponentModel.CancelEventHandler(this.codtipo_Validating);
            // 
            // habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.codtipo);
            this.Controls.Add(this.codest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.descriphab);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descriptem);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codhab);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HABITACION";
            this.Load += new System.EventHandler(this.habitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox descripcion;
        private System.Windows.Forms.TextBox codhab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.ComboBox descriptem;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox descriphab;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox codest;
        private System.Windows.Forms.ComboBox codtipo;
    }
}