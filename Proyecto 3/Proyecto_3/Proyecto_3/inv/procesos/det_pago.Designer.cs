namespace Proyecto_3.inv.procesos
{
    partial class det_pago
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
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.efectivo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.devolver = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Enabled = false;
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(126, 98);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(165, 23);
            this.total.TabIndex = 112;
            this.total.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total.UseCustomBackColor = true;
            this.total.UseCustomForeColor = true;
            this.total.UseSelectable = true;
            this.total.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(22, 102);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(98, 19);
            this.metroLabel11.TabIndex = 113;
            this.metroLabel11.Text = "Monto a Pagar";
            // 
            // efectivo
            // 
            this.efectivo.BackColor = System.Drawing.Color.White;
            this.efectivo.Lines = new string[0];
            this.efectivo.Location = new System.Drawing.Point(126, 138);
            this.efectivo.MaxLength = 32767;
            this.efectivo.Name = "efectivo";
            this.efectivo.PasswordChar = '\0';
            this.efectivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.efectivo.SelectedText = "";
            this.efectivo.Size = new System.Drawing.Size(165, 23);
            this.efectivo.TabIndex = 1;
            this.efectivo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.efectivo.UseCustomBackColor = true;
            this.efectivo.UseCustomForeColor = true;
            this.efectivo.UseSelectable = true;
            this.efectivo.UseStyleColors = true;
            this.efectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.efectivo_KeyPress);
            this.efectivo.Validated += new System.EventHandler(this.efectivo_Validated);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 115;
            this.metroLabel1.Text = "Efectivo";
            // 
            // devolver
            // 
            this.devolver.BackColor = System.Drawing.Color.White;
            this.devolver.Enabled = false;
            this.devolver.Lines = new string[0];
            this.devolver.Location = new System.Drawing.Point(126, 177);
            this.devolver.MaxLength = 32767;
            this.devolver.Name = "devolver";
            this.devolver.PasswordChar = '\0';
            this.devolver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.devolver.SelectedText = "";
            this.devolver.Size = new System.Drawing.Size(165, 23);
            this.devolver.TabIndex = 2;
            this.devolver.Theme = MetroFramework.MetroThemeStyle.Light;
            this.devolver.UseCustomBackColor = true;
            this.devolver.UseCustomForeColor = true;
            this.devolver.UseSelectable = true;
            this.devolver.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 181);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 117;
            this.metroLabel2.Text = "Devolver";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(86, 224);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 42);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Aceptar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(189, 224);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 42);
            this.metroButton2.TabIndex = 119;
            this.metroButton2.Text = "Retornar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // det_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 270);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.devolver);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.efectivo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.metroLabel11);
            this.KeyPreview = true;
            this.Name = "det_pago";
            this.Resizable = false;
            this.Text = "Detalle del Pago";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.det_pago_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.det_pago_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox total;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox efectivo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox devolver;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}