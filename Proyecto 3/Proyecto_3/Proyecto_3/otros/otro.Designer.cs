namespace Proyecto_3.otros
{
    partial class otro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 605);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.BackColor = System.Drawing.Color.White;
            this.metroUserControl1.BackgroundImage = global::Proyecto_3.Properties.Resources.modelos;
            this.metroUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroUserControl1.Location = new System.Drawing.Point(220, 60);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(641, 590);
            this.metroUserControl1.TabIndex = 15;
            this.metroUserControl1.UseCustomBackColor = true;
            this.metroUserControl1.UseCustomForeColor = true;
            this.metroUserControl1.UseSelectable = true;
            this.metroUserControl1.UseStyleColors = true;
            // 
            // otro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 685);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "otro";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
    }
}



