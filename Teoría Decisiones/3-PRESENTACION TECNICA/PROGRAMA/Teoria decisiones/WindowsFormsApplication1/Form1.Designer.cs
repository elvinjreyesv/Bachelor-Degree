namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.layoutGroup1 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.layoutGroup2 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.layoutGroup3 = new DevComponents.DotNetBar.Layout.LayoutGroup();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.layoutControl1 = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.LightGray, System.Drawing.Color.Red);
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.LightGray, System.Drawing.Color.Red);
            // 
            // layoutGroup1
            // 
            this.layoutGroup1.Height = 100;
            this.layoutGroup1.Image = global::WindowsFormsApplication1.Properties.Resources.color;
            this.layoutGroup1.MinSize = new System.Drawing.Size(200, 80);
            this.layoutGroup1.Name = "layoutGroup1";
            this.layoutGroup1.SymbolColor = System.Drawing.Color.Red;
            this.layoutGroup1.Text = "primero";
            this.layoutGroup1.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup1.Width = 200;
            // 
            // layoutGroup2
            // 
            this.layoutGroup2.Height = 100;
            this.layoutGroup2.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup2.Name = "layoutGroup2";
            this.layoutGroup2.Text = "ssssssssssss";
            this.layoutGroup2.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup2.Width = 200;
            // 
            // layoutGroup3
            // 
            this.layoutGroup3.Height = 100;
            this.layoutGroup3.MinSize = new System.Drawing.Size(120, 32);
            this.layoutGroup3.Name = "layoutGroup3";
            this.layoutGroup3.Text = "ssssssssss";
            this.layoutGroup3.TextPosition = DevComponents.DotNetBar.Layout.eLayoutPosition.Top;
            this.layoutGroup3.Width = 200;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chart1;
            this.layoutControlItem1.Height = 308;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "Label:";
            this.layoutControlItem1.Width = 308;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 304);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(262, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chart2;
            this.layoutControlItem2.Height = 308;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "Label:";
            this.layoutControlItem2.Width = 270;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(42, 612);
            this.chart2.Margin = new System.Windows.Forms.Padding(0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(224, 300);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chart1);
            this.layoutControl1.Controls.Add(this.chart2);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            // 
            // 
            // 
            this.layoutControl1.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutGroup1,
            this.layoutGroup2,
            this.layoutGroup3,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControl1.Size = new System.Drawing.Size(35, 358);
            this.layoutControl1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layoutControl1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup1;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup2;
        private DevComponents.DotNetBar.Layout.LayoutGroup layoutGroup3;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DevComponents.DotNetBar.Layout.LayoutControl layoutControl1;
        private System.Windows.Forms.Button button1;

    }
}