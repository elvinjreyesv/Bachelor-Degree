namespace habitacion
{
    partial class suplidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suplidores));
            this.salir = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proveedor = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(339, 280);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 36);
            this.salir.TabIndex = 12;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(167, 280);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 36);
            this.eliminar.TabIndex = 11;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(86, 280);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 36);
            this.nuevo.TabIndex = 10;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(5, 280);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 36);
            this.salvar.TabIndex = 9;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // consultar
            // 
            this.consultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.consultar.Location = new System.Drawing.Point(252, 280);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 36);
            this.consultar.TabIndex = 8;
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // descripcion
            // 
            this.descripcion.FormattingEnabled = true;
            this.descripcion.Location = new System.Drawing.Point(142, 256);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 21);
            this.descripcion.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Correo";
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(76, 56);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(100, 20);
            this.proveedor.TabIndex = 24;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(78, 101);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 23;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(86, 148);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 22;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(68, 215);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 20);
            this.correo.TabIndex = 21;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(70, 14);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 20;
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo de Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.images__13_1;
            this.pictureBox1.Location = new System.Drawing.Point(279, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Telefono";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(86, 184);
            this.telefono.Mask = "000-000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 34;
            // 
            // suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 328);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proveedor);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.consultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "suplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPLIDORES";
            this.Load += new System.EventHandler(this.suplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.ComboBox descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proveedor;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telefono;
    }
}