namespace sistema_administracion_bares
{
    partial class estado
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.cod_estado = new MetroFramework.Controls.MetroTextBox();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(130, 151);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(92, 20);
            this.fecha.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "CODIGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "FECHA";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(35, 217);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(411, 150);
            this.data.TabIndex = 45;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(237, 188);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(124, 23);
            this.busca.TabIndex = 50;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(8, 380);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 51;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(237, 170);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 52;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(99, 380);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 53;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(190, 380);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(85, 28);
            this.eliminar1.TabIndex = 54;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            this.eliminar1.Click += new System.EventHandler(this.eliminar1_Click);
            // 
            // consultar1
            // 
            this.consultar1.Location = new System.Drawing.Point(367, 183);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(85, 28);
            this.consultar1.TabIndex = 55;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseSelectable = true;
            this.consultar1.Click += new System.EventHandler(this.consultar1_Click);
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(372, 380);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(85, 28);
            this.salir1.TabIndex = 56;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(281, 380);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(85, 28);
            this.actualizar1.TabIndex = 57;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            this.actualizar1.Click += new System.EventHandler(this.actualizar1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(296, 170);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 58;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // cod_estado
            // 
            this.cod_estado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_estado.Lines = new string[0];
            this.cod_estado.Location = new System.Drawing.Point(130, 68);
            this.cod_estado.MaxLength = 32767;
            this.cod_estado.Name = "cod_estado";
            this.cod_estado.PasswordChar = '\0';
            this.cod_estado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_estado.SelectedText = "";
            this.cod_estado.Size = new System.Drawing.Size(75, 23);
            this.cod_estado.TabIndex = 59;
            this.cod_estado.UseCustomBackColor = true;
            this.cod_estado.UseSelectable = true;
            this.cod_estado.Validating += new System.ComponentModel.CancelEventHandler(this.cod_estado_Validating_1);
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(130, 105);
            this.descripcion.MaxLength = 32767;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.Size = new System.Drawing.Size(111, 23);
            this.descripcion.TabIndex = 60;
            this.descripcion.UseCustomBackColor = true;
            this.descripcion.UseSelectable = true;
            // 
            // estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(474, 431);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.cod_estado);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "estado";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "ESTADO";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.estado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Controls.MetroButton eliminar1;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroTextBox cod_estado;
        private MetroFramework.Controls.MetroTextBox descripcion;
    }
}