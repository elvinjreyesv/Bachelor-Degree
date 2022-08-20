namespace sistema_administracion_bares
{
    partial class empleados
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
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.MaskedTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.cod_emp = new MetroFramework.Controls.MetroTextBox();
            this.cargo = new MetroFramework.Controls.MetroTextBox();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.correo = new MetroFramework.Controls.MetroTextBox();
            this.apellido = new MetroFramework.Controls.MetroTextBox();
            this.direccion = new MetroFramework.Controls.MetroTextBox();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.nombree = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(13, 318);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(517, 150);
            this.data.TabIndex = 58;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(401, 139);
            this.telefono.Mask = "000-000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 57;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(135, 288);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "FECHA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "DIRECCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "ESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "NOMBRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "CORREO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "CODIGO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 63;
            this.label11.Text = "CEDULA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 65;
            this.label12.Text = "CARGO";
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(132, 176);
            this.cedula.Mask = "000-0000000-0";
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 20);
            this.cedula.TabIndex = 70;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(60, 474);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(78, 28);
            this.salvar1.TabIndex = 75;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(396, 474);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(78, 28);
            this.salir1.TabIndex = 76;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(312, 474);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(78, 28);
            this.actualizar1.TabIndex = 77;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            this.actualizar1.Click += new System.EventHandler(this.actualizar1_Click);
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(228, 474);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(78, 28);
            this.eliminar1.TabIndex = 78;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            this.eliminar1.Click += new System.EventHandler(this.eliminar1_Click);
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(144, 474);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(78, 28);
            this.nuevo1.TabIndex = 79;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // consultar1
            // 
            this.consultar1.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar1.Location = new System.Drawing.Point(446, 284);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(78, 28);
            this.consultar1.TabIndex = 80;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseCustomBackColor = true;
            this.consultar1.UseSelectable = true;
            this.consultar1.Click += new System.EventHandler(this.consultar1_Click);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(132, 100);
            this.nombre.MaxLength = 32767;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.Size = new System.Drawing.Size(120, 23);
            this.nombre.TabIndex = 81;
            this.nombre.UseCustomBackColor = true;
            this.nombre.UseSelectable = true;
            // 
            // cod_emp
            // 
            this.cod_emp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_emp.Lines = new string[0];
            this.cod_emp.Location = new System.Drawing.Point(132, 67);
            this.cod_emp.MaxLength = 32767;
            this.cod_emp.Name = "cod_emp";
            this.cod_emp.PasswordChar = '\0';
            this.cod_emp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_emp.SelectedText = "";
            this.cod_emp.Size = new System.Drawing.Size(90, 23);
            this.cod_emp.TabIndex = 82;
            this.cod_emp.UseCustomBackColor = true;
            this.cod_emp.UseSelectable = true;
            this.cod_emp.Validating += new System.ComponentModel.CancelEventHandler(this.cod_emp_Validating_1);
            // 
            // cargo
            // 
            this.cargo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cargo.Lines = new string[0];
            this.cargo.Location = new System.Drawing.Point(132, 247);
            this.cargo.MaxLength = 32767;
            this.cargo.Name = "cargo";
            this.cargo.PasswordChar = '\0';
            this.cargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cargo.SelectedText = "";
            this.cargo.Size = new System.Drawing.Size(120, 23);
            this.cargo.TabIndex = 83;
            this.cargo.UseCustomBackColor = true;
            this.cargo.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(312, 289);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(128, 23);
            this.busca.TabIndex = 84;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.correo.Lines = new string[0];
            this.correo.Location = new System.Drawing.Point(401, 102);
            this.correo.MaxLength = 32767;
            this.correo.Name = "correo";
            this.correo.PasswordChar = '\0';
            this.correo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.correo.SelectedText = "";
            this.correo.Size = new System.Drawing.Size(126, 23);
            this.correo.TabIndex = 85;
            this.correo.UseCustomBackColor = true;
            this.correo.UseSelectable = true;
            // 
            // apellido
            // 
            this.apellido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.apellido.Lines = new string[0];
            this.apellido.Location = new System.Drawing.Point(132, 136);
            this.apellido.MaxLength = 32767;
            this.apellido.Name = "apellido";
            this.apellido.PasswordChar = '\0';
            this.apellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apellido.SelectedText = "";
            this.apellido.Size = new System.Drawing.Size(120, 23);
            this.apellido.TabIndex = 86;
            this.apellido.UseCustomBackColor = true;
            this.apellido.UseSelectable = true;
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.direccion.Lines = new string[0];
            this.direccion.Location = new System.Drawing.Point(401, 69);
            this.direccion.MaxLength = 32767;
            this.direccion.Name = "direccion";
            this.direccion.PasswordChar = '\0';
            this.direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.direccion.SelectedText = "";
            this.direccion.Size = new System.Drawing.Size(126, 23);
            this.direccion.TabIndex = 87;
            this.direccion.UseCustomBackColor = true;
            this.direccion.UseSelectable = true;
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(132, 216);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 88;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(195, 216);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 89;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(312, 268);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 90;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // nombree
            // 
            this.nombree.AutoSize = true;
            this.nombree.Location = new System.Drawing.Point(373, 268);
            this.nombree.Name = "nombree";
            this.nombree.Size = new System.Drawing.Size(67, 15);
            this.nombree.TabIndex = 91;
            this.nombree.Text = "Nombre";
            this.nombree.UseSelectable = true;
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(547, 519);
            this.Controls.Add(this.nombree);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.cod_emp);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.data);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "empleados";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "EMPLEADOS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.MaskedTextBox telefono;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox cedula;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Controls.MetroButton eliminar1;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroTextBox direccion;
        private MetroFramework.Controls.MetroTextBox apellido;
        private MetroFramework.Controls.MetroTextBox correo;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox cargo;
        private MetroFramework.Controls.MetroTextBox cod_emp;
        private MetroFramework.Controls.MetroRadioButton nombree;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton activo;
    }
}