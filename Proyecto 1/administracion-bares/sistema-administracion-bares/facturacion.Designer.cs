namespace sistema_administracion_bares
{
    partial class facturacion
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.codigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.procesar = new MetroFramework.Controls.MetroButton();
            this.descuento = new MetroFramework.Controls.MetroTextBox();
            this.cod_mesero = new MetroFramework.Controls.MetroComboBox();
            this.agregar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.cancelar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.precio = new MetroFramework.Controls.MetroTextBox();
            this.cantidad = new MetroFramework.Controls.MetroTextBox();
            this.bub_total = new MetroFramework.Controls.MetroTextBox();
            this.itbis = new MetroFramework.Controls.MetroTextBox();
            this.num_fac = new MetroFramework.Controls.MetroTextBox();
            this.totales = new MetroFramework.Controls.MetroTextBox();
            this.cod_cli = new MetroFramework.Controls.MetroComboBox();
            this.cod_art = new MetroFramework.Controls.MetroComboBox();
            this.cod_mesa = new MetroFramework.Controls.MetroComboBox();
            this.descrip = new MetroFramework.Controls.MetroComboBox();
            this.mesero = new MetroFramework.Controls.MetroComboBox();
            this.mesa = new MetroFramework.Controls.MetroComboBox();
            this.cliente = new MetroFramework.Controls.MetroComboBox();
            this.f = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(395, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 18);
            this.label14.TabIndex = 87;
            this.label14.Text = "Precio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(178, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 86;
            this.label13.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 85;
            this.label10.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Codigo_Articulo";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigos,
            this.descripcion,
            this.cantidadd,
            this.precio_v,
            this.importes});
            this.data.Location = new System.Drawing.Point(29, 273);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(549, 150);
            this.data.TabIndex = 75;
            // 
            // codigos
            // 
            this.codigos.HeaderText = "Codigo";
            this.codigos.Name = "codigos";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // cantidadd
            // 
            this.cantidadd.HeaderText = "Cantidad";
            this.cantidadd.Name = "cantidadd";
            // 
            // precio_v
            // 
            this.precio_v.HeaderText = "Precio";
            this.precio_v.Name = "precio_v";
            // 
            // importes
            // 
            this.importes.HeaderText = "Importe";
            this.importes.Name = "importes";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(577, 452);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(50, 18);
            this.TOTAL.TabIndex = 64;
            this.TOTAL.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "CLIENTE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 61;
            this.label8.Text = "# FACTURA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "MESA";
            // 
            // fechas
            // 
            this.fechas.AutoSize = true;
            this.fechas.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechas.Location = new System.Drawing.Point(627, 65);
            this.fechas.Name = "fechas";
            this.fechas.Size = new System.Drawing.Size(0, 23);
            this.fechas.TabIndex = 93;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 94;
            this.label5.Text = "MESERO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 97;
            this.label7.Text = "% DESCUENTO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(340, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 18);
            this.label15.TabIndex = 99;
            this.label15.Text = "ITBIS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 18);
            this.label16.TabIndex = 101;
            this.label16.Text = "SUBTOTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_administracion_bares.Properties.Resources.descarga__10_;
            this.pictureBox1.Location = new System.Drawing.Point(598, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // procesar
            // 
            this.procesar.BackColor = System.Drawing.Color.AliceBlue;
            this.procesar.Location = new System.Drawing.Point(70, 442);
            this.procesar.Name = "procesar";
            this.procesar.Size = new System.Drawing.Size(85, 28);
            this.procesar.TabIndex = 106;
            this.procesar.Text = "PROCESAR";
            this.procesar.UseCustomBackColor = true;
            this.procesar.UseSelectable = true;
            // 
            // descuento
            // 
            this.descuento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descuento.Lines = new string[0];
            this.descuento.Location = new System.Drawing.Point(449, 80);
            this.descuento.MaxLength = 32767;
            this.descuento.Name = "descuento";
            this.descuento.PasswordChar = '\0';
            this.descuento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descuento.SelectedText = "";
            this.descuento.Size = new System.Drawing.Size(75, 23);
            this.descuento.TabIndex = 107;
            this.descuento.UseCustomBackColor = true;
            this.descuento.UseSelectable = true;
            // 
            // cod_mesero
            // 
            this.cod_mesero.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_mesero.FormattingEnabled = true;
            this.cod_mesero.ItemHeight = 19;
            this.cod_mesero.Location = new System.Drawing.Point(115, 153);
            this.cod_mesero.Name = "cod_mesero";
            this.cod_mesero.Size = new System.Drawing.Size(75, 25);
            this.cod_mesero.TabIndex = 108;
            this.cod_mesero.UseSelectable = true;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.AliceBlue;
            this.agregar.Location = new System.Drawing.Point(475, 234);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(85, 28);
            this.agregar.TabIndex = 109;
            this.agregar.Text = "AGREGAR";
            this.agregar.UseCustomBackColor = true;
            this.agregar.UseSelectable = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(432, 442);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 110;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.AliceBlue;
            this.cancelar.Location = new System.Drawing.Point(343, 442);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(85, 28);
            this.cancelar.TabIndex = 111;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseCustomBackColor = true;
            this.cancelar.UseSelectable = true;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(252, 442);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 112;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(161, 442);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 113;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precio.Lines = new string[0];
            this.precio.Location = new System.Drawing.Point(381, 238);
            this.precio.MaxLength = 32767;
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.precio.SelectedText = "";
            this.precio.Size = new System.Drawing.Size(75, 23);
            this.precio.TabIndex = 114;
            this.precio.UseCustomBackColor = true;
            this.precio.UseSelectable = true;
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cantidad.Lines = new string[0];
            this.cantidad.Location = new System.Drawing.Point(284, 239);
            this.cantidad.MaxLength = 32767;
            this.cantidad.Name = "cantidad";
            this.cantidad.PasswordChar = '\0';
            this.cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidad.SelectedText = "";
            this.cantidad.Size = new System.Drawing.Size(75, 23);
            this.cantidad.TabIndex = 115;
            this.cantidad.UseCustomBackColor = true;
            this.cantidad.UseSelectable = true;
            // 
            // bub_total
            // 
            this.bub_total.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bub_total.Lines = new string[0];
            this.bub_total.Location = new System.Drawing.Point(449, 152);
            this.bub_total.MaxLength = 32767;
            this.bub_total.Name = "bub_total";
            this.bub_total.PasswordChar = '\0';
            this.bub_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bub_total.SelectedText = "";
            this.bub_total.Size = new System.Drawing.Size(75, 23);
            this.bub_total.TabIndex = 116;
            this.bub_total.UseCustomBackColor = true;
            this.bub_total.UseSelectable = true;
            // 
            // itbis
            // 
            this.itbis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itbis.Lines = new string[0];
            this.itbis.Location = new System.Drawing.Point(449, 116);
            this.itbis.MaxLength = 32767;
            this.itbis.Name = "itbis";
            this.itbis.PasswordChar = '\0';
            this.itbis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itbis.SelectedText = "";
            this.itbis.Size = new System.Drawing.Size(75, 23);
            this.itbis.TabIndex = 117;
            this.itbis.UseCustomBackColor = true;
            this.itbis.UseSelectable = true;
            // 
            // num_fac
            // 
            this.num_fac.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num_fac.Lines = new string[0];
            this.num_fac.Location = new System.Drawing.Point(115, 42);
            this.num_fac.MaxLength = 32767;
            this.num_fac.Name = "num_fac";
            this.num_fac.PasswordChar = '\0';
            this.num_fac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.num_fac.SelectedText = "";
            this.num_fac.Size = new System.Drawing.Size(75, 23);
            this.num_fac.TabIndex = 118;
            this.num_fac.UseCustomBackColor = true;
            this.num_fac.UseSelectable = true;
            // 
            // totales
            // 
            this.totales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totales.Enabled = false;
            this.totales.Lines = new string[0];
            this.totales.Location = new System.Drawing.Point(633, 450);
            this.totales.MaxLength = 32767;
            this.totales.Name = "totales";
            this.totales.PasswordChar = '\0';
            this.totales.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totales.SelectedText = "";
            this.totales.Size = new System.Drawing.Size(75, 23);
            this.totales.TabIndex = 119;
            this.totales.UseCustomBackColor = true;
            this.totales.UseSelectable = true;
            // 
            // cod_cli
            // 
            this.cod_cli.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_cli.FormattingEnabled = true;
            this.cod_cli.ItemHeight = 19;
            this.cod_cli.Location = new System.Drawing.Point(115, 80);
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.Size = new System.Drawing.Size(75, 25);
            this.cod_cli.TabIndex = 120;
            this.cod_cli.UseSelectable = true;
            // 
            // cod_art
            // 
            this.cod_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_art.FormattingEnabled = true;
            this.cod_art.ItemHeight = 19;
            this.cod_art.Location = new System.Drawing.Point(56, 237);
            this.cod_art.Name = "cod_art";
            this.cod_art.Size = new System.Drawing.Size(99, 25);
            this.cod_art.TabIndex = 121;
            this.cod_art.UseSelectable = true;
            // 
            // cod_mesa
            // 
            this.cod_mesa.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_mesa.FormattingEnabled = true;
            this.cod_mesa.ItemHeight = 19;
            this.cod_mesa.Location = new System.Drawing.Point(115, 117);
            this.cod_mesa.Name = "cod_mesa";
            this.cod_mesa.Size = new System.Drawing.Size(75, 25);
            this.cod_mesa.TabIndex = 122;
            this.cod_mesa.UseSelectable = true;
            // 
            // descrip
            // 
            this.descrip.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.descrip.FormattingEnabled = true;
            this.descrip.ItemHeight = 19;
            this.descrip.Location = new System.Drawing.Point(169, 238);
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(101, 25);
            this.descrip.TabIndex = 123;
            this.descrip.UseSelectable = true;
            // 
            // mesero
            // 
            this.mesero.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mesero.FormattingEnabled = true;
            this.mesero.ItemHeight = 19;
            this.mesero.Location = new System.Drawing.Point(196, 152);
            this.mesero.Name = "mesero";
            this.mesero.Size = new System.Drawing.Size(121, 25);
            this.mesero.TabIndex = 124;
            this.mesero.UseSelectable = true;
            // 
            // mesa
            // 
            this.mesa.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mesa.FormattingEnabled = true;
            this.mesa.ItemHeight = 19;
            this.mesa.Location = new System.Drawing.Point(196, 117);
            this.mesa.Name = "mesa";
            this.mesa.Size = new System.Drawing.Size(121, 25);
            this.mesa.TabIndex = 125;
            this.mesa.UseSelectable = true;
            // 
            // cliente
            // 
            this.cliente.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cliente.FormattingEnabled = true;
            this.cliente.ItemHeight = 19;
            this.cliente.Location = new System.Drawing.Point(196, 80);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(121, 25);
            this.cliente.TabIndex = 126;
            this.cliente.UseSelectable = true;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.Location = new System.Drawing.Point(610, 42);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(0, 23);
            this.f.TabIndex = 127;
            // 
            // facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(759, 496);
            this.Controls.Add(this.f);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.mesa);
            this.Controls.Add(this.mesero);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.cod_mesa);
            this.Controls.Add(this.cod_art);
            this.Controls.Add(this.cod_cli);
            this.Controls.Add(this.totales);
            this.Controls.Add(this.num_fac);
            this.Controls.Add(this.itbis);
            this.Controls.Add(this.bub_total);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.cod_mesero);
            this.Controls.Add(this.descuento);
            this.Controls.Add(this.procesar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "facturacion";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "FACTURACION";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn importes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton cancelar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton agregar;
        private MetroFramework.Controls.MetroComboBox cod_mesero;
        private MetroFramework.Controls.MetroTextBox descuento;
        private MetroFramework.Controls.MetroButton procesar;
        private MetroFramework.Controls.MetroTextBox itbis;
        private MetroFramework.Controls.MetroTextBox bub_total;
        private MetroFramework.Controls.MetroTextBox cantidad;
        private MetroFramework.Controls.MetroTextBox precio;
        private MetroFramework.Controls.MetroTextBox totales;
        private MetroFramework.Controls.MetroTextBox num_fac;
        private MetroFramework.Controls.MetroComboBox cliente;
        private MetroFramework.Controls.MetroComboBox mesa;
        private MetroFramework.Controls.MetroComboBox mesero;
        private MetroFramework.Controls.MetroComboBox descrip;
        private MetroFramework.Controls.MetroComboBox cod_mesa;
        private MetroFramework.Controls.MetroComboBox cod_art;
        private MetroFramework.Controls.MetroComboBox cod_cli;
        private System.Windows.Forms.Label f;

    }
}