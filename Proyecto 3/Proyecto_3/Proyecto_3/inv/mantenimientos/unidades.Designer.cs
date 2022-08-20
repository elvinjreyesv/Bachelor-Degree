namespace Proyecto_3.inv.mantenimientos
{
    partial class unidades
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
            this.cod_unidad = new MetroFramework.Controls.MetroTextBox();
            this.des_unidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(59, 119);
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
            this.salir.Location = new System.Drawing.Point(329, 195);
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
            this.activar2.Location = new System.Drawing.Point(235, 195);
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
            this.nuevo.Location = new System.Drawing.Point(141, 195);
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
            this.salvar.Location = new System.Drawing.Point(47, 195);
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
            // cod_unidad
            // 
            this.cod_unidad.Lines = new string[0];
            this.cod_unidad.Location = new System.Drawing.Point(133, 76);
            this.cod_unidad.MaxLength = 32767;
            this.cod_unidad.Name = "cod_unidad";
            this.cod_unidad.PasswordChar = '\0';
            this.cod_unidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_unidad.SelectedText = "";
            this.cod_unidad.Size = new System.Drawing.Size(41, 23);
            this.cod_unidad.TabIndex = 1;
            this.cod_unidad.UseCustomBackColor = true;
            this.cod_unidad.UseCustomForeColor = true;
            this.cod_unidad.UseSelectable = true;
            this.cod_unidad.UseStyleColors = true;
            this.cod_unidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_unidad_KeyPress);
            this.cod_unidad.Validating += new System.ComponentModel.CancelEventHandler(this.cod_unidad_Validating);
            // 
            // des_unidad
            // 
            this.des_unidad.Lines = new string[0];
            this.des_unidad.Location = new System.Drawing.Point(175, 76);
            this.des_unidad.MaxLength = 32767;
            this.des_unidad.Name = "des_unidad";
            this.des_unidad.PasswordChar = '\0';
            this.des_unidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.des_unidad.SelectedText = "";
            this.des_unidad.Size = new System.Drawing.Size(228, 23);
            this.des_unidad.TabIndex = 2;
            this.des_unidad.UseCustomBackColor = true;
            this.des_unidad.UseCustomForeColor = true;
            this.des_unidad.UseSelectable = true;
            this.des_unidad.UseStyleColors = true;
            this.des_unidad.TextChanged += new System.EventHandler(this.des_unidad_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(59, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Unidad";
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(405, 76);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 3;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.activar2);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.cod_unidad);
            this.Controls.Add(this.des_unidad);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buscar);
            this.KeyPreview = true;
            this.Name = "unidades";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Unidades";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.unidades_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unidades_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox estado;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton activar2;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroTextBox cod_unidad;
        private MetroFramework.Controls.MetroTextBox des_unidad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton buscar;
    }
}