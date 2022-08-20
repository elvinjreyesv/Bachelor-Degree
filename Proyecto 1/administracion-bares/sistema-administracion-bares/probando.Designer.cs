namespace sistema_administracion_bares
{
    partial class probando
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
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.precio = new MetroFramework.Controls.MetroTextBox();
            this.buscar = new MetroFramework.Controls.MetroTextBox();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.desc_cat = new MetroFramework.Controls.MetroComboBox();
            this.marca = new MetroFramework.Controls.MetroComboBox();
            this.categoria = new MetroFramework.Controls.MetroComboBox();
            this.des_marca = new MetroFramework.Controls.MetroComboBox();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.unidad = new MetroFramework.Controls.MetroComboBox();
            this.cod_art = new MetroFramework.Controls.MetroTextBox();
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(167, 65);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(132, 23);
            this.descripcion.TabIndex = 84;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseSelectable = true;
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precio.Lines = new string[0];
            this.precio.Location = new System.Drawing.Point(433, 48);
            this.precio.MaxLength = 32767;
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.precio.SelectedText = "";
            this.precio.Size = new System.Drawing.Size(83, 23);
            this.precio.TabIndex = 83;
            this.precio.UseCustomBackColor = true;
            this.precio.UseSelectable = true;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscar.Lines = new string[0];
            this.buscar.Location = new System.Drawing.Point(349, 233);
            this.buscar.MaxLength = 32767;
            this.buscar.Name = "buscar";
            this.buscar.PasswordChar = '\0';
            this.buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buscar.SelectedText = "";
            this.buscar.Size = new System.Drawing.Size(116, 23);
            this.buscar.TabIndex = 82;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(225, 185);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 81;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(343, 215);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 80;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(405, 215);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 79;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // desc_cat
            // 
            this.desc_cat.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.desc_cat.FormattingEnabled = true;
            this.desc_cat.ItemHeight = 19;
            this.desc_cat.Location = new System.Drawing.Point(256, 141);
            this.desc_cat.Name = "desc_cat";
            this.desc_cat.Size = new System.Drawing.Size(121, 25);
            this.desc_cat.TabIndex = 78;
            this.desc_cat.UseSelectable = true;
            // 
            // marca
            // 
            this.marca.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.marca.FormattingEnabled = true;
            this.marca.ItemHeight = 19;
            this.marca.Location = new System.Drawing.Point(167, 102);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(83, 25);
            this.marca.TabIndex = 77;
            this.marca.UseSelectable = true;
            // 
            // categoria
            // 
            this.categoria.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.categoria.FormattingEnabled = true;
            this.categoria.ItemHeight = 19;
            this.categoria.Location = new System.Drawing.Point(167, 141);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(83, 25);
            this.categoria.TabIndex = 76;
            this.categoria.UseSelectable = true;
            // 
            // des_marca
            // 
            this.des_marca.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.des_marca.FormattingEnabled = true;
            this.des_marca.ItemHeight = 19;
            this.des_marca.Location = new System.Drawing.Point(256, 102);
            this.des_marca.Name = "des_marca";
            this.des_marca.Size = new System.Drawing.Size(121, 25);
            this.des_marca.TabIndex = 75;
            this.des_marca.UseSelectable = true;
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(349, 418);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(85, 28);
            this.actualizar1.TabIndex = 74;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(76, 418);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 73;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(440, 418);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(85, 28);
            this.salir1.TabIndex = 72;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(167, 418);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 71;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            // 
            // consultar1
            // 
            this.consultar1.Location = new System.Drawing.Point(471, 228);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(85, 28);
            this.consultar1.TabIndex = 70;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseSelectable = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(167, 185);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 69;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // unidad
            // 
            this.unidad.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.unidad.FormattingEnabled = true;
            this.unidad.ItemHeight = 19;
            this.unidad.Location = new System.Drawing.Point(433, 5);
            this.unidad.Name = "unidad";
            this.unidad.Size = new System.Drawing.Size(83, 25);
            this.unidad.TabIndex = 68;
            this.unidad.UseSelectable = true;
            // 
            // cod_art
            // 
            this.cod_art.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_art.Lines = new string[0];
            this.cod_art.Location = new System.Drawing.Point(167, 32);
            this.cod_art.MaxLength = 32767;
            this.cod_art.Name = "cod_art";
            this.cod_art.PasswordChar = '\0';
            this.cod_art.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_art.SelectedText = "";
            this.cod_art.Size = new System.Drawing.Size(92, 23);
            this.cod_art.TabIndex = 67;
            this.cod_art.UseCustomBackColor = true;
            this.cod_art.UseSelectable = true;
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(258, 418);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(85, 28);
            this.eliminar1.TabIndex = 66;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Unidad";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(47, 262);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(509, 150);
            this.data.TabIndex = 63;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(166, 226);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(87, 20);
            this.fecha.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "CODIGO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "DESCRIPCION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "MARCA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "ESTADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "FECHA";
            // 
            // probando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 451);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.desc_cat);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.des_marca);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.unidad);
            this.Controls.Add(this.cod_art);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "probando";
            this.Text = "probando";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroTextBox precio;
        private MetroFramework.Controls.MetroTextBox buscar;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroComboBox desc_cat;
        private MetroFramework.Controls.MetroComboBox marca;
        private MetroFramework.Controls.MetroComboBox categoria;
        private MetroFramework.Controls.MetroComboBox des_marca;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroComboBox unidad;
        private MetroFramework.Controls.MetroTextBox cod_art;
        private MetroFramework.Controls.MetroButton eliminar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}