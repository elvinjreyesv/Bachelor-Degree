namespace Proyecto_3
{
    partial class prueba
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ultimo1 = new Proyecto_3.ultimo();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.ultimo1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(543, 345);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // prueba
            // 
            this.ClientSize = new System.Drawing.Size(583, 425);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "prueba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.prueba_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
      //  private new_rpt new_rpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private ultimo ultimo1;
    }
}