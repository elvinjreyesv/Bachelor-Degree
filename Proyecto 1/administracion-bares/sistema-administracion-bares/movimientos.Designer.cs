namespace sistema_administracion_bares
{
    partial class movimientos
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.Codigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.und_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.und_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.btnunidad = new MetroFramework.Controls.MetroButton();
            this.cod_mov = new MetroFramework.Controls.MetroTextBox();
            this.cod_sup = new MetroFramework.Controls.MetroComboBox();
            this.txtc = new MetroFramework.Controls.MetroTextBox();
            this.costo = new MetroFramework.Controls.MetroTextBox();
            this.tipo_mov = new MetroFramework.Controls.MetroTextBox();
            this.cantidad = new MetroFramework.Controls.MetroTextBox();
            this.txtprecio = new MetroFramework.Controls.MetroTextBox();
            this.documento = new MetroFramework.Controls.MetroTextBox();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.cancelar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.cod_art = new MetroFramework.Controls.MetroComboBox();
            this.almacen = new MetroFramework.Controls.MetroComboBox();
            this.cod_almacen = new MetroFramework.Controls.MetroComboBox();
            this.desc_art = new MetroFramework.Controls.MetroComboBox();
            this.unidad_c = new MetroFramework.Controls.MetroComboBox();
            this.unidad_v = new MetroFramework.Controls.MetroComboBox();
            this.nom_sup = new MetroFramework.Controls.MetroComboBox();
            this.add = new MetroFramework.Controls.MetroButton();
            this.totales = new MetroFramework.Controls.MetroTextBox();
           // this.fecha = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "CODIGO DEL ALMACEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "NUMERO DE DOCUMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "FECHA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "CODIGO DE MOVIMIENTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "TIPO DE MOVIMIENTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "CODIGO DEL SUPLIDOR";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(656, 492);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(50, 18);
            this.TOTAL.TabIndex = 17;
            this.TOTAL.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Codigo_Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unidad_venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(155, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Descripcion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(340, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "Unidad_compra";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigos,
            this.descripcion,
            this.cantidadd,
            this.und_c,
            this.und_v,
            this.costos,
            this.precio_v,
            this.importes});
            this.data.Location = new System.Drawing.Point(12, 327);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(795, 150);
            this.data.TabIndex = 57;
            // 
            // Codigos
            // 
            this.Codigos.HeaderText = "Codigo";
            this.Codigos.Name = "Codigos";
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
            // und_c
            // 
            this.und_c.HeaderText = "Unidad_compra";
            this.und_c.Name = "und_c";
            // 
            // und_v
            // 
            this.und_v.HeaderText = "unidad_venta";
            this.und_v.Name = "und_v";
            // 
            // costos
            // 
            this.costos.HeaderText = "Valor";
            this.costos.Name = "costos";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Precio";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // btnunidad
            // 
            this.btnunidad.BackColor = System.Drawing.Color.LightCyan;
            this.btnunidad.Location = new System.Drawing.Point(691, 187);
            this.btnunidad.Name = "btnunidad";
            this.btnunidad.Size = new System.Drawing.Size(123, 28);
            this.btnunidad.TabIndex = 62;
            this.btnunidad.Text = "CONVERTIR UNIDAD";
            this.btnunidad.UseCustomBackColor = true;
            this.btnunidad.UseSelectable = true;
            this.btnunidad.Click += new System.EventHandler(this.btnunidad_Click_1);
            // 
            // cod_mov
            // 
            this.cod_mov.Lines = new string[0];
            this.cod_mov.Location = new System.Drawing.Point(222, 53);
            this.cod_mov.MaxLength = 32767;
            this.cod_mov.Name = "cod_mov";
            this.cod_mov.PasswordChar = '\0';
            this.cod_mov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_mov.SelectedText = "";
            this.cod_mov.Size = new System.Drawing.Size(75, 23);
            this.cod_mov.TabIndex = 63;
            this.cod_mov.UseCustomBackColor = true;
            this.cod_mov.UseSelectable = true;
            // 
            // cod_sup
            // 
            this.cod_sup.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_sup.FormattingEnabled = true;
            this.cod_sup.ItemHeight = 19;
            this.cod_sup.Location = new System.Drawing.Point(222, 82);
            this.cod_sup.Name = "cod_sup";
            this.cod_sup.Size = new System.Drawing.Size(75, 25);
            this.cod_sup.TabIndex = 64;
            this.cod_sup.UseSelectable = true;
            this.cod_sup.Validating += new System.ComponentModel.CancelEventHandler(this.cod_sup_Validating_1);
            // 
            // txtc
            // 
            this.txtc.Enabled = false;
            this.txtc.Lines = new string[0];
            this.txtc.Location = new System.Drawing.Point(546, 297);
            this.txtc.MaxLength = 32767;
            this.txtc.Name = "txtc";
            this.txtc.PasswordChar = '\0';
            this.txtc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtc.SelectedText = "";
            this.txtc.Size = new System.Drawing.Size(35, 23);
            this.txtc.TabIndex = 65;
            this.txtc.UseCustomBackColor = true;
            this.txtc.UseSelectable = true;
            // 
            // costo
            // 
            this.costo.Lines = new string[0];
            this.costo.Location = new System.Drawing.Point(587, 297);
            this.costo.MaxLength = 32767;
            this.costo.Name = "costo";
            this.costo.PasswordChar = '\0';
            this.costo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costo.SelectedText = "";
            this.costo.Size = new System.Drawing.Size(75, 23);
            this.costo.TabIndex = 66;
            this.costo.UseCustomBackColor = true;
            this.costo.UseSelectable = true;
            // 
            // tipo_mov
            // 
            this.tipo_mov.Lines = new string[0];
            this.tipo_mov.Location = new System.Drawing.Point(222, 118);
            this.tipo_mov.MaxLength = 32767;
            this.tipo_mov.Name = "tipo_mov";
            this.tipo_mov.PasswordChar = '\0';
            this.tipo_mov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tipo_mov.SelectedText = "";
            this.tipo_mov.Size = new System.Drawing.Size(109, 23);
            this.tipo_mov.TabIndex = 67;
            this.tipo_mov.UseCustomBackColor = true;
            this.tipo_mov.UseSelectable = true;
            // 
            // cantidad
            // 
            this.cantidad.Lines = new string[0];
            this.cantidad.Location = new System.Drawing.Point(259, 298);
            this.cantidad.MaxLength = 32767;
            this.cantidad.Name = "cantidad";
            this.cantidad.PasswordChar = '\0';
            this.cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cantidad.SelectedText = "";
            this.cantidad.Size = new System.Drawing.Size(75, 23);
            this.cantidad.TabIndex = 68;
            this.cantidad.UseCustomBackColor = true;
            this.cantidad.UseSelectable = true;
            // 
            // txtprecio
            // 
            this.txtprecio.Lines = new string[0];
            this.txtprecio.Location = new System.Drawing.Point(668, 296);
            this.txtprecio.MaxLength = 32767;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PasswordChar = '\0';
            this.txtprecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprecio.SelectedText = "";
            this.txtprecio.Size = new System.Drawing.Size(64, 23);
            this.txtprecio.TabIndex = 69;
            this.txtprecio.UseCustomBackColor = true;
            this.txtprecio.UseSelectable = true;
            // 
            // documento
            // 
            this.documento.Lines = new string[0];
            this.documento.Location = new System.Drawing.Point(222, 219);
            this.documento.MaxLength = 32767;
            this.documento.Name = "documento";
            this.documento.PasswordChar = '\0';
            this.documento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.documento.SelectedText = "";
            this.documento.Size = new System.Drawing.Size(92, 23);
            this.documento.TabIndex = 70;
            this.documento.UseCustomBackColor = true;
            this.documento.UseSelectable = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightCyan;
            this.salir.Location = new System.Drawing.Point(518, 483);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 71;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.LightCyan;
            this.cancelar.Location = new System.Drawing.Point(427, 483);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(85, 28);
            this.cancelar.TabIndex = 72;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseCustomBackColor = true;
            this.cancelar.UseSelectable = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.LightCyan;
            this.eliminar.Location = new System.Drawing.Point(336, 483);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 73;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.LightCyan;
            this.nuevo.Location = new System.Drawing.Point(245, 483);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 74;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.LightCyan;
            this.salvar.Location = new System.Drawing.Point(154, 483);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 75;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cod_art
            // 
            this.cod_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_art.FormattingEnabled = true;
            this.cod_art.ItemHeight = 19;
            this.cod_art.Location = new System.Drawing.Point(33, 298);
            this.cod_art.Name = "cod_art";
            this.cod_art.Size = new System.Drawing.Size(99, 25);
            this.cod_art.TabIndex = 76;
            this.cod_art.UseSelectable = true;
            this.cod_art.Validating += new System.ComponentModel.CancelEventHandler(this.cod_art_Validating_1);
            // 
            // almacen
            // 
            this.almacen.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.almacen.FormattingEnabled = true;
            this.almacen.ItemHeight = 19;
            this.almacen.Location = new System.Drawing.Point(303, 147);
            this.almacen.Name = "almacen";
            this.almacen.Size = new System.Drawing.Size(116, 25);
            this.almacen.TabIndex = 77;
            this.almacen.UseSelectable = true;
            this.almacen.Validating += new System.ComponentModel.CancelEventHandler(this.almacen_Validating_1);
            // 
            // cod_almacen
            // 
            this.cod_almacen.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_almacen.FormattingEnabled = true;
            this.cod_almacen.ItemHeight = 19;
            this.cod_almacen.Location = new System.Drawing.Point(222, 147);
            this.cod_almacen.Name = "cod_almacen";
            this.cod_almacen.Size = new System.Drawing.Size(75, 25);
            this.cod_almacen.TabIndex = 78;
            this.cod_almacen.UseSelectable = true;
            this.cod_almacen.Validating += new System.ComponentModel.CancelEventHandler(this.cod_almacen_Validating_1);
            // 
            // desc_art
            // 
            this.desc_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.desc_art.FormattingEnabled = true;
            this.desc_art.ItemHeight = 19;
            this.desc_art.Location = new System.Drawing.Point(147, 297);
            this.desc_art.Name = "desc_art";
            this.desc_art.Size = new System.Drawing.Size(92, 25);
            this.desc_art.TabIndex = 79;
            this.desc_art.UseSelectable = true;
            this.desc_art.Validating += new System.ComponentModel.CancelEventHandler(this.desc_art_Validating_1);
            // 
            // unidad_c
            // 
            this.unidad_c.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.unidad_c.FormattingEnabled = true;
            this.unidad_c.ItemHeight = 19;
            this.unidad_c.Items.AddRange(new object[] {
            "unidades",
            "cajas grandes",
            "cajas pequenas"});
            this.unidad_c.Location = new System.Drawing.Point(347, 296);
            this.unidad_c.Name = "unidad_c";
            this.unidad_c.Size = new System.Drawing.Size(95, 25);
            this.unidad_c.TabIndex = 80;
            this.unidad_c.UseSelectable = true;
            // 
            // unidad_v
            // 
            this.unidad_v.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.unidad_v.FormattingEnabled = true;
            this.unidad_v.ItemHeight = 19;
            this.unidad_v.Items.AddRange(new object[] {
            "unidades",
            "cajas grandes",
            "cajas pequenas"});
            this.unidad_v.Location = new System.Drawing.Point(448, 295);
            this.unidad_v.Name = "unidad_v";
            this.unidad_v.Size = new System.Drawing.Size(92, 25);
            this.unidad_v.TabIndex = 81;
            this.unidad_v.UseSelectable = true;
            this.unidad_v.Validating += new System.ComponentModel.CancelEventHandler(this.unidad_v_Validating);
            // 
            // nom_sup
            // 
            this.nom_sup.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.nom_sup.FormattingEnabled = true;
            this.nom_sup.ItemHeight = 19;
            this.nom_sup.Location = new System.Drawing.Point(303, 82);
            this.nom_sup.Name = "nom_sup";
            this.nom_sup.Size = new System.Drawing.Size(116, 25);
            this.nom_sup.TabIndex = 82;
            this.nom_sup.UseSelectable = true;
            this.nom_sup.Validating += new System.ComponentModel.CancelEventHandler(this.nom_sup_Validating_1);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightCyan;
            this.add.Location = new System.Drawing.Point(736, 294);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 28);
            this.add.TabIndex = 83;
            this.add.Text = "AGREGAR";
            this.add.UseCustomBackColor = true;
            this.add.UseSelectable = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // totales
            // 
            this.totales.Lines = new string[0];
            this.totales.Location = new System.Drawing.Point(705, 487);
            this.totales.MaxLength = 32767;
            this.totales.Name = "totales";
            this.totales.PasswordChar = '\0';
            this.totales.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totales.SelectedText = "";
            this.totales.Size = new System.Drawing.Size(91, 23);
            this.totales.TabIndex = 84;
            this.totales.UseCustomBackColor = true;
            this.totales.UseSelectable = true;
            // 
            // fecha
            // 
           // this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
           // this.fecha.Location = new System.Drawing.Point(222, 187);
           // this.fecha.Name = "fecha";
           // this.fecha.Size = new System.Drawing.Size(98, 20);
           // this.fecha.TabIndex = 101;
            // 
            // movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(819, 518);
            //this.Controls.Add(this.fecha);
            this.Controls.Add(this.totales);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nom_sup);
            this.Controls.Add(this.unidad_v);
            this.Controls.Add(this.unidad_c);
            this.Controls.Add(this.desc_art);
            this.Controls.Add(this.cod_almacen);
            this.Controls.Add(this.almacen);
            this.Controls.Add(this.cod_art);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.tipo_mov);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.cod_sup);
            this.Controls.Add(this.cod_mov);
            this.Controls.Add(this.btnunidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "movimientos";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "MOVIMIENTOS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn und_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn und_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn costos;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn importes;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox cod_sup;
        private MetroFramework.Controls.MetroTextBox cod_mov;
        private MetroFramework.Controls.MetroButton btnunidad;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton cancelar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroTextBox documento;
        private MetroFramework.Controls.MetroTextBox txtprecio;
        private MetroFramework.Controls.MetroTextBox cantidad;
        private MetroFramework.Controls.MetroTextBox tipo_mov;
        private MetroFramework.Controls.MetroTextBox costo;
        private MetroFramework.Controls.MetroTextBox txtc;
        private MetroFramework.Controls.MetroComboBox nom_sup;
        private MetroFramework.Controls.MetroComboBox unidad_v;
        private MetroFramework.Controls.MetroComboBox unidad_c;
        private MetroFramework.Controls.MetroComboBox desc_art;
        private MetroFramework.Controls.MetroComboBox cod_almacen;
        private MetroFramework.Controls.MetroComboBox almacen;
        private MetroFramework.Controls.MetroComboBox cod_art;
        private MetroFramework.Controls.MetroButton add;
        private MetroFramework.Controls.MetroTextBox totales;
        //private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker fecha;
    }
}