namespace habitacion
{
    partial class entre_fechas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ver = new System.Windows.Forms.Button();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(133, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(276, 309);
            this.reportViewer1.TabIndex = 0;
            // 
            // ver
            // 
            this.ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver.Location = new System.Drawing.Point(28, 208);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 41);
            this.ver.TabIndex = 1;
            this.ver.Text = "VER FACTURA";
            this.ver.UseVisualStyleBackColor = true;
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(4, 111);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(123, 20);
            this.fecha1.TabIndex = 2;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(4, 164);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(123, 20);
            this.fecha2.TabIndex = 3;
            // 
            // entre_fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 309);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.reportViewer1);
            this.Name = "entre_fechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE ENTRE FECHAS";
            this.Load += new System.EventHandler(this.entre_fechas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DateTimePicker fecha2;
    }
}