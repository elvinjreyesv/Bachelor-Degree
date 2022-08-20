namespace taller.Procesos
{
    partial class factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cod = new MetroFramework.Controls.MetroTextBox();
            this.cliente = new MetroFramework.Controls.MetroTextBox();
            this.cod_recep = new MetroFramework.Controls.MetroTextBox();
            this.descuento = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.cancelar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.procesar = new MetroFramework.Controls.MetroButton();
            this.can_tra = new MetroFramework.Controls.MetroTextBox();
            this.pre_tra = new MetroFramework.Controls.MetroTextBox();
            this.cod_tra = new MetroFramework.Controls.MetroTextBox();
            this.agregar = new MetroFramework.Controls.MetroButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ncf = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hora = new System.Windows.Forms.Label();
            this.detalle = new MetroFramework.Controls.MetroComboBox();
            this.itbis = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cod_cli = new MetroFramework.Controls.MetroTextBox();
            this.rnc = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.sub_total = new MetroFramework.Controls.MetroTextBox();
            this.des = new MetroFramework.Controls.MetroTextBox();
            this.itbiss = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.direccion = new MetroFramework.Controls.MetroTextBox();
            this.buscar_recep = new MetroFramework.Controls.MetroButton();
            this.label21 = new System.Windows.Forms.Label();
            this.buscar_cli = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check1 = new MetroFramework.Controls.MetroCheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CODIGO DE RECEPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "% DESCUENTO";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ITBIS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "TOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "FACTURACION";
            // 
            // cod
            // 
            this.cod.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cod.Lines = new string[0];
            this.cod.Location = new System.Drawing.Point(356, 51);
            this.cod.MaxLength = 32767;
            this.cod.Name = "cod";
            this.cod.PasswordChar = '\0';
            this.cod.ReadOnly = true;
            this.cod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod.SelectedText = "";
            this.cod.Size = new System.Drawing.Size(77, 23);
            this.cod.TabIndex = 23;
            this.cod.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod.UseCustomBackColor = true;
            this.cod.UseCustomForeColor = true;
            this.cod.UseSelectable = true;
            this.cod.UseStyleColors = true;
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cliente.Lines = new string[0];
            this.cliente.Location = new System.Drawing.Point(236, 21);
            this.cliente.MaxLength = 32767;
            this.cliente.Name = "cliente";
            this.cliente.PasswordChar = '\0';
            this.cliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cliente.SelectedText = "";
            this.cliente.Size = new System.Drawing.Size(138, 23);
            this.cliente.TabIndex = 23;
            this.cliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cliente.UseCustomBackColor = true;
            this.cliente.UseCustomForeColor = true;
            this.cliente.UseSelectable = true;
            this.cliente.UseStyleColors = true;
            this.cliente.Validating += new System.ComponentModel.CancelEventHandler(this.cliente_Validating);
            // 
            // cod_recep
            // 
            this.cod_recep.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cod_recep.Lines = new string[0];
            this.cod_recep.Location = new System.Drawing.Point(179, 60);
            this.cod_recep.MaxLength = 32767;
            this.cod_recep.Name = "cod_recep";
            this.cod_recep.PasswordChar = '\0';
            this.cod_recep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_recep.SelectedText = "";
            this.cod_recep.Size = new System.Drawing.Size(51, 23);
            this.cod_recep.TabIndex = 23;
            this.cod_recep.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod_recep.UseCustomBackColor = true;
            this.cod_recep.UseCustomForeColor = true;
            this.cod_recep.UseSelectable = true;
            this.cod_recep.UseStyleColors = true;
            // 
            // descuento
            // 
            this.descuento.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.descuento.FormattingEnabled = true;
            this.descuento.ItemHeight = 19;
            this.descuento.Items.AddRange(new object[] {
            "0",
            "5",
            "7",
            "8",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.descuento.Location = new System.Drawing.Point(310, 249);
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(41, 25);
            this.descuento.TabIndex = 20;
            this.descuento.UseSelectable = true;
            this.descuento.Visible = false;
            this.descuento.Validating += new System.ComponentModel.CancelEventHandler(this.descuento_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.importe});
            this.dataGridView1.Location = new System.Drawing.Point(31, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DETALLE";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 75;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.Width = 75;
            // 
            // importe
            // 
            this.importe.HeaderText = "IMPORTE";
            this.importe.Name = "importe";
            this.importe.Width = 75;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.HighlightText;
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(702, 301);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ReadOnly = true;
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(77, 23);
            this.total.TabIndex = 23;
            this.total.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total.UseCustomBackColor = true;
            this.total.UseCustomForeColor = true;
            this.total.UseSelectable = true;
            this.total.UseStyleColors = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salir.Location = new System.Drawing.Point(409, 291);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(79, 27);
            this.salir.TabIndex = 119;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelar.Location = new System.Drawing.Point(324, 291);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(79, 27);
            this.cancelar.TabIndex = 120;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseCustomBackColor = true;
            this.cancelar.UseSelectable = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eliminar.Location = new System.Drawing.Point(610, 109);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(79, 27);
            this.eliminar.TabIndex = 121;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nuevo.Location = new System.Drawing.Point(236, 291);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(79, 27);
            this.nuevo.TabIndex = 122;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // procesar
            // 
            this.procesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.procesar.Location = new System.Drawing.Point(151, 291);
            this.procesar.Name = "procesar";
            this.procesar.Size = new System.Drawing.Size(79, 27);
            this.procesar.TabIndex = 123;
            this.procesar.Text = "PROCESAR";
            this.procesar.UseCustomBackColor = true;
            this.procesar.UseSelectable = true;
            this.procesar.Click += new System.EventHandler(this.procesar_Click);
            // 
            // can_tra
            // 
            this.can_tra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.can_tra.Lines = new string[0];
            this.can_tra.Location = new System.Drawing.Point(295, 45);
            this.can_tra.MaxLength = 32767;
            this.can_tra.Name = "can_tra";
            this.can_tra.PasswordChar = '\0';
            this.can_tra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.can_tra.SelectedText = "";
            this.can_tra.Size = new System.Drawing.Size(77, 23);
            this.can_tra.TabIndex = 23;
            this.can_tra.Theme = MetroFramework.MetroThemeStyle.Light;
            this.can_tra.UseCustomBackColor = true;
            this.can_tra.UseCustomForeColor = true;
            this.can_tra.UseSelectable = true;
            this.can_tra.UseStyleColors = true;
            this.can_tra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.can_tra_KeyPress);
            this.can_tra.Validating += new System.ComponentModel.CancelEventHandler(this.can_tra_Validating);
            // 
            // pre_tra
            // 
            this.pre_tra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pre_tra.Lines = new string[0];
            this.pre_tra.Location = new System.Drawing.Point(378, 45);
            this.pre_tra.MaxLength = 32767;
            this.pre_tra.Name = "pre_tra";
            this.pre_tra.PasswordChar = '\0';
            this.pre_tra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pre_tra.SelectedText = "";
            this.pre_tra.Size = new System.Drawing.Size(77, 23);
            this.pre_tra.TabIndex = 23;
            this.pre_tra.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pre_tra.UseCustomBackColor = true;
            this.pre_tra.UseCustomForeColor = true;
            this.pre_tra.UseSelectable = true;
            this.pre_tra.UseStyleColors = true;
            // 
            // cod_tra
            // 
            this.cod_tra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cod_tra.Lines = new string[0];
            this.cod_tra.Location = new System.Drawing.Point(31, 45);
            this.cod_tra.MaxLength = 32767;
            this.cod_tra.Name = "cod_tra";
            this.cod_tra.PasswordChar = '\0';
            this.cod_tra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_tra.SelectedText = "";
            this.cod_tra.Size = new System.Drawing.Size(52, 23);
            this.cod_tra.TabIndex = 23;
            this.cod_tra.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod_tra.UseCustomBackColor = true;
            this.cod_tra.UseCustomForeColor = true;
            this.cod_tra.UseSelectable = true;
            this.cod_tra.UseStyleColors = true;
            this.cod_tra.Validating += new System.ComponentModel.CancelEventHandler(this.cod_tra_Validating);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.agregar.Location = new System.Drawing.Point(610, 76);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(79, 27);
            this.agregar.TabIndex = 119;
            this.agregar.Text = "AGREGAR";
            this.agregar.UseCustomBackColor = true;
            this.agregar.UseSelectable = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "PRECIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "CANTIDAD";
            // 
            // ncf
            // 
            this.ncf.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ncf.Lines = new string[0];
            this.ncf.Location = new System.Drawing.Point(571, 70);
            this.ncf.MaxLength = 32767;
            this.ncf.Name = "ncf";
            this.ncf.PasswordChar = '\0';
            this.ncf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ncf.SelectedText = "";
            this.ncf.Size = new System.Drawing.Size(209, 23);
            this.ncf.TabIndex = 126;
            this.ncf.UseCustomBackColor = true;
            this.ncf.UseCustomForeColor = true;
            this.ncf.UseSelectable = true;
            this.ncf.UseStyleColors = true;
            this.ncf.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 125;
            this.label8.Text = "NCF";
            this.label8.Visible = false;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(6, 15);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(62, 26);
            this.fecha.TabIndex = 127;
            this.fecha.Text = "fecha";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(20, 41);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(54, 26);
            this.hora.TabIndex = 127;
            this.hora.Text = "hora";
            // 
            // detalle
            // 
            this.detalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.detalle.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.detalle.FormattingEnabled = true;
            this.detalle.ItemHeight = 19;
            this.detalle.Location = new System.Drawing.Point(89, 45);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(200, 25);
            this.detalle.TabIndex = 128;
            this.detalle.UseCustomBackColor = true;
            this.detalle.UseSelectable = true;
            this.detalle.Validating += new System.ComponentModel.CancelEventHandler(this.detalle_Validating);
            // 
            // itbis
            // 
            this.itbis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.itbis.Enabled = false;
            this.itbis.Lines = new string[] {
        "18"};
            this.itbis.Location = new System.Drawing.Point(702, 25);
            this.itbis.MaxLength = 32767;
            this.itbis.Name = "itbis";
            this.itbis.PasswordChar = '\0';
            this.itbis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itbis.SelectedText = "";
            this.itbis.Size = new System.Drawing.Size(41, 23);
            this.itbis.TabIndex = 129;
            this.itbis.Text = "18";
            this.itbis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itbis.UseCustomBackColor = true;
            this.itbis.UseCustomForeColor = true;
            this.itbis.UseSelectable = true;
            this.itbis.UseStyleColors = true;
            this.itbis.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(747, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 130;
            this.label9.Text = "%";
            // 
            // cod_cli
            // 
            this.cod_cli.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cod_cli.Lines = new string[0];
            this.cod_cli.Location = new System.Drawing.Point(179, 21);
            this.cod_cli.MaxLength = 32767;
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.PasswordChar = '\0';
            this.cod_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_cli.SelectedText = "";
            this.cod_cli.Size = new System.Drawing.Size(51, 23);
            this.cod_cli.TabIndex = 131;
            this.cod_cli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod_cli.UseCustomBackColor = true;
            this.cod_cli.UseCustomForeColor = true;
            this.cod_cli.UseSelectable = true;
            this.cod_cli.UseStyleColors = true;
            this.cod_cli.Validating += new System.ComponentModel.CancelEventHandler(this.cod_cli_Validating);
            // 
            // rnc
            // 
            this.rnc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rnc.Lines = new string[0];
            this.rnc.Location = new System.Drawing.Point(571, 11);
            this.rnc.MaxLength = 32767;
            this.rnc.Name = "rnc";
            this.rnc.PasswordChar = '\0';
            this.rnc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rnc.SelectedText = "";
            this.rnc.Size = new System.Drawing.Size(209, 23);
            this.rnc.TabIndex = 132;
            this.rnc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rnc.UseCustomBackColor = true;
            this.rnc.UseCustomForeColor = true;
            this.rnc.UseSelectable = true;
            this.rnc.UseStyleColors = true;
            this.rnc.Validating += new System.ComponentModel.CancelEventHandler(this.rnc_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(535, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 125;
            this.label12.Text = "RNC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(353, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "%";
            this.label13.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.can_tra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.itbis);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pre_tra);
            this.groupBox1.Controls.Add(this.cod_tra);
            this.groupBox1.Controls.Add(this.detalle);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.procesar);
            this.groupBox1.Controls.Add(this.nuevo);
            this.groupBox1.Controls.Add(this.eliminar);
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Controls.Add(this.salir);
            this.groupBox1.Controls.Add(this.agregar);
            this.groupBox1.Controls.Add(this.descuento);
            this.groupBox1.Controls.Add(this.sub_total);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.itbiss);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 330);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "CODIGO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(123, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "DETALLE DEL TRABAJO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(627, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "SUB_TOTAL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "DESCUENTO";
            this.label18.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(655, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "ITBIS";
            // 
            // sub_total
            // 
            this.sub_total.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sub_total.Lines = new string[0];
            this.sub_total.Location = new System.Drawing.Point(702, 231);
            this.sub_total.MaxLength = 32767;
            this.sub_total.Name = "sub_total";
            this.sub_total.PasswordChar = '\0';
            this.sub_total.ReadOnly = true;
            this.sub_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sub_total.SelectedText = "";
            this.sub_total.Size = new System.Drawing.Size(77, 23);
            this.sub_total.TabIndex = 23;
            this.sub_total.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sub_total.UseCustomBackColor = true;
            this.sub_total.UseCustomForeColor = true;
            this.sub_total.UseSelectable = true;
            this.sub_total.UseStyleColors = true;
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.SystemColors.HighlightText;
            this.des.Lines = new string[0];
            this.des.Location = new System.Drawing.Point(89, 251);
            this.des.MaxLength = 32767;
            this.des.Name = "des";
            this.des.PasswordChar = '\0';
            this.des.ReadOnly = true;
            this.des.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.des.SelectedText = "";
            this.des.Size = new System.Drawing.Size(77, 23);
            this.des.TabIndex = 23;
            this.des.Theme = MetroFramework.MetroThemeStyle.Light;
            this.des.UseCustomBackColor = true;
            this.des.UseCustomForeColor = true;
            this.des.UseSelectable = true;
            this.des.UseStyleColors = true;
            this.des.Visible = false;
            // 
            // itbiss
            // 
            this.itbiss.BackColor = System.Drawing.SystemColors.HighlightText;
            this.itbiss.Lines = new string[0];
            this.itbiss.Location = new System.Drawing.Point(702, 267);
            this.itbiss.MaxLength = 32767;
            this.itbiss.Name = "itbiss";
            this.itbiss.PasswordChar = '\0';
            this.itbiss.ReadOnly = true;
            this.itbiss.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itbiss.SelectedText = "";
            this.itbiss.Size = new System.Drawing.Size(77, 23);
            this.itbiss.TabIndex = 23;
            this.itbiss.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itbiss.UseCustomBackColor = true;
            this.itbiss.UseCustomForeColor = true;
            this.itbiss.UseSelectable = true;
            this.itbiss.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.cod_recep);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rnc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cod_cli);
            this.groupBox2.Controls.Add(this.cliente);
            this.groupBox2.Controls.Add(this.direccion);
            this.groupBox2.Controls.Add(this.ncf);
            this.groupBox2.Controls.Add(this.buscar_recep);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buscar_cli);
            this.groupBox2.Location = new System.Drawing.Point(28, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 115);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.direccion.Lines = new string[0];
            this.direccion.Location = new System.Drawing.Point(571, 40);
            this.direccion.MaxLength = 32767;
            this.direccion.Name = "direccion";
            this.direccion.PasswordChar = '\0';
            this.direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.direccion.SelectedText = "";
            this.direccion.Size = new System.Drawing.Size(209, 23);
            this.direccion.TabIndex = 126;
            this.direccion.UseCustomBackColor = true;
            this.direccion.UseCustomForeColor = true;
            this.direccion.UseSelectable = true;
            this.direccion.UseStyleColors = true;
            // 
            // buscar_recep
            // 
            this.buscar_recep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buscar_recep.BackgroundImage = global::taller.Properties.Resources._1354069686_search_24;
            this.buscar_recep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar_recep.Location = new System.Drawing.Point(236, 60);
            this.buscar_recep.Name = "buscar_recep";
            this.buscar_recep.Size = new System.Drawing.Size(35, 23);
            this.buscar_recep.TabIndex = 31;
            this.buscar_recep.UseCustomBackColor = true;
            this.buscar_recep.UseSelectable = true;
            this.buscar_recep.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(500, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 125;
            this.label21.Text = "DIRECCION";
            // 
            // buscar_cli
            // 
            this.buscar_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buscar_cli.BackgroundImage = global::taller.Properties.Resources._1354069686_search_24;
            this.buscar_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar_cli.Location = new System.Drawing.Point(378, 21);
            this.buscar_cli.Name = "buscar_cli";
            this.buscar_cli.Size = new System.Drawing.Size(35, 23);
            this.buscar_cli.TabIndex = 31;
            this.buscar_cli.UseCustomBackColor = true;
            this.buscar_cli.UseSelectable = true;
            this.buscar_cli.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox3.Controls.Add(this.check1);
            this.groupBox3.Controls.Add(this.cod);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.hora);
            this.groupBox3.Controls.Add(this.fecha);
            this.groupBox3.Location = new System.Drawing.Point(28, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 91);
            this.groupBox3.TabIndex = 135;
            this.groupBox3.TabStop = false;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(548, 59);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(237, 15);
            this.check1.TabIndex = 128;
            this.check1.Text = "Realizar Factura con Comprobante Fiscal";
            this.check1.UseCustomBackColor = true;
            this.check1.UseCustomForeColor = true;
            this.check1.UseMnemonic = false;
            this.check1.UseSelectable = true;
            this.check1.UseStyleColors = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(677, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 26);
            this.label20.TabIndex = 0;
            this.label20.Text = "# FACTURA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(598, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "USUARIO:";
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox cod;
        private MetroFramework.Controls.MetroTextBox cliente;
        private MetroFramework.Controls.MetroTextBox cod_recep;
        private MetroFramework.Controls.MetroButton buscar_recep;
        private MetroFramework.Controls.MetroButton buscar_cli;
        private MetroFramework.Controls.MetroComboBox descuento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox total;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton cancelar;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton procesar;
        private MetroFramework.Controls.MetroTextBox can_tra;
        private MetroFramework.Controls.MetroTextBox pre_tra;
        private MetroFramework.Controls.MetroTextBox cod_tra;
        private MetroFramework.Controls.MetroButton agregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox ncf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hora;
        private MetroFramework.Controls.MetroComboBox detalle;
        private MetroFramework.Controls.MetroTextBox itbis;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox cod_cli;
        private MetroFramework.Controls.MetroTextBox rnc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroTextBox sub_total;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private MetroFramework.Controls.MetroTextBox itbiss;
        private System.Windows.Forms.Label label18;
        private MetroFramework.Controls.MetroTextBox des;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private MetroFramework.Controls.MetroTextBox direccion;
        private System.Windows.Forms.Label label21;
        private MetroFramework.Controls.MetroCheckBox check1;
    }
}