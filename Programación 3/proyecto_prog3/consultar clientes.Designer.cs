namespace proyecto_prog3
{
    partial class consultar_clientes
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
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(3, 12);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.Size = new System.Drawing.Size(637, 280);
            this.dgvclientes.TabIndex = 0;
            // 
            // consultar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 304);
            this.Controls.Add(this.dgvclientes);
            this.Name = "consultar_clientes";
            this.Text = "consultar_clientes";
            this.Load += new System.EventHandler(this.consultar_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclientes;
    }
}