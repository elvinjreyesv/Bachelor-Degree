namespace sistema_administracion_bares
{
    partial class conversion_unidades
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.btnconvertir = new MetroFramework.Controls.MetroButton();
            this.btnregresar = new MetroFramework.Controls.MetroButton();
            this.txtcantidad = new MetroFramework.Controls.MetroTextBox();
            this.cbounidad = new MetroFramework.Controls.MetroComboBox();
            this.cbounidadf = new MetroFramework.Controls.MetroComboBox();
            this.txtresultado = new MetroFramework.Controls.MetroTextBox();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIDAD FINAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "RESULTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "UNIDAD INICIAL";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // btnconvertir
            // 
            this.btnconvertir.BackColor = System.Drawing.Color.AliceBlue;
            this.btnconvertir.Location = new System.Drawing.Point(39, 216);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(85, 28);
            this.btnconvertir.TabIndex = 39;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseCustomBackColor = true;
            this.btnconvertir.UseSelectable = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnregresar.Location = new System.Drawing.Point(139, 216);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(85, 28);
            this.btnregresar.TabIndex = 39;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseCustomBackColor = true;
            this.btnregresar.UseSelectable = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click_1);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcantidad.Lines = new string[0];
            this.txtcantidad.Location = new System.Drawing.Point(39, 90);
            this.txtcantidad.MaxLength = 32767;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.PasswordChar = '\0';
            this.txtcantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcantidad.SelectedText = "";
            this.txtcantidad.Size = new System.Drawing.Size(51, 23);
            this.txtcantidad.TabIndex = 40;
            this.txtcantidad.UseCustomBackColor = true;
            this.txtcantidad.UseSelectable = true;
            // 
            // cbounidad
            // 
            this.cbounidad.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbounidad.FormattingEnabled = true;
            this.cbounidad.ItemHeight = 19;
            this.cbounidad.Items.AddRange(new object[] {
            "unidades",
            "cajas grandes",
            "cajas pequenas"});
            this.cbounidad.Location = new System.Drawing.Point(110, 88);
            this.cbounidad.Name = "cbounidad";
            this.cbounidad.Size = new System.Drawing.Size(115, 25);
            this.cbounidad.TabIndex = 42;
            this.cbounidad.UseSelectable = true;
            // 
            // cbounidadf
            // 
            this.cbounidadf.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbounidadf.FormattingEnabled = true;
            this.cbounidadf.ItemHeight = 19;
            this.cbounidadf.Items.AddRange(new object[] {
            "unidades",
            "cajas grandes",
            "cajas pequenas"});
            this.cbounidadf.Location = new System.Drawing.Point(38, 168);
            this.cbounidadf.Name = "cbounidadf";
            this.cbounidadf.Size = new System.Drawing.Size(115, 25);
            this.cbounidadf.TabIndex = 43;
            this.cbounidadf.UseSelectable = true;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtresultado.Enabled = false;
            this.txtresultado.Lines = new string[0];
            this.txtresultado.Location = new System.Drawing.Point(166, 168);
            this.txtresultado.MaxLength = 32767;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.PasswordChar = '\0';
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtresultado.SelectedText = "";
            this.txtresultado.Size = new System.Drawing.Size(59, 23);
            this.txtresultado.TabIndex = 44;
            this.txtresultado.UseCustomBackColor = true;
            this.txtresultado.UseSelectable = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(207, 194);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(0, 13);
            this.nombre.TabIndex = 45;
            // 
            // conversion_unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.cbounidadf);
            this.Controls.Add(this.cbounidad);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "conversion_unidades";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "conversion Unidades";
            this.Load += new System.EventHandler(this.conversion_unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton btnconvertir;
        private MetroFramework.Controls.MetroButton btnregresar;
        private MetroFramework.Controls.MetroTextBox txtresultado;
        private MetroFramework.Controls.MetroComboBox cbounidadf;
        private MetroFramework.Controls.MetroComboBox cbounidad;
        private MetroFramework.Controls.MetroTextBox txtcantidad;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Label nombre;

    }
}