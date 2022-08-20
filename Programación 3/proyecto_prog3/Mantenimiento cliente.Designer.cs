namespace proyecto_prog3
{
    partial class Mantenimiento_cliente
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
            this.checkcliente = new System.Windows.Forms.CheckBox();
            this.bcguardar = new System.Windows.Forms.Button();
            this.bcconsultar = new System.Windows.Forms.Button();
            this.bcactualizar = new System.Windows.Forms.Button();
            this.bceliminar = new System.Windows.Forms.Button();
            this.bcsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodcli = new System.Windows.Forms.TextBox();
            this.txtnomcli = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkcliente
            // 
            this.checkcliente.AutoSize = true;
            this.checkcliente.Location = new System.Drawing.Point(49, 139);
            this.checkcliente.Name = "checkcliente";
            this.checkcliente.Size = new System.Drawing.Size(56, 17);
            this.checkcliente.TabIndex = 0;
            this.checkcliente.Text = "Status";
            this.checkcliente.UseVisualStyleBackColor = true;
            this.checkcliente.CheckedChanged += new System.EventHandler(this.checkcliente_CheckedChanged);
            // 
            // bcguardar
            // 
            this.bcguardar.Location = new System.Drawing.Point(132, 232);
            this.bcguardar.Name = "bcguardar";
            this.bcguardar.Size = new System.Drawing.Size(75, 23);
            this.bcguardar.TabIndex = 1;
            this.bcguardar.Text = "Guardar";
            this.bcguardar.UseVisualStyleBackColor = true;
            this.bcguardar.Click += new System.EventHandler(this.bcguardar_Click);
            // 
            // bcconsultar
            // 
            this.bcconsultar.Location = new System.Drawing.Point(287, 232);
            this.bcconsultar.Name = "bcconsultar";
            this.bcconsultar.Size = new System.Drawing.Size(75, 23);
            this.bcconsultar.TabIndex = 2;
            this.bcconsultar.Text = "Consultar";
            this.bcconsultar.UseVisualStyleBackColor = true;
            this.bcconsultar.Click += new System.EventHandler(this.bcconsultar_Click);
            // 
            // bcactualizar
            // 
            this.bcactualizar.Location = new System.Drawing.Point(438, 232);
            this.bcactualizar.Name = "bcactualizar";
            this.bcactualizar.Size = new System.Drawing.Size(75, 23);
            this.bcactualizar.TabIndex = 3;
            this.bcactualizar.Text = "Actualizar";
            this.bcactualizar.UseVisualStyleBackColor = true;
            this.bcactualizar.Click += new System.EventHandler(this.bcactualizar_Click);
            // 
            // bceliminar
            // 
            this.bceliminar.Location = new System.Drawing.Point(576, 232);
            this.bceliminar.Name = "bceliminar";
            this.bceliminar.Size = new System.Drawing.Size(75, 23);
            this.bceliminar.TabIndex = 4;
            this.bceliminar.Text = "eliminar";
            this.bceliminar.UseVisualStyleBackColor = true;
            this.bceliminar.Click += new System.EventHandler(this.bceliminar_Click);
            // 
            // bcsalir
            // 
            this.bcsalir.Location = new System.Drawing.Point(714, 232);
            this.bcsalir.Name = "bcsalir";
            this.bcsalir.Size = new System.Drawing.Size(75, 23);
            this.bcsalir.TabIndex = 5;
            this.bcsalir.Text = "Salir";
            this.bcsalir.UseVisualStyleBackColor = true;
            this.bcsalir.Click += new System.EventHandler(this.bcsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // txtcodcli
            // 
            this.txtcodcli.Location = new System.Drawing.Point(181, 39);
            this.txtcodcli.Name = "txtcodcli";
            this.txtcodcli.Size = new System.Drawing.Size(100, 20);
            this.txtcodcli.TabIndex = 8;
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(181, 89);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.Size = new System.Drawing.Size(100, 20);
            this.txtnomcli.TabIndex = 9;
            // 
            // Mantenimiento_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 314);
            this.Controls.Add(this.txtnomcli);
            this.Controls.Add(this.txtcodcli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcsalir);
            this.Controls.Add(this.bceliminar);
            this.Controls.Add(this.bcactualizar);
            this.Controls.Add(this.bcconsultar);
            this.Controls.Add(this.bcguardar);
            this.Controls.Add(this.checkcliente);
            this.Name = "Mantenimiento_cliente";
            this.Text = "Mantenimiento_cliente";
            this.Load += new System.EventHandler(this.Mantenimiento_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkcliente;
        private System.Windows.Forms.Button bcguardar;
        private System.Windows.Forms.Button bcconsultar;
        private System.Windows.Forms.Button bcactualizar;
        private System.Windows.Forms.Button bceliminar;
        private System.Windows.Forms.Button bcsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodcli;
        private System.Windows.Forms.TextBox txtnomcli;
    }
}