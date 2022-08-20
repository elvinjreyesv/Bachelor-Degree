namespace proyecto_prog3
{
    partial class Consultar_productos
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
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(2, 12);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.Size = new System.Drawing.Size(644, 280);
            this.dgvproductos.TabIndex = 0;
            // 
            // Consultar_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 304);
            this.Controls.Add(this.dgvproductos);
            this.Name = "Consultar_productos";
            this.Text = "Consultar_productos";
            this.Load += new System.EventHandler(this.Consultar_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproductos;
    }
}