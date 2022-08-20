namespace sistema_administracion_bares
{
    partial class Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.aceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rechazar = new System.Windows.Forms.Button();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.contrasena = new MetroFramework.Controls.MetroTextBox();
            this.usuario = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape2,
            this.rectangleShape3,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(377, 223);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape5.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.rectangleShape5.Location = new System.Drawing.Point(3, 1);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(371, 1);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape4.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.rectangleShape4.Location = new System.Drawing.Point(1, 220);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(374, 1);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape2.Location = new System.Drawing.Point(374, 1);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(1, 219);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape3.Location = new System.Drawing.Point(1, 1);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(1, 219);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.rectangleShape1.Location = new System.Drawing.Point(1, 143);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(372, 1);
            // 
            // aceptar
            // 
            this.aceptar.BackgroundImage = global::sistema_administracion_bares.Properties.Resources.aceptar;
            this.aceptar.Location = new System.Drawing.Point(123, 145);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(65, 75);
            this.aceptar.TabIndex = 6;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_administracion_bares.Properties.Resources.users2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rechazar
            // 
            this.rechazar.BackgroundImage = global::sistema_administracion_bares.Properties.Resources.cancelar;
            this.rechazar.Location = new System.Drawing.Point(186, 145);
            this.rechazar.Name = "rechazar";
            this.rechazar.Size = new System.Drawing.Size(65, 75);
            this.rechazar.TabIndex = 0;
            this.rechazar.UseVisualStyleBackColor = true;
            this.rechazar.Click += new System.EventHandler(this.rechazar_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "FAVOR IDENTIFICARSE CON EL SISTEMA";
            // 
            // contrasena
            // 
            this.contrasena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contrasena.Lines = new string[0];
            this.contrasena.Location = new System.Drawing.Point(186, 92);
            this.contrasena.MaxLength = 32767;
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '\0';
            this.contrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contrasena.SelectedText = "";
            this.contrasena.Size = new System.Drawing.Size(123, 23);
            this.contrasena.TabIndex = 13;
            this.contrasena.UseCustomBackColor = true;
            this.contrasena.UseSelectable = true;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario.Lines = new string[0];
            this.usuario.Location = new System.Drawing.Point(186, 55);
            this.usuario.MaxLength = 32767;
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '\0';
            this.usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usuario.SelectedText = "";
            this.usuario.Size = new System.Drawing.Size(123, 23);
            this.usuario.TabIndex = 14;
            this.usuario.UseCustomBackColor = true;
            this.usuario.UseSelectable = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(377, 223);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rechazar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Usuarios_FormClosing);
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.TextChanged += new System.EventHandler(this.Usuarios_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Usuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rechazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aceptar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox usuario;
        private MetroFramework.Controls.MetroTextBox contrasena;
    }
}