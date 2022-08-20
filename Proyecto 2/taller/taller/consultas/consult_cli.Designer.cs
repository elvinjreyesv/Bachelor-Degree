namespace taller.consultas
{
    partial class consult_cli
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
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.consultar = new System.Windows.Forms.DataGridView();
            this.rte = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rnc = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 155;
            this.label1.Text = "Nombre";
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buscar.BackgroundImage = global::taller.Properties.Resources._1354069686_search_24;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar.Location = new System.Drawing.Point(344, 110);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(35, 23);
            this.buscar.TabIndex = 154;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // consultar
            // 
            this.consultar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultar.Location = new System.Drawing.Point(0, 170);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(825, 234);
            this.consultar.TabIndex = 153;
            this.consultar.DoubleClick += new System.EventHandler(this.consultar_DoubleClick);
            // 
            // rte
            // 
            this.rte.BackColor = System.Drawing.Color.White;
            this.rte.Lines = new string[0];
            this.rte.Location = new System.Drawing.Point(96, 35);
            this.rte.MaxLength = 32767;
            this.rte.Name = "rte";
            this.rte.PasswordChar = '\0';
            this.rte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rte.SelectedText = "";
            this.rte.Size = new System.Drawing.Size(150, 23);
            this.rte.TabIndex = 152;
            this.rte.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rte.UseCustomBackColor = true;
            this.rte.UseCustomForeColor = true;
            this.rte.UseSelectable = true;
            this.rte.UseStyleColors = true;
            this.rte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rte_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.rnc);
            this.groupBox1.Controls.Add(this.rte);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 139);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE BUSQUEDA";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // rnc
            // 
            this.rnc.BackColor = System.Drawing.Color.White;
            this.rnc.Lines = new string[0];
            this.rnc.Location = new System.Drawing.Point(96, 93);
            this.rnc.MaxLength = 32767;
            this.rnc.Name = "rnc";
            this.rnc.PasswordChar = '\0';
            this.rnc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rnc.SelectedText = "";
            this.rnc.Size = new System.Drawing.Size(150, 23);
            this.rnc.TabIndex = 152;
            this.rnc.UseCustomBackColor = true;
            this.rnc.UseCustomForeColor = true;
            this.rnc.UseSelectable = true;
            this.rnc.UseStyleColors = true;
            this.rnc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rte_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 155;
            this.label2.Text = "Rnc";
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.White;
            this.codigo.Lines = new string[0];
            this.codigo.Location = new System.Drawing.Point(96, 64);
            this.codigo.MaxLength = 32767;
            this.codigo.Name = "codigo";
            this.codigo.PasswordChar = '\0';
            this.codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codigo.SelectedText = "";
            this.codigo.Size = new System.Drawing.Size(150, 23);
            this.codigo.TabIndex = 152;
            this.codigo.UseCustomBackColor = true;
            this.codigo.UseCustomForeColor = true;
            this.codigo.UseSelectable = true;
            this.codigo.UseStyleColors = true;
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rte_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 155;
            this.label3.Text = "Codigo";
            // 
            // consult_cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.consultar);
            this.Name = "consult_cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR CLIENTES";
            this.Load += new System.EventHandler(this.consult_cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton buscar;
        private System.Windows.Forms.DataGridView consultar;
        private MetroFramework.Controls.MetroTextBox rte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox codigo;
        private MetroFramework.Controls.MetroTextBox rnc;
    }
}