namespace sistema_administracion_bares
{
    partial class t_mesas
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.codigo = new MetroFramework.Controls.MetroTextBox();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.actualizar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.consultar = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(239, 180);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(132, 23);
            this.busca.TabIndex = 103;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codigo.Lines = new string[0];
            this.codigo.Location = new System.Drawing.Point(119, 57);
            this.codigo.MaxLength = 32767;
            this.codigo.Name = "codigo";
            this.codigo.PasswordChar = '\0';
            this.codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codigo.SelectedText = "";
            this.codigo.Size = new System.Drawing.Size(75, 23);
            this.codigo.TabIndex = 102;
            this.codigo.UseCustomBackColor = true;
            this.codigo.UseSelectable = true;
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating_1);
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(182, 130);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 101;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(239, 163);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 100;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(307, 163);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 99;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(118, 90);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(129, 23);
            this.descripcion.TabIndex = 98;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseSelectable = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(119, 130);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 97;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar.Location = new System.Drawing.Point(13, 365);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 96;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(104, 365);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 95;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(195, 365);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 94;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar.Location = new System.Drawing.Point(286, 365);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 93;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseCustomBackColor = true;
            this.actualizar.UseSelectable = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click_1);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(377, 365);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 92;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_2);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar.Location = new System.Drawing.Point(378, 178);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 28);
            this.consultar.TabIndex = 91;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseCustomBackColor = true;
            this.consultar.UseSelectable = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "ESTADO";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(118, 157);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(92, 20);
            this.fecha.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 88;
            this.label4.Text = "FECHA";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(9, 209);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(454, 150);
            this.data.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 86;
            this.label3.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "DESCRIPCION";
            // 
            // t_mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(473, 407);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "t_mesas";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "TIPO DE MESAS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.t_mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox codigo;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton actualizar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton consultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}