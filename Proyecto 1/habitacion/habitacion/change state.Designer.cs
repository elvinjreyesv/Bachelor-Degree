namespace habitacion
{
    partial class change_state
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_state));
            this.label1 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codhab = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.codest = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Habitacion";
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(115, 47);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(108, 21);
            this.estado.TabIndex = 2;
            this.estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado";
            // 
            // codhab
            // 
            this.codhab.FormattingEnabled = true;
            this.codhab.Location = new System.Drawing.Point(163, 15);
            this.codhab.Name = "codhab";
            this.codhab.Size = new System.Drawing.Size(48, 21);
            this.codhab.TabIndex = 1;
            this.codhab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codhab_KeyPress);
            this.codhab.Validating += new System.ComponentModel.CancelEventHandler(this.codhab_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources.descarga__6_1;
            this.pictureBox1.Location = new System.Drawing.Point(274, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(285, 92);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 36);
            this.salir.TabIndex = 4;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_241;
            this.salvar.Location = new System.Drawing.Point(204, 92);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 36);
            this.salvar.TabIndex = 3;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // codest
            // 
            this.codest.FormattingEnabled = true;
            this.codest.Location = new System.Drawing.Point(69, 46);
            this.codest.Name = "codest";
            this.codest.Size = new System.Drawing.Size(40, 21);
            this.codest.TabIndex = 8;
            this.codest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codest_KeyPress);
            this.codest.Validating += new System.ComponentModel.CancelEventHandler(this.codest_Validating);
            // 
            // change_state
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 140);
            this.Controls.Add(this.codest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.codhab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "change_state";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR ESTADO";
            this.Load += new System.EventHandler(this.change_state_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox codhab;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox codest;
    }
}