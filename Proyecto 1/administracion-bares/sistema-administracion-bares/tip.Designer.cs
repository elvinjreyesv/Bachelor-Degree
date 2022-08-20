namespace sistema_administracion_bares
{
    partial class tip
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.salida = new MetroFramework.Controls.MetroButton();
            this.entrada = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // salida
            // 
            this.salida.BackColor = System.Drawing.Color.DodgerBlue;
            this.salida.Location = new System.Drawing.Point(77, 103);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(137, 28);
            this.salida.TabIndex = 0;
            this.salida.Text = "SALIDA DE ARTICULOS";
            this.salida.UseCustomBackColor = true;
            this.salida.UseSelectable = true;
            this.salida.Click += new System.EventHandler(this.salida_Click);
            // 
            // entrada
            // 
            this.entrada.BackColor = System.Drawing.Color.DodgerBlue;
            this.entrada.Location = new System.Drawing.Point(242, 103);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(157, 28);
            this.entrada.TabIndex = 1;
            this.entrada.Text = "ENTRADA DE ARTICULOS";
            this.entrada.UseCustomBackColor = true;
            this.entrada.UseSelectable = true;
            this.entrada.Click += new System.EventHandler(this.entrada_Click_1);
            // 
            // tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(444, 154);
            this.ControlBox = false;
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.salida);
            this.Name = "tip";
            this.ShowIcon = false;
            this.Text = "QUE ACCION DESEAS REALIZAR?";
           // this.Load += new System.EventHandler(this.tip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton entrada;
        private MetroFramework.Controls.MetroButton salida;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;


    }
}