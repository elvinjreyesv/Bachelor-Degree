namespace taller.mantenimientos
{
    partial class compras
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
            this.nom_sup = new MetroFramework.Controls.MetroComboBox();
            this.desc_art = new MetroFramework.Controls.MetroComboBox();
            this.almacen = new MetroFramework.Controls.MetroComboBox();
            this.cod_art = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.Codigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_sup
            // 
            this.nom_sup.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.nom_sup.FormattingEnabled = true;
            this.nom_sup.ItemHeight = 19;
            this.nom_sup.Location = new System.Drawing.Point(191, 86);
            this.nom_sup.Name = "nom_sup";
            this.nom_sup.Size = new System.Drawing.Size(116, 25);
            this.nom_sup.TabIndex = 113;
            this.nom_sup.UseSelectable = true;
            // 
            // desc_art
            // 
            this.desc_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.desc_art.FormattingEnabled = true;
            this.desc_art.ItemHeight = 19;
            this.desc_art.Location = new System.Drawing.Point(147, 237);
            this.desc_art.Name = "desc_art";
            this.desc_art.Size = new System.Drawing.Size(92, 25);
            this.desc_art.TabIndex = 110;
            this.desc_art.UseSelectable = true;
            // 
            // almacen
            // 
            this.almacen.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.almacen.FormattingEnabled = true;
            this.almacen.ItemHeight = 19;
            this.almacen.Location = new System.Drawing.Point(191, 155);
            this.almacen.Name = "almacen";
            this.almacen.Size = new System.Drawing.Size(116, 25);
            this.almacen.TabIndex = 108;
            this.almacen.UseSelectable = true;
            // 
            // cod_art
            // 
            this.cod_art.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cod_art.FormattingEnabled = true;
            this.cod_art.ItemHeight = 19;
            this.cod_art.Location = new System.Drawing.Point(33, 238);
            this.cod_art.Name = "cod_art";
            this.cod_art.Size = new System.Drawing.Size(99, 25);
            this.cod_art.TabIndex = 107;
            this.cod_art.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Precio";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigos,
            this.descripcion,
            this.cantidadd,
            this.precio_v,
            this.importes});
            this.data.Location = new System.Drawing.Point(12, 267);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(552, 150);
            this.data.TabIndex = 96;
            // 
            // Codigos
            // 
            this.Codigos.HeaderText = "Codigo";
            this.Codigos.Name = "Codigos";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // cantidadd
            // 
            this.cantidadd.HeaderText = "Cantidad";
            this.cantidadd.Name = "cantidadd";
            // 
            // precio_v
            // 
            this.precio_v.HeaderText = "Precio";
            this.precio_v.Name = "precio_v";
            // 
            // importes
            // 
            this.importes.HeaderText = "Importe";
            this.importes.Name = "importes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(155, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 94;
            this.label13.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 93;
            this.label10.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Codigo_Articulo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 89;
            this.label11.Text = "SUPLIDOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 18);
            this.label9.TabIndex = 88;
            this.label9.Text = "COSTOS I.FABRICACION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "CODIGO DE COMPRA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "ALMACEN";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton5.Location = new System.Drawing.Point(393, 462);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(79, 27);
            this.metroButton5.TabIndex = 127;
            this.metroButton5.Text = "SALIR";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton4.Location = new System.Drawing.Point(308, 462);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(79, 27);
            this.metroButton4.TabIndex = 128;
            this.metroButton4.Text = "ACTUALIZAR";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton3.Location = new System.Drawing.Point(223, 462);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(79, 27);
            this.metroButton3.TabIndex = 129;
            this.metroButton3.Text = "ELIMINAR";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton2.Location = new System.Drawing.Point(138, 462);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(79, 27);
            this.metroButton2.TabIndex = 130;
            this.metroButton2.Text = "NUEVO";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton1.Location = new System.Drawing.Point(53, 462);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(79, 27);
            this.metroButton1.TabIndex = 131;
            this.metroButton1.Text = "SALVAR";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(191, 48);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(107, 23);
            this.metroTextBox2.TabIndex = 132;
            this.metroTextBox2.UseCustomBackColor = true;
            this.metroTextBox2.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 133;
            this.label6.Text = "COMPRAS";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(271, 240);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.Size = new System.Drawing.Size(60, 23);
            this.metroTextBox3.TabIndex = 134;
            this.metroTextBox3.UseCustomBackColor = true;
            this.metroTextBox3.UseSelectable = true;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(356, 240);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.Size = new System.Drawing.Size(60, 23);
            this.metroTextBox4.TabIndex = 135;
            this.metroTextBox4.UseCustomBackColor = true;
            this.metroTextBox4.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton6.Location = new System.Drawing.Point(473, 236);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(79, 27);
            this.metroButton6.TabIndex = 136;
            this.metroButton6.Text = "AGREGAR";
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 19;
            this.metroComboBox1.Location = new System.Drawing.Point(191, 120);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(116, 25);
            this.metroComboBox1.TabIndex = 137;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(505, 423);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(60, 23);
            this.metroTextBox1.TabIndex = 138;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 97;
            this.label3.Text = "TOTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::taller.Properties.Resources.descarga__10_;
            this.pictureBox1.Location = new System.Drawing.Point(426, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.nom_sup);
            this.Controls.Add(this.desc_art);
            this.Controls.Add(this.almacen);
            this.Controls.Add(this.cod_art);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox nom_sup;
        private MetroFramework.Controls.MetroComboBox desc_art;
        private MetroFramework.Controls.MetroComboBox almacen;
        private MetroFramework.Controls.MetroComboBox cod_art;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn importes;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}