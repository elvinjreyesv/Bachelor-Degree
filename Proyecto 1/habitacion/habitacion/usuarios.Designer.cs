namespace habitacion
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.entrar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.SystemColors.Window;
            this.usuario.Location = new System.Drawing.Point(79, 8);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(118, 20);
            this.usuario.TabIndex = 1;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // contrasena
            // 
            this.contrasena.BackColor = System.Drawing.SystemColors.Window;
            this.contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(98, 37);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(121, 22);
            this.contrasena.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contrasena";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.images__29_;
            this.pictureBox1.Location = new System.Drawing.Point(225, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // entrar
            // 
            this.entrar.Image = global::habitacion.Properties.Resources._1354069683_unlock_24;
            this.entrar.Location = new System.Drawing.Point(15, 98);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 44);
            this.entrar.TabIndex = 3;
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(98, 98);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 44);
            this.salir.TabIndex = 4;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__11_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 150);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.usuarios_FormClosing);
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}