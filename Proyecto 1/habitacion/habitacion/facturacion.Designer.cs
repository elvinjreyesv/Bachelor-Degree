namespace habitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturacion));
            this.salvar = new System.Windows.Forms.Button();
            this.numfac = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fecc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.procesar = new System.Windows.Forms.Button();
            this.preccio = new System.Windows.Forms.TextBox();
            this.canven = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.ComboBox();
            this.codcli = new System.Windows.Forms.ComboBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.codprod = new System.Windows.Forms.ComboBox();
            this.descripprod = new System.Windows.Forms.ComboBox();
            this.estadia = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precion = new System.Windows.Forms.TextBox();
            this.codhab = new System.Windows.Forms.TextBox();
            this.tipohabi = new System.Windows.Forms.TextBox();
            this.descriptem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.porciento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.precio_t = new System.Windows.Forms.TextBox();
            this.horas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.preciob = new System.Windows.Forms.TextBox();
            this.entrada = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.product = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.Location = new System.Drawing.Point(462, 221);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 0;
            this.salvar.Text = "SALVAR";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // numfac
            // 
            this.numfac.AutoSize = true;
            this.numfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numfac.Location = new System.Drawing.Point(155, 47);
            this.numfac.Name = "numfac";
            this.numfac.Size = new System.Drawing.Size(0, 15);
            this.numfac.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.importe});
            this.dataGridView1.Location = new System.Drawing.Point(4, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            // 
            // importe
            // 
            this.importe.HeaderText = "IMPORTE";
            this.importe.Name = "importe";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fecc
            // 
            this.fecc.AutoSize = true;
            this.fecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecc.Location = new System.Drawing.Point(11, 5);
            this.fecc.Name = "fecc";
            this.fecc.Size = new System.Drawing.Size(0, 15);
            this.fecc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUMERO DE FACTURA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Codigo";
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(105, 405);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 38);
            this.eliminar.TabIndex = 15;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // consultar
            // 
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(186, 406);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(96, 38);
            this.consultar.TabIndex = 16;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(376, 405);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 38);
            this.salir.TabIndex = 17;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(288, 405);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(82, 38);
            this.cancelar.TabIndex = 18;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // procesar
            // 
            this.procesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesar.Location = new System.Drawing.Point(16, 405);
            this.procesar.Name = "procesar";
            this.procesar.Size = new System.Drawing.Size(83, 38);
            this.procesar.TabIndex = 14;
            this.procesar.Text = "PROCESAR";
            this.procesar.UseVisualStyleBackColor = true;
            this.procesar.Click += new System.EventHandler(this.procesar_Click);
            // 
            // preccio
            // 
            this.preccio.Enabled = false;
            this.preccio.Location = new System.Drawing.Point(351, 223);
            this.preccio.Name = "preccio";
            this.preccio.Size = new System.Drawing.Size(100, 20);
            this.preccio.TabIndex = 19;
            // 
            // canven
            // 
            this.canven.Location = new System.Drawing.Point(245, 223);
            this.canven.Name = "canven";
            this.canven.Size = new System.Drawing.Size(100, 20);
            this.canven.TabIndex = 20;
            this.canven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canven_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "DATOS DE HABITACION:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "FACTURACION DE PRODUCTOS:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.hora);
            this.panel3.Controls.Add(this.nombre);
            this.panel3.Controls.Add(this.codcli);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.fecc);
            this.panel3.Controls.Add(this.numfac);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 123);
            this.panel3.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "DATOS DEL CLIENTE:";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(22, 21);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(0, 13);
            this.hora.TabIndex = 30;
            // 
            // nombre
            // 
            this.nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nombre.FormattingEnabled = true;
            this.nombre.Location = new System.Drawing.Point(115, 85);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(121, 21);
            this.nombre.TabIndex = 29;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            this.nombre.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_Validating);
            // 
            // codcli
            // 
            this.codcli.FormattingEnabled = true;
            this.codcli.Location = new System.Drawing.Point(70, 85);
            this.codcli.Name = "codcli";
            this.codcli.Size = new System.Drawing.Size(38, 21);
            this.codcli.TabIndex = 5;
            this.codcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codcli_KeyPress);
            this.codcli.Validating += new System.ComponentModel.CancelEventHandler(this.codcli_Validating);
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(457, 424);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(459, 405);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Total:";
            // 
            // codprod
            // 
            this.codprod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.codprod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.codprod.FormattingEnabled = true;
            this.codprod.Location = new System.Drawing.Point(48, 222);
            this.codprod.Name = "codprod";
            this.codprod.Size = new System.Drawing.Size(82, 21);
            this.codprod.TabIndex = 33;
            this.codprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codprod_KeyPress);
            this.codprod.Validating += new System.ComponentModel.CancelEventHandler(this.codprod_Validating);
            // 
            // descripprod
            // 
            this.descripprod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descripprod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.descripprod.FormattingEnabled = true;
            this.descripprod.Location = new System.Drawing.Point(136, 223);
            this.descripprod.Name = "descripprod";
            this.descripprod.Size = new System.Drawing.Size(103, 21);
            this.descripprod.TabIndex = 34;
            this.descripprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripprod_KeyPress);
            this.descripprod.Validating += new System.ComponentModel.CancelEventHandler(this.descripprod_Validating);
            // 
            // estadia
            // 
            this.estadia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.estadia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estadia.FormattingEnabled = true;
            this.estadia.Location = new System.Drawing.Point(93, 109);
            this.estadia.Name = "estadia";
            this.estadia.Size = new System.Drawing.Size(102, 21);
            this.estadia.TabIndex = 35;
            this.estadia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadia_KeyPress);
            this.estadia.Validating += new System.ComponentModel.CancelEventHandler(this.estadia_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(-4, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Tipo de Estadia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Precio Bruto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tematica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo";
            // 
            // precion
            // 
            this.precion.Enabled = false;
            this.precion.Location = new System.Drawing.Point(93, 83);
            this.precion.Name = "precion";
            this.precion.Size = new System.Drawing.Size(100, 20);
            this.precion.TabIndex = 22;
            // 
            // codhab
            // 
            this.codhab.Location = new System.Drawing.Point(93, 8);
            this.codhab.Name = "codhab";
            this.codhab.Size = new System.Drawing.Size(100, 20);
            this.codhab.TabIndex = 27;
            this.codhab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codhab_KeyPress);
            this.codhab.Validating += new System.ComponentModel.CancelEventHandler(this.codhab_Validating);
            // 
            // tipohabi
            // 
            this.tipohabi.Enabled = false;
            this.tipohabi.Location = new System.Drawing.Point(93, 33);
            this.tipohabi.Name = "tipohabi";
            this.tipohabi.Size = new System.Drawing.Size(100, 20);
            this.tipohabi.TabIndex = 26;
            // 
            // descriptem
            // 
            this.descriptem.Enabled = false;
            this.descriptem.Location = new System.Drawing.Point(93, 57);
            this.descriptem.Name = "descriptem";
            this.descriptem.Size = new System.Drawing.Size(100, 20);
            this.descriptem.TabIndex = 25;
            this.descriptem.Validating += new System.ComponentModel.CancelEventHandler(this.descriptem_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.porciento);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.precio_t);
            this.panel1.Controls.Add(this.horas);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.preciob);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.descriptem);
            this.panel1.Controls.Add(this.estadia);
            this.panel1.Controls.Add(this.codhab);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tipohabi);
            this.panel1.Controls.Add(this.precion);
            this.panel1.Location = new System.Drawing.Point(365, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 165);
            this.panel1.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(194, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 15);
            this.label21.TabIndex = 47;
            this.label21.Text = "Precio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(247, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 15);
            this.label20.TabIndex = 46;
            this.label20.Text = "%";
            // 
            // porciento
            // 
            this.porciento.Enabled = false;
            this.porciento.Location = new System.Drawing.Point(234, 109);
            this.porciento.Name = "porciento";
            this.porciento.Size = new System.Drawing.Size(34, 20);
            this.porciento.TabIndex = 44;
            this.porciento.TextChanged += new System.EventHandler(this.porciento_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(196, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 45;
            this.label16.Text = "Horas";
            // 
            // precio_t
            // 
            this.precio_t.Enabled = false;
            this.precio_t.Location = new System.Drawing.Point(195, 57);
            this.precio_t.Name = "precio_t";
            this.precio_t.Size = new System.Drawing.Size(39, 20);
            this.precio_t.TabIndex = 43;
            // 
            // horas
            // 
            this.horas.Enabled = false;
            this.horas.Location = new System.Drawing.Point(197, 109);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(34, 20);
            this.horas.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "Precio Neto ";
            // 
            // preciob
            // 
            this.preciob.Enabled = false;
            this.preciob.Location = new System.Drawing.Point(91, 136);
            this.preciob.Name = "preciob";
            this.preciob.Size = new System.Drawing.Size(100, 20);
            this.preciob.TabIndex = 38;
            // 
            // entrada
            // 
            this.entrada.Enabled = false;
            this.entrada.Location = new System.Drawing.Point(89, 138);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(100, 20);
            this.entrada.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-2, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Hora Entrada";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(197, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Salida";
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(248, 139);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(100, 20);
            this.salida.TabIndex = 41;
            this.salida.TextChanged += new System.EventHandler(this.salida_TextChanged);
            this.salida.Validating += new System.ComponentModel.CancelEventHandler(this.salida_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.images__27_;
            this.pictureBox1.Location = new System.Drawing.Point(273, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(16, 176);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(15, 14);
            this.product.TabIndex = 43;
            this.product.UseVisualStyleBackColor = true;
            this.product.CheckedChanged += new System.EventHandler(this.product_CheckedChanged);
            // 
            // facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 448);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descripprod);
            this.Controls.Add(this.codprod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.canven);
            this.Controls.Add(this.preccio);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.procesar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACION";
            this.Load += new System.EventHandler(this.facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label numfac;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fecc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button procesar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox canven;
        private System.Windows.Forms.TextBox preccio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox codcli;
        private System.Windows.Forms.ComboBox descripprod;
        private System.Windows.Forms.ComboBox codprod;
        private System.Windows.Forms.ComboBox nombre;
        private System.Windows.Forms.TextBox descriptem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tipohabi;
        private System.Windows.Forms.ComboBox estadia;
        private System.Windows.Forms.TextBox codhab;
        private System.Windows.Forms.TextBox precion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox preciob;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox salida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.TextBox precio_t;
        private System.Windows.Forms.TextBox porciento;
        private System.Windows.Forms.TextBox horas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox product;
    }
}