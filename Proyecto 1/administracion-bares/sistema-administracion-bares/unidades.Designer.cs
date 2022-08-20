namespace sistema_administracion_bares
{
    partial class unidades
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.data = new System.Windows.Forms.DataGridView();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.consultar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.actualizar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.cod_unidad = new MetroFramework.Controls.MetroTextBox();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.unidad_venta = new MetroFramework.Controls.MetroTextBox();
            this.unidad_almacen = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "UNIDAD DE VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "UNIDAD DE ALMACEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "CODIGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "ESTADO";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(166, 220);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 17;
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(16, 277);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(489, 150);
            this.data.TabIndex = 21;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(129, 435);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 28;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click_1);
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar.Location = new System.Drawing.Point(38, 435);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 29;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar.Location = new System.Drawing.Point(420, 243);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 28);
            this.consultar.TabIndex = 30;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseCustomBackColor = true;
            this.consultar.UseSelectable = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click_1);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(402, 435);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 31;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar.Location = new System.Drawing.Point(311, 435);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 32;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseCustomBackColor = true;
            this.actualizar.UseSelectable = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(220, 435);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 33;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // cod_unidad
            // 
            this.cod_unidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_unidad.Lines = new string[0];
            this.cod_unidad.Location = new System.Drawing.Point(168, 60);
            this.cod_unidad.MaxLength = 32767;
            this.cod_unidad.Name = "cod_unidad";
            this.cod_unidad.PasswordChar = '\0';
            this.cod_unidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_unidad.SelectedText = "";
            this.cod_unidad.Size = new System.Drawing.Size(75, 23);
            this.cod_unidad.TabIndex = 34;
            this.cod_unidad.UseCustomBackColor = true;
            this.cod_unidad.UseSelectable = true;
            this.cod_unidad.Validating += new System.ComponentModel.CancelEventHandler(this.cod_unidad_Validating_1);
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(166, 182);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 35;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(345, 230);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 36;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(281, 230);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 37;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(220, 182);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 38;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(281, 248);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(131, 23);
            this.busca.TabIndex = 39;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // unidad_venta
            // 
            this.unidad_venta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.unidad_venta.Lines = new string[0];
            this.unidad_venta.Location = new System.Drawing.Point(168, 140);
            this.unidad_venta.MaxLength = 32767;
            this.unidad_venta.Name = "unidad_venta";
            this.unidad_venta.PasswordChar = '\0';
            this.unidad_venta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unidad_venta.SelectedText = "";
            this.unidad_venta.Size = new System.Drawing.Size(98, 23);
            this.unidad_venta.TabIndex = 40;
            this.unidad_venta.UseCustomBackColor = true;
            this.unidad_venta.UseSelectable = true;
            // 
            // unidad_almacen
            // 
            this.unidad_almacen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.unidad_almacen.Lines = new string[0];
            this.unidad_almacen.Location = new System.Drawing.Point(168, 98);
            this.unidad_almacen.MaxLength = 32767;
            this.unidad_almacen.Name = "unidad_almacen";
            this.unidad_almacen.PasswordChar = '\0';
            this.unidad_almacen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unidad_almacen.SelectedText = "";
            this.unidad_almacen.Size = new System.Drawing.Size(98, 23);
            this.unidad_almacen.TabIndex = 41;
            this.unidad_almacen.UseCustomBackColor = true;
            this.unidad_almacen.UseSelectable = true;
            // 
            // unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(515, 475);
            this.Controls.Add(this.unidad_almacen);
            this.Controls.Add(this.unidad_venta);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.cod_unidad);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "unidades";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "UNIDADES";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DataGridView data;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton consultar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton actualizar;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroTextBox cod_unidad;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox unidad_venta;
        private MetroFramework.Controls.MetroTextBox unidad_almacen;
    }
}