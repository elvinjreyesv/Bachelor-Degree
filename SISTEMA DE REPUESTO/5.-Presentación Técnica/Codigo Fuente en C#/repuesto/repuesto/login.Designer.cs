namespace repuesto
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
            this.label3 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.contrasena = new MetroFramework.Controls.MetroTextBox();
            this.usuario = new MetroFramework.Controls.MetroTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.aceptar = new System.Windows.Forms.Button();
            this.rechazar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(51, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "FAVOR IDENTIFICARSE CON EL SISTEMA";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(107, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(107, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Password";
            // 
            // contrasena
            // 
            this.contrasena.BackColor = System.Drawing.Color.White;
            this.contrasena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.contrasena.Lines = new string[0];
            this.contrasena.Location = new System.Drawing.Point(217, 107);
            this.contrasena.MaxLength = 32767;
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contrasena.SelectedText = "";
            this.contrasena.Size = new System.Drawing.Size(147, 23);
            this.contrasena.TabIndex = 12;
            this.contrasena.UseCustomBackColor = true;
            this.contrasena.UseSelectable = true;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.White;
            this.usuario.Lines = new string[0];
            this.usuario.Location = new System.Drawing.Point(217, 59);
            this.usuario.MaxLength = 32767;
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '\0';
            this.usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usuario.SelectedText = "";
            this.usuario.Size = new System.Drawing.Size(147, 23);
            this.usuario.TabIndex = 12;
            this.usuario.UseCustomBackColor = true;
            this.usuario.UseSelectable = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(368, 170);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -17;
            this.lineShape1.X2 = 393;
            this.lineShape1.Y1 = 95;
            this.lineShape1.Y2 = 95;
            // 
            // aceptar
            // 
            this.aceptar.Image = global::repuesto.Properties.Resources.aceptar;
            this.aceptar.Location = new System.Drawing.Point(147, 171);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(65, 75);
            this.aceptar.TabIndex = 16;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // rechazar
            // 
            this.rechazar.Image = global::repuesto.Properties.Resources.cancelar;
            this.rechazar.Location = new System.Drawing.Point(211, 171);
            this.rechazar.Name = "rechazar";
            this.rechazar.Size = new System.Drawing.Size(65, 75);
            this.rechazar.TabIndex = 15;
            this.rechazar.UseVisualStyleBackColor = true;
            this.rechazar.Click += new System.EventHandler(this.rechazar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::repuesto.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 250);
            this.ControlBox = false;
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.rechazar);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox contrasena;
        private MetroFramework.Controls.MetroTextBox usuario;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button rechazar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}