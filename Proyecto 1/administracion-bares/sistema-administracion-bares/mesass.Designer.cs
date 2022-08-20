namespace sistema_administracion_bares
{
    partial class mesass
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.salir = new MetroFramework.Controls.MetroButton();
            this.actualizar = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.tipo_mesa = new MetroFramework.Controls.MetroComboBox();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.cod_mesa = new MetroFramework.Controls.MetroTextBox();
            this.ubicacion = new MetroFramework.Controls.MetroTextBox();
            this.sillas = new MetroFramework.Controls.MetroTextBox();
            this.des_tmesa = new MetroFramework.Controls.MetroComboBox();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 72;
            this.label8.Text = "TIPO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "UBICACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "CANTIDAD DE SILLAS";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(23, 246);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(496, 150);
            this.data.TabIndex = 63;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(114, 170);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(92, 20);
            this.fecha.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "CODIGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "FECHA";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(414, 402);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 78;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar.Location = new System.Drawing.Point(323, 402);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 79;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseCustomBackColor = true;
            this.actualizar.UseSelectable = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click_1);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.AliceBlue;
            this.metroButton3.Location = new System.Drawing.Point(445, 212);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(85, 28);
            this.metroButton3.TabIndex = 80;
            this.metroButton3.Text = "CONSULTAR";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(50, 402);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 81;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(232, 402);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(85, 28);
            this.eliminar1.TabIndex = 82;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            this.eliminar1.Click += new System.EventHandler(this.eliminar1_Click);
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(141, 402);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 83;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(323, 217);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(116, 23);
            this.busca.TabIndex = 84;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(376, 196);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 85;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // tipo_mesa
            // 
            this.tipo_mesa.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.tipo_mesa.FormattingEnabled = true;
            this.tipo_mesa.ItemHeight = 19;
            this.tipo_mesa.Location = new System.Drawing.Point(114, 213);
            this.tipo_mesa.Name = "tipo_mesa";
            this.tipo_mesa.Size = new System.Drawing.Size(75, 25);
            this.tipo_mesa.TabIndex = 86;
            this.tipo_mesa.UseSelectable = true;
            this.tipo_mesa.Validating += new System.ComponentModel.CancelEventHandler(this.tipo_mesa_Validating);
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(114, 92);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(128, 23);
            this.descripcion.TabIndex = 87;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseSelectable = true;
            // 
            // cod_mesa
            // 
            this.cod_mesa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_mesa.Lines = new string[0];
            this.cod_mesa.Location = new System.Drawing.Point(114, 53);
            this.cod_mesa.MaxLength = 32767;
            this.cod_mesa.Name = "cod_mesa";
            this.cod_mesa.PasswordChar = '\0';
            this.cod_mesa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_mesa.SelectedText = "";
            this.cod_mesa.Size = new System.Drawing.Size(75, 23);
            this.cod_mesa.TabIndex = 88;
            this.cod_mesa.UseCustomBackColor = true;
            this.cod_mesa.UseSelectable = true;
            this.cod_mesa.Validating += new System.ComponentModel.CancelEventHandler(this.cod_mesa_Validating_1);
            // 
            // ubicacion
            // 
            this.ubicacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ubicacion.Lines = new string[0];
            this.ubicacion.Location = new System.Drawing.Point(414, 92);
            this.ubicacion.MaxLength = 32767;
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.PasswordChar = '\0';
            this.ubicacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ubicacion.SelectedText = "";
            this.ubicacion.Size = new System.Drawing.Size(116, 23);
            this.ubicacion.TabIndex = 89;
            this.ubicacion.UseCustomBackColor = true;
            this.ubicacion.UseSelectable = true;
            // 
            // sillas
            // 
            this.sillas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sillas.Lines = new string[0];
            this.sillas.Location = new System.Drawing.Point(414, 55);
            this.sillas.MaxLength = 32767;
            this.sillas.Name = "sillas";
            this.sillas.PasswordChar = '\0';
            this.sillas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sillas.SelectedText = "";
            this.sillas.Size = new System.Drawing.Size(91, 23);
            this.sillas.TabIndex = 90;
            this.sillas.UseCustomBackColor = true;
            this.sillas.UseSelectable = true;
            // 
            // des_tmesa
            // 
            this.des_tmesa.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.des_tmesa.FormattingEnabled = true;
            this.des_tmesa.ItemHeight = 19;
            this.des_tmesa.Location = new System.Drawing.Point(195, 213);
            this.des_tmesa.Name = "des_tmesa";
            this.des_tmesa.Size = new System.Drawing.Size(92, 25);
            this.des_tmesa.TabIndex = 91;
            this.des_tmesa.UseSelectable = true;
            this.des_tmesa.Validating += new System.ComponentModel.CancelEventHandler(this.des_tmesa_Validating);
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(177, 133);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 92;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(114, 135);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 93;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(312, 196);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 94;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // mesass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(535, 440);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.des_tmesa);
            this.Controls.Add(this.sillas);
            this.Controls.Add(this.ubicacion);
            this.Controls.Add(this.cod_mesa);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.tipo_mesa);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "mesass";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "MESAS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.mesass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton actualizar;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroButton eliminar1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Controls.MetroTextBox sillas;
        private MetroFramework.Controls.MetroTextBox ubicacion;
        private MetroFramework.Controls.MetroTextBox cod_mesa;
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroComboBox tipo_mesa;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroComboBox des_tmesa;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroRadioButton inactivo;
    }
}