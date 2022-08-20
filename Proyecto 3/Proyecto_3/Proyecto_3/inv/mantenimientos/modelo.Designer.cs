namespace Proyecto_3.inv.mantenimientos
{
    partial class modelo
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
            this.estado = new MetroFramework.Controls.MetroCheckBox();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.activar2 = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.cod_modelo = new MetroFramework.Controls.MetroTextBox();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cod_marca = new MetroFramework.Controls.MetroTextBox();
            this.des_marca = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.valid = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(36, 149);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(58, 15);
            this.estado.TabIndex = 58;
            this.estado.Text = "Estado";
            this.estado.UseSelectable = true;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.Location = new System.Drawing.Point(333, 192);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 39);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 57;
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
            this.activar2.Location = new System.Drawing.Point(239, 192);
            this.activar2.Name = "activar2";
            this.activar2.Size = new System.Drawing.Size(94, 39);
            this.activar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.activar2.TabIndex = 56;
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
            this.nuevo.Location = new System.Drawing.Point(145, 192);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(94, 39);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 55;
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
            this.salvar.Location = new System.Drawing.Point(51, 192);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(94, 39);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 54;
            this.salvar.Text = "Salvar";
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cod_modelo
            // 
            this.cod_modelo.Lines = new string[0];
            this.cod_modelo.Location = new System.Drawing.Point(142, 115);
            this.cod_modelo.MaxLength = 32767;
            this.cod_modelo.Name = "cod_modelo";
            this.cod_modelo.PasswordChar = '\0';
            this.cod_modelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_modelo.SelectedText = "";
            this.cod_modelo.Size = new System.Drawing.Size(41, 23);
            this.cod_modelo.TabIndex = 50;
            this.cod_modelo.UseCustomBackColor = true;
            this.cod_modelo.UseCustomForeColor = true;
            this.cod_modelo.UseSelectable = true;
            this.cod_modelo.UseStyleColors = true;
            this.cod_modelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_modelo_KeyPress);
            this.cod_modelo.Validating += new System.ComponentModel.CancelEventHandler(this.cod_modelo_Validating);
            // 
            // descripcion
            // 
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(184, 115);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(200, 23);
            this.descripcion.TabIndex = 51;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseCustomForeColor = true;
            this.descripcion.UseSelectable = true;
            this.descripcion.UseStyleColors = true;
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "Modelo";
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(386, 115);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 53;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Marca";
            // 
            // cod_marca
            // 
            this.cod_marca.Lines = new string[0];
            this.cod_marca.Location = new System.Drawing.Point(142, 84);
            this.cod_marca.MaxLength = 32767;
            this.cod_marca.Name = "cod_marca";
            this.cod_marca.PasswordChar = '\0';
            this.cod_marca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_marca.SelectedText = "";
            this.cod_marca.Size = new System.Drawing.Size(41, 23);
            this.cod_marca.TabIndex = 63;
            this.cod_marca.UseCustomBackColor = true;
            this.cod_marca.UseCustomForeColor = true;
            this.cod_marca.UseSelectable = true;
            this.cod_marca.UseStyleColors = true;
            this.cod_marca.Click += new System.EventHandler(this.cod_marca_Click);
            this.cod_marca.Validating += new System.ComponentModel.CancelEventHandler(this.cod_marca_Validating);
            // 
            // des_marca
            // 
            this.des_marca.Lines = new string[0];
            this.des_marca.Location = new System.Drawing.Point(184, 84);
            this.des_marca.MaxLength = 32767;
            this.des_marca.Name = "des_marca";
            this.des_marca.PasswordChar = '\0';
            this.des_marca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.des_marca.SelectedText = "";
            this.des_marca.Size = new System.Drawing.Size(200, 23);
            this.des_marca.TabIndex = 64;
            this.des_marca.UseCustomBackColor = true;
            this.des_marca.UseCustomForeColor = true;
            this.des_marca.UseSelectable = true;
            this.des_marca.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(386, 84);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(38, 23);
            this.metroButton1.TabIndex = 65;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // valid
            // 
            this.valid.Lines = new string[0];
            this.valid.Location = new System.Drawing.Point(142, 149);
            this.valid.MaxLength = 32767;
            this.valid.Name = "valid";
            this.valid.PasswordChar = '\0';
            this.valid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.valid.SelectedText = "";
            this.valid.Size = new System.Drawing.Size(56, 23);
            this.valid.TabIndex = 66;
            this.valid.UseSelectable = true;
            this.valid.Visible = false;
            this.valid.Validating += new System.ComponentModel.CancelEventHandler(this.vali_Validating);
            // 
            // modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.cod_marca);
            this.Controls.Add(this.des_marca);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.activar2);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.cod_modelo);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buscar);
            this.KeyPreview = true;
            this.Name = "modelo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Modelo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.modelo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modelo_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox estado;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton activar2;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroTextBox cod_modelo;
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox cod_marca;
        private MetroFramework.Controls.MetroTextBox des_marca;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox valid;
    }
}