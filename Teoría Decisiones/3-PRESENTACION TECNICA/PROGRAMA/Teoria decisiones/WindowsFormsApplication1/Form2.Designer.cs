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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis2 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis2 = new Telerik.WinControls.UI.LinearAxis();
            this.r1 = new Telerik.WinControls.UI.RadChartView();
            this.e1 = new MetroFramework.Controls.MetroLabel();
            this.r2 = new Telerik.WinControls.UI.RadChartView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).BeginInit();
            this.SuspendLayout();
            // 
            // r1
            // 
            this.r1.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.TickOrigin = null;
            this.r1.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.r1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.r1.Location = new System.Drawing.Point(12, 43);
            this.r1.Name = "r1";
            this.r1.ShowGrid = false;
            this.r1.Size = new System.Drawing.Size(807, 259);
            this.r1.TabIndex = 6;
            this.r1.Text = "radChartView1";
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.BackColor = System.Drawing.Color.Transparent;
            this.e1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.e1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.e1.Location = new System.Drawing.Point(36, 9);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(229, 25);
            this.e1.TabIndex = 37;
            this.e1.Text = "Porcentaje de cada Causa";
            this.e1.UseCustomBackColor = true;
            this.e1.UseCustomForeColor = true;
            this.e1.UseStyleColors = true;
            this.e1.Click += new System.EventHandler(this.e1_Click);
            // 
            // r2
            // 
            this.r2.AreaDesign = cartesianArea2;
            categoricalAxis2.IsPrimary = true;
            linearAxis2.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis2.IsPrimary = true;
            linearAxis2.TickOrigin = null;
            this.r2.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis2,
            linearAxis2});
            this.r2.BackColor = System.Drawing.Color.Azure;
            this.r2.Location = new System.Drawing.Point(12, 366);
            this.r2.Name = "r2";
            this.r2.ShowGrid = false;
            this.r2.Size = new System.Drawing.Size(807, 259);
            this.r2.TabIndex = 38;
            this.r2.Text = "radChartView1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(12, 338);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(296, 25);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Presupuesto para las Alternativas";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(831, 600);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.r1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Informe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadChartView r1;
        private MetroFramework.Controls.MetroLabel e1;
        public Telerik.WinControls.UI.RadChartView r2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}