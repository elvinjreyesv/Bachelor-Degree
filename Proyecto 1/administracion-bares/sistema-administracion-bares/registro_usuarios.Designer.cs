namespace sistema_administracion_bares
{
    partial class registro_usuarios
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.cod_emp = new MetroFramework.Controls.MetroTextBox();
            this.consultar = new MetroFramework.Controls.MetroButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.empleado = new MetroFramework.Controls.MetroComboBox();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.actualizar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.cuenta = new MetroFramework.Controls.MetroTextBox();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.repetir = new MetroFramework.Controls.MetroTextBox();
            this.clave = new MetroFramework.Controls.MetroTextBox();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.nivel = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "CONTRASENA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "CODIGO DEL EMPLEADO";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(8, 328);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(545, 150);
            this.data.TabIndex = 58;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(186, 283);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(92, 20);
            this.fecha.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "NOMBRE DE LA CUENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 67;
            this.label4.Text = "REPETIR CONTRASENA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "NIVEL DE ACCESO";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // cod_emp
            // 
            this.cod_emp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_emp.Lines = new string[0];
            this.cod_emp.Location = new System.Drawing.Point(185, 93);
            this.cod_emp.MaxLength = 32767;
            this.cod_emp.Name = "cod_emp";
            this.cod_emp.PasswordChar = '\0';
            this.cod_emp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_emp.SelectedText = "";
            this.cod_emp.Size = new System.Drawing.Size(75, 23);
            this.cod_emp.TabIndex = 74;
            this.cod_emp.UseCustomBackColor = true;
            this.cod_emp.UseSelectable = true;
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar.Location = new System.Drawing.Point(469, 296);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 28);
            this.consultar.TabIndex = 75;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseCustomBackColor = true;
            this.consultar.UseSelectable = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click_1);
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(186, 247);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 76;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // empleado
            // 
            this.empleado.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.empleado.FormattingEnabled = true;
            this.empleado.ItemHeight = 19;
            this.empleado.Location = new System.Drawing.Point(266, 91);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(121, 25);
            this.empleado.TabIndex = 77;
            this.empleado.UseSelectable = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(422, 481);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 78;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_2);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar.Location = new System.Drawing.Point(331, 481);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 79;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseCustomBackColor = true;
            this.actualizar.UseSelectable = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(240, 481);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 80;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(149, 481);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 81;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click_1);
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar.Location = new System.Drawing.Point(58, 481);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 82;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // cuenta
            // 
            this.cuenta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuenta.Lines = new string[0];
            this.cuenta.Location = new System.Drawing.Point(185, 62);
            this.cuenta.MaxLength = 32767;
            this.cuenta.Name = "cuenta";
            this.cuenta.PasswordChar = '\0';
            this.cuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cuenta.SelectedText = "";
            this.cuenta.Size = new System.Drawing.Size(75, 23);
            this.cuenta.TabIndex = 83;
            this.cuenta.UseCustomBackColor = true;
            this.cuenta.UseSelectable = true;
            this.cuenta.Validating += new System.ComponentModel.CancelEventHandler(this.cuenta_Validating_1);
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(368, 303);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(95, 23);
            this.busca.TabIndex = 84;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // repetir
            // 
            this.repetir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repetir.Lines = new string[0];
            this.repetir.Location = new System.Drawing.Point(185, 164);
            this.repetir.MaxLength = 32767;
            this.repetir.Name = "repetir";
            this.repetir.PasswordChar = '*';
            this.repetir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.repetir.SelectedText = "";
            this.repetir.Size = new System.Drawing.Size(118, 23);
            this.repetir.TabIndex = 85;
            this.repetir.UseCustomBackColor = true;
            this.repetir.UseSelectable = true;
            // 
            // clave
            // 
            this.clave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clave.Lines = new string[0];
            this.clave.Location = new System.Drawing.Point(185, 129);
            this.clave.MaxLength = 32767;
            this.clave.Name = "clave";
            this.clave.PasswordChar = '*';
            this.clave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clave.SelectedText = "";
            this.clave.Size = new System.Drawing.Size(118, 23);
            this.clave.TabIndex = 86;
            this.clave.UseCustomBackColor = true;
            this.clave.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(384, 282);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(65, 15);
            this.nombre.TabIndex = 87;
            this.nombre.Text = "nombre";
            this.nombre.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(249, 247);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 88;
            this.inactivo.Text = "inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // nivel
            // 
            this.nivel.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.nivel.FormattingEnabled = true;
            this.nivel.ItemHeight = 19;
            this.nivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.nivel.Location = new System.Drawing.Point(185, 202);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(75, 25);
            this.nivel.TabIndex = 89;
            this.nivel.UseSelectable = true;
            // 
            // registro_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(565, 520);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.repetir);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.empleado);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cod_emp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "registro_usuarios";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "REGISTRO DE USUARIOS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.registro_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton actualizar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroComboBox empleado;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroButton consultar;
        private MetroFramework.Controls.MetroTextBox cod_emp;
        private MetroFramework.Controls.MetroTextBox clave;
        private MetroFramework.Controls.MetroTextBox repetir;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox cuenta;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroComboBox nivel;
    }
}