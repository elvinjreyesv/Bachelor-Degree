namespace Proyecto_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ingresar = new MetroFramework.Controls.MetroButton();
            this.cancelar = new MetroFramework.Controls.MetroButton();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.clave = new MetroFramework.Controls.MetroTextBox();
            this.usuario = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.ingresar.Highlight = true;
            this.ingresar.Location = new System.Drawing.Point(-1, 340);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(380, 50);
            this.ingresar.Style = MetroFramework.MetroColorStyle.Teal;
            this.ingresar.TabIndex = 3;
            this.ingresar.Text = "Ingresar";
            this.ingresar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ingresar.UseCustomBackColor = true;
            this.ingresar.UseCustomForeColor = true;
            this.ingresar.UseSelectable = true;
            this.ingresar.UseStyleColors = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelar.Highlight = true;
            this.cancelar.Location = new System.Drawing.Point(23, 268);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(20, 25);
            this.cancelar.Style = MetroFramework.MetroColorStyle.Teal;
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cancelar.UseCustomBackColor = true;
            this.cancelar.UseCustomForeColor = true;
            this.cancelar.UseSelectable = true;
            this.cancelar.UseStyleColors = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nombre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nombre.Location = new System.Drawing.Point(116, 20);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(118, 25);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "metroLabel1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(71, 171);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Usuario";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(83, 206);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Clave";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.BackgroundImage = global::Proyecto_3.Properties.Resources.imagen;
            this.metroUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroUserControl1.Location = new System.Drawing.Point(138, 48);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(94, 59);
            this.metroUserControl1.TabIndex = 7;
            this.metroUserControl1.UseCustomBackColor = true;
            this.metroUserControl1.UseCustomForeColor = true;
            this.metroUserControl1.UseSelectable = true;
            this.metroUserControl1.UseStyleColors = true;
            // 
            // clave
            // 
            this.clave.BackColor = System.Drawing.Color.White;
            this.clave.Icon = global::Proyecto_3.Properties.Resources.icon_c;
            this.clave.Lines = new string[0];
            this.clave.Location = new System.Drawing.Point(148, 202);
            this.clave.MaxLength = 32767;
            this.clave.Name = "clave";
            this.clave.PasswordChar = '●';
            this.clave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clave.SelectedText = "";
            this.clave.Size = new System.Drawing.Size(143, 23);
            this.clave.Style = MetroFramework.MetroColorStyle.Teal;
            this.clave.TabIndex = 2;
            this.clave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.clave.UseCustomBackColor = true;
            this.clave.UseCustomForeColor = true;
            this.clave.UseSelectable = true;
            this.clave.UseStyleColors = true;
            this.clave.UseSystemPasswordChar = true;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.White;
            this.usuario.Icon = global::Proyecto_3.Properties.Resources.icon_uss;
            this.usuario.Lines = new string[0];
            this.usuario.Location = new System.Drawing.Point(148, 167);
            this.usuario.MaxLength = 32767;
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '\0';
            this.usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usuario.SelectedText = "";
            this.usuario.Size = new System.Drawing.Size(143, 23);
            this.usuario.Style = MetroFramework.MetroColorStyle.Teal;
            this.usuario.TabIndex = 1;
            this.usuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usuario.UseCustomBackColor = true;
            this.usuario.UseCustomForeColor = true;
            this.usuario.UseSelectable = true;
            this.usuario.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_3.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(348, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Proyecto_3.Properties.Resources.gris;
            this.ClientSize = new System.Drawing.Size(379, 390);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.ingresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton cancelar;
        private MetroFramework.Controls.MetroButton ingresar;
        private MetroFramework.Controls.MetroTextBox clave;
        private MetroFramework.Controls.MetroTextBox usuario;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}