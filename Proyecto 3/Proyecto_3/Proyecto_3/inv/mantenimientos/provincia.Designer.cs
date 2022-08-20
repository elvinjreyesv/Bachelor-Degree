namespace Proyecto_3.inv.mantenimientos
{
    partial class provincia
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
            this.cod_prov = new MetroFramework.Controls.MetroTextBox();
            this.descrip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(35, 118);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(58, 15);
            this.estado.TabIndex = 0;
            this.estado.Text = "Estado";
            this.estado.UseSelectable = true;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.Location = new System.Drawing.Point(337, 194);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 39);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 7;
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
            this.activar2.Location = new System.Drawing.Point(243, 194);
            this.activar2.Name = "activar2";
            this.activar2.Size = new System.Drawing.Size(94, 39);
            this.activar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.activar2.TabIndex = 6;
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
            this.nuevo.Location = new System.Drawing.Point(149, 194);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(94, 39);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 5;
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
            this.salvar.Location = new System.Drawing.Point(55, 194);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(94, 39);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 4;
            this.salvar.Text = "Salvar";
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cod_prov
            // 
            this.cod_prov.Lines = new string[0];
            this.cod_prov.Location = new System.Drawing.Point(141, 75);
            this.cod_prov.MaxLength = 32767;
            this.cod_prov.Name = "cod_prov";
            this.cod_prov.PasswordChar = '\0';
            this.cod_prov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_prov.SelectedText = "";
            this.cod_prov.Size = new System.Drawing.Size(41, 23);
            this.cod_prov.TabIndex = 1;
            this.cod_prov.UseCustomBackColor = true;
            this.cod_prov.UseCustomForeColor = true;
            this.cod_prov.UseSelectable = true;
            this.cod_prov.UseStyleColors = true;
            this.cod_prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_prov_KeyPress);
            this.cod_prov.Validating += new System.ComponentModel.CancelEventHandler(this.cod_prov_Validating);
            // 
            // descrip
            // 
            this.descrip.Lines = new string[0];
            this.descrip.Location = new System.Drawing.Point(183, 75);
            this.descrip.MaxLength = 32767;
            this.descrip.Name = "descrip";
            this.descrip.PasswordChar = '\0';
            this.descrip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descrip.SelectedText = "";
            this.descrip.Size = new System.Drawing.Size(228, 23);
            this.descrip.TabIndex = 2;
            this.descrip.UseCustomBackColor = true;
            this.descrip.UseCustomForeColor = true;
            this.descrip.UseSelectable = true;
            this.descrip.UseStyleColors = true;
            this.descrip.TextChanged += new System.EventHandler(this.descrip_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Provincia";
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(413, 75);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 3;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // provincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.activar2);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.cod_prov);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buscar);
            this.KeyPreview = true;
            this.Name = "provincia";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Provincia";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.provincia_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.provincia_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox estado;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton activar2;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroTextBox cod_prov;
        private MetroFramework.Controls.MetroTextBox descrip;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buscar;
    }
}