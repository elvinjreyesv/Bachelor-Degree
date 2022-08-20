namespace Proyecto_3.cxc2.con_cxc
{
    partial class consulta_recibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.data = new MetroFramework.Controls.MetroGrid();
            this.nomcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.codcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.fechaf = new MetroFramework.Controls.MetroDateTime();
            this.fechai = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.numcob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feccob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data2
            // 
            this.data2.AllowUserToAddRows = false;
            this.data2.AllowUserToDeleteRows = false;
            this.data2.BackgroundColor = System.Drawing.Color.White;
            this.data2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Location = new System.Drawing.Point(655, 8);
            this.data2.Name = "data2";
            this.data2.ReadOnly = true;
            this.data2.Size = new System.Drawing.Size(111, 71);
            this.data2.TabIndex = 153;
            this.data2.Visible = false;
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.BackgroundColor = System.Drawing.Color.White;
            this.data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(694, 27);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Size = new System.Drawing.Size(52, 29);
            this.data1.TabIndex = 152;
            this.data1.Visible = false;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numcob,
            this.nombre,
            this.balreg,
            this.fact,
            this.feccob});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data.Location = new System.Drawing.Point(2, 138);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(764, 285);
            this.data.Style = MetroFramework.MetroColorStyle.Blue;
            this.data.TabIndex = 147;
            this.data.Theme = MetroFramework.MetroThemeStyle.Light;
            this.data.UseCustomBackColor = true;
            this.data.UseCustomForeColor = true;
            this.data.UseStyleColors = true;
            // 
            // nomcli
            // 
            this.nomcli.BackColor = System.Drawing.Color.White;
            this.nomcli.Enabled = false;
            this.nomcli.Lines = new string[0];
            this.nomcli.Location = new System.Drawing.Point(386, 56);
            this.nomcli.MaxLength = 32767;
            this.nomcli.Name = "nomcli";
            this.nomcli.PasswordChar = '\0';
            this.nomcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomcli.SelectedText = "";
            this.nomcli.Size = new System.Drawing.Size(180, 23);
            this.nomcli.TabIndex = 146;
            this.nomcli.UseCustomBackColor = true;
            this.nomcli.UseCustomForeColor = true;
            this.nomcli.UseSelectable = true;
            this.nomcli.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 141;
            this.metroLabel2.Text = "Fecha Inicial";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 91);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 142;
            this.metroLabel3.Text = "Fecha Final";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // codcli
            // 
            this.codcli.BackColor = System.Drawing.Color.White;
            this.codcli.Lines = new string[0];
            this.codcli.Location = new System.Drawing.Point(335, 56);
            this.codcli.MaxLength = 32767;
            this.codcli.Name = "codcli";
            this.codcli.PasswordChar = '\0';
            this.codcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codcli.SelectedText = "";
            this.codcli.Size = new System.Drawing.Size(51, 23);
            this.codcli.TabIndex = 3;
            this.codcli.UseCustomBackColor = true;
            this.codcli.UseCustomForeColor = true;
            this.codcli.UseSelectable = true;
            this.codcli.UseStyleColors = true;
            this.codcli.Validating += new System.ComponentModel.CancelEventHandler(this.codcli_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(265, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 143;
            this.metroLabel4.Text = "Cliente";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // fechaf
            // 
            this.fechaf.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.fechaf.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.fechaf.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.fechaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaf.Location = new System.Drawing.Point(124, 88);
            this.fechaf.MinimumSize = new System.Drawing.Size(0, 25);
            this.fechaf.Name = "fechaf";
            this.fechaf.Size = new System.Drawing.Size(126, 25);
            this.fechaf.Style = MetroFramework.MetroColorStyle.Blue;
            this.fechaf.TabIndex = 2;
            this.fechaf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fechaf.ValueChanged += new System.EventHandler(this.fechaf_ValueChanged);
            // 
            // fechai
            // 
            this.fechai.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.fechai.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.fechai.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.fechai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechai.Location = new System.Drawing.Point(124, 62);
            this.fechai.MinimumSize = new System.Drawing.Size(0, 25);
            this.fechai.Name = "fechai";
            this.fechai.Size = new System.Drawing.Size(126, 25);
            this.fechai.Style = MetroFramework.MetroColorStyle.Blue;
            this.fechai.TabIndex = 1;
            this.fechai.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fechai.ValueChanged += new System.EventHandler(this.fechai_ValueChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightGray;
            this.metroButton1.BackgroundImage = global::Proyecto_3.Properties.Resources.printer;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.Location = new System.Drawing.Point(272, 432);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 151;
            this.metroButton1.Text = "F6-Presentar";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.LightGray;
            this.metroButton2.BackgroundImage = global::Proyecto_3.Properties.Resources.elvin;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton2.Location = new System.Drawing.Point(157, 432);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 36);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "F5-Buscar";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.BackgroundImage = global::Proyecto_3.Properties.Resources.salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.Location = new System.Drawing.Point(502, 432);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(114, 36);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 150;
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
            this.nuevo.Location = new System.Drawing.Point(387, 432);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(114, 36);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 149;
            this.nuevo.Text = "F4-Nuevo";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseCustomForeColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.UseStyleColors = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.White;
            this.buscar.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscar.Location = new System.Drawing.Point(566, 56);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(38, 23);
            this.buscar.TabIndex = 145;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseCustomForeColor = true;
            this.buscar.UseSelectable = true;
            this.buscar.UseStyleColors = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // numcob
            // 
            this.numcob.HeaderText = "Cobro";
            this.numcob.Name = "numcob";
            this.numcob.ReadOnly = true;
            this.numcob.Width = 80;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 190;
            // 
            // balreg
            // 
            this.balreg.HeaderText = "Total del Recibo";
            this.balreg.Name = "balreg";
            this.balreg.ReadOnly = true;
            // 
            // fact
            // 
            this.fact.HeaderText = "Factura";
            this.fact.Name = "fact";
            this.fact.ReadOnly = true;
            // 
            // feccob
            // 
            this.feccob.HeaderText = "Fecha";
            this.feccob.Name = "feccob";
            this.feccob.ReadOnly = true;
            // 
            // consulta_recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(769, 477);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.data);
            this.Controls.Add(this.nomcli);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.codcli);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.fechaf);
            this.Controls.Add(this.fechai);
            this.KeyPreview = true;
            this.Name = "consulta_recibos";
            this.Resizable = false;
            this.Text = "Consulta de Recibos";
            this.Load += new System.EventHandler(this.consulta_recibos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consulta_recibos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.DataGridView data1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroGrid data;
        private MetroFramework.Controls.MetroTextBox nomcli;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox codcli;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime fechaf;
        private MetroFramework.Controls.MetroDateTime fechai;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcob;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn balreg;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn feccob;
    }
}