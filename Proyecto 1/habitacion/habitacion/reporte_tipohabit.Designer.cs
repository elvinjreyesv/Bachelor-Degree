﻿namespace habitacion
{
    partial class reporte_tipohabit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporte_tipohabit));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new DataSet1();
            this.v_tipohabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_tipohabTableAdapter = new DataSet1TableAdapters.v_tipohabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_tipohabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.v_tipohabBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "habitacion.Rep_tipohabitac.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_tipohabBindingSource
            // 
            this.v_tipohabBindingSource.DataMember = "v_tipohab";
            this.v_tipohabBindingSource.DataSource = this.DataSet1;
            // 
            // v_tipohabTableAdapter
            // 
            this.v_tipohabTableAdapter.ClearBeforeFill = true;
            // 
            // reporte_tipohabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reporte_tipohabit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reporte_tipohabit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_tipohabBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource v_tipohabBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.v_tipohabTableAdapter v_tipohabTableAdapter;
    }
}