namespace sistema_administracion_bares
{
    partial class proveedores
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.fax = new System.Windows.Forms.MaskedTextBox();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.det_tipro = new MetroFramework.Controls.MetroComboBox();
            this.cod_tippro = new MetroFramework.Controls.MetroComboBox();
            this.cod_prov = new MetroFramework.Controls.MetroTextBox();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.correo = new MetroFramework.Controls.MetroTextBox();
            this.direccion = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.nombree = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "CORREO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "FAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "TELEFONO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "DIRECCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "NOMBRE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "CODIGO";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(461, 168);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "TIPO DE PROVEEDOR";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(22, 264);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(644, 150);
            this.data.TabIndex = 27;
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(461, 53);
            this.fax.Mask = "000-000-0000";
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(100, 20);
            this.fax.TabIndex = 32;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(132, 163);
            this.telefono.Mask = "000-000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 33;
            // 
            // det_tipro
            // 
            this.det_tipro.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.det_tipro.FormattingEnabled = true;
            this.det_tipro.ItemHeight = 19;
            this.det_tipro.Location = new System.Drawing.Point(243, 194);
            this.det_tipro.Name = "det_tipro";
            this.det_tipro.Size = new System.Drawing.Size(104, 25);
            this.det_tipro.TabIndex = 34;
            this.det_tipro.UseSelectable = true;
            this.det_tipro.Validating += new System.ComponentModel.CancelEventHandler(this.det_tipro_Validating_1);
            // 
            // cod_tippro
            // 
            this.cod_tippro.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_tippro.FormattingEnabled = true;
            this.cod_tippro.ItemHeight = 19;
            this.cod_tippro.Location = new System.Drawing.Point(179, 194);
            this.cod_tippro.Name = "cod_tippro";
            this.cod_tippro.Size = new System.Drawing.Size(58, 25);
            this.cod_tippro.TabIndex = 35;
            this.cod_tippro.UseSelectable = true;
            this.cod_tippro.Validating += new System.ComponentModel.CancelEventHandler(this.cod_tippro_Validating_1);
            // 
            // cod_prov
            // 
            this.cod_prov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_prov.Lines = new string[0];
            this.cod_prov.Location = new System.Drawing.Point(132, 53);
            this.cod_prov.MaxLength = 32767;
            this.cod_prov.Name = "cod_prov";
            this.cod_prov.PasswordChar = '\0';
            this.cod_prov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_prov.SelectedText = "";
            this.cod_prov.Size = new System.Drawing.Size(75, 23);
            this.cod_prov.TabIndex = 38;
            this.cod_prov.UseCustomBackColor = true;
            this.cod_prov.UseSelectable = true;
            this.cod_prov.Validating += new System.ComponentModel.CancelEventHandler(this.cod_prov_Validating_1);
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(463, 238);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(116, 23);
            this.busca.TabIndex = 39;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.correo.Lines = new string[0];
            this.correo.Location = new System.Drawing.Point(461, 87);
            this.correo.MaxLength = 32767;
            this.correo.Name = "correo";
            this.correo.PasswordChar = '\0';
            this.correo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.correo.SelectedText = "";
            this.correo.Size = new System.Drawing.Size(134, 23);
            this.correo.TabIndex = 40;
            this.correo.UseCustomBackColor = true;
            this.correo.UseSelectable = true;
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.direccion.Lines = new string[0];
            this.direccion.Location = new System.Drawing.Point(132, 125);
            this.direccion.MaxLength = 32767;
            this.direccion.Name = "direccion";
            this.direccion.PasswordChar = '\0';
            this.direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.direccion.SelectedText = "";
            this.direccion.Size = new System.Drawing.Size(134, 23);
            this.direccion.TabIndex = 41;
            this.direccion.UseCustomBackColor = true;
            this.direccion.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(132, 86);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.Size = new System.Drawing.Size(105, 23);
            this.nombre.TabIndex = 42;
            this.nombre.UseCustomBackColor = true;
            this.nombre.UseSelectable = true;
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(122, 420);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 43;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // consultar1
            // 
            this.consultar1.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar1.Location = new System.Drawing.Point(585, 233);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(85, 28);
            this.consultar1.TabIndex = 44;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseCustomBackColor = true;
            this.consultar1.UseSelectable = true;
            this.consultar1.Click += new System.EventHandler(this.consultar1_Click);
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(486, 420);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(85, 28);
            this.salir1.TabIndex = 45;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(395, 420);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(85, 28);
            this.actualizar1.TabIndex = 46;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            this.actualizar1.Click += new System.EventHandler(this.actualizar1_Click);
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(304, 420);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(85, 28);
            this.eliminar1.TabIndex = 47;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            this.eliminar1.Click += new System.EventHandler(this.eliminar1_Click);
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(213, 420);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 48;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(461, 128);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 49;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // nombree
            // 
            this.nombree.AutoSize = true;
            this.nombree.Location = new System.Drawing.Point(512, 217);
            this.nombree.Name = "nombree";
            this.nombree.Size = new System.Drawing.Size(67, 15);
            this.nombree.TabIndex = 50;
            this.nombree.Text = "Nombre";
            this.nombree.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(444, 217);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 51;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(524, 130);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 52;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ESTADO";
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(687, 458);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.nombree);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.cod_prov);
            this.Controls.Add(this.cod_tippro);
            this.Controls.Add(this.det_tipro);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "proveedores";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "SUPLIDORES";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.MaskedTextBox fax;
        private System.Windows.Forms.MaskedTextBox telefono;
        private MetroFramework.Controls.MetroComboBox det_tipro;
        private MetroFramework.Controls.MetroComboBox cod_tippro;
        private MetroFramework.Controls.MetroTextBox cod_prov;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox correo;
        private MetroFramework.Controls.MetroTextBox direccion;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroButton eliminar1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton nombree;
        private MetroFramework.Controls.MetroRadioButton activo;
        private System.Windows.Forms.Label label3;
    }
}