namespace repuesto
{
    partial class cotizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cotizar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nom_cli = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ncf = new MetroFramework.Controls.MetroTextBox();
            this.cod_cli = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detalle = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.quitar = new MetroFramework.Controls.MetroButton();
            this.agregar = new MetroFramework.Controls.MetroButton();
            this.cod_art = new MetroFramework.Controls.MetroTextBox();
            this.sub_total = new MetroFramework.Controls.MetroTextBox();
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.itbis = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.precio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.consultar = new System.Windows.Forms.DataGridView();
            this.cod_veh = new MetroFramework.Controls.MetroTextBox();
            this.ano = new MetroFramework.Controls.MetroTextBox();
            this.model = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.marc = new MetroFramework.Controls.MetroTextBox();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userr = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.num_cot = new MetroFramework.Controls.MetroTextBox();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.nom_cli);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.ncf);
            this.groupBox1.Controls.Add(this.cod_cli);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // nom_cli
            // 
            this.nom_cli.BackColor = System.Drawing.Color.White;
            this.nom_cli.Lines = new string[0];
            this.nom_cli.Location = new System.Drawing.Point(88, 78);
            this.nom_cli.MaxLength = 32767;
            this.nom_cli.Name = "nom_cli";
            this.nom_cli.PasswordChar = '\0';
            this.nom_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_cli.SelectedText = "";
            this.nom_cli.Size = new System.Drawing.Size(205, 23);
            this.nom_cli.TabIndex = 0;
            this.nom_cli.UseCustomBackColor = true;
            this.nom_cli.UseSelectable = true;
            this.nom_cli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            this.nom_cli.Validating += new System.ComponentModel.CancelEventHandler(this.nom_cli_Validating);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(274, 36);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "NCF";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Codigo";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // ncf
            // 
            this.ncf.BackColor = System.Drawing.Color.White;
            this.ncf.Lines = new string[0];
            this.ncf.Location = new System.Drawing.Point(333, 36);
            this.ncf.MaxLength = 32767;
            this.ncf.Name = "ncf";
            this.ncf.PasswordChar = '\0';
            this.ncf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ncf.SelectedText = "";
            this.ncf.Size = new System.Drawing.Size(154, 23);
            this.ncf.TabIndex = 0;
            this.ncf.UseCustomBackColor = true;
            this.ncf.UseSelectable = true;
            this.ncf.Validating += new System.ComponentModel.CancelEventHandler(this.ncf_Validating);
            // 
            // cod_cli
            // 
            this.cod_cli.BackColor = System.Drawing.Color.White;
            this.cod_cli.Lines = new string[0];
            this.cod_cli.Location = new System.Drawing.Point(88, 40);
            this.cod_cli.MaxLength = 32767;
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.PasswordChar = '\0';
            this.cod_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_cli.SelectedText = "";
            this.cod_cli.Size = new System.Drawing.Size(85, 23);
            this.cod_cli.TabIndex = 0;
            this.cod_cli.UseCustomBackColor = true;
            this.cod_cli.UseSelectable = true;
            this.cod_cli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            this.cod_cli.Validating += new System.ComponentModel.CancelEventHandler(this.metroTextBox1_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.detalle);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.nuevo);
            this.groupBox2.Controls.Add(this.metroButton5);
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.quitar);
            this.groupBox2.Controls.Add(this.agregar);
            this.groupBox2.Controls.Add(this.cod_art);
            this.groupBox2.Controls.Add(this.sub_total);
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.itbis);
            this.groupBox2.Controls.Add(this.metroLabel17);
            this.groupBox2.Controls.Add(this.precio);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.cantidad);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos";
            // 
            // detalle
            // 
            this.detalle.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.detalle.FormattingEnabled = true;
            this.detalle.ItemHeight = 19;
            this.detalle.Location = new System.Drawing.Point(76, 72);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(140, 25);
            this.detalle.TabIndex = 162;
            this.detalle.UseSelectable = true;
            this.detalle.Validating += new System.ComponentModel.CancelEventHandler(this.metroComboBox2_Validating);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(160, 231);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(83, 30);
            this.metroButton4.TabIndex = 160;
            this.metroButton4.Text = "Procesar";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(461, 231);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(83, 30);
            this.metroButton5.TabIndex = 160;
            this.metroButton5.Text = "Salir";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(264, 231);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(83, 30);
            this.metroButton3.TabIndex = 160;
            this.metroButton3.Text = "Cancelar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(668, 147);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(83, 30);
            this.quitar.TabIndex = 160;
            this.quitar.Text = "Quitar";
            this.quitar.UseSelectable = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(668, 111);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(83, 30);
            this.agregar.TabIndex = 160;
            this.agregar.Text = "Agregar";
            this.agregar.UseSelectable = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // cod_art
            // 
            this.cod_art.BackColor = System.Drawing.Color.White;
            this.cod_art.Lines = new string[0];
            this.cod_art.Location = new System.Drawing.Point(8, 72);
            this.cod_art.MaxLength = 32767;
            this.cod_art.Name = "cod_art";
            this.cod_art.PasswordChar = '\0';
            this.cod_art.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_art.SelectedText = "";
            this.cod_art.Size = new System.Drawing.Size(58, 23);
            this.cod_art.TabIndex = 150;
            this.cod_art.UseCustomBackColor = true;
            this.cod_art.UseSelectable = true;
            this.cod_art.Validating += new System.ComponentModel.CancelEventHandler(this.cod_art_Validating);
            // 
            // sub_total
            // 
            this.sub_total.BackColor = System.Drawing.Color.White;
            this.sub_total.Lines = new string[0];
            this.sub_total.Location = new System.Drawing.Point(783, 238);
            this.sub_total.MaxLength = 32767;
            this.sub_total.Name = "sub_total";
            this.sub_total.PasswordChar = '\0';
            this.sub_total.ReadOnly = true;
            this.sub_total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sub_total.SelectedText = "";
            this.sub_total.Size = new System.Drawing.Size(105, 23);
            this.sub_total.TabIndex = 151;
            this.sub_total.UseCustomBackColor = true;
            this.sub_total.UseSelectable = true;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(783, 196);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ReadOnly = true;
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(105, 23);
            this.total.TabIndex = 151;
            this.total.UseCustomBackColor = true;
            this.total.UseSelectable = true;
            // 
            // itbis
            // 
            this.itbis.BackColor = System.Drawing.Color.White;
            this.itbis.Lines = new string[0];
            this.itbis.Location = new System.Drawing.Point(797, 28);
            this.itbis.MaxLength = 32767;
            this.itbis.Name = "itbis";
            this.itbis.PasswordChar = '\0';
            this.itbis.ReadOnly = true;
            this.itbis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itbis.SelectedText = "";
            this.itbis.Size = new System.Drawing.Size(51, 23);
            this.itbis.TabIndex = 151;
            this.itbis.UseCustomBackColor = true;
            this.itbis.UseSelectable = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(700, 200);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(64, 19);
            this.metroLabel17.TabIndex = 155;
            this.metroLabel17.Text = "Sub Total";
            this.metroLabel17.UseCustomBackColor = true;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.Color.White;
            this.precio.Lines = new string[0];
            this.precio.Location = new System.Drawing.Point(334, 72);
            this.precio.MaxLength = 32767;
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.precio.SelectedText = "";
            this.precio.Size = new System.Drawing.Size(85, 23);
            this.precio.TabIndex = 151;
            this.precio.UseCustomBackColor = true;
            this.precio.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(726, 242);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(38, 19);
            this.metroLabel16.TabIndex = 155;
            this.metroLabel16.Text = "Total";
            this.metroLabel16.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(722, 32);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(32, 19);
            this.metroLabel9.TabIndex = 155;
            this.metroLabel9.Text = "Itbis";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.White;
            this.cantidad.Lines = new string[0];
            this.cantidad.Location = new System.Drawing.Point(222, 72);
            this.cantidad.MaxLength = 32767;
            this.cantidad.Name = "cantidad";
            this.cantidad.PasswordChar = '\0';
            this.cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidad.SelectedText = "";
            this.cantidad.Size = new System.Drawing.Size(106, 23);
            this.cantidad.TabIndex = 152;
            this.cantidad.UseCustomBackColor = true;
            this.cantidad.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(363, 50);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 155;
            this.metroLabel10.Text = "Precio";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(246, 50);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(62, 19);
            this.metroLabel11.TabIndex = 156;
            this.metroLabel11.Text = "Cantidad";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(8, 50);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(53, 19);
            this.metroLabel12.TabIndex = 157;
            this.metroLabel12.Text = "Codigo";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(103, 50);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(49, 19);
            this.metroLabel13.TabIndex = 158;
            this.metroLabel13.Text = "Detalle";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidadd,
            this.precios,
            this.importe});
            this.dataGridView1.Location = new System.Drawing.Point(6, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 94);
            this.dataGridView1.TabIndex = 148;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
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
            // precios
            // 
            this.precios.HeaderText = "Precios";
            this.precios.Name = "precios";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.consultar);
            this.groupBox3.Controls.Add(this.cod_veh);
            this.groupBox3.Controls.Add(this.ano);
            this.groupBox3.Controls.Add(this.model);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.marc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1006, 248);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Vehiculo";
            // 
            // consultar
            // 
            this.consultar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultar.Location = new System.Drawing.Point(52, 93);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(291, 149);
            this.consultar.TabIndex = 148;
            this.consultar.DoubleClick += new System.EventHandler(this.consultar_DoubleClick);
            this.consultar.Validating += new System.ComponentModel.CancelEventHandler(this.consultar_Validating);
            // 
            // cod_veh
            // 
            this.cod_veh.BackColor = System.Drawing.Color.White;
            this.cod_veh.Lines = new string[0];
            this.cod_veh.Location = new System.Drawing.Point(8, 64);
            this.cod_veh.MaxLength = 32767;
            this.cod_veh.Name = "cod_veh";
            this.cod_veh.PasswordChar = '\0';
            this.cod_veh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_veh.SelectedText = "";
            this.cod_veh.Size = new System.Drawing.Size(58, 23);
            this.cod_veh.TabIndex = 0;
            this.cod_veh.UseCustomBackColor = true;
            this.cod_veh.UseSelectable = true;
            this.cod_veh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox8_KeyPress);
            this.cod_veh.Validating += new System.ComponentModel.CancelEventHandler(this.cod_veh_Validating);
            // 
            // ano
            // 
            this.ano.BackColor = System.Drawing.Color.White;
            this.ano.Lines = new string[0];
            this.ano.Location = new System.Drawing.Point(290, 64);
            this.ano.MaxLength = 32767;
            this.ano.Name = "ano";
            this.ano.PasswordChar = '\0';
            this.ano.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ano.SelectedText = "";
            this.ano.Size = new System.Drawing.Size(85, 23);
            this.ano.TabIndex = 0;
            this.ano.UseCustomBackColor = true;
            this.ano.UseSelectable = true;
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.White;
            this.model.Lines = new string[0];
            this.model.Location = new System.Drawing.Point(178, 64);
            this.model.MaxLength = 32767;
            this.model.Name = "model";
            this.model.PasswordChar = '\0';
            this.model.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.model.SelectedText = "";
            this.model.Size = new System.Drawing.Size(106, 23);
            this.model.TabIndex = 0;
            this.model.UseCustomBackColor = true;
            this.model.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(319, 42);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Año";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(202, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Modelo";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(8, 42);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Codigo";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(103, 42);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Marca";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // marc
            // 
            this.marc.BackColor = System.Drawing.Color.White;
            this.marc.Lines = new string[0];
            this.marc.Location = new System.Drawing.Point(72, 64);
            this.marc.MaxLength = 32767;
            this.marc.Name = "marc";
            this.marc.PasswordChar = '\0';
            this.marc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.marc.SelectedText = "";
            this.marc.Size = new System.Drawing.Size(100, 23);
            this.marc.TabIndex = 0;
            this.marc.UseCustomBackColor = true;
            this.marc.UseSelectable = true;
            this.marc.Validating += new System.ComponentModel.CancelEventHandler(this.marc_Validating);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(11, 27);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(32, 13);
            this.hora.TabIndex = 128;
            this.hora.Text = "hora";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(12, 9);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(39, 13);
            this.fecha.TabIndex = 129;
            this.fecha.Text = "fecha";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userr
            // 
            this.userr.AutoSize = true;
            this.userr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userr.Location = new System.Drawing.Point(598, 9);
            this.userr.Name = "userr";
            this.userr.Size = new System.Drawing.Size(76, 20);
            this.userr.TabIndex = 129;
            this.userr.Text = "Usuario:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(676, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(13, 20);
            this.label.TabIndex = 129;
            this.label.Text = "i";
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buscar.BackgroundImage = global::repuesto.Properties.Resources._1354069686_search_24;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar.Location = new System.Drawing.Point(383, 78);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(35, 23);
            this.buscar.TabIndex = 147;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(300, 21);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(142, 19);
            this.metroLabel6.TabIndex = 131;
            this.metroLabel6.Text = "Numero de Cotizacion";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // num_cot
            // 
            this.num_cot.BackColor = System.Drawing.Color.White;
            this.num_cot.Lines = new string[0];
            this.num_cot.Location = new System.Drawing.Point(444, 17);
            this.num_cot.MaxLength = 32767;
            this.num_cot.Name = "num_cot";
            this.num_cot.PasswordChar = '\0';
            this.num_cot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.num_cot.SelectedText = "";
            this.num_cot.Size = new System.Drawing.Size(85, 23);
            this.num_cot.TabIndex = 130;
            this.num_cot.UseCustomBackColor = true;
            this.num_cot.UseSelectable = true;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(363, 231);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(83, 30);
            this.nuevo.TabIndex = 160;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 24);
            this.label3.TabIndex = 154;
            this.label3.Text = "RECOMENDACIONES DE USO";
            this.label3.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(432, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(568, 190);
            this.dataGridView2.TabIndex = 153;
            this.dataGridView2.Visible = false;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // cotizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 715);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.num_cot);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.label);
            this.Controls.Add(this.userr);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cotizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COTIZACION DE ARTICULOS";
            this.Load += new System.EventHandler(this.cotizar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label userr;
        private System.Windows.Forms.Label label;
        private MetroFramework.Controls.MetroTextBox cod_cli;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nom_cli;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroTextBox ano;
        private MetroFramework.Controls.MetroTextBox model;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox marc;
        private MetroFramework.Controls.MetroTextBox cod_veh;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridView consultar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox ncf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox cod_art;
        private MetroFramework.Controls.MetroTextBox precio;
        private MetroFramework.Controls.MetroTextBox cantidad;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton quitar;
        private MetroFramework.Controls.MetroButton agregar;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox itbis;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox detalle;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox total;
        private MetroFramework.Controls.MetroTextBox sub_total;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precios;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox num_cot;
        private MetroFramework.Controls.MetroButton nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}