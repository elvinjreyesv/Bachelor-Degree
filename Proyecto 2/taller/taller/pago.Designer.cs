namespace taller
{
    partial class pago
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
            this.label2 = new System.Windows.Forms.Label();
            this.cod_fact = new MetroFramework.Controls.MetroTextBox();
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.devolver = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recibido = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "Factura";
            // 
            // cod_fact
            // 
            this.cod_fact.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cod_fact.Lines = new string[0];
            this.cod_fact.Location = new System.Drawing.Point(172, 28);
            this.cod_fact.MaxLength = 32767;
            this.cod_fact.Name = "cod_fact";
            this.cod_fact.PasswordChar = '\0';
            this.cod_fact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cod_fact.SelectedText = "";
            this.cod_fact.Size = new System.Drawing.Size(90, 23);
            this.cod_fact.TabIndex = 133;
            this.cod_fact.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cod_fact.UseCustomBackColor = true;
            this.cod_fact.UseCustomForeColor = true;
            this.cod_fact.UseSelectable = true;
            this.cod_fact.UseStyleColors = true;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.HighlightText;
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(172, 80);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(90, 23);
            this.total.TabIndex = 133;
            this.total.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total.UseCustomBackColor = true;
            this.total.UseCustomForeColor = true;
            this.total.UseSelectable = true;
            this.total.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "Total de la Factura";
            // 
            // devolver
            // 
            this.devolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.devolver.Lines = new string[0];
            this.devolver.Location = new System.Drawing.Point(172, 175);
            this.devolver.MaxLength = 32767;
            this.devolver.Name = "devolver";
            this.devolver.PasswordChar = '\0';
            this.devolver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.devolver.SelectedText = "";
            this.devolver.Size = new System.Drawing.Size(90, 23);
            this.devolver.TabIndex = 133;
            this.devolver.Theme = MetroFramework.MetroThemeStyle.Light;
            this.devolver.UseCustomBackColor = true;
            this.devolver.UseCustomForeColor = true;
            this.devolver.UseSelectable = true;
            this.devolver.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 132;
            this.label3.Text = "Monto a Devolver";
            // 
            // recibido
            // 
            this.recibido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.recibido.Lines = new string[0];
            this.recibido.Location = new System.Drawing.Point(172, 127);
            this.recibido.MaxLength = 32767;
            this.recibido.Name = "recibido";
            this.recibido.PasswordChar = '\0';
            this.recibido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recibido.SelectedText = "";
            this.recibido.Size = new System.Drawing.Size(90, 23);
            this.recibido.TabIndex = 133;
            this.recibido.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recibido.UseCustomBackColor = true;
            this.recibido.UseCustomForeColor = true;
            this.recibido.UseSelectable = true;
            this.recibido.UseStyleColors = true;
            this.recibido.Validating += new System.ComponentModel.CancelEventHandler(this.recibido_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 132;
            this.label4.Text = "Monto Recibido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 134;
            // 
            // pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.devolver);
            this.Controls.Add(this.recibido);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cod_fact);
            this.Name = "pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REALIZAR PAGO";
            this.Load += new System.EventHandler(this.pago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox cod_fact;
        private MetroFramework.Controls.MetroTextBox total;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox devolver;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox recibido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}