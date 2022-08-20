namespace Proyecto_3
{
    partial class ncf_reg2
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
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(238, 93);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(35, 15);
            this.metroRadioButton1.TabIndex = 113;
            this.metroRadioButton1.Text = "    ";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            this.metroRadioButton1.Click += new System.EventHandler(this.metroRadioButton1_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(32, 89);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(200, 19);
            this.metroLabel9.TabIndex = 112;
            this.metroLabel9.Text = "Proveedores Informales [01]";
            // 
            // ncf_reg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 166);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroLabel9);
            this.Name = "ncf_reg2";
            this.Resizable = false;
            this.Text = "NCF";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ncf_reg2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}