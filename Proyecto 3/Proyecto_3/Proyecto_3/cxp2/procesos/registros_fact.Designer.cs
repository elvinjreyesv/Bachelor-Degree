namespace Proyecto_3.cxp2.procesos
{
    partial class registros_fact
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
            this.nc = new MetroFramework.Controls.MetroCheckBox();
            this.ncf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.balcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.observacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.monto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.concepto = new MetroFramework.Controls.MetroTextBox();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.feccob = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.refcob = new MetroFramework.Controls.MetroTextBox();
            this.nomcli = new MetroFramework.Controls.MetroTextBox();
            this.rnccli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.codcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cobro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.b5 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // nc
            // 
            this.nc.AutoSize = true;
            this.nc.Location = new System.Drawing.Point(320, 214);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(32, 15);
            this.nc.TabIndex = 143;
            this.nc.Text = "   ";
            this.nc.UseSelectable = true;
            this.nc.CheckedChanged += new System.EventHandler(this.nc_CheckedChanged);
            this.nc.Click += new System.EventHandler(this.nc_Click);
            // 
            // ncf
            // 
            this.ncf.BackColor = System.Drawing.Color.White;
            this.ncf.Lines = new string[0];
            this.ncf.Location = new System.Drawing.Point(136, 208);
            this.ncf.MaxLength = 20;
            this.ncf.Name = "ncf";
            this.ncf.PasswordChar = '\0';
            this.ncf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ncf.SelectedText = "";
            this.ncf.Size = new System.Drawing.Size(178, 23);
            this.ncf.TabIndex = 3;
            this.ncf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ncf.UseCustomBackColor = true;
            this.ncf.UseCustomForeColor = true;
            this.ncf.UseSelectable = true;
            this.ncf.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 150);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 141;
            this.metroLabel8.Text = "Balance Pendiente";
            // 
            // balcli
            // 
            this.balcli.BackColor = System.Drawing.Color.White;
            this.balcli.Enabled = false;
            this.balcli.Lines = new string[0];
            this.balcli.Location = new System.Drawing.Point(136, 146);
            this.balcli.MaxLength = 32767;
            this.balcli.Name = "balcli";
            this.balcli.PasswordChar = '\0';
            this.balcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.balcli.SelectedText = "";
            this.balcli.Size = new System.Drawing.Size(82, 23);
            this.balcli.TabIndex = 4;
            this.balcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.balcli.UseCustomBackColor = true;
            this.balcli.UseCustomForeColor = true;
            this.balcli.UseSelectable = true;
            this.balcli.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 304);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 19);
            this.metroLabel7.TabIndex = 136;
            this.metroLabel7.Text = "Observacion";
            // 
            // observacion
            // 
            this.observacion.BackColor = System.Drawing.Color.White;
            this.observacion.Lines = new string[0];
            this.observacion.Location = new System.Drawing.Point(136, 301);
            this.observacion.MaxLength = 100;
            this.observacion.Multiline = true;
            this.observacion.Name = "observacion";
            this.observacion.PasswordChar = '\0';
            this.observacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.observacion.SelectedText = "";
            this.observacion.Size = new System.Drawing.Size(480, 63);
            this.observacion.TabIndex = 6;
            this.observacion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.observacion.UseCustomBackColor = true;
            this.observacion.UseCustomForeColor = true;
            this.observacion.UseSelectable = true;
            this.observacion.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 275);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 134;
            this.metroLabel5.Text = "Monto";
            // 
            // monto
            // 
            this.monto.BackColor = System.Drawing.Color.White;
            this.monto.Lines = new string[0];
            this.monto.Location = new System.Drawing.Point(136, 272);
            this.monto.MaxLength = 32767;
            this.monto.Name = "monto";
            this.monto.PasswordChar = '\0';
            this.monto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.monto.SelectedText = "";
            this.monto.Size = new System.Drawing.Size(82, 23);
            this.monto.TabIndex = 5;
            this.monto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.monto.UseCustomBackColor = true;
            this.monto.UseCustomForeColor = true;
            this.monto.UseSelectable = true;
            this.monto.UseStyleColors = true;
            this.monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monto_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 246);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 132;
            this.metroLabel3.Text = "Concepto";
            // 
            // concepto
            // 
            this.concepto.BackColor = System.Drawing.Color.White;
            this.concepto.Lines = new string[0];
            this.concepto.Location = new System.Drawing.Point(136, 243);
            this.concepto.MaxLength = 30;
            this.concepto.Name = "concepto";
            this.concepto.PasswordChar = '\0';
            this.concepto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.concepto.SelectedText = "";
            this.concepto.Size = new System.Drawing.Size(270, 23);
            this.concepto.TabIndex = 4;
            this.concepto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.concepto.UseCustomBackColor = true;
            this.concepto.UseCustomForeColor = true;
            this.concepto.UseSelectable = true;
            this.concepto.UseStyleColors = true;
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.BackgroundColor = System.Drawing.Color.White;
            this.data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.GridColor = System.Drawing.Color.White;
            this.data1.Location = new System.Drawing.Point(588, 21);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Size = new System.Drawing.Size(28, 29);
            this.data1.TabIndex = 130;
            this.data1.Visible = false;
            // 
            // feccob
            // 
            this.feccob.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.feccob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.feccob.Location = new System.Drawing.Point(498, 66);
            this.feccob.MinimumSize = new System.Drawing.Size(0, 25);
            this.feccob.Name = "feccob";
            this.feccob.Size = new System.Drawing.Size(116, 25);
            this.feccob.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 128;
            this.metroLabel4.Text = "Referencia";
            // 
            // refcob
            // 
            this.refcob.BackColor = System.Drawing.Color.White;
            this.refcob.Lines = new string[0];
            this.refcob.Location = new System.Drawing.Point(136, 173);
            this.refcob.MaxLength = 20;
            this.refcob.Name = "refcob";
            this.refcob.PasswordChar = '\0';
            this.refcob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.refcob.SelectedText = "";
            this.refcob.Size = new System.Drawing.Size(178, 23);
            this.refcob.TabIndex = 2;
            this.refcob.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refcob.UseCustomBackColor = true;
            this.refcob.UseCustomForeColor = true;
            this.refcob.UseSelectable = true;
            this.refcob.UseStyleColors = true;
            // 
            // nomcli
            // 
            this.nomcli.BackColor = System.Drawing.Color.White;
            this.nomcli.Enabled = false;
            this.nomcli.Lines = new string[0];
            this.nomcli.Location = new System.Drawing.Point(192, 96);
            this.nomcli.MaxLength = 32767;
            this.nomcli.Name = "nomcli";
            this.nomcli.PasswordChar = '\0';
            this.nomcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomcli.SelectedText = "";
            this.nomcli.Size = new System.Drawing.Size(214, 23);
            this.nomcli.TabIndex = 127;
            this.nomcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomcli.UseCustomBackColor = true;
            this.nomcli.UseCustomForeColor = true;
            this.nomcli.UseSelectable = true;
            this.nomcli.UseStyleColors = true;
            // 
            // rnccli
            // 
            this.rnccli.BackColor = System.Drawing.Color.White;
            this.rnccli.Enabled = false;
            this.rnccli.Lines = new string[0];
            this.rnccli.Location = new System.Drawing.Point(136, 120);
            this.rnccli.MaxLength = 32767;
            this.rnccli.Name = "rnccli";
            this.rnccli.PasswordChar = '\0';
            this.rnccli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rnccli.SelectedText = "";
            this.rnccli.Size = new System.Drawing.Size(178, 23);
            this.rnccli.TabIndex = 3;
            this.rnccli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rnccli.UseCustomBackColor = true;
            this.rnccli.UseCustomForeColor = true;
            this.rnccli.UseSelectable = true;
            this.rnccli.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 126;
            this.metroLabel2.Text = "Suplidor";
            // 
            // codcli
            // 
            this.codcli.BackColor = System.Drawing.Color.White;
            this.codcli.Lines = new string[0];
            this.codcli.Location = new System.Drawing.Point(136, 96);
            this.codcli.MaxLength = 32767;
            this.codcli.Name = "codcli";
            this.codcli.PasswordChar = '\0';
            this.codcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codcli.SelectedText = "";
            this.codcli.Size = new System.Drawing.Size(56, 23);
            this.codcli.TabIndex = 1;
            this.codcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codcli.UseCustomBackColor = true;
            this.codcli.UseCustomForeColor = true;
            this.codcli.UseSelectable = true;
            this.codcli.UseStyleColors = true;
            this.codcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codcli_KeyPress);
            this.codcli.Validating += new System.ComponentModel.CancelEventHandler(this.codcli_Validating);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(450, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 125;
            this.metroLabel1.Text = "Fecha";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(13, 72);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 124;
            this.metroLabel6.Text = "Registro";
            // 
            // cobro
            // 
            this.cobro.BackColor = System.Drawing.Color.White;
            this.cobro.Enabled = false;
            this.cobro.Lines = new string[0];
            this.cobro.Location = new System.Drawing.Point(136, 72);
            this.cobro.MaxLength = 32767;
            this.cobro.Name = "cobro";
            this.cobro.PasswordChar = '\0';
            this.cobro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cobro.SelectedText = "";
            this.cobro.Size = new System.Drawing.Size(82, 23);
            this.cobro.TabIndex = 9;
            this.cobro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cobro.UseCustomBackColor = true;
            this.cobro.UseCustomForeColor = true;
            this.cobro.UseSelectable = true;
            this.cobro.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 124);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 144;
            this.metroLabel9.Text = "RNC";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(13, 210);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(35, 19);
            this.metroLabel10.TabIndex = 145;
            this.metroLabel10.Text = "NCF";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.BackgroundImage = global::Proyecto_3.Properties.Resources.salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.Location = new System.Drawing.Point(380, 371);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(114, 36);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 139;
            this.salir.Text = "Esc-Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salir.UseCustomBackColor = true;
            this.salir.UseCustomForeColor = true;
            this.salir.UseSelectable = true;
            this.salir.UseStyleColors = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.LightGray;
            this.nuevo.BackgroundImage = global::Proyecto_3.Properties.Resources.nuevo;
            this.nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nuevo.Location = new System.Drawing.Point(265, 371);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(114, 36);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 138;
            this.nuevo.Text = "F4-Nuevo";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.salvar.BackgroundImage = global::Proyecto_3.Properties.Resources.salvar1;
            this.salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salvar.Location = new System.Drawing.Point(150, 371);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(114, 36);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 8;
            this.salvar.Text = " F10-Salvar";
            this.salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b5.Location = new System.Drawing.Point(408, 96);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(38, 23);
            this.b5.TabIndex = 129;
            this.b5.UseSelectable = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // registros_fact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(635, 435);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.ncf);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.balcli);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.observacion);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.concepto);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.feccob);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.refcob);
            this.Controls.Add(this.nomcli);
            this.Controls.Add(this.rnccli);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.codcli);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cobro);
            this.KeyPreview = true;
            this.Name = "registros_fact";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Registro de Facturas [CXP]";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.registros_fact_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registros_fact_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.registros_fact_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox nc;
        private MetroFramework.Controls.MetroTextBox ncf;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox balcli;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox observacion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox monto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox concepto;
        private System.Windows.Forms.DataGridView data1;
        private MetroFramework.Controls.MetroDateTime feccob;
        private MetroFramework.Controls.MetroButton b5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox refcob;
        private MetroFramework.Controls.MetroTextBox nomcli;
        private MetroFramework.Controls.MetroTextBox rnccli;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox codcli;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox cobro;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}