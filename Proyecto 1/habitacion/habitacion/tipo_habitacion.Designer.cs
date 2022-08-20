namespace habitacion
{
    partial class tipo_habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipo_habitacion));
            this.label1 = new System.Windows.Forms.Label();
            this.codtipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salvar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // codtipo
            // 
            this.codtipo.Location = new System.Drawing.Point(68, 9);
            this.codtipo.Name = "codtipo";
            this.codtipo.Size = new System.Drawing.Size(100, 20);
            this.codtipo.TabIndex = 1;
            this.codtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codtipo_KeyPress);
            this.codtipo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(102, 41);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 2;
            this.descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcion_KeyPress);
            this.descripcion.Validated += new System.EventHandler(this.descripcion_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.descarga__4_;
            this.pictureBox1.Location = new System.Drawing.Point(291, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(12, 94);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 34);
            this.salvar.TabIndex = 3;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(93, 94);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 34);
            this.nuevo.TabIndex = 4;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(174, 94);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 34);
            this.eliminar.TabIndex = 5;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // consultar
            // 
            this.consultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.consultar.Location = new System.Drawing.Point(255, 94);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 34);
            this.consultar.TabIndex = 6;
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(336, 94);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 34);
            this.salir.TabIndex = 7;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tipo_habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 134);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.codtipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tipo_habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIPO DE HABITACION";
            this.Load += new System.EventHandler(this.tipo_habitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codtipo;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}