namespace Proyecto_3.inv.mantenimientos
{
    partial class vehiculos
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
            this.cod_veh = new MetroFramework.Controls.MetroTextBox();
            this.detalles = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.busca_vehiculo = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.vehiculo = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tipo_veh = new MetroFramework.Controls.MetroComboBox();
            this.comentario = new MetroFramework.Controls.MetroTextBox();
            this.combustible = new MetroFramework.Controls.MetroComboBox();
            this.num_placa = new MetroFramework.Controls.MetroTextBox();
            this.color = new MetroFramework.Controls.MetroTextBox();
            this.motor = new MetroFramework.Controls.MetroTextBox();
            this.ano = new MetroFramework.Controls.MetroTextBox();
            this.des_modelo = new MetroFramework.Controls.MetroTextBox();
            this.cod_modelo = new MetroFramework.Controls.MetroTextBox();
            this.cod_marca = new MetroFramework.Controls.MetroTextBox();
            this.des_marca = new MetroFramework.Controls.MetroTextBox();
            this.busca_modelo = new MetroFramework.Controls.MetroButton();
            this.busca_marca = new MetroFramework.Controls.MetroButton();
            this.estado = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dircli = new MetroFramework.Controls.MetroTextBox();
            this.celcli = new MetroFramework.Controls.MetroTextBox();
            this.telcli = new MetroFramework.Controls.MetroTextBox();
            this.cedcli = new MetroFramework.Controls.MetroTextBox();
            this.busca_cliente = new MetroFramework.Controls.MetroButton();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.nomcli = new MetroFramework.Controls.MetroTextBox();
            this.codcli = new MetroFramework.Controls.MetroTextBox();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.activar2 = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.vehiculo.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_veh
            // 
            this.cod_veh.Lines = new string[0];
            this.cod_veh.Location = new System.Drawing.Point(189, 63);
            this.cod_veh.MaxLength = 32767;
            this.cod_veh.Name = "cod_veh";
            this.cod_veh.PasswordChar = '\0';
            this.cod_veh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_veh.SelectedText = "";
            this.cod_veh.Size = new System.Drawing.Size(56, 23);
            this.cod_veh.TabIndex = 1;
            this.cod_veh.UseCustomBackColor = true;
            this.cod_veh.UseCustomForeColor = true;
            this.cod_veh.UseSelectable = true;
            this.cod_veh.UseStyleColors = true;
            this.cod_veh.Validating += new System.ComponentModel.CancelEventHandler(this.cod_veh_Validating);
            // 
            // detalles
            // 
            this.detalles.Lines = new string[0];
            this.detalles.Location = new System.Drawing.Point(189, 92);
            this.detalles.MaxLength = 32767;
            this.detalles.Name = "detalles";
            this.detalles.PasswordChar = '\0';
            this.detalles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.detalles.SelectedText = "";
            this.detalles.Size = new System.Drawing.Size(228, 23);
            this.detalles.TabIndex = 2;
            this.detalles.UseCustomBackColor = true;
            this.detalles.UseCustomForeColor = true;
            this.detalles.UseSelectable = true;
            this.detalles.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Vehículo";
            // 
            // busca_vehiculo
            // 
            this.busca_vehiculo.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.busca_vehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.busca_vehiculo.Location = new System.Drawing.Point(247, 63);
            this.busca_vehiculo.Name = "busca_vehiculo";
            this.busca_vehiculo.Size = new System.Drawing.Size(38, 23);
            this.busca_vehiculo.TabIndex = 3;
            this.busca_vehiculo.UseSelectable = true;
            this.busca_vehiculo.Visible = false;
            this.busca_vehiculo.Click += new System.EventHandler(this.busca_vehiculo_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Detalles";
            // 
            // vehiculo
            // 
            this.vehiculo.Controls.Add(this.metroTabPage1);
            this.vehiculo.Controls.Add(this.metroTabPage2);
            this.vehiculo.Location = new System.Drawing.Point(1, 121);
            this.vehiculo.Name = "vehiculo";
            this.vehiculo.SelectedIndex = 0;
            this.vehiculo.Size = new System.Drawing.Size(542, 425);
            this.vehiculo.TabIndex = 49;
            this.vehiculo.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.tipo_veh);
            this.metroTabPage1.Controls.Add(this.comentario);
            this.metroTabPage1.Controls.Add(this.combustible);
            this.metroTabPage1.Controls.Add(this.num_placa);
            this.metroTabPage1.Controls.Add(this.color);
            this.metroTabPage1.Controls.Add(this.motor);
            this.metroTabPage1.Controls.Add(this.ano);
            this.metroTabPage1.Controls.Add(this.des_modelo);
            this.metroTabPage1.Controls.Add(this.cod_modelo);
            this.metroTabPage1.Controls.Add(this.cod_marca);
            this.metroTabPage1.Controls.Add(this.des_marca);
            this.metroTabPage1.Controls.Add(this.busca_modelo);
            this.metroTabPage1.Controls.Add(this.busca_marca);
            this.metroTabPage1.Controls.Add(this.estado);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(534, 383);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Datos del Vehículo";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.UseCustomForeColor = true;
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // tipo_veh
            // 
            this.tipo_veh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo_veh.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.tipo_veh.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.tipo_veh.FormattingEnabled = true;
            this.tipo_veh.ItemHeight = 19;
            this.tipo_veh.Items.AddRange(new object[] {
            "Carro",
            "Camion",
            "Camioneta",
            "Yeepeta"});
            this.tipo_veh.Location = new System.Drawing.Point(184, 232);
            this.tipo_veh.Name = "tipo_veh";
            this.tipo_veh.Size = new System.Drawing.Size(174, 25);
            this.tipo_veh.TabIndex = 12;
            this.tipo_veh.UseSelectable = true;
            // 
            // comentario
            // 
            this.comentario.Lines = new string[0];
            this.comentario.Location = new System.Drawing.Point(184, 267);
            this.comentario.MaxLength = 32767;
            this.comentario.Multiline = true;
            this.comentario.Name = "comentario";
            this.comentario.PasswordChar = '\0';
            this.comentario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.comentario.SelectedText = "";
            this.comentario.Size = new System.Drawing.Size(251, 85);
            this.comentario.Style = MetroFramework.MetroColorStyle.Blue;
            this.comentario.TabIndex = 13;
            this.comentario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comentario.UseCustomBackColor = true;
            this.comentario.UseCustomForeColor = true;
            this.comentario.UseSelectable = true;
            this.comentario.UseStyleColors = true;
            // 
            // combustible
            // 
            this.combustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combustible.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.combustible.FormattingEnabled = true;
            this.combustible.ItemHeight = 19;
            this.combustible.Items.AddRange(new object[] {
            "Gasolina",
            "Gas",
            "Gasoil"});
            this.combustible.Location = new System.Drawing.Point(184, 124);
            this.combustible.Name = "combustible";
            this.combustible.Size = new System.Drawing.Size(174, 25);
            this.combustible.TabIndex = 7;
            this.combustible.UseSelectable = true;
            // 
            // num_placa
            // 
            this.num_placa.Lines = new string[0];
            this.num_placa.Location = new System.Drawing.Point(184, 155);
            this.num_placa.MaxLength = 32767;
            this.num_placa.Name = "num_placa";
            this.num_placa.PasswordChar = '\0';
            this.num_placa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.num_placa.SelectedText = "";
            this.num_placa.Size = new System.Drawing.Size(174, 23);
            this.num_placa.Style = MetroFramework.MetroColorStyle.Blue;
            this.num_placa.TabIndex = 8;
            this.num_placa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.num_placa.UseCustomBackColor = true;
            this.num_placa.UseCustomForeColor = true;
            this.num_placa.UseSelectable = true;
            this.num_placa.UseStyleColors = true;
            // 
            // color
            // 
            this.color.Lines = new string[0];
            this.color.Location = new System.Drawing.Point(184, 193);
            this.color.MaxLength = 32767;
            this.color.Name = "color";
            this.color.PasswordChar = '\0';
            this.color.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color.SelectedText = "";
            this.color.Size = new System.Drawing.Size(174, 23);
            this.color.Style = MetroFramework.MetroColorStyle.Blue;
            this.color.TabIndex = 9;
            this.color.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color.UseCustomBackColor = true;
            this.color.UseCustomForeColor = true;
            this.color.UseSelectable = true;
            this.color.UseStyleColors = true;
            // 
            // motor
            // 
            this.motor.Lines = new string[0];
            this.motor.Location = new System.Drawing.Point(184, 95);
            this.motor.MaxLength = 32767;
            this.motor.Name = "motor";
            this.motor.PasswordChar = '\0';
            this.motor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.motor.SelectedText = "";
            this.motor.Size = new System.Drawing.Size(174, 23);
            this.motor.Style = MetroFramework.MetroColorStyle.Blue;
            this.motor.TabIndex = 6;
            this.motor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.motor.UseCustomBackColor = true;
            this.motor.UseCustomForeColor = true;
            this.motor.UseSelectable = true;
            this.motor.UseStyleColors = true;
            // 
            // ano
            // 
            this.ano.Lines = new string[0];
            this.ano.Location = new System.Drawing.Point(184, 66);
            this.ano.MaxLength = 32767;
            this.ano.Name = "ano";
            this.ano.PasswordChar = '\0';
            this.ano.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ano.SelectedText = "";
            this.ano.Size = new System.Drawing.Size(85, 23);
            this.ano.Style = MetroFramework.MetroColorStyle.Blue;
            this.ano.TabIndex = 5;
            this.ano.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ano.UseCustomBackColor = true;
            this.ano.UseCustomForeColor = true;
            this.ano.UseSelectable = true;
            this.ano.UseStyleColors = true;
            this.ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ano_KeyPress);
            // 
            // des_modelo
            // 
            this.des_modelo.Enabled = false;
            this.des_modelo.Lines = new string[0];
            this.des_modelo.Location = new System.Drawing.Point(226, 37);
            this.des_modelo.MaxLength = 32767;
            this.des_modelo.Name = "des_modelo";
            this.des_modelo.PasswordChar = '\0';
            this.des_modelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.des_modelo.SelectedText = "";
            this.des_modelo.Size = new System.Drawing.Size(228, 23);
            this.des_modelo.Style = MetroFramework.MetroColorStyle.Blue;
            this.des_modelo.TabIndex = 4;
            this.des_modelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.des_modelo.UseCustomBackColor = true;
            this.des_modelo.UseCustomForeColor = true;
            this.des_modelo.UseSelectable = true;
            this.des_modelo.UseStyleColors = true;
            // 
            // cod_modelo
            // 
            this.cod_modelo.Lines = new string[0];
            this.cod_modelo.Location = new System.Drawing.Point(184, 37);
            this.cod_modelo.MaxLength = 32767;
            this.cod_modelo.Name = "cod_modelo";
            this.cod_modelo.PasswordChar = '\0';
            this.cod_modelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_modelo.SelectedText = "";
            this.cod_modelo.Size = new System.Drawing.Size(41, 23);
            this.cod_modelo.Style = MetroFramework.MetroColorStyle.Blue;
            this.cod_modelo.TabIndex = 3;
            this.cod_modelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod_modelo.UseCustomBackColor = true;
            this.cod_modelo.UseCustomForeColor = true;
            this.cod_modelo.UseSelectable = true;
            this.cod_modelo.UseStyleColors = true;
            this.cod_modelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_modelo_KeyPress);
            this.cod_modelo.Validating += new System.ComponentModel.CancelEventHandler(this.cod_modelo_Validating);
            // 
            // cod_marca
            // 
            this.cod_marca.Lines = new string[0];
            this.cod_marca.Location = new System.Drawing.Point(184, 8);
            this.cod_marca.MaxLength = 32767;
            this.cod_marca.Name = "cod_marca";
            this.cod_marca.PasswordChar = '\0';
            this.cod_marca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_marca.SelectedText = "";
            this.cod_marca.Size = new System.Drawing.Size(41, 23);
            this.cod_marca.TabIndex = 1;
            this.cod_marca.UseCustomBackColor = true;
            this.cod_marca.UseCustomForeColor = true;
            this.cod_marca.UseSelectable = true;
            this.cod_marca.UseStyleColors = true;
            this.cod_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_marca_KeyPress);
            this.cod_marca.Validating += new System.ComponentModel.CancelEventHandler(this.cod_marca_Validating);
            // 
            // des_marca
            // 
            this.des_marca.Enabled = false;
            this.des_marca.Lines = new string[0];
            this.des_marca.Location = new System.Drawing.Point(226, 8);
            this.des_marca.MaxLength = 32767;
            this.des_marca.Name = "des_marca";
            this.des_marca.PasswordChar = '\0';
            this.des_marca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.des_marca.SelectedText = "";
            this.des_marca.Size = new System.Drawing.Size(228, 23);
            this.des_marca.TabIndex = 2;
            this.des_marca.UseCustomBackColor = true;
            this.des_marca.UseCustomForeColor = true;
            this.des_marca.UseSelectable = true;
            this.des_marca.UseStyleColors = true;
            // 
            // busca_modelo
            // 
            this.busca_modelo.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.busca_modelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.busca_modelo.Location = new System.Drawing.Point(456, 37);
            this.busca_modelo.Name = "busca_modelo";
            this.busca_modelo.Size = new System.Drawing.Size(38, 23);
            this.busca_modelo.TabIndex = 71;
            this.busca_modelo.UseSelectable = true;
            this.busca_modelo.Click += new System.EventHandler(this.busca_modelo_Click);
            // 
            // busca_marca
            // 
            this.busca_marca.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.busca_marca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.busca_marca.Location = new System.Drawing.Point(456, 8);
            this.busca_marca.Name = "busca_marca";
            this.busca_marca.Size = new System.Drawing.Size(38, 23);
            this.busca_marca.TabIndex = 71;
            this.busca_marca.UseSelectable = true;
            this.busca_marca.Click += new System.EventHandler(this.busca_marca_Click);
            this.busca_marca.Validating += new System.ComponentModel.CancelEventHandler(this.busca_marca_Validating);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(24, 337);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(58, 15);
            this.estado.TabIndex = 68;
            this.estado.Text = "Estado";
            this.estado.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(24, 264);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(79, 19);
            this.metroLabel12.TabIndex = 58;
            this.metroLabel12.Text = "Comentario";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(22, 197);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(42, 19);
            this.metroLabel10.TabIndex = 60;
            this.metroLabel10.Text = "Color";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 165);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 19);
            this.metroLabel9.TabIndex = 61;
            this.metroLabel9.Text = "Placa";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(24, 238);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(107, 19);
            this.metroLabel8.TabIndex = 62;
            this.metroLabel8.Text = "Tipo de Vehículo";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(24, 130);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 63;
            this.metroLabel7.Text = "Combustible";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 99);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "Motor";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 65;
            this.metroLabel5.Text = "Año";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 41);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 66;
            this.metroLabel4.Text = "Modelo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Marca";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.dircli);
            this.metroTabPage2.Controls.Add(this.celcli);
            this.metroTabPage2.Controls.Add(this.telcli);
            this.metroTabPage2.Controls.Add(this.cedcli);
            this.metroTabPage2.Controls.Add(this.busca_cliente);
            this.metroTabPage2.Controls.Add(this.metroLabel18);
            this.metroTabPage2.Controls.Add(this.metroLabel17);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.nomcli);
            this.metroTabPage2.Controls.Add(this.codcli);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(534, 383);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cliente Propietario";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.UseCustomForeColor = true;
            this.metroTabPage2.UseStyleColors = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dircli
            // 
            this.dircli.Enabled = false;
            this.dircli.Lines = new string[0];
            this.dircli.Location = new System.Drawing.Point(184, 217);
            this.dircli.MaxLength = 32767;
            this.dircli.Name = "dircli";
            this.dircli.PasswordChar = '\0';
            this.dircli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dircli.SelectedText = "";
            this.dircli.Size = new System.Drawing.Size(335, 23);
            this.dircli.Style = MetroFramework.MetroColorStyle.Blue;
            this.dircli.TabIndex = 6;
            this.dircli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dircli.UseCustomBackColor = true;
            this.dircli.UseCustomForeColor = true;
            this.dircli.UseSelectable = true;
            this.dircli.UseStyleColors = true;
            // 
            // celcli
            // 
            this.celcli.Enabled = false;
            this.celcli.Lines = new string[0];
            this.celcli.Location = new System.Drawing.Point(184, 181);
            this.celcli.MaxLength = 32767;
            this.celcli.Name = "celcli";
            this.celcli.PasswordChar = '\0';
            this.celcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.celcli.SelectedText = "";
            this.celcli.Size = new System.Drawing.Size(149, 23);
            this.celcli.Style = MetroFramework.MetroColorStyle.Blue;
            this.celcli.TabIndex = 5;
            this.celcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.celcli.UseCustomBackColor = true;
            this.celcli.UseCustomForeColor = true;
            this.celcli.UseSelectable = true;
            this.celcli.UseStyleColors = true;
            // 
            // telcli
            // 
            this.telcli.Enabled = false;
            this.telcli.Lines = new string[0];
            this.telcli.Location = new System.Drawing.Point(184, 145);
            this.telcli.MaxLength = 32767;
            this.telcli.Name = "telcli";
            this.telcli.PasswordChar = '\0';
            this.telcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telcli.SelectedText = "";
            this.telcli.Size = new System.Drawing.Size(149, 23);
            this.telcli.Style = MetroFramework.MetroColorStyle.Blue;
            this.telcli.TabIndex = 4;
            this.telcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telcli.UseCustomBackColor = true;
            this.telcli.UseCustomForeColor = true;
            this.telcli.UseSelectable = true;
            this.telcli.UseStyleColors = true;
            // 
            // cedcli
            // 
            this.cedcli.Enabled = false;
            this.cedcli.Lines = new string[0];
            this.cedcli.Location = new System.Drawing.Point(184, 108);
            this.cedcli.MaxLength = 32767;
            this.cedcli.Name = "cedcli";
            this.cedcli.PasswordChar = '\0';
            this.cedcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cedcli.SelectedText = "";
            this.cedcli.Size = new System.Drawing.Size(149, 23);
            this.cedcli.Style = MetroFramework.MetroColorStyle.Blue;
            this.cedcli.TabIndex = 3;
            this.cedcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cedcli.UseCustomBackColor = true;
            this.cedcli.UseCustomForeColor = true;
            this.cedcli.UseSelectable = true;
            this.cedcli.UseStyleColors = true;
            // 
            // busca_cliente
            // 
            this.busca_cliente.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.busca_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.busca_cliente.Location = new System.Drawing.Point(263, 30);
            this.busca_cliente.Name = "busca_cliente";
            this.busca_cliente.Size = new System.Drawing.Size(38, 23);
            this.busca_cliente.TabIndex = 7;
            this.busca_cliente.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(82, 225);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(63, 19);
            this.metroLabel18.TabIndex = 48;
            this.metroLabel18.Text = "Dirección";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(82, 189);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(50, 19);
            this.metroLabel17.TabIndex = 48;
            this.metroLabel17.Text = "Celular";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(82, 153);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(60, 19);
            this.metroLabel16.TabIndex = 48;
            this.metroLabel16.Text = "Teléfono";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(82, 116);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(50, 19);
            this.metroLabel15.TabIndex = 48;
            this.metroLabel15.Text = "Cédula";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(82, 74);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(59, 19);
            this.metroLabel14.TabIndex = 48;
            this.metroLabel14.Text = "Nombre";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(82, 34);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(53, 19);
            this.metroLabel13.TabIndex = 48;
            this.metroLabel13.Text = "Código";
            // 
            // nomcli
            // 
            this.nomcli.Enabled = false;
            this.nomcli.Lines = new string[0];
            this.nomcli.Location = new System.Drawing.Point(184, 70);
            this.nomcli.MaxLength = 32767;
            this.nomcli.Name = "nomcli";
            this.nomcli.PasswordChar = '\0';
            this.nomcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomcli.SelectedText = "";
            this.nomcli.Size = new System.Drawing.Size(270, 23);
            this.nomcli.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomcli.TabIndex = 2;
            this.nomcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomcli.UseCustomBackColor = true;
            this.nomcli.UseCustomForeColor = true;
            this.nomcli.UseSelectable = true;
            this.nomcli.UseStyleColors = true;
            // 
            // codcli
            // 
            this.codcli.Lines = new string[0];
            this.codcli.Location = new System.Drawing.Point(184, 30);
            this.codcli.MaxLength = 32767;
            this.codcli.Name = "codcli";
            this.codcli.PasswordChar = '\0';
            this.codcli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codcli.SelectedText = "";
            this.codcli.Size = new System.Drawing.Size(75, 23);
            this.codcli.Style = MetroFramework.MetroColorStyle.Blue;
            this.codcli.TabIndex = 1;
            this.codcli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codcli.UseCustomBackColor = true;
            this.codcli.UseCustomForeColor = true;
            this.codcli.UseSelectable = true;
            this.codcli.UseStyleColors = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.Location = new System.Drawing.Point(369, 552);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(94, 39);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 4;
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
            this.activar2.Location = new System.Drawing.Point(275, 552);
            this.activar2.Name = "activar2";
            this.activar2.Size = new System.Drawing.Size(94, 39);
            this.activar2.Style = MetroFramework.MetroColorStyle.Blue;
            this.activar2.TabIndex = 3;
            this.activar2.Text = "Activar";
            this.activar2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activar2.UseCustomBackColor = true;
            this.activar2.UseCustomForeColor = true;
            this.activar2.UseSelectable = true;
            this.activar2.UseStyleColors = true;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.LightGray;
            this.nuevo.Location = new System.Drawing.Point(181, 552);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(94, 39);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 2;
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
            this.salvar.Location = new System.Drawing.Point(87, 552);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(94, 39);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 1;
            this.salvar.Text = "Salvar";
            this.salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseCustomForeColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.UseStyleColors = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 598);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.activar2);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.vehiculo);
            this.Controls.Add(this.cod_veh);
            this.Controls.Add(this.detalles);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.busca_vehiculo);
            this.KeyPreview = true;
            this.Name = "vehiculos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Vehículos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.vehiculos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vehiculos_KeyPress);
            this.vehiculo.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox cod_veh;
        private MetroFramework.Controls.MetroTextBox detalles;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton busca_vehiculo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabControl vehiculo;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton activar2;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox estado;
        private MetroFramework.Controls.MetroTextBox cod_marca;
        private MetroFramework.Controls.MetroTextBox des_marca;
        private MetroFramework.Controls.MetroButton busca_marca;
        private MetroFramework.Controls.MetroTextBox comentario;
        private MetroFramework.Controls.MetroComboBox combustible;
        private MetroFramework.Controls.MetroTextBox num_placa;
        private MetroFramework.Controls.MetroTextBox color;
        private MetroFramework.Controls.MetroTextBox motor;
        private MetroFramework.Controls.MetroTextBox ano;
        private MetroFramework.Controls.MetroTextBox des_modelo;
        private MetroFramework.Controls.MetroTextBox cod_modelo;
        private MetroFramework.Controls.MetroButton busca_modelo;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox nomcli;
        private MetroFramework.Controls.MetroTextBox codcli;
        private MetroFramework.Controls.MetroTextBox dircli;
        private MetroFramework.Controls.MetroTextBox celcli;
        private MetroFramework.Controls.MetroTextBox telcli;
        private MetroFramework.Controls.MetroTextBox cedcli;
        private MetroFramework.Controls.MetroButton busca_cliente;
        private MetroFramework.Controls.MetroComboBox tipo_veh;
    }
}