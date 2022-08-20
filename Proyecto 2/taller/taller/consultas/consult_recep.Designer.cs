namespace taller.consultas
{
    partial class consult_recep
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
            this.consultar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // consultar
            // 
            this.consultar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultar.Location = new System.Drawing.Point(-1, 75);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(512, 234);
            this.consultar.TabIndex = 157;
            this.consultar.DoubleClick += new System.EventHandler(this.consultar_DoubleClick);
            // 
            // consult_recep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 310);
            this.Controls.Add(this.consultar);
            this.Name = "consult_recep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECEPCIONES";
            this.Load += new System.EventHandler(this.consult_recep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView consultar;
    }
}