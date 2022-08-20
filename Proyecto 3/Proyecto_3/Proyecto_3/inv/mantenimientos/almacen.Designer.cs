namespace Proyecto_3.inv.mantenimientos
{
    partial class almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(almacen));
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.activar2 = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.estado = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.ubic = new MetroFramework.Controls.MetroTextBox();
            this.codigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.LightGray;
            this.salvar.Location = new System.Drawing.Point(34, 227);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(94, 39);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 6;
            this.salvar.Text = "Salvar";
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.LightGray;
            this.nuevo.Location = new System.Drawing.Point(128, 227);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(94, 39);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 7;
            this.nuevo.Text = "Nuevo";
            this.nuevo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseCustomForeColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.UseStyleColors = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // activar2
            // 
            this.activar2.BackColor = System.Drawing.Color.LightGray;
            this.activar2.Location = new System.Drawing.Point(222, 227);
            this.activar2.Name = "activar2";
            this.activar2.Size = new System.Drawing.Size(94, 39);
            this.activar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.activar2.TabIndex = 8;
            this.activar2.Text = "Activar";
            this.activar2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activar2.UseCustomBackColor = true;
            this.activar2.UseCustomForeColor = true;
            this.activar2.UseSelectable = true;
            this.activar2.UseStyleColors = true;
            this.activar2.Click += new System.EventHandler(this.activar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.Location = new System.Drawing.Point(316, 227);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 39);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 9;
            this.salir.Text = "Salir";
            this.salir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salir.UseCustomBackColor = true;
            this.salir.UseCustomForeColor = true;
            this.salir.UseSelectable = true;
            this.salir.UseStyleColors = true;
            this.salir.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(40, 169);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(58, 15);
            this.estado.TabIndex = 5;
            this.estado.Text = "Estado";
            this.estado.UseSelectable = true;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Almacén";
            // 
            // nombre
            // 
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(185, 82);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.Size = new System.Drawing.Size(131, 23);
            this.nombre.TabIndex = 2;
            this.nombre.UseCustomBackColor = true;
            this.nombre.UseCustomForeColor = true;
            this.nombre.UseSelectable = true;
            this.nombre.UseStyleColors = true;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            this.nombre.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_Validating);
            // 
            // ubic
            // 
            this.ubic.Lines = new string[0];
            this.ubic.Location = new System.Drawing.Point(143, 120);
            this.ubic.MaxLength = 32767;
            this.ubic.Name = "ubic";
            this.ubic.PasswordChar = '\0';
            this.ubic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ubic.SelectedText = "";
            this.ubic.Size = new System.Drawing.Size(213, 23);
            this.ubic.TabIndex = 4;
            this.ubic.UseCustomBackColor = true;
            this.ubic.UseCustomForeColor = true;
            this.ubic.UseSelectable = true;
            this.ubic.UseStyleColors = true;
            this.ubic.TextChanged += new System.EventHandler(this.ubic_TextChanged);
            // 
            // codigo
            // 
            this.codigo.Lines = new string[0];
            this.codigo.Location = new System.Drawing.Point(143, 82);
            this.codigo.MaxLength = 32767;
            this.codigo.Name = "codigo";
            this.codigo.PasswordChar = '\0';
            this.codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codigo.SelectedText = "";
            this.codigo.Size = new System.Drawing.Size(41, 23);
            this.codigo.TabIndex = 1;
            this.codigo.UseCustomBackColor = true;
            this.codigo.UseCustomForeColor = true;
            this.codigo.UseSelectable = true;
            this.codigo.UseStyleColors = true;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            this.codigo.Click += new System.EventHandler(this.codigo_Click);
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Ubicación";
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(318, 82);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 3;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 280);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.ubic);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.activar2);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "almacen";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Almacén";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.almacen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.almacen_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton activar2;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroCheckBox estado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroTextBox ubic;
        private MetroFramework.Controls.MetroTextBox codigo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}