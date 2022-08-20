namespace sistema_administracion_bares
{
    partial class cxc
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
            this.label5 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.salir = new MetroFramework.Controls.MetroButton();
            this.cod_est = new MetroFramework.Controls.MetroComboBox();
            this.cod = new MetroFramework.Controls.MetroRadioButton();
            this.codigo = new MetroFramework.Controls.MetroTextBox();
            this.actualizar = new MetroFramework.Controls.MetroButton();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.nuevo = new MetroFramework.Controls.MetroButton();
            this.salvar = new MetroFramework.Controls.MetroButton();
            this.consultar = new MetroFramework.Controls.MetroButton();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.estado = new MetroFramework.Controls.MetroComboBox();
            this.cod_cli = new MetroFramework.Controls.MetroComboBox();
            this.nomb_cli = new MetroFramework.Controls.MetroComboBox();
            this.busca = new MetroFramework.Controls.MetroTextBox();
            this.valor = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 87;
            this.label5.Text = "CLIENTE";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(225, 209);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(94, 20);
            this.fecha.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "FECHA DE ADQUISICION";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data.Location = new System.Drawing.Point(12, 302);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(534, 150);
            this.data.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "VALOR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 90;
            this.label6.Text = "FECHA DE VENCIMIMIENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 92;
            this.label7.Text = "ESTADO";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.AliceBlue;
            this.salir.Location = new System.Drawing.Point(416, 461);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 28);
            this.salir.TabIndex = 95;
            this.salir.Text = "SALIR";
            this.salir.UseCustomBackColor = true;
            this.salir.UseSelectable = true;
            // 
            // cod_est
            // 
            this.cod_est.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_est.FormattingEnabled = true;
            this.cod_est.ItemHeight = 19;
            this.cod_est.Location = new System.Drawing.Point(132, 170);
            this.cod_est.Name = "cod_est";
            this.cod_est.Size = new System.Drawing.Size(67, 25);
            this.cod_est.TabIndex = 96;
            this.cod_est.UseSelectable = true;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(335, 255);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(62, 15);
            this.cod.TabIndex = 97;
            this.cod.Text = "Codigo";
            this.cod.UseSelectable = true;
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codigo.Lines = new string[0];
            this.codigo.Location = new System.Drawing.Point(132, 62);
            this.codigo.MaxLength = 32767;
            this.codigo.Name = "codigo";
            this.codigo.PasswordChar = '\0';
            this.codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codigo.SelectedText = "";
            this.codigo.Size = new System.Drawing.Size(82, 23);
            this.codigo.TabIndex = 98;
            this.codigo.UseCustomBackColor = true;
            this.codigo.UseSelectable = true;
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.actualizar.Location = new System.Drawing.Point(325, 461);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 99;
            this.actualizar.Text = "ACTUALIZAR";
            this.actualizar.UseCustomBackColor = true;
            this.actualizar.UseSelectable = true;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.eliminar.Location = new System.Drawing.Point(234, 461);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 28);
            this.eliminar.TabIndex = 100;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseCustomBackColor = true;
            this.eliminar.UseSelectable = true;
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.nuevo.Location = new System.Drawing.Point(143, 461);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(85, 28);
            this.nuevo.TabIndex = 101;
            this.nuevo.Text = "NUEVO";
            this.nuevo.UseCustomBackColor = true;
            this.nuevo.UseSelectable = true;
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.AliceBlue;
            this.salvar.Location = new System.Drawing.Point(52, 461);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(85, 28);
            this.salvar.TabIndex = 102;
            this.salvar.Text = "SALVAR";
            this.salvar.UseCustomBackColor = true;
            this.salvar.UseSelectable = true;
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.AliceBlue;
            this.consultar.Location = new System.Drawing.Point(467, 268);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(85, 28);
            this.consultar.TabIndex = 103;
            this.consultar.Text = "CONSULTAR";
            this.consultar.UseCustomBackColor = true;
            this.consultar.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(397, 255);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(67, 15);
            this.nombre.TabIndex = 104;
            this.nombre.Text = "Nombre";
            this.nombre.UseSelectable = true;
            // 
            // estado
            // 
            this.estado.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.estado.FormattingEnabled = true;
            this.estado.ItemHeight = 19;
            this.estado.Location = new System.Drawing.Point(206, 170);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(111, 25);
            this.estado.TabIndex = 105;
            this.estado.UseSelectable = true;
            // 
            // cod_cli
            // 
            this.cod_cli.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_cli.FormattingEnabled = true;
            this.cod_cli.ItemHeight = 19;
            this.cod_cli.Location = new System.Drawing.Point(132, 134);
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.Size = new System.Drawing.Size(67, 25);
            this.cod_cli.TabIndex = 106;
            this.cod_cli.UseSelectable = true;
            // 
            // nomb_cli
            // 
            this.nomb_cli.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.nomb_cli.FormattingEnabled = true;
            this.nomb_cli.ItemHeight = 19;
            this.nomb_cli.Location = new System.Drawing.Point(206, 133);
            this.nomb_cli.Name = "nomb_cli";
            this.nomb_cli.Size = new System.Drawing.Size(111, 25);
            this.nomb_cli.TabIndex = 107;
            this.nomb_cli.UseSelectable = true;
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.busca.Lines = new string[0];
            this.busca.Location = new System.Drawing.Point(351, 273);
            this.busca.MaxLength = 32767;
            this.busca.Name = "busca";
            this.busca.PasswordChar = '\0';
            this.busca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busca.SelectedText = "";
            this.busca.Size = new System.Drawing.Size(110, 23);
            this.busca.TabIndex = 108;
            this.busca.UseCustomBackColor = true;
            this.busca.UseSelectable = true;
            // 
            // valor
            // 
            this.valor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.valor.Lines = new string[0];
            this.valor.Location = new System.Drawing.Point(132, 91);
            this.valor.MaxLength = 32767;
            this.valor.Name = "valor";
            this.valor.PasswordChar = '\0';
            this.valor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.valor.SelectedText = "";
            this.valor.Size = new System.Drawing.Size(82, 23);
            this.valor.TabIndex = 109;
            this.valor.UseCustomBackColor = true;
            this.valor.UseSelectable = true;
            // 
            // cxc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(558, 496);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.nomb_cli);
            this.Controls.Add(this.cod_cli);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.cod_est);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "cxc";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Cuenta por Cobrar";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.cxc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton consultar;
        private MetroFramework.Controls.MetroButton salvar;
        private MetroFramework.Controls.MetroButton nuevo;
        private MetroFramework.Controls.MetroButton eliminar;
        private MetroFramework.Controls.MetroButton actualizar;
        private MetroFramework.Controls.MetroTextBox codigo;
        private MetroFramework.Controls.MetroRadioButton cod;
        private MetroFramework.Controls.MetroComboBox cod_est;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroComboBox nomb_cli;
        private MetroFramework.Controls.MetroComboBox cod_cli;
        private MetroFramework.Controls.MetroComboBox estado;
        private MetroFramework.Controls.MetroTextBox valor;
        private MetroFramework.Controls.MetroTextBox busca;
    }
}