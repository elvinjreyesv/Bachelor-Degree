namespace habitacion
{
    partial class tipo_de_estadia
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
            this.label6 = new System.Windows.Forms.Label();
            this.dias = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.TextBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 81;
            this.label6.Text = "Horas";
            // 
            // dias
            // 
            this.dias.Location = new System.Drawing.Point(210, 75);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(36, 20);
            this.dias.TabIndex = 84;
            this.dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dias_KeyPress);
            // 
            // hora
            // 
            this.hora.Location = new System.Drawing.Point(90, 74);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(48, 20);
            this.hora.TabIndex = 82;
            this.hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hora_KeyPress);
            // 
            // eliminar
            // 
            this.eliminar.Image = global::habitacion.Properties.Resources._1354069451_dialog_close;
            this.eliminar.Location = new System.Drawing.Point(167, 132);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 34);
            this.eliminar.TabIndex = 80;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = global::habitacion.Properties.Resources._1354069571_notepad_24;
            this.nuevo.Location = new System.Drawing.Point(86, 132);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 34);
            this.nuevo.TabIndex = 79;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // salvar
            // 
            this.salvar.Image = global::habitacion.Properties.Resources._1354069627_saveall_24;
            this.salvar.Location = new System.Drawing.Point(5, 132);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 34);
            this.salvar.TabIndex = 78;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // consultar
            // 
            this.consultar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.consultar.Location = new System.Drawing.Point(248, 135);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 34);
            this.consultar.TabIndex = 76;
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(90, 43);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(156, 20);
            this.descripcion.TabIndex = 75;
            this.descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripcion_KeyPress);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(70, 8);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(75, 20);
            this.codigo.TabIndex = 74;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Codigo";
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(329, 135);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 34);
            this.salir.TabIndex = 85;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "Dias";
            // 
            // tipo_de_estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tipo_de_estadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIPO DE ESTADIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dias;
        private System.Windows.Forms.TextBox hora;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label3;
    }
}