namespace sistema_administracion_bares
{
    partial class clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.telefono = new System.Windows.Forms.MaskedTextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.eliminar1 = new MetroFramework.Controls.MetroButton();
            this.cod_cli = new MetroFramework.Controls.MetroTextBox();
            this.codt_cli = new MetroFramework.Controls.MetroComboBox();
            this.activo = new MetroFramework.Controls.MetroRadioButton();
            this.t_cli = new MetroFramework.Controls.MetroComboBox();
            this.nuevo1 = new MetroFramework.Controls.MetroButton();
            this.salvar1 = new MetroFramework.Controls.MetroButton();
            this.consultar1 = new MetroFramework.Controls.MetroButton();
            this.salir1 = new MetroFramework.Controls.MetroButton();
            this.actualizar1 = new MetroFramework.Controls.MetroButton();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.ape_cli = new MetroFramework.Controls.MetroTextBox();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.correo = new MetroFramework.Controls.MetroTextBox();
            this.direccion = new MetroFramework.Controls.MetroTextBox();
            this.nom_cli = new MetroFramework.Controls.MetroTextBox();
            this.ina = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "CORREO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "APELLIDOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "NOMBRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "TIPO DE CLIENTE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "ESTADO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "DIRECCION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "FECHA";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(135, 286);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 20);
            this.fecha.TabIndex = 25;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(135, 175);
            this.telefono.Mask = "000-000-0000";
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 26;
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(13, 315);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(517, 150);
            this.data.TabIndex = 27;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // eliminar1
            // 
            this.eliminar1.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar1.Location = new System.Drawing.Point(230, 471);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(85, 28);
            this.eliminar1.TabIndex = 34;
            this.eliminar1.Text = "ELIMINAR";
            this.eliminar1.UseCustomBackColor = true;
            this.eliminar1.UseSelectable = true;
            this.eliminar1.Click += new System.EventHandler(this.eliminar1_Click);
            // 
            // cod_cli
            // 
            this.cod_cli.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cod_cli.Lines = new string[0];
            this.cod_cli.Location = new System.Drawing.Point(135, 63);
            this.cod_cli.MaxLength = 32767;
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.PasswordChar = '\0';
            this.cod_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_cli.SelectedText = "";
            this.cod_cli.Size = new System.Drawing.Size(92, 23);
            this.cod_cli.TabIndex = 35;
            this.cod_cli.UseCustomBackColor = true;
            this.cod_cli.UseSelectable = true;
            this.cod_cli.Validating += new System.ComponentModel.CancelEventHandler(this.cod_cli_Validating_1);
            // 
            // codt_cli
            // 
            this.codt_cli.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.codt_cli.FormattingEnabled = true;
            this.codt_cli.ItemHeight = 19;
            this.codt_cli.Location = new System.Drawing.Point(135, 242);
            this.codt_cli.Name = "codt_cli";
            this.codt_cli.Size = new System.Drawing.Size(55, 25);
            this.codt_cli.TabIndex = 36;
            this.codt_cli.UseSelectable = true;
            this.codt_cli.Validating += new System.ComponentModel.CancelEventHandler(this.codt_cli_Validating_1);
            // 
            // activo
            // 
            this.activo.AutoSize = true;
            this.activo.Location = new System.Drawing.Point(135, 213);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(57, 15);
            this.activo.TabIndex = 37;
            this.activo.Text = "Activo";
            this.activo.UseSelectable = true;
            // 
            // t_cli
            // 
            this.t_cli.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.t_cli.FormattingEnabled = true;
            this.t_cli.ItemHeight = 19;
            this.t_cli.Location = new System.Drawing.Point(196, 242);
            this.t_cli.Name = "t_cli";
            this.t_cli.Size = new System.Drawing.Size(103, 25);
            this.t_cli.TabIndex = 38;
            this.t_cli.UseSelectable = true;
            this.t_cli.Validating += new System.ComponentModel.CancelEventHandler(this.t_cli_Validating_1);
            // 
            // nuevo1
            // 
            this.nuevo1.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo1.Location = new System.Drawing.Point(139, 471);
            this.nuevo1.Name = "nuevo1";
            this.nuevo1.Size = new System.Drawing.Size(85, 28);
            this.nuevo1.TabIndex = 39;
            this.nuevo1.Text = "NUEVO";
            this.nuevo1.UseCustomBackColor = true;
            this.nuevo1.UseSelectable = true;
            this.nuevo1.Click += new System.EventHandler(this.nuevo1_Click);
            // 
            // salvar1
            // 
            this.salvar1.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar1.Location = new System.Drawing.Point(48, 471);
            this.salvar1.Name = "salvar1";
            this.salvar1.Size = new System.Drawing.Size(85, 28);
            this.salvar1.TabIndex = 40;
            this.salvar1.Text = "SALVAR";
            this.salvar1.UseCustomBackColor = true;
            this.salvar1.UseSelectable = true;
            this.salvar1.Click += new System.EventHandler(this.salvar1_Click);
            // 
            // consultar1
            // 
            this.consultar1.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar1.Location = new System.Drawing.Point(445, 284);
            this.consultar1.Name = "consultar1";
            this.consultar1.Size = new System.Drawing.Size(85, 28);
            this.consultar1.TabIndex = 41;
            this.consultar1.Text = "CONSULTAR";
            this.consultar1.UseCustomBackColor = true;
            this.consultar1.UseSelectable = true;
            this.consultar1.Click += new System.EventHandler(this.consultar1_Click);
            // 
            // salir1
            // 
            this.salir1.BackColor = System.Drawing.Color.AliceBlue;
            this.salir1.Location = new System.Drawing.Point(407, 471);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(85, 28);
            this.salir1.TabIndex = 42;
            this.salir1.Text = "SALIR";
            this.salir1.UseCustomBackColor = true;
            this.salir1.UseSelectable = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // actualizar1
            // 
            this.actualizar1.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar1.Location = new System.Drawing.Point(319, 471);
            this.actualizar1.Name = "actualizar1";
            this.actualizar1.Size = new System.Drawing.Size(85, 28);
            this.actualizar1.TabIndex = 43;
            this.actualizar1.Text = "ACTUALIZAR";
            this.actualizar1.UseCustomBackColor = true;
            this.actualizar1.UseSelectable = true;
            this.actualizar1.Click += new System.EventHandler(this.actualizar1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(372, 268);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 44;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(310, 268);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 45;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // ape_cli
            // 
            this.ape_cli.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ape_cli.Lines = new string[0];
            this.ape_cli.Location = new System.Drawing.Point(135, 135);
            this.ape_cli.MaxLength = 32767;
            this.ape_cli.Name = "ape_cli";
            this.ape_cli.PasswordChar = '\0';
            this.ape_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ape_cli.SelectedText = "";
            this.ape_cli.Size = new System.Drawing.Size(120, 23);
            this.ape_cli.TabIndex = 47;
            this.ape_cli.UseCustomBackColor = true;
            this.ape_cli.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(321, 286);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(118, 23);
            this.busca.TabIndex = 48;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.correo.Lines = new string[0];
            this.correo.Location = new System.Drawing.Point(372, 95);
            this.correo.MaxLength = 32767;
            this.correo.Name = "correo";
            this.correo.PasswordChar = '\0';
            this.correo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.correo.SelectedText = "";
            this.correo.Size = new System.Drawing.Size(142, 23);
            this.correo.TabIndex = 49;
            this.correo.UseCustomBackColor = true;
            this.correo.UseSelectable = true;
            // 
            // direccion
            // 
            this.direccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.direccion.Lines = new string[0];
            this.direccion.Location = new System.Drawing.Point(372, 62);
            this.direccion.MaxLength = 32767;
            this.direccion.Name = "direccion";
            this.direccion.PasswordChar = '\0';
            this.direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.direccion.SelectedText = "";
            this.direccion.Size = new System.Drawing.Size(142, 23);
            this.direccion.TabIndex = 50;
            this.direccion.UseCustomBackColor = true;
            this.direccion.UseSelectable = true;
            // 
            // nom_cli
            // 
            this.nom_cli.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nom_cli.Lines = new string[0];
            this.nom_cli.Location = new System.Drawing.Point(135, 100);
            this.nom_cli.MaxLength = 32767;
            this.nom_cli.Name = "nom_cli";
            this.nom_cli.PasswordChar = '\0';
            this.nom_cli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_cli.SelectedText = "";
            this.nom_cli.Size = new System.Drawing.Size(120, 23);
            this.nom_cli.TabIndex = 51;
            this.nom_cli.UseCustomBackColor = true;
            this.nom_cli.UseSelectable = true;
            // 
            // ina
            // 
            this.ina.AutoSize = true;
            this.ina.Location = new System.Drawing.Point(198, 213);
            this.ina.Name = "ina";
            this.ina.Size = new System.Drawing.Size(65, 15);
            this.ina.TabIndex = 52;
            this.ina.Text = "Inactivo";
            this.ina.UseSelectable = true;
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(537, 515);
            this.Controls.Add(this.ina);
            this.Controls.Add(this.nom_cli);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.ape_cli);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.actualizar1);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.consultar1);
            this.Controls.Add(this.salvar1);
            this.Controls.Add(this.nuevo1);
            this.Controls.Add(this.t_cli);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.codt_cli);
            this.Controls.Add(this.cod_cli);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clientes";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "CLIENTES";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.MaskedTextBox telefono;
        private System.Windows.Forms.DataGridView data;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox t_cli;
        private MetroFramework.Controls.MetroRadioButton activo;
        private MetroFramework.Controls.MetroComboBox codt_cli;
        private MetroFramework.Controls.MetroTextBox cod_cli;
        private MetroFramework.Controls.MetroButton eliminar1;
        private MetroFramework.Controls.MetroButton actualizar1;
        private MetroFramework.Controls.MetroButton salir1;
        private MetroFramework.Controls.MetroButton consultar1;
        private MetroFramework.Controls.MetroButton salvar1;
        private MetroFramework.Controls.MetroButton nuevo1;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroTextBox nom_cli;
        private MetroFramework.Controls.MetroTextBox direccion;
        private MetroFramework.Controls.MetroTextBox correo;
        private MetroFramework.Controls.MetroTextBox busca;
        private MetroFramework.Controls.MetroTextBox ape_cli;
        private MetroFramework.Controls.MetroRadioButton ina;
    }
}