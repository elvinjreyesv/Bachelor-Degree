namespace proyecto_prog3
{
    partial class login
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
            this.usuario = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(72, 73);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(43, 13);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario";
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Location = new System.Drawing.Point(72, 119);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(61, 13);
            this.contrasena.TabIndex = 1;
            this.contrasena.Text = "Contraseña";
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(156, 158);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(64, 37);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "&Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(147, 66);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(147, 116);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(100, 20);
            this.txtcontrasena.TabIndex = 4;
            this.txtcontrasena.TextChanged += new System.EventHandler(this.txtcontrasena_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.usuario);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
    }
}