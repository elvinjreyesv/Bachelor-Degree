namespace sistema_administracion_bares
{
    partial class reservaciones
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.consultar = new MetroFramework.Controls.MetroButton();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.actualizar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.b_mesas = new MetroFramework.Controls.MetroButton();
            this.b_cli = new MetroFramework.Controls.MetroButton();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.cod_res = new MetroFramework.Controls.MetroTextBox();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.inactivo = new MetroFramework.Controls.MetroRadioButton();
            this.cod_cli = new MetroFramework.Controls.MetroTextBox();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.cod_mes = new MetroFramework.Controls.MetroTextBox();
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
            this.data.Location = new System.Drawing.Point(12, 255);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(482, 150);
            this.data.TabIndex = 36;
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(170, 210);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(92, 20);
            this.fecha.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "FECHA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "CODIGO DE LA MESA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "CODIGO DEL CLIENTE";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar.Location = new System.Drawing.Point(27, 411);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 49;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click_1);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar.Location = new System.Drawing.Point(409, 223);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 28);
            this.consultar.TabIndex = 50;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseCustomBackColor = true;
            this.consultar.UseSelectable = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click_1);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(390, 411);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 51;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_2);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar.Location = new System.Drawing.Point(299, 411);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 52;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseCustomBackColor = true;
            this.actualizar.UseSelectable = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click_1);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(209, 411);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 53;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(118, 411);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 54;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click_1);
            // 
            // b_mesas
            // 
            this.b_mesas.BackColor = System.Drawing.Color.AliceBlue;
            this.b_mesas.Location = new System.Drawing.Point(250, 127);
            this.b_mesas.Name = "b_mesas";
            this.b_mesas.Size = new System.Drawing.Size(104, 28);
            this.b_mesas.TabIndex = 55;
            this.b_mesas.Text = "BUSCAR MESAS";
            this.b_mesas.UseCustomBackColor = true;
            this.b_mesas.UseSelectable = true;
            this.b_mesas.Click += new System.EventHandler(this.b_mesas_Click);
            // 
            // b_cli
            // 
            this.b_cli.BackColor = System.Drawing.Color.AliceBlue;
            this.b_cli.Location = new System.Drawing.Point(250, 90);
            this.b_cli.Name = "b_cli";
            this.b_cli.Size = new System.Drawing.Size(104, 28);
            this.b_cli.TabIndex = 56;
            this.b_cli.Text = "BUSCAR CLIENTES";
            this.b_cli.UseCustomBackColor = true;
            this.b_cli.UseSelectable = true;
            this.b_cli.Click += new System.EventHandler(this.b_cli_Click);
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(170, 175);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 57;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // cod_res
            // 
            this.cod_res.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_res.Lines = new string[0];
            this.cod_res.Location = new System.Drawing.Point(170, 59);
            this.cod_res.MaxLength = 32767;
            this.cod_res.Name = "cod_res";
            this.cod_res.PasswordChar = '\0';
            this.cod_res.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_res.SelectedText = "";
            this.cod_res.Size = new System.Drawing.Size(75, 23);
            this.cod_res.TabIndex = 58;
            this.cod_res.UseCustomBackColor = true;
            this.cod_res.UseSelectable = true;
            this.cod_res.Validating += new System.ComponentModel.CancelEventHandler(this.cod_res_Validating_1);
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(322, 210);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 59;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // inactivo
            // 
            this.inactivo.AutoSize = true;
            this.inactivo.Location = new System.Drawing.Point(229, 175);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(65, 15);
            this.inactivo.TabIndex = 60;
            this.inactivo.Text = "Inactivo";
            this.inactivo.UseSelectable = true;
            // 
            // cod_cli
            // 
            this.cod_cli.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_cli.Lines = new string[0];
            this.cod_cli.Location = new System.Drawing.Point(169, 95);
            this.cod_cli.MaxLength = 32767;
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.PasswordChar = '\0';
            this.cod_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_cli.SelectedText = "";
            this.cod_cli.Size = new System.Drawing.Size(75, 23);
            this.cod_cli.TabIndex = 61;
            this.cod_cli.UseCustomBackColor = true;
            this.cod_cli.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(299, 228);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(104, 23);
            this.busca.TabIndex = 62;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // cod_mes
            // 
            this.cod_mes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_mes.Lines = new string[0];
            this.cod_mes.Location = new System.Drawing.Point(170, 132);
            this.cod_mes.MaxLength = 32767;
            this.cod_mes.Name = "cod_mes";
            this.cod_mes.PasswordChar = '\0';
            this.cod_mes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_mes.SelectedText = "";
            this.cod_mes.Size = new System.Drawing.Size(75, 23);
            this.cod_mes.TabIndex = 63;
            this.cod_mes.UseCustomBackColor = true;
            this.cod_mes.UseSelectable = true;
            // 
            // reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(517, 452);
            this.Controls.Add(this.cod_mes);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.cod_cli);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.cod_res);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.b_cli);
            this.Controls.Add(this.b_mesas);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "reservaciones";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "RESERVACIONES";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.reservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton b_cli;
        private MetroFramework.Controls.MetroButton b_mesas;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton actualizar;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton consultar;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroRadioButton inactivo;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroTextBox cod_res;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroTextBox cod_mes;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox cod_cli;
    }
}