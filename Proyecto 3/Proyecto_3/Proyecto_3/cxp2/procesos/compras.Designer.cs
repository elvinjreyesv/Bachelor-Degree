namespace Proyecto_3.cxp2.procesos
{
    partial class compras
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
            this.cod_cli = new MetroFramework.Controls.MetroTextBox();
            this.imprimir = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.sub = new MetroFramework.Controls.MetroTextBox();
            this.itbis = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.prec1 = new MetroFramework.Controls.MetroTextBox();
            this.cant1 = new MetroFramework.Controls.MetroTextBox();
            this.descrip1 = new MetroFramework.Controls.MetroTextBox();
            this.cod1 = new MetroFramework.Controls.MetroTextBox();
            this.condicion = new MetroFramework.Controls.MetroComboBox();
            this.telefono = new MetroFramework.Controls.MetroTextBox();
            this.rnc = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.fecha = new MetroFramework.Controls.MetroDateTime();
            this.data = new MetroFramework.Controls.MetroGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.factura = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.descuento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ncf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.marca = new MetroFramework.Controls.MetroCheckBox();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.b7 = new MetroFramework.Controls.MetroButton();
            this.b6 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.habilitar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.b5 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_cli
            // 
            this.cod_cli.BackColor = System.Drawing.Color.White;
            this.cod_cli.Lines = new string[0];
            this.cod_cli.Location = new System.Drawing.Point(137, 52);
            this.cod_cli.MaxLength = 32767;
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.PasswordChar = '\0';
            this.cod_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_cli.SelectedText = "";
            this.cod_cli.Size = new System.Drawing.Size(82, 23);
            this.cod_cli.TabIndex = 197;
            this.cod_cli.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod_cli.UseCustomBackColor = true;
            this.cod_cli.UseCustomForeColor = true;
            this.cod_cli.UseSelectable = true;
            this.cod_cli.UseStyleColors = true;
            this.cod_cli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_cli_KeyPress);
            this.cod_cli.Validating += new System.ComponentModel.CancelEventHandler(this.cod_cli_Validating);
            // 
            // imprimir
            // 
            this.imprimir.AutoSize = true;
            this.imprimir.Location = new System.Drawing.Point(492, 519);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(69, 15);
            this.imprimir.Style = MetroFramework.MetroColorStyle.Blue;
            this.imprimir.TabIndex = 195;
            this.imprimir.Text = "Imprimir";
            this.imprimir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.imprimir.UseSelectable = true;
            this.imprimir.Visible = false;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(113, 227);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(77, 19);
            this.metroLabel16.TabIndex = 194;
            this.metroLabel16.Text = "Repuestos";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(632, 218);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(38, 19);
            this.metroLabel14.TabIndex = 189;
            this.metroLabel14.Text = "Total";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(638, 185);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(32, 19);
            this.metroLabel8.TabIndex = 188;
            this.metroLabel8.Text = "Itbis";
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.White;
            this.sub.Enabled = false;
            this.sub.Lines = new string[0];
            this.sub.Location = new System.Drawing.Point(679, 153);
            this.sub.MaxLength = 32767;
            this.sub.Name = "sub";
            this.sub.PasswordChar = '\0';
            this.sub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sub.SelectedText = "";
            this.sub.Size = new System.Drawing.Size(100, 23);
            this.sub.TabIndex = 187;
            this.sub.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sub.UseCustomBackColor = true;
            this.sub.UseCustomForeColor = true;
            this.sub.UseSelectable = true;
            this.sub.UseStyleColors = true;
            // 
            // itbis
            // 
            this.itbis.BackColor = System.Drawing.Color.White;
            this.itbis.Enabled = false;
            this.itbis.Lines = new string[0];
            this.itbis.Location = new System.Drawing.Point(679, 184);
            this.itbis.MaxLength = 32767;
            this.itbis.Name = "itbis";
            this.itbis.PasswordChar = '\0';
            this.itbis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itbis.SelectedText = "";
            this.itbis.Size = new System.Drawing.Size(100, 23);
            this.itbis.TabIndex = 185;
            this.itbis.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itbis.UseCustomBackColor = true;
            this.itbis.UseCustomForeColor = true;
            this.itbis.UseSelectable = true;
            this.itbis.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(613, 156);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 184;
            this.metroLabel5.Text = "Subtotal";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Enabled = false;
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(679, 213);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(100, 23);
            this.total.TabIndex = 180;
            this.total.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total.UseCustomBackColor = true;
            this.total.UseCustomForeColor = true;
            this.total.UseSelectable = true;
            this.total.UseStyleColors = true;
            // 
            // prec1
            // 
            this.prec1.BackColor = System.Drawing.Color.White;
            this.prec1.Lines = new string[0];
            this.prec1.Location = new System.Drawing.Point(517, 249);
            this.prec1.MaxLength = 32767;
            this.prec1.Name = "prec1";
            this.prec1.PasswordChar = '\0';
            this.prec1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prec1.SelectedText = "";
            this.prec1.Size = new System.Drawing.Size(86, 23);
            this.prec1.TabIndex = 163;
            this.prec1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prec1.UseCustomBackColor = true;
            this.prec1.UseCustomForeColor = true;
            this.prec1.UseSelectable = true;
            this.prec1.UseStyleColors = true;
            this.prec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prec1_KeyPress);
            // 
            // cant1
            // 
            this.cant1.BackColor = System.Drawing.Color.White;
            this.cant1.Lines = new string[0];
            this.cant1.Location = new System.Drawing.Point(430, 249);
            this.cant1.MaxLength = 32767;
            this.cant1.Name = "cant1";
            this.cant1.PasswordChar = '\0';
            this.cant1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cant1.SelectedText = "";
            this.cant1.Size = new System.Drawing.Size(86, 23);
            this.cant1.TabIndex = 162;
            this.cant1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cant1.UseCustomBackColor = true;
            this.cant1.UseCustomForeColor = true;
            this.cant1.UseSelectable = true;
            this.cant1.UseStyleColors = true;
            this.cant1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cant1_KeyPress);
            // 
            // descrip1
            // 
            this.descrip1.BackColor = System.Drawing.Color.White;
            this.descrip1.Lines = new string[0];
            this.descrip1.Location = new System.Drawing.Point(136, 249);
            this.descrip1.MaxLength = 32767;
            this.descrip1.Name = "descrip1";
            this.descrip1.PasswordChar = '\0';
            this.descrip1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descrip1.SelectedText = "";
            this.descrip1.Size = new System.Drawing.Size(293, 23);
            this.descrip1.TabIndex = 178;
            this.descrip1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descrip1.UseCustomBackColor = true;
            this.descrip1.UseCustomForeColor = true;
            this.descrip1.UseSelectable = true;
            this.descrip1.UseStyleColors = true;
            // 
            // cod1
            // 
            this.cod1.BackColor = System.Drawing.Color.White;
            this.cod1.Lines = new string[0];
            this.cod1.Location = new System.Drawing.Point(79, 249);
            this.cod1.MaxLength = 32767;
            this.cod1.Name = "cod1";
            this.cod1.PasswordChar = '\0';
            this.cod1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod1.SelectedText = "";
            this.cod1.Size = new System.Drawing.Size(56, 23);
            this.cod1.TabIndex = 161;
            this.cod1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod1.UseCustomBackColor = true;
            this.cod1.UseCustomForeColor = true;
            this.cod1.UseSelectable = true;
            this.cod1.UseStyleColors = true;
            this.cod1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod1_KeyPress);
            this.cod1.Validating += new System.ComponentModel.CancelEventHandler(this.cod1_Validating);
            // 
            // condicion
            // 
            this.condicion.BackColor = System.Drawing.Color.White;
            this.condicion.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.condicion.FormattingEnabled = true;
            this.condicion.ItemHeight = 19;
            this.condicion.Items.AddRange(new object[] {
            "CONTADO",
            "1 A 15 DIAS",
            "1 A 30  DIAS",
            "1 A 60 DIAS",
            "1 A 90  DIAS"});
            this.condicion.Location = new System.Drawing.Point(137, 181);
            this.condicion.Name = "condicion";
            this.condicion.Size = new System.Drawing.Size(165, 25);
            this.condicion.Style = MetroFramework.MetroColorStyle.Blue;
            this.condicion.TabIndex = 157;
            this.condicion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.condicion.UseCustomBackColor = true;
            this.condicion.UseCustomForeColor = true;
            this.condicion.UseSelectable = true;
            this.condicion.UseStyleColors = true;
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.Color.White;
            this.telefono.Lines = new string[0];
            this.telefono.Location = new System.Drawing.Point(137, 127);
            this.telefono.MaxLength = 32767;
            this.telefono.Name = "telefono";
            this.telefono.PasswordChar = '\0';
            this.telefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telefono.SelectedText = "";
            this.telefono.Size = new System.Drawing.Size(165, 23);
            this.telefono.TabIndex = 156;
            this.telefono.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telefono.UseCustomBackColor = true;
            this.telefono.UseCustomForeColor = true;
            this.telefono.UseSelectable = true;
            this.telefono.UseStyleColors = true;
            // 
            // rnc
            // 
            this.rnc.BackColor = System.Drawing.Color.White;
            this.rnc.Lines = new string[0];
            this.rnc.Location = new System.Drawing.Point(137, 102);
            this.rnc.MaxLength = 32767;
            this.rnc.Name = "rnc";
            this.rnc.PasswordChar = '\0';
            this.rnc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rnc.SelectedText = "";
            this.rnc.Size = new System.Drawing.Size(165, 23);
            this.rnc.TabIndex = 155;
            this.rnc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rnc.UseCustomBackColor = true;
            this.rnc.UseCustomForeColor = true;
            this.rnc.UseSelectable = true;
            this.rnc.UseStyleColors = true;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.White;
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(137, 77);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.Size = new System.Drawing.Size(238, 23);
            this.nombre.TabIndex = 154;
            this.nombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombre.UseCustomBackColor = true;
            this.nombre.UseCustomForeColor = true;
            this.nombre.UseSelectable = true;
            this.nombre.UseStyleColors = true;
            // 
            // fecha
            // 
            this.fecha.CalendarTitleBackColor = System.Drawing.Color.SkyBlue;
            this.fecha.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.fecha.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(652, 47);
            this.fecha.MinimumSize = new System.Drawing.Size(0, 25);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(126, 25);
            this.fecha.Style = MetroFramework.MetroColorStyle.Blue;
            this.fecha.TabIndex = 176;
            this.fecha.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
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
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.importe});
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
            this.data.Location = new System.Drawing.Point(45, 277);
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
            this.data.Size = new System.Drawing.Size(695, 226);
            this.data.TabIndex = 171;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 250;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(605, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 169;
            this.metroLabel1.Text = "Fecha";
            // 
            // factura
            // 
            this.factura.BackColor = System.Drawing.Color.White;
            this.factura.Lines = new string[0];
            this.factura.Location = new System.Drawing.Point(137, 23);
            this.factura.MaxLength = 32767;
            this.factura.Name = "factura";
            this.factura.PasswordChar = '\0';
            this.factura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.factura.SelectedText = "";
            this.factura.Size = new System.Drawing.Size(126, 23);
            this.factura.TabIndex = 153;
            this.factura.Theme = MetroFramework.MetroThemeStyle.Light;
            this.factura.UseCustomBackColor = true;
            this.factura.UseCustomForeColor = true;
            this.factura.UseSelectable = true;
            this.factura.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(45, 106);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 19);
            this.metroLabel13.TabIndex = 207;
            this.metroLabel13.Text = "RNC";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(45, 187);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(68, 19);
            this.metroLabel12.TabIndex = 206;
            this.metroLabel12.Text = "Condición";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(45, 131);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(60, 19);
            this.metroLabel11.TabIndex = 205;
            this.metroLabel11.Text = "Teléfono";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(45, 77);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 204;
            this.metroLabel10.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 201;
            this.metroLabel2.Text = "Suplidor";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 200;
            this.metroLabel6.Text = "# Compra";
            // 
            // descuento
            // 
            this.descuento.BackColor = System.Drawing.Color.White;
            this.descuento.Lines = new string[0];
            this.descuento.Location = new System.Drawing.Point(678, 124);
            this.descuento.MaxLength = 32767;
            this.descuento.Name = "descuento";
            this.descuento.PasswordChar = '\0';
            this.descuento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descuento.SelectedText = "";
            this.descuento.Size = new System.Drawing.Size(100, 23);
            this.descuento.TabIndex = 209;
            this.descuento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descuento.UseCustomBackColor = true;
            this.descuento.UseCustomForeColor = true;
            this.descuento.UseSelectable = true;
            this.descuento.UseStyleColors = true;
            this.descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descuento_KeyPress);
            this.descuento.Validated += new System.EventHandler(this.descuento_Validated);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(609, 127);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 208;
            this.metroLabel3.Text = "Descuento";
            // 
            // ncf
            // 
            this.ncf.BackColor = System.Drawing.Color.White;
            this.ncf.Lines = new string[0];
            this.ncf.Location = new System.Drawing.Point(136, 154);
            this.ncf.MaxLength = 19;
            this.ncf.Name = "ncf";
            this.ncf.PasswordChar = '\0';
            this.ncf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ncf.SelectedText = "";
            this.ncf.Size = new System.Drawing.Size(165, 23);
            this.ncf.TabIndex = 210;
            this.ncf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ncf.UseCustomBackColor = true;
            this.ncf.UseCustomForeColor = true;
            this.ncf.UseSelectable = true;
            this.ncf.UseStyleColors = true;
            this.ncf.TextChanged += new System.EventHandler(this.ncf_TextChanged);
            this.ncf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ncf_KeyDown);
            this.ncf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ncf_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 211;
            this.metroLabel4.Text = "NCF";
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(307, 160);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(125, 15);
            this.marca.TabIndex = 212;
            this.marca.Text = "proveedor Informal";
            this.marca.UseSelectable = true;
            this.marca.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToDeleteRows = false;
            this.data1.BackgroundColor = System.Drawing.Color.White;
            this.data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(705, 22);
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Size = new System.Drawing.Size(24, 19);
            this.data1.TabIndex = 213;
            this.data1.Visible = false;
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.White;
            this.b7.BackgroundImage = global::Proyecto_3.Properties.Resources.plus24;
            this.b7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b7.Location = new System.Drawing.Point(741, 264);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(38, 23);
            this.b7.TabIndex = 164;
            this.b7.UseSelectable = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.White;
            this.b6.BackgroundImage = global::Proyecto_3.Properties.Resources.quitar;
            this.b6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b6.Location = new System.Drawing.Point(741, 288);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(38, 23);
            this.b6.TabIndex = 190;
            this.b6.UseSelectable = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(604, 249);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(38, 23);
            this.metroButton1.TabIndex = 179;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // habilitar
            // 
            this.habilitar.BackColor = System.Drawing.Color.White;
            this.habilitar.BackgroundImage = global::Proyecto_3.Properties.Resources.writing9;
            this.habilitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.habilitar.Location = new System.Drawing.Point(264, 23);
            this.habilitar.Name = "habilitar";
            this.habilitar.Size = new System.Drawing.Size(38, 23);
            this.habilitar.TabIndex = 177;
            this.habilitar.UseSelectable = true;
            this.habilitar.Click += new System.EventHandler(this.habilitar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.BackgroundImage = global::Proyecto_3.Properties.Resources.salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.Location = new System.Drawing.Point(344, 506);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(114, 36);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 175;
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
            this.nuevo.Location = new System.Drawing.Point(229, 506);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(114, 36);
            this.nuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.nuevo.TabIndex = 174;
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
            this.salvar.Location = new System.Drawing.Point(114, 506);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(114, 36);
            this.salvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.salvar.TabIndex = 173;
            this.salvar.Text = " F10-Procesar";
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
            this.b5.Location = new System.Drawing.Point(220, 52);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(38, 23);
            this.b5.TabIndex = 172;
            this.b5.UseSelectable = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(794, 560);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.ncf);
            this.Controls.Add(this.descuento);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cod_cli);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.itbis);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.prec1);
            this.Controls.Add(this.cant1);
            this.Controls.Add(this.descrip1);
            this.Controls.Add(this.cod1);
            this.Controls.Add(this.condicion);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.rnc);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.habilitar);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.factura);
            this.KeyPreview = true;
            this.Name = "compras";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Compras";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.compras_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compras_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.compras_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox cod_cli;
        private MetroFramework.Controls.MetroCheckBox imprimir;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton b7;
        private MetroFramework.Controls.MetroButton b6;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox sub;
        private MetroFramework.Controls.MetroTextBox itbis;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox total;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox prec1;
        private MetroFramework.Controls.MetroTextBox cant1;
        private MetroFramework.Controls.MetroTextBox descrip1;
        private MetroFramework.Controls.MetroTextBox cod1;
        private MetroFramework.Controls.MetroComboBox condicion;
        private MetroFramework.Controls.MetroTextBox telefono;
        private MetroFramework.Controls.MetroTextBox rnc;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroButton habilitar;
        private MetroFramework.Controls.MetroDateTime fecha;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton b5;
        public MetroFramework.Controls.MetroGrid data;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox factura;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox descuento;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox ncf;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox marca;
        private System.Windows.Forms.DataGridView data1;
    }
}