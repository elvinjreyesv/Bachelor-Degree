namespace sistema_administracion_bares
{
    partial class categoria
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.cod_categoria = new MetroFramework.Controls.MetroTextBox();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCRICION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "FECHA";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(126, 173);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(98, 20);
            this.fecha.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "ESTADO";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(12, 244);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(435, 150);
            this.data.TabIndex = 21;
            // 
            // cod_categoria
            // 
            this.cod_categoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_categoria.Lines = new string[0];
            this.cod_categoria.Location = new System.Drawing.Point(136, 54);
            this.cod_categoria.MaxLength = 32767;
            this.cod_categoria.Name = "cod_categoria";
            this.cod_categoria.PasswordChar = '\0';
            this.cod_categoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_categoria.SelectedText = "";
            this.cod_categoria.Size = new System.Drawing.Size(101, 23);
            this.cod_categoria.TabIndex = 28;
            this.cod_categoria.UseCustomBackColor = true;
            this.cod_categoria.UseSelectable = true;
            this.cod_categoria.Validating += new System.ComponentModel.CancelEventHandler(this.cod_categoria_Validating_1);
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(6, 404);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 29;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(241, 197);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 30;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(260, 215);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(101, 23);
            this.busca.TabIndex = 31;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(136, 91);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(137, 23);
            this.descripcion.TabIndex = 32;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(302, 197);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 33;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(126, 137);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 34;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(189, 137);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 35;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // consultar1
            // 
            this.consultar1.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar1.Location = new System.Drawing.Point(367, 210);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(85, 28);
            this.consultar1.TabIndex = 36;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseCustomBackColor = true;
            this.consultar1.UseSelectable = true;
            this.consultar1.Click += new System.EventHandler(this.consultar1_Click);
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(367, 404);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(85, 28);
            this.salir1.TabIndex = 37;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(278, 404);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(85, 28);
            this.actualizar1.TabIndex = 38;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            this.actualizar1.Click += new System.EventHandler(this.actualizar1_Click);
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(188, 404);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(85, 28);
            this.eliminar1.TabIndex = 39;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            this.eliminar1.Click += new System.EventHandler(this.eliminar1_Click);
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(97, 404);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 40;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(459, 455);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.cod_categoria);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "categoria";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "CATEGORIA";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data;
        private MetroFramework.Controls.MetroTextBox cod_categoria;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroButton eliminar1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}