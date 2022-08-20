namespace WindowsFormsApplication1
{
    partial class mostrar
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
            this.documento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // documento
            // 
            this.documento.ActiveViewIndex = -1;
            this.documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documento.Cursor = System.Windows.Forms.Cursors.Default;
            this.documento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documento.Location = new System.Drawing.Point(20, 60);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(469, 361);
            this.documento.TabIndex = 0;
            this.documento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 441);
            this.Controls.Add(this.documento);
            this.Name = "mostrar";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer documento;

    }
}