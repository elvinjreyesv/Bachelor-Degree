namespace repuesto
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
            this.rte = new MetroFramework.Controls.MetroTextBox();
            this.consultar = new System.Windows.Forms.DataGridView();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // rte
            // 
            this.rte.BackColor = System.Drawing.Color.White;
            this.rte.Lines = new string[0];
            this.rte.Location = new System.Drawing.Point(94, 39);
            this.rte.MaxLength = 32767;
            this.rte.Name = "rte";
            this.rte.PasswordChar = '\0';
            this.rte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rte.SelectedText = "";
            this.rte.Size = new System.Drawing.Size(85, 23);
            this.rte.TabIndex = 1;
            this.rte.UseCustomBackColor = true;
            this.rte.UseSelectable = true;
            // 
            // consultar
            // 
            this.consultar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cedula,
            this.ncf,
            this.celular,
            this.correo});
            this.consultar.Location = new System.Drawing.Point(12, 104);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(436, 149);
            this.consultar.TabIndex = 149;
            this.consultar.DoubleClick += new System.EventHandler(this.consultar_DoubleClick);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buscar.BackgroundImage = global::repuesto.Properties.Resources._1354069686_search_24;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar.Location = new System.Drawing.Point(185, 39);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(35, 23);
            this.buscar.TabIndex = 150;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 151;
            this.label1.Text = "Nombre";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            // 
            // ncf
            // 
            this.ncf.HeaderText = "Ncf";
            this.ncf.Name = "ncf";
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // consult_cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.rte);
            this.Name = "consult_cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RUSCAR CLIENTES";
            this.Load += new System.EventHandler(this.consult_cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox rte;
        private System.Windows.Forms.DataGridView consultar;
        private MetroFramework.Controls.MetroButton buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncf;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}