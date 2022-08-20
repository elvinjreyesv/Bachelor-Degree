namespace habitacion
{
    partial class consult_habit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consult_habit));
            this.codigo = new System.Windows.Forms.CheckBox();
            this.todos = new System.Windows.Forms.CheckBox();
            this.nombre = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consultar = new System.Windows.Forms.TextBox();
            this.SSS = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(345, 46);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(88, 17);
            this.codigo.TabIndex = 31;
            this.codigo.Text = "Por Codigo";
            this.codigo.UseVisualStyleBackColor = true;
            this.codigo.CheckedChanged += new System.EventHandler(this.codigo_CheckedChanged);
            // 
            // todos
            // 
            this.todos.AutoSize = true;
            this.todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todos.Location = new System.Drawing.Point(345, 23);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(61, 17);
            this.todos.TabIndex = 30;
            this.todos.Text = "Todos";
            this.todos.UseVisualStyleBackColor = true;
            this.todos.CheckedChanged += new System.EventHandler(this.todos_CheckedChanged);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(345, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(90, 17);
            this.nombre.TabIndex = 29;
            this.nombre.Text = "Por nombre";
            this.nombre.UseVisualStyleBackColor = true;
            this.nombre.CheckedChanged += new System.EventHandler(this.nombre_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // consultar
            // 
            this.consultar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.consultar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.consultar.Location = new System.Drawing.Point(107, 18);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(121, 20);
            this.consultar.TabIndex = 26;
            // 
            // SSS
            // 
            this.SSS.AutoSize = true;
            this.SSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSS.Location = new System.Drawing.Point(12, 19);
            this.SSS.Name = "SSS";
            this.SSS.Size = new System.Drawing.Size(89, 15);
            this.SSS.TabIndex = 25;
            this.SSS.Text = "CONSULTAR";
            // 
            // salir
            // 
            this.salir.Image = global::habitacion.Properties.Resources._1354069449_misc_17;
            this.salir.Location = new System.Drawing.Point(344, 226);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 35);
            this.salir.TabIndex = 28;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // buscar
            // 
            this.buscar.Image = global::habitacion.Properties.Resources._1354069525_view_24;
            this.buscar.Location = new System.Drawing.Point(254, 227);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 34);
            this.buscar.TabIndex = 24;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::habitacion.Properties.Resources._1354036530_Zoom_Out_01;
            this.pictureBox1.Location = new System.Drawing.Point(239, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // consult_habit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::habitacion.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.todos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.SSS);
            this.Controls.Add(this.buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consult_habit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR";
            this.Load += new System.EventHandler(this.consult_habit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox codigo;
        private System.Windows.Forms.CheckBox todos;
        private System.Windows.Forms.CheckBox nombre;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox consultar;
        private System.Windows.Forms.Label SSS;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}