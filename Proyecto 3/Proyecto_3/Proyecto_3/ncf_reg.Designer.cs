namespace Proyecto_3
{
    partial class ncf_reg
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
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(40, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(160, 19);
            this.metroLabel9.TabIndex = 110;
            this.metroLabel9.Text = "Consumidor Fiscal [01]";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(40, 174);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(215, 19);
            this.metroLabel8.TabIndex = 108;
            this.metroLabel8.Text = "Facturas Gubernamentales [15]";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(40, 143);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(209, 19);
            this.metroLabel5.TabIndex = 104;
            this.metroLabel5.Text = "Comprobantes Especiales [14]";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(40, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 19);
            this.metroLabel1.TabIndex = 102;
            this.metroLabel1.Text = "Consumidor Final [02]";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(270, 81);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(35, 15);
            this.metroRadioButton1.TabIndex = 111;
            this.metroRadioButton1.Text = "    ";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(270, 110);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(35, 15);
            this.metroRadioButton2.TabIndex = 112;
            this.metroRadioButton2.Text = "    ";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(270, 143);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(35, 15);
            this.metroRadioButton3.TabIndex = 113;
            this.metroRadioButton3.Text = "    ";
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(270, 178);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(35, 15);
            this.metroRadioButton4.TabIndex = 114;
            this.metroRadioButton4.Text = "    ";
            this.metroRadioButton4.UseSelectable = true;
            this.metroRadioButton4.CheckedChanged += new System.EventHandler(this.metroRadioButton4_CheckedChanged);
            // 
            // ncf_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 230);
            this.Controls.Add(this.metroRadioButton4);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ncf_reg";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Tipo de NCF";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ncf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
    }
}