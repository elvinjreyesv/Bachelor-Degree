namespace sistema_administracion_bares
{
    partial class progreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGANDO LA APLICACION";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(46, 109);
            this.progress.Name = "progress";
            this.progress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progress.Size = new System.Drawing.Size(100, 23);
            this.progress.Style = MetroFramework.MetroColorStyle.Blue;
            this.progress.TabIndex = 1;
          //  this.progress.Validating += new System.ComponentModel.CancelEventHandler(this.progress_Validating);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(49, 162);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(90, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Aceptar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(298, 145);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner1.TabIndex = 3;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 60;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(245, 145);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner2.TabIndex = 4;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.Value = 10;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(267, 145);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner3.TabIndex = 5;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 30;
            // 
            // progreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 223);
            this.Controls.Add(this.metroProgressSpinner3);
            this.Controls.Add(this.metroProgressSpinner2);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label1);
            this.Name = "progreso";
            this.Text = "progreso";
            this.Load += new System.EventHandler(this.progreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroProgressBar progress;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
    }
}