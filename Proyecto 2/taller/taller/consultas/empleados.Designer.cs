namespace taller.consultas
{
    partial class empleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView1.TabIndex = 43;
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton6.BackgroundImage = global::taller.Properties.Resources._1354069686_search_24;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.Location = new System.Drawing.Point(164, 61);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(35, 23);
            this.metroButton6.TabIndex = 42;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroButton5.Location = new System.Drawing.Point(324, 270);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(79, 27);
            this.metroButton5.TabIndex = 41;
            this.metroButton5.Text = "SALIR";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(51, 61);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(107, 23);
            this.metroTextBox1.TabIndex = 40;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "CONSULTAR EMPLEADOS";
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.label3);
            this.Name = "empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label3;
    }
}