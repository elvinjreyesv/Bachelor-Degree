namespace sistema_administracion_bares
{
    partial class ofertas
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
            this.data = new System.Windows.Forms.DataGridView();
            this.fecha_in = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_fn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.desc_art = new MetroFramework.Controls.MetroComboBox();
            this.cod_ofert = new MetroFramework.Controls.MetroTextBox();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.precio = new MetroFramework.Controls.MetroTextBox();
            this.cod_art = new MetroFramework.Controls.MetroComboBox();
            this.des_unidad = new MetroFramework.Controls.MetroComboBox();
            this.unidad = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(12, 274);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(508, 150);
            this.data.TabIndex = 36;
            // 
            // fecha_in
            // 
            this.fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_in.Location = new System.Drawing.Point(125, 101);
            this.fecha_in.Name = "fecha_in";
            this.fecha_in.Size = new System.Drawing.Size(92, 20);
            this.fecha_in.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "CODIGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "FECHA INICIAL";
            // 
            // fecha_fn
            // 
            this.fecha_fn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fn.Location = new System.Drawing.Point(125, 141);
            this.fecha_fn.Name = "fecha_fn";
            this.fecha_fn.Size = new System.Drawing.Size(92, 20);
            this.fecha_fn.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "FECHA FINAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "ARTICULO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "PRECIO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "UNIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "ESTADO";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar.Location = new System.Drawing.Point(97, 430);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 55;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(372, 430);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 57;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_2);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(281, 430);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 59;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(190, 430);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 60;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click_1);
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(125, 180);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 61;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(188, 180);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 62;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // desc_art
            // 
            this.desc_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.desc_art.FormattingEnabled = true;
            this.desc_art.ItemHeight = 19;
            this.desc_art.Location = new System.Drawing.Point(407, 50);
            this.desc_art.Name = "desc_art";
            this.desc_art.Size = new System.Drawing.Size(101, 25);
            this.desc_art.TabIndex = 63;
            this.desc_art.UseSelectable = true;
            this.desc_art.Validating += new System.ComponentModel.CancelEventHandler(this.desc_art_Validating_1);
            // 
            // cod_ofert
            // 
            this.cod_ofert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_ofert.Lines = new string[0];
            this.cod_ofert.Location = new System.Drawing.Point(125, 64);
            this.cod_ofert.MaxLength = 32767;
            this.cod_ofert.Name = "cod_ofert";
            this.cod_ofert.PasswordChar = '\0';
            this.cod_ofert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_ofert.SelectedText = "";
            this.cod_ofert.Size = new System.Drawing.Size(75, 23);
            this.cod_ofert.TabIndex = 64;
            this.cod_ofert.UseCustomBackColor = true;
            this.cod_ofert.UseSelectable = true;
            this.cod_ofert.Validating += new System.ComponentModel.CancelEventHandler(this.cod_ofert_Validating_1);
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(123, 221);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(148, 23);
            this.descripcion.TabIndex = 65;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseSelectable = true;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precio.Lines = new string[0];
            this.precio.Location = new System.Drawing.Point(348, 86);
            this.precio.MaxLength = 32767;
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.precio.SelectedText = "";
            this.precio.Size = new System.Drawing.Size(75, 23);
            this.precio.TabIndex = 66;
            this.precio.UseCustomBackColor = true;
            this.precio.UseSelectable = true;
            // 
            // cod_art
            // 
            this.cod_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_art.FormattingEnabled = true;
            this.cod_art.ItemHeight = 19;
            this.cod_art.Location = new System.Drawing.Point(348, 50);
            this.cod_art.Name = "cod_art";
            this.cod_art.Size = new System.Drawing.Size(53, 25);
            this.cod_art.TabIndex = 67;
            this.cod_art.UseSelectable = true;
            this.cod_art.Validating += new System.ComponentModel.CancelEventHandler(this.cod_art_Validating_1);
            // 
            // des_unidad
            // 
            this.des_unidad.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.des_unidad.FormattingEnabled = true;
            this.des_unidad.ItemHeight = 19;
            this.des_unidad.Location = new System.Drawing.Point(407, 121);
            this.des_unidad.Name = "des_unidad";
            this.des_unidad.Size = new System.Drawing.Size(101, 25);
            this.des_unidad.TabIndex = 68;
            this.des_unidad.UseSelectable = true;
            this.des_unidad.Validating += new System.ComponentModel.CancelEventHandler(this.des_unidad_Validating_1);
            // 
            // unidad
            // 
            this.unidad.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.unidad.FormattingEnabled = true;
            this.unidad.ItemHeight = 19;
            this.unidad.Location = new System.Drawing.Point(348, 121);
            this.unidad.Name = "unidad";
            this.unidad.Size = new System.Drawing.Size(53, 25);
            this.unidad.TabIndex = 69;
            this.unidad.UseSelectable = true;
            this.unidad.Validating += new System.ComponentModel.CancelEventHandler(this.unidad_Validating_1);
            // 
            // ofertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(532, 467);
            this.Controls.Add(this.unidad);
            this.Controls.Add(this.des_unidad);
            this.Controls.Add(this.cod_art);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.cod_ofert);
            this.Controls.Add(this.desc_art);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fecha_fn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ofertas";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "OFERTAS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ofertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DateTimePicker fecha_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha_fn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroComboBox unidad;
        private MetroFramework.Controls.MetroComboBox des_unidad;
        private MetroFramework.Controls.MetroComboBox cod_art;
        private MetroFramework.Controls.MetroTextBox precio;
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroTextBox cod_ofert;
        private MetroFramework.Controls.MetroComboBox desc_art;
    }
}