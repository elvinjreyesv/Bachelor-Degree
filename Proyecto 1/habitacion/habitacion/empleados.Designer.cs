namespace habitacion
{
    partial class empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empleados));
            this.cedula = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.ComboBox();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(70, 138);
            this.cedula.Mask = "000-0000000-0";
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 20);
            this.cedula.TabIndex = 5;
            this.cedula.Validated += new System.EventHandler(this.cedula_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(70, 17);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 1;
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo de Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Correo";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(68, 202);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(131, 20);
            this.correo.TabIndex = 7;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(86, 235);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(139, 20);
            this.direccion.TabIndex = 8;
            this.direccion.Validated += new System.EventHandler(this.direccion_Validated);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(76, 81);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(123, 20);
            this.apellido.TabIndex = 3;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            this.apellido.Validated += new System.EventHandler(this.apellido_Validated);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(76, 50);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 2;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            this.nombre.Validated += new System.EventHandler(this.nombre_Validated);
            // 
            // descripcion
            // 
            this.descripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.descripcion.FormattingEnabled = true;
            this.descripcion.Location = new System.Drawing.Point(142, 111);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(121, 21);
            this.descripcion.TabIndex = 4;
            this.descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcion_KeyPress);
            this.descripcion.Validated += new System.EventHandler(this.descripcion_Validated);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(76, 168);
            this.telefono.Mask = "000-000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 6;
            this.telefono.Validated += new System.EventHandler(this.telefono_Validated);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(68, 264);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 20);
            this.estado.TabIndex = 9;
            this.estado.Validated += new System.EventHandler(this.estado_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(290, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(96, 297);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 33);
            this.nuevo.TabIndex = 11;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(177, 297);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 33);
            this.eliminar.TabIndex = 12;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // consultar
            // 
            this.consultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.consultar.Location = new System.Drawing.Point(258, 297);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 33);
            this.consultar.TabIndex = 13;
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(339, 297);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 33);
            this.salir.TabIndex = 14;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(15, 297);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 33);
            this.salvar.TabIndex = 10;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.cedula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADOS";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cedula;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox descripcion;
        private System.Windows.Forms.MaskedTextBox telefono;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}