namespace Proyecto_3.otros
{
    partial class principal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal2));
            this.metroUserControl4 = new MetroFramework.Controls.MetroUserControl();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroUserControl4
            // 
            this.metroUserControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroUserControl4.BackgroundImage = global::Proyecto_3.Properties.Resources.modelos;
            this.metroUserControl4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroUserControl4.Location = new System.Drawing.Point(-246, 38);
            this.metroUserControl4.Name = "metroUserControl4";
            this.metroUserControl4.Size = new System.Drawing.Size(761, 640);
            this.metroUserControl4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroUserControl4.TabIndex = 13;
            this.metroUserControl4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroUserControl4.UseCustomBackColor = true;
            this.metroUserControl4.UseCustomForeColor = true;
            this.metroUserControl4.UseSelectable = true;
            this.metroUserControl4.UseStyleColors = true;
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 701);
            this.Controls.Add(this.metroUserControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal2";
            this.Opacity = 0.5D;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl4;
        public MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}