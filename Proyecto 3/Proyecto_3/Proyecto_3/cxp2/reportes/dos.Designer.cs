namespace Proyecto_3.cxp2.reportes
{
    partial class dos
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
            this.datos = new System.Windows.Forms.DataGridView();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.formato = new MetroFramework.Controls.MetroComboBox();
            this.ordenado = new MetroFramework.Controls.MetroComboBox();
            this.estado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.nomcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.codcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.fechaf = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.fechai = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(456, 336);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(10, 16);
            this.datos.TabIndex = 132;
            this.datos.Visible = false;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.salir.Location = new System.Drawing.Point(237, 382);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(229, 46);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 131;
            this.salir.Text = "Salir";
            this.salir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salir.UseCustomBackColor = true;
            this.salir.UseCustomForeColor = true;
            this.salir.UseSelectable = true;
            this.salir.UseStyleColors = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.salvar.Location = new System.Drawing.Point(4, 382);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(234, 46);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 130;
            this.salvar.Text = "Presentar";
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(4, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(203, 19);
            this.metroLabel1.TabIndex = 128;
            this.metroLabel1.Text = "Reporte de Pago de Facturas";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.Controls.Add(this.formato);
            this.metroPanel1.Controls.Add(this.ordenado);
            this.metroPanel1.Controls.Add(this.estado);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.nomcli);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.buscar);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.codcli);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.fechaf);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.fechai);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(18, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(435, 354);
            this.metroPanel1.TabIndex = 129;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // formato
            // 
            this.formato.BackColor = System.Drawing.Color.White;
            this.formato.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.formato.FormattingEnabled = true;
            this.formato.ItemHeight = 19;
            this.formato.Items.AddRange(new object[] {
            "Listado de Cobros"});
            this.formato.Location = new System.Drawing.Point(109, 272);
            this.formato.Name = "formato";
            this.formato.Size = new System.Drawing.Size(177, 25);
            this.formato.Style = MetroFramework.MetroColorStyle.Blue;
            this.formato.TabIndex = 118;
            this.formato.Theme = MetroFramework.MetroThemeStyle.Light;
            this.formato.UseCustomBackColor = true;
            this.formato.UseCustomForeColor = true;
            this.formato.UseSelectable = true;
            this.formato.UseStyleColors = true;
            // 
            // ordenado
            // 
            this.ordenado.BackColor = System.Drawing.Color.White;
            this.ordenado.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.ordenado.FormattingEnabled = true;
            this.ordenado.ItemHeight = 19;
            this.ordenado.Items.AddRange(new object[] {
            "#Pago",
            "Fecha",
            "#Suplidor"});
            this.ordenado.Location = new System.Drawing.Point(109, 246);
            this.ordenado.Name = "ordenado";
            this.ordenado.Size = new System.Drawing.Size(177, 25);
            this.ordenado.Style = MetroFramework.MetroColorStyle.Blue;
            this.ordenado.TabIndex = 119;
            this.ordenado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ordenado.UseCustomBackColor = true;
            this.ordenado.UseCustomForeColor = true;
            this.ordenado.UseSelectable = true;
            this.ordenado.UseStyleColors = true;
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.Color.White;
            this.estado.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.estado.FormattingEnabled = true;
            this.estado.ItemHeight = 19;
            this.estado.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Cancelados"});
            this.estado.Location = new System.Drawing.Point(108, 134);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(180, 25);
            this.estado.Style = MetroFramework.MetroColorStyle.Blue;
            this.estado.TabIndex = 116;
            this.estado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.estado.UseCustomBackColor = true;
            this.estado.UseCustomForeColor = true;
            this.estado.UseSelectable = true;
            this.estado.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(8, 278);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Formato";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // nomcli
            // 
            this.nomcli.BackColor = System.Drawing.Color.White;
            this.nomcli.Enabled = false;
            this.nomcli.Lines = new string[0];
            this.nomcli.Location = new System.Drawing.Point(109, 110);
            this.nomcli.MaxLength = 32767;
            this.nomcli.Name = "nomcli";
            this.nomcli.PasswordChar = '\0';
            this.nomcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomcli.SelectedText = "";
            this.nomcli.Size = new System.Drawing.Size(180, 23);
            this.nomcli.TabIndex = 115;
            this.nomcli.UseCustomBackColor = true;
            this.nomcli.UseCustomForeColor = true;
            this.nomcli.UseSelectable = true;
            this.nomcli.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(8, 252);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Ordenado Por";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(8, 114);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 114;
            this.metroLabel10.Text = "Nombre";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Fecha Inicial";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.White;
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(197, 86);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 113;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseCustomForeColor = true;
            this.buscar.UseSelectable = true;
            this.buscar.UseStyleColors = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Fecha Final";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // codcli
            // 
            this.codcli.BackColor = System.Drawing.Color.White;
            this.codcli.Lines = new string[0];
            this.codcli.Location = new System.Drawing.Point(109, 86);
            this.codcli.MaxLength = 32767;
            this.codcli.Name = "codcli";
            this.codcli.PasswordChar = '\0';
            this.codcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codcli.SelectedText = "";
            this.codcli.Size = new System.Drawing.Size(87, 23);
            this.codcli.TabIndex = 112;
            this.codcli.UseCustomBackColor = true;
            this.codcli.UseCustomForeColor = true;
            this.codcli.UseSelectable = true;
            this.codcli.UseStyleColors = true;
            this.codcli.Validating += new System.ComponentModel.CancelEventHandler(this.codcli_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Suplidor";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // fechaf
            // 
            this.fechaf.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.fechaf.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.fechaf.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.fechaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaf.Location = new System.Drawing.Point(109, 60);
            this.fechaf.MinimumSize = new System.Drawing.Size(0, 25);
            this.fechaf.Name = "fechaf";
            this.fechaf.Size = new System.Drawing.Size(126, 25);
            this.fechaf.Style = MetroFramework.MetroColorStyle.Blue;
            this.fechaf.TabIndex = 111;
            this.fechaf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fechaf.ValueChanged += new System.EventHandler(this.fechaf_ValueChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Estado";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // fechai
            // 
            this.fechai.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.fechai.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.fechai.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.fechai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechai.Location = new System.Drawing.Point(109, 34);
            this.fechai.MinimumSize = new System.Drawing.Size(0, 25);
            this.fechai.Name = "fechai";
            this.fechai.Size = new System.Drawing.Size(126, 25);
            this.fechai.Style = MetroFramework.MetroColorStyle.Blue;
            this.fechai.TabIndex = 109;
            this.fechai.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fechai.ValueChanged += new System.EventHandler(this.fechai_ValueChanged);
            // 
            // dos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(470, 433);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "dos";
            this.Load += new System.EventHandler(this.dos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datos;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox formato;
        private MetroFramework.Controls.MetroComboBox ordenado;
        private MetroFramework.Controls.MetroComboBox estado;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox nomcli;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox codcli;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime fechaf;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime fechai;
    }
}