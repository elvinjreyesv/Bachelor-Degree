namespace sistema_administracion_bares
{
    partial class meseros
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.cod_emp = new MetroFramework.Controls.MetroTextBox();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.nombree = new MetroFramework.Controls.MetroComboBox();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.cod_mesero = new MetroFramework.Controls.MetroTextBox();
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
            this.data.Location = new System.Drawing.Point(55, 254);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(388, 150);
            this.data.TabIndex = 63;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(174, 165);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(92, 20);
            this.fecha.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "CODIGO DEL MESERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "CODIGO DEL EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "ESTADO";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // cod_emp
            // 
            this.cod_emp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_emp.Lines = new string[0];
            this.cod_emp.Location = new System.Drawing.Point(174, 93);
            this.cod_emp.MaxLength = 32767;
            this.cod_emp.Name = "cod_emp";
            this.cod_emp.PasswordChar = '\0';
            this.cod_emp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_emp.SelectedText = "";
            this.cod_emp.Size = new System.Drawing.Size(70, 23);
            this.cod_emp.TabIndex = 74;
            this.cod_emp.UseCustomBackColor = true;
            this.cod_emp.UseSelectable = true;
            this.cod_emp.Validating += new System.ComponentModel.CancelEventHandler(this.cod_emp_Validating_1);
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(23, 410);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 75;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(174, 134);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 76;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // nombree
            // 
            this.nombree.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.nombree.FormattingEnabled = true;
            this.nombree.ItemHeight = 19;
            this.nombree.Location = new System.Drawing.Point(250, 91);
            this.nombree.Name = "nombree";
            this.nombree.Size = new System.Drawing.Size(106, 25);
            this.nombree.TabIndex = 77;
            this.nombree.UseSelectable = true;
            this.nombree.Validating += new System.ComponentModel.CancelEventHandler(this.nombree_Validating_1);
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(387, 410);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(85, 28);
            this.salir1.TabIndex = 78;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // consultar1
            // 
            this.consultar1.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar1.Location = new System.Drawing.Point(358, 220);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(85, 28);
            this.consultar1.TabIndex = 79;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseCustomBackColor = true;
            this.consultar1.UseSelectable = true;
            this.consultar1.Click += new System.EventHandler(this.consultar1_Click);
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(296, 410);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(85, 28);
            this.actualizar1.TabIndex = 80;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            this.actualizar1.Click += new System.EventHandler(this.actualizar1_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(205, 410);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 81;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(114, 410);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 82;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(237, 134);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 83;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(269, 207);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 84;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(250, 225);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(102, 23);
            this.busca.TabIndex = 85;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // cod_mesero
            // 
            this.cod_mesero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_mesero.Lines = new string[0];
            this.cod_mesero.Location = new System.Drawing.Point(174, 59);
            this.cod_mesero.MaxLength = 32767;
            this.cod_mesero.Name = "cod_mesero";
            this.cod_mesero.PasswordChar = '\0';
            this.cod_mesero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_mesero.SelectedText = "";
            this.cod_mesero.Size = new System.Drawing.Size(70, 23);
            this.cod_mesero.TabIndex = 86;
            this.cod_mesero.UseCustomBackColor = true;
            this.cod_mesero.UseSelectable = true;
            this.cod_mesero.Validating += new System.ComponentModel.CancelEventHandler(this.cod_mesero_Validating_1);
            // 
            // meseros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(480, 458);
            this.Controls.Add(this.cod_mesero);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.nombree);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.cod_emp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "meseros";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "MESEROS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.meseros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox nombree;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroTextBox cod_emp;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroTextBox cod_mesero;
        private MetroFramework.Controls.MetroTextBox busca;
    }
}