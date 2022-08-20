namespace Proyecto_3.inv.mantenimientos
{
    partial class comp_seguro
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
            this.codcom = new MetroFramework.Controls.MetroTextBox();
            this.dir_com = new MetroFramework.Controls.MetroTextBox();
            this.nom_com = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.estado = new MetroFramework.Controls.MetroCheckBox();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.activar2 = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.telcom = new MetroFramework.Controls.MetroTextBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.comentario = new MetroFramework.Controls.MetroTextBox();
            this.tel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // codcom
            // 
            this.codcom.Lines = new string[0];
            this.codcom.Location = new System.Drawing.Point(144, 75);
            this.codcom.MaxLength = 32767;
            this.codcom.Name = "codcom";
            this.codcom.PasswordChar = '\0';
            this.codcom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codcom.SelectedText = "";
            this.codcom.Size = new System.Drawing.Size(41, 23);
            this.codcom.TabIndex = 1;
            this.codcom.UseCustomBackColor = true;
            this.codcom.UseCustomForeColor = true;
            this.codcom.UseSelectable = true;
            this.codcom.UseStyleColors = true;
            this.codcom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codcom_KeyPress);
            this.codcom.Validating += new System.ComponentModel.CancelEventHandler(this.codcom_Validating);
            // 
            // dir_com
            // 
            this.dir_com.Lines = new string[0];
            this.dir_com.Location = new System.Drawing.Point(144, 178);
            this.dir_com.MaxLength = 32767;
            this.dir_com.Name = "dir_com";
            this.dir_com.PasswordChar = '\0';
            this.dir_com.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dir_com.SelectedText = "";
            this.dir_com.Size = new System.Drawing.Size(317, 23);
            this.dir_com.TabIndex = 5;
            this.dir_com.UseCustomBackColor = true;
            this.dir_com.UseCustomForeColor = true;
            this.dir_com.UseSelectable = true;
            this.dir_com.UseStyleColors = true;
            this.dir_com.TextChanged += new System.EventHandler(this.dir_com_TextChanged);
            // 
            // nom_com
            // 
            this.nom_com.Lines = new string[0];
            this.nom_com.Location = new System.Drawing.Point(186, 75);
            this.nom_com.MaxLength = 32767;
            this.nom_com.Name = "nom_com";
            this.nom_com.PasswordChar = '\0';
            this.nom_com.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_com.SelectedText = "";
            this.nom_com.Size = new System.Drawing.Size(131, 23);
            this.nom_com.TabIndex = 2;
            this.nom_com.UseCustomBackColor = true;
            this.nom_com.UseCustomForeColor = true;
            this.nom_com.UseSelectable = true;
            this.nom_com.UseStyleColors = true;
            this.nom_com.TextChanged += new System.EventHandler(this.nom_com_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 182);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Dirección";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Compañía";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(39, 250);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(58, 15);
            this.estado.TabIndex = 16;
            this.estado.Text = "Estado";
            this.estado.UseSelectable = true;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(319, 75);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 13;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.Location = new System.Drawing.Point(321, 278);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 39);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 10;
            this.salir.Text = "Salir";
            this.salir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salir.UseCustomBackColor = true;
            this.salir.UseCustomForeColor = true;
            this.salir.UseSelectable = true;
            this.salir.UseStyleColors = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // activar2
            // 
            this.activar2.BackColor = System.Drawing.Color.LightGray;
            this.activar2.Location = new System.Drawing.Point(227, 278);
            this.activar2.Name = "activar2";
            this.activar2.Size = new System.Drawing.Size(94, 39);
            this.activar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.activar2.TabIndex = 9;
            this.activar2.Text = "Activar";
            this.activar2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activar2.UseCustomBackColor = true;
            this.activar2.UseCustomForeColor = true;
            this.activar2.UseSelectable = true;
            this.activar2.UseStyleColors = true;
            this.activar2.Click += new System.EventHandler(this.activar2_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.LightGray;
            this.nuevo.Location = new System.Drawing.Point(133, 278);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(94, 39);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 8;
            this.nuevo.Text = "Nuevo";
            this.nuevo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseCustomForeColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.UseStyleColors = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.LightGray;
            this.salvar.Location = new System.Drawing.Point(39, 278);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(94, 39);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 7;
            this.salvar.Text = "Salvar";
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // telcom
            // 
            this.telcom.BackColor = System.Drawing.Color.White;
            this.telcom.Lines = new string[0];
            this.telcom.Location = new System.Drawing.Point(144, 111);
            this.telcom.MaxLength = 13;
            this.telcom.Multiline = true;
            this.telcom.Name = "telcom";
            this.telcom.PasswordChar = '\0';
            this.telcom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telcom.SelectedText = "";
            this.telcom.Size = new System.Drawing.Size(173, 23);
            this.telcom.Style = MetroFramework.MetroColorStyle.Blue;
            this.telcom.TabIndex = 3;
            this.telcom.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telcom.UseCustomBackColor = true;
            this.telcom.UseCustomForeColor = true;
            this.telcom.UseSelectable = true;
            this.telcom.UseStyleColors = true;
            this.telcom.TextChanged += new System.EventHandler(this.telcom_TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(144, 145);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(213, 23);
            this.email.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.TabIndex = 4;
            this.email.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.UseCustomBackColor = true;
            this.email.UseCustomForeColor = true;
            this.email.UseSelectable = true;
            this.email.UseStyleColors = true;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // comentario
            // 
            this.comentario.BackColor = System.Drawing.Color.White;
            this.comentario.Lines = new string[0];
            this.comentario.Location = new System.Drawing.Point(144, 212);
            this.comentario.MaxLength = 32767;
            this.comentario.Name = "comentario";
            this.comentario.PasswordChar = '\0';
            this.comentario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.comentario.SelectedText = "";
            this.comentario.Size = new System.Drawing.Size(317, 23);
            this.comentario.Style = MetroFramework.MetroColorStyle.Blue;
            this.comentario.TabIndex = 6;
            this.comentario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comentario.UseCustomBackColor = true;
            this.comentario.UseCustomForeColor = true;
            this.comentario.UseSelectable = true;
            this.comentario.UseStyleColors = true;
            this.comentario.TextChanged += new System.EventHandler(this.comentario_TextChanged);
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.BackColor = System.Drawing.Color.White;
            this.tel.Location = new System.Drawing.Point(35, 111);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(60, 19);
            this.tel.Style = MetroFramework.MetroColorStyle.Blue;
            this.tel.TabIndex = 12;
            this.tel.Text = "Teléfono";
            this.tel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tel.UseCustomBackColor = true;
            this.tel.UseCustomForeColor = true;
            this.tel.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(35, 149);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Correo";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(35, 216);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Comentario";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // comp_seguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.comentario);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telcom);
            this.Controls.Add(this.codcom);
            this.Controls.Add(this.dir_com);
            this.Controls.Add(this.nom_com);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.activar2);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.KeyPreview = true;
            this.Name = "comp_seguro";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Compañías de Seguros";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.comp_seguro_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comp_seguro_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox codcom;
        private MetroFramework.Controls.MetroTextBox dir_com;
        private MetroFramework.Controls.MetroTextBox nom_com;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox estado;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton activar2;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroTextBox telcom;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox comentario;
        private MetroFramework.Controls.MetroLabel tel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}