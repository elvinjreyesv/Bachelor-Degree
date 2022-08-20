namespace Proyecto_3.cxc2.procesos
{
    partial class recibos_ingresos
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cobro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.codcli = new MetroFramework.Controls.MetroTextBox();
            this.rnccli = new MetroFramework.Controls.MetroTextBox();
            this.nomcli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.refcob = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tcob = new MetroFramework.Controls.MetroTextBox();
            this.data = new MetroFramework.Controls.MetroGrid();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.b5 = new MetroFramework.Controls.MetroButton();
            this.feccob = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.observacion = new MetroFramework.Controls.MetroTextBox();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.tipo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pago = new MetroFramework.Controls.MetroLabel();
            this.numero = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Cobro";
            // 
            // cobro
            // 
            this.cobro.BackColor = System.Drawing.Color.White;
            this.cobro.Enabled = false;
            this.cobro.Lines = new string[0];
            this.cobro.Location = new System.Drawing.Point(108, 60);
            this.cobro.MaxLength = 32767;
            this.cobro.Name = "cobro";
            this.cobro.PasswordChar = '\0';
            this.cobro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cobro.SelectedText = "";
            this.cobro.Size = new System.Drawing.Size(82, 23);
            this.cobro.TabIndex = 1;
            this.cobro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cobro.UseCustomBackColor = true;
            this.cobro.UseCustomForeColor = true;
            this.cobro.UseSelectable = true;
            this.cobro.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(530, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Fecha";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Cliente";
            // 
            // codcli
            // 
            this.codcli.BackColor = System.Drawing.Color.White;
            this.codcli.Lines = new string[0];
            this.codcli.Location = new System.Drawing.Point(108, 84);
            this.codcli.MaxLength = 32767;
            this.codcli.Name = "codcli";
            this.codcli.PasswordChar = '\0';
            this.codcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codcli.SelectedText = "";
            this.codcli.Size = new System.Drawing.Size(56, 23);
            this.codcli.TabIndex = 2;
            this.codcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codcli.UseCustomBackColor = true;
            this.codcli.UseCustomForeColor = true;
            this.codcli.UseSelectable = true;
            this.codcli.UseStyleColors = true;
            this.codcli.Validating += new System.ComponentModel.CancelEventHandler(this.codcli_Validating);
            // 
            // rnccli
            // 
            this.rnccli.BackColor = System.Drawing.Color.White;
            this.rnccli.Enabled = false;
            this.rnccli.Lines = new string[0];
            this.rnccli.Location = new System.Drawing.Point(108, 108);
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
            // nomcli
            // 
            this.nomcli.BackColor = System.Drawing.Color.White;
            this.nomcli.Enabled = false;
            this.nomcli.Lines = new string[0];
            this.nomcli.Location = new System.Drawing.Point(164, 84);
            this.nomcli.MaxLength = 32767;
            this.nomcli.Name = "nomcli";
            this.nomcli.PasswordChar = '\0';
            this.nomcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomcli.SelectedText = "";
            this.nomcli.Size = new System.Drawing.Size(214, 23);
            this.nomcli.TabIndex = 34;
            this.nomcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomcli.UseCustomBackColor = true;
            this.nomcli.UseCustomForeColor = true;
            this.nomcli.UseSelectable = true;
            this.nomcli.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 135);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Referencia";
            // 
            // refcob
            // 
            this.refcob.BackColor = System.Drawing.Color.White;
            this.refcob.Lines = new string[0];
            this.refcob.Location = new System.Drawing.Point(108, 132);
            this.refcob.MaxLength = 32767;
            this.refcob.Name = "refcob";
            this.refcob.PasswordChar = '\0';
            this.refcob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.refcob.SelectedText = "";
            this.refcob.Size = new System.Drawing.Size(82, 23);
            this.refcob.TabIndex = 4;
            this.refcob.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refcob.UseCustomBackColor = true;
            this.refcob.UseCustomForeColor = true;
            this.refcob.UseSelectable = true;
            this.refcob.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(492, 554);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 19);
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Total del Cobro";
            // 
            // tcob
            // 
            this.tcob.BackColor = System.Drawing.Color.White;
            this.tcob.Enabled = false;
            this.tcob.Lines = new string[0];
            this.tcob.Location = new System.Drawing.Point(596, 550);
            this.tcob.MaxLength = 32767;
            this.tcob.Name = "tcob";
            this.tcob.PasswordChar = '\0';
            this.tcob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tcob.SelectedText = "";
            this.tcob.Size = new System.Drawing.Size(82, 23);
            this.tcob.TabIndex = 41;
            this.tcob.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tcob.UseCustomBackColor = true;
            this.tcob.UseCustomForeColor = true;
            this.tcob.UseSelectable = true;
            this.tcob.UseStyleColors = true;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.Factura,
            this.fecha,
            this.pendiente,
            this.aplicar,
            this.val,
            this.balance});
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
            this.data.Location = new System.Drawing.Point(9, 260);
            this.data.Name = "data";
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
            this.data.Size = new System.Drawing.Size(685, 214);
            this.data.TabIndex = 8;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellValueChanged);
            this.data.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.data_EditingControlShowing);
            this.data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.data_KeyPress);
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // pendiente
            // 
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            // 
            // aplicar
            // 
            this.aplicar.HeaderText = "Aplicar";
            this.aplicar.Name = "aplicar";
            // 
            // val
            // 
            this.val.HeaderText = "Val";
            this.val.Name = "val";
            this.val.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.val.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.val.Width = 30;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance Final";
            this.balance.Name = "balance";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.BackgroundImage = global::Proyecto_3.Properties.Resources.salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.Location = new System.Drawing.Point(339, 537);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(114, 36);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 47;
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
            this.nuevo.Location = new System.Drawing.Point(224, 537);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(114, 36);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 45;
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
            this.salvar.Location = new System.Drawing.Point(109, 537);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(114, 36);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 44;
            this.salvar.Text = " F10-Salvar";
            this.salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(8, 106);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 48;
            this.metroLabel9.Text = "RNC";
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b5.Location = new System.Drawing.Point(380, 84);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(38, 23);
            this.b5.TabIndex = 49;
            this.b5.UseSelectable = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // feccob
            // 
            this.feccob.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.feccob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.feccob.Location = new System.Drawing.Point(578, 44);
            this.feccob.MinimumSize = new System.Drawing.Size(0, 25);
            this.feccob.Name = "feccob";
            this.feccob.Size = new System.Drawing.Size(116, 25);
            this.feccob.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Comentario";
            // 
            // observacion
            // 
            this.observacion.BackColor = System.Drawing.Color.White;
            this.observacion.Lines = new string[0];
            this.observacion.Location = new System.Drawing.Point(108, 193);
            this.observacion.MaxLength = 32767;
            this.observacion.Multiline = true;
            this.observacion.Name = "observacion";
            this.observacion.PasswordChar = '\0';
            this.observacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.observacion.SelectedText = "";
            this.observacion.Size = new System.Drawing.Size(400, 56);
            this.observacion.TabIndex = 5;
            this.observacion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.observacion.UseCustomBackColor = true;
            this.observacion.UseCustomForeColor = true;
            this.observacion.UseSelectable = true;
            this.observacion.UseStyleColors = true;
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.BackgroundColor = System.Drawing.Color.White;
            this.data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.GridColor = System.Drawing.Color.White;
            this.data1.Location = new System.Drawing.Point(457, 26);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Size = new System.Drawing.Size(33, 26);
            this.data1.TabIndex = 56;
            this.data1.Visible = false;
            // 
            // tipo
            // 
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.tipo.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.tipo.FormattingEnabled = true;
            this.tipo.ItemHeight = 19;
            this.tipo.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque",
            "Transferencia",
            "Tarjeta"});
            this.tipo.Location = new System.Drawing.Point(108, 161);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(178, 25);
            this.tipo.TabIndex = 83;
            this.tipo.UseSelectable = true;
            this.tipo.SelectedIndexChanged += new System.EventHandler(this.tipo_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 84;
            this.metroLabel3.Text = "Tipo de Cobro";
            // 
            // pago
            // 
            this.pago.AutoSize = true;
            this.pago.Location = new System.Drawing.Point(305, 141);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(0, 0);
            this.pago.TabIndex = 91;
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.White;
            this.numero.Lines = new string[0];
            this.numero.Location = new System.Drawing.Point(309, 163);
            this.numero.MaxLength = 32767;
            this.numero.Name = "numero";
            this.numero.PasswordChar = '\0';
            this.numero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numero.SelectedText = "";
            this.numero.Size = new System.Drawing.Size(126, 23);
            this.numero.TabIndex = 90;
            this.numero.Theme = MetroFramework.MetroThemeStyle.Light;
            this.numero.UseCustomBackColor = true;
            this.numero.UseCustomForeColor = true;
            this.numero.UseSelectable = true;
            this.numero.UseStyleColors = true;
            this.numero.Visible = false;
            // 
            // recibos_ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(701, 596);
            this.Controls.Add(this.pago);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.observacion);
            this.Controls.Add(this.feccob);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.data);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tcob);
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
            this.Name = "recibos_ingresos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Recibos de Ingresos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.cobros_factura_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recibos_ingresos_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.recibos_ingresos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox cobro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox codcli;
        private MetroFramework.Controls.MetroTextBox rnccli;
        private MetroFramework.Controls.MetroTextBox nomcli;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox refcob;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tcob;
        public MetroFramework.Controls.MetroGrid data;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton b5;
        private MetroFramework.Controls.MetroDateTime feccob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn val;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox observacion;
        private System.Windows.Forms.DataGridView data1;
        private MetroFramework.Controls.MetroComboBox tipo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel pago;
        private MetroFramework.Controls.MetroTextBox numero;
    }
}