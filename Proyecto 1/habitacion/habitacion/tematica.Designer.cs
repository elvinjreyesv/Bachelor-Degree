namespace habitacion
{
    partial class tematica
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tematica));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codtem = new System.Windows.Forms.TextBox();
            this.descriptem = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consultar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.precio_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // codtem
            // 
            this.codtem.Location = new System.Drawing.Point(69, 18);
            this.codtem.Name = "codtem";
            this.codtem.Size = new System.Drawing.Size(100, 20);
            this.codtem.TabIndex = 1;
            this.codtem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codtem_KeyPress);
            this.codtem.Validating += new System.ComponentModel.CancelEventHandler(this.codtem_Validating);
            this.codtem.Validated += new System.EventHandler(this.codtem_Validated);
            // 
            // descriptem
            // 
            this.descriptem.Location = new System.Drawing.Point(101, 47);
            this.descriptem.Name = "descriptem";
            this.descriptem.Size = new System.Drawing.Size(100, 20);
            this.descriptem.TabIndex = 2;
            this.descriptem.TextChanged += new System.EventHandler(this.descriptem_TextChanged);
            this.descriptem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptem_KeyPress);
            this.descriptem.Validating += new System.ComponentModel.CancelEventHandler(this.descriptem_Validating);
            this.descriptem.Validated += new System.EventHandler(this.descriptem_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.descarga__3_;
            this.pictureBox1.Location = new System.Drawing.Point(287, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // consultar
            // 
            this.consultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.consultar.Location = new System.Drawing.Point(257, 115);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 39);
            this.consultar.TabIndex = 6;
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(338, 115);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 39);
            this.salir.TabIndex = 7;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(94, 115);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 39);
            this.nuevo.TabIndex = 4;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(175, 115);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 39);
            this.eliminar.TabIndex = 5;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.salir_Click);
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(12, 115);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 39);
            this.salvar.TabIndex = 3;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // precio_t
            // 
            this.precio_t.Location = new System.Drawing.Point(69, 78);
            this.precio_t.Name = "precio_t";
            this.precio_t.Size = new System.Drawing.Size(100, 20);
            this.precio_t.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // tematica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 166);
            this.Controls.Add(this.precio_t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.descriptem);
            this.Controls.Add(this.codtem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tematica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEMATICA";
            this.Load += new System.EventHandler(this.tematica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codtem;
        private System.Windows.Forms.TextBox descriptem;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox precio_t;
        private System.Windows.Forms.Label label3;
    }
}

