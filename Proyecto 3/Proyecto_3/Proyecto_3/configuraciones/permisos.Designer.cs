namespace Proyecto_3
{
    partial class permisos
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
            this.Comprobante = new MetroFramework.Controls.MetroTabControl();
            this.Inventario1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.cxc = new MetroFramework.Controls.MetroTabPage();
            this.cxp = new MetroFramework.Controls.MetroTabPage();
            this.nomina = new MetroFramework.Controls.MetroTabPage();
            this.comprobante1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.Comprobante.SuspendLayout();
            this.Inventario1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Comprobante
            // 
            this.Comprobante.Controls.Add(this.Inventario1);
            this.Comprobante.Controls.Add(this.cxc);
            this.Comprobante.Controls.Add(this.cxp);
            this.Comprobante.Controls.Add(this.nomina);
            this.Comprobante.Controls.Add(this.comprobante1);
            this.Comprobante.Location = new System.Drawing.Point(10, 88);
            this.Comprobante.Name = "Comprobante";
            this.Comprobante.SelectedIndex = 0;
            this.Comprobante.Size = new System.Drawing.Size(671, 415);
            this.Comprobante.TabIndex = 0;
            this.Comprobante.UseSelectable = true;
            // 
            // Inventario1
            // 
            this.Inventario1.Controls.Add(this.metroLabel2);
            this.Inventario1.Controls.Add(this.metroToggle2);
            this.Inventario1.Controls.Add(this.metroToggle1);
            this.Inventario1.HorizontalScrollbarBarColor = true;
            this.Inventario1.HorizontalScrollbarHighlightOnWheel = false;
            this.Inventario1.HorizontalScrollbarSize = 10;
            this.Inventario1.Location = new System.Drawing.Point(4, 38);
            this.Inventario1.Name = "Inventario1";
            this.Inventario1.Size = new System.Drawing.Size(663, 373);
            this.Inventario1.TabIndex = 0;
            this.Inventario1.Text = "Inventario";
            this.Inventario1.VerticalScrollbarBarColor = true;
            this.Inventario1.VerticalScrollbarHighlightOnWheel = false;
            this.Inventario1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(6, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Todos";
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.BackColor = System.Drawing.Color.White;
            this.metroToggle2.Location = new System.Drawing.Point(65, 31);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggle2.TabIndex = 3;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle2.UseCustomBackColor = true;
            this.metroToggle2.UseCustomForeColor = true;
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.UseStyleColors = true;
            this.metroToggle2.Validating += new System.ComponentModel.CancelEventHandler(this.metroToggle2_Validating);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(97, 120);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 2;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // cxc
            // 
            this.cxc.HorizontalScrollbarBarColor = true;
            this.cxc.HorizontalScrollbarHighlightOnWheel = false;
            this.cxc.HorizontalScrollbarSize = 10;
            this.cxc.Location = new System.Drawing.Point(4, 38);
            this.cxc.Name = "cxc";
            this.cxc.Size = new System.Drawing.Size(663, 373);
            this.cxc.TabIndex = 1;
            this.cxc.Text = "Cuentas Por cobrar";
            this.cxc.VerticalScrollbarBarColor = true;
            this.cxc.VerticalScrollbarHighlightOnWheel = false;
            this.cxc.VerticalScrollbarSize = 10;
            // 
            // cxp
            // 
            this.cxp.HorizontalScrollbarBarColor = true;
            this.cxp.HorizontalScrollbarHighlightOnWheel = false;
            this.cxp.HorizontalScrollbarSize = 10;
            this.cxp.Location = new System.Drawing.Point(4, 38);
            this.cxp.Name = "cxp";
            this.cxp.Size = new System.Drawing.Size(663, 373);
            this.cxp.TabIndex = 2;
            this.cxp.Text = "Cuentas Por Pagar";
            this.cxp.VerticalScrollbarBarColor = true;
            this.cxp.VerticalScrollbarHighlightOnWheel = false;
            this.cxp.VerticalScrollbarSize = 10;
            // 
            // nomina
            // 
            this.nomina.HorizontalScrollbarBarColor = true;
            this.nomina.HorizontalScrollbarHighlightOnWheel = false;
            this.nomina.HorizontalScrollbarSize = 10;
            this.nomina.Location = new System.Drawing.Point(4, 38);
            this.nomina.Name = "nomina";
            this.nomina.Size = new System.Drawing.Size(663, 373);
            this.nomina.TabIndex = 3;
            this.nomina.Text = "Nomina";
            this.nomina.VerticalScrollbarBarColor = true;
            this.nomina.VerticalScrollbarHighlightOnWheel = false;
            this.nomina.VerticalScrollbarSize = 10;
            // 
            // comprobante1
            // 
            this.comprobante1.HorizontalScrollbarBarColor = true;
            this.comprobante1.HorizontalScrollbarHighlightOnWheel = false;
            this.comprobante1.HorizontalScrollbarSize = 10;
            this.comprobante1.Location = new System.Drawing.Point(4, 38);
            this.comprobante1.Name = "comprobante1";
            this.comprobante1.Size = new System.Drawing.Size(663, 373);
            this.comprobante1.TabIndex = 4;
            this.comprobante1.Text = "Comprobante Fiscal";
            this.comprobante1.VerticalScrollbarBarColor = true;
            this.comprobante1.VerticalScrollbarHighlightOnWheel = false;
            this.comprobante1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Usuario";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(131, 44);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(129, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::Proyecto_3.Properties.Resources.icon_us1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(271, 44);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(38, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.White;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(79, 44);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(51, 23);
            this.metroTextBox2.TabIndex = 4;
            this.metroTextBox2.UseCustomBackColor = true;
            this.metroTextBox2.UseCustomForeColor = true;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.UseStyleColors = true;
            // 
            // permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 509);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Comprobante);
            this.Name = "permisos";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Permisos a Usuarios";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.permisos_Load);
            this.Comprobante.ResumeLayout(false);
            this.Inventario1.ResumeLayout(false);
            this.Inventario1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Comprobante;
        private MetroFramework.Controls.MetroTabPage Inventario1;
        private MetroFramework.Controls.MetroTabPage cxc;
        private MetroFramework.Controls.MetroTabPage cxp;
        private MetroFramework.Controls.MetroTabPage nomina;
        private MetroFramework.Controls.MetroTabPage comprobante1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
    }
}