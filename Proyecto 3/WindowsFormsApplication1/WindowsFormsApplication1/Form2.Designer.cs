namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.crv_impresion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport31 = new WindowsFormsApplication1.CrystalReport3();
            this.SuspendLayout();
            // 
            // crv_impresion
            // 
            this.crv_impresion.ActiveViewIndex = 0;
            this.crv_impresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_impresion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_impresion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_impresion.Location = new System.Drawing.Point(0, 0);
            this.crv_impresion.Name = "crv_impresion";
            this.crv_impresion.ReportSource = this.CrystalReport31;
            this.crv_impresion.Size = new System.Drawing.Size(563, 447);
            this.crv_impresion.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 447);
            this.Controls.Add(this.crv_impresion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_impresion;
        private CrystalReport3 CrystalReport31;
    }
}