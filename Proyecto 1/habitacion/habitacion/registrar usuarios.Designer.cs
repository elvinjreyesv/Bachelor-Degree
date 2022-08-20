namespace habitacion
{
    partial class registrar_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrar_usuarios));
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.comsultar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(142, 102);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(111, 20);
            this.usuario.TabIndex = 1;
            this.usuario.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contrasena";
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(16, 222);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 37);
            this.salvar.TabIndex = 4;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(340, 222);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 37);
            this.salir.TabIndex = 8;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // comsultar
            // 
            this.comsultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.comsultar.Location = new System.Drawing.Point(259, 222);
            this.comsultar.Name = "comsultar";
            this.comsultar.Size = new System.Drawing.Size(75, 37);
            this.comsultar.TabIndex = 7;
            this.comsultar.UseVisualStyleBackColor = true;
            this.comsultar.Click += new System.EventHandler(this.comsultar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(178, 222);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 37);
            this.eliminar.TabIndex = 6;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(97, 222);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 37);
            this.nuevo.TabIndex = 5;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(97, 140);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(134, 20);
            this.contrasena.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(10, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 15);
            this.label.TabIndex = 9;
            this.label.Text = "Cuenta de Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.images__41_;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(173, 179);
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '*';
            this.confirm.Size = new System.Drawing.Size(134, 20);
            this.confirm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirmar Contrasena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(80, 23);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(111, 20);
            this.nombre.TabIndex = 13;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(97, 64);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(111, 20);
            this.apellido.TabIndex = 14;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido";
            // 
            // registrar_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.comsultar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registrar_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR USUARIOS";
            this.Load += new System.EventHandler(this.registrar_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button comsultar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
    }
}