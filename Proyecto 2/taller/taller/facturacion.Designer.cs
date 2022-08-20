namespace taller
{
    partial class facturacion
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
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taller_fDataSet2 = new taller.taller_fDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturasTableAdapter = new taller.taller_fDataSet2TableAdapters.facturasTableAdapter();
            this.rep_facturacionTableAdapter = new taller.taller_fDataSetTableAdapters.rep_facturacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rep_facturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller_fDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller_fDataSet2)).BeginInit();
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
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "facturas";
            this.facturasBindingSource.DataSource = this.taller_fDataSet2;
            // 
            // taller_fDataSet2
            // 
            this.taller_fDataSet2.DataSetName = "taller_fDataSet2";
            this.taller_fDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rep_facturacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "taller.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 624);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // rep_facturacionTableAdapter
            // 
            this.rep_facturacionTableAdapter.ClearBeforeFill = true;
            // 
            // facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 622);
            this.Controls.Add(this.reportViewer1);
            this.Name = "facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rep_facturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller_fDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taller_fDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private taller_fDataSet2 taller_fDataSet2;
        private taller_fDataSet2TableAdapters.facturasTableAdapter facturasTableAdapter;
        private taller_fDataSet taller_fDataSet;
        private System.Windows.Forms.BindingSource rep_facturacionBindingSource;
        private taller_fDataSetTableAdapters.rep_facturacionTableAdapter rep_facturacionTableAdapter;
    }
}