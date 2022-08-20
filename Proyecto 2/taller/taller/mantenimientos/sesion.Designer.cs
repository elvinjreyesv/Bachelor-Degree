namespace taller.mantenimientos
{
    partial class sesion
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Usuario = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.usuarios = new MetroFramework.Controls.MetroTextBox();
            this.clave = new MetroFramework.Controls.MetroTextBox();
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
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "FAVOR IDENTIFICARSE CON EL SISTEMA";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(344, 159);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -13;
            this.lineShape1.X2 = 366;
            this.lineShape1.Y1 = 92;
            this.lineShape1.Y2 = 92;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(90, 70);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(53, 19);
            this.Usuario.TabIndex = 11;
            this.Usuario.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(90, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Password";
            // 
            // usuarios
            // 
            this.usuarios.Lines = new string[0];
            this.usuarios.Location = new System.Drawing.Point(179, 63);
            this.usuarios.MaxLength = 32767;
            this.usuarios.Name = "usuarios";
            this.usuarios.PasswordChar = '\0';
            this.usuarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usuarios.SelectedText = "";
            this.usuarios.Size = new System.Drawing.Size(155, 23);
            this.usuarios.TabIndex = 12;
            this.usuarios.UseCustomBackColor = true;
            this.usuarios.UseCustomForeColor = true;
            this.usuarios.UseSelectable = true;
            this.usuarios.UseStyleColors = true;
            // 
            // clave
            // 
            this.clave.Lines = new string[0];
            this.clave.Location = new System.Drawing.Point(179, 104);
            this.clave.MaxLength = 32767;
            this.clave.Name = "clave";
            this.clave.PasswordChar = '●';
            this.clave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clave.SelectedText = "";
            this.clave.Size = new System.Drawing.Size(155, 23);
            this.clave.TabIndex = 12;
            this.clave.UseCustomBackColor = true;
            this.clave.UseCustomForeColor = true;
            this.clave.UseSelectable = true;
            this.clave.UseStyleColors = true;
            this.clave.UseSystemPasswordChar = true;
            // 
            // aceptar
            // 
            this.aceptar.BackgroundImage = global::taller.Properties.Resources.aceptar;
            this.aceptar.Location = new System.Drawing.Point(116, 155);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(65, 75);
            this.aceptar.TabIndex = 14;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // rechazar
            // 
            this.rechazar.BackgroundImage = global::taller.Properties.Resources.cancelar;
            this.rechazar.Location = new System.Drawing.Point(180, 155);
            this.rechazar.Name = "rechazar";
            this.rechazar.Size = new System.Drawing.Size(65, 75);
            this.rechazar.TabIndex = 13;
            this.rechazar.UseVisualStyleBackColor = true;
            this.rechazar.Click += new System.EventHandler(this.rechazar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::taller.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(23, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 239);
            this.ControlBox = false;
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.rechazar);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.usuarios);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sesion_FormClosing);
            this.Load += new System.EventHandler(this.sesion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sesion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroLabel Usuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox usuarios;
        private MetroFramework.Controls.MetroTextBox clave;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button rechazar;
    }
}