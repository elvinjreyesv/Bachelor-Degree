namespace taller
{
    partial class facturacion2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rep_facturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taller_fDataSet = new taller.taller_fDataSet();
            this.rep_facturacionTableAdapter = new taller.taller_fDataSetTableAdapters.rep_facturacionTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.rep_facturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller_fDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rep_facturacionBindingSource
            // 
            this.rep_facturacionBindingSource.DataMember = "rep_facturacion";
            this.rep_facturacionBindingSource.DataSource = this.taller_fDataSet;
            // 
            // taller_fDataSet
            // 
            this.taller_fDataSet.DataSetName = "taller_fDataSet";
            this.taller_fDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rep_facturacionTableAdapter
            // 
            this.rep_facturacionTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rep_facturacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "taller.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 625);
            this.reportViewer1.TabIndex = 1;
            // 
            // facturacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 622);
            this.Controls.Add(this.reportViewer1);
            this.Name = "facturacion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facturacion2";
            this.Load += new System.EventHandler(this.facturacion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rep_facturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller_fDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource rep_facturacionBindingSource;
        private taller_fDataSet taller_fDataSet;
        private taller_fDataSetTableAdapters.rep_facturacionTableAdapter rep_facturacionTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}