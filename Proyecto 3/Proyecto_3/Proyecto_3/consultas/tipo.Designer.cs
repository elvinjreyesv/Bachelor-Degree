namespace Proyecto_3.consultas
{
    partial class tipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titulo1 = new MetroFramework.Controls.MetroLabel();
            this.nombre = new MetroFramework.Controls.MetroRadioButton();
            this.codigo = new MetroFramework.Controls.MetroRadioButton();
            this.buscar = new MetroFramework.Controls.MetroTextBox();
            this.data = new MetroFramework.Controls.MetroGrid();
            this.data1 = new MetroFramework.Controls.MetroGrid();
            this.salir = new MetroFramework.Controls.MetroButton();
            this.seleccionar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titulo1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.titulo1.Location = new System.Drawing.Point(188, 11);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(17, 25);
            this.titulo1.TabIndex = 16;
            this.titulo1.Text = " ";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(503, 50);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(88, 15);
            this.nombre.TabIndex = 15;
            this.nombre.Text = "Por Nombre";
            this.nombre.UseSelectable = true;
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(503, 29);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(83, 15);
            this.codigo.TabIndex = 14;
            this.codigo.Text = "Por Código";
            this.codigo.UseSelectable = true;
            this.codigo.Click += new System.EventHandler(this.codigo_Click);
            // 
            // buscar
            // 
            this.buscar.Lines = new string[0];
            this.buscar.Location = new System.Drawing.Point(24, 48);
            this.buscar.MaxLength = 32767;
            this.buscar.Name = "buscar";
            this.buscar.PasswordChar = '\0';
            this.buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buscar.SelectedText = "";
            this.buscar.Size = new System.Drawing.Size(239, 23);
            this.buscar.TabIndex = 0;
            this.buscar.UseCustomBackColor = true;
            this.buscar.UseCustomForeColor = true;
            this.buscar.UseSelectable = true;
            this.buscar.UseStyleColors = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            this.buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscar_KeyPress);
            this.buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscar_KeyUp);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.data.Location = new System.Drawing.Point(24, 73);
            this.data.Name = "data";
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.data.Size = new System.Drawing.Size(589, 193);
            this.data.TabIndex = 12;
            this.data.UseCustomBackColor = true;
            this.data.UseCustomForeColor = true;
            this.data.UseStyleColors = true;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            this.data.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentDoubleClick);
            this.data.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellValidated);
            this.data.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.data_CellValidating);
            this.data.Click += new System.EventHandler(this.data_Click);
            this.data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_KeyDown);
            this.data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.data_KeyPress);
            // 
            // data1
            // 
            this.data1.AllowUserToAddRows = false;
            this.data1.AllowUserToResizeRows = false;
            this.data1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data1.DefaultCellStyle = dataGridViewCellStyle5;
            this.data1.Enabled = false;
            this.data1.EnableHeadersVisualStyles = false;
            this.data1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data1.Location = new System.Drawing.Point(49, 271);
            this.data1.Name = "data1";
            this.data1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data1.Size = new System.Drawing.Size(549, 61);
            this.data1.Style = MetroFramework.MetroColorStyle.Blue;
            this.data1.TabIndex = 19;
            this.data1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.BackgroundImage = global::Proyecto_3.Properties.Resources.salir;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salir.Location = new System.Drawing.Point(322, 338);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(105, 39);
            this.salir.Style = MetroFramework.MetroColorStyle.Blue;
            this.salir.TabIndex = 21;
            this.salir.Text = "Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salir.UseCustomBackColor = true;
            this.salir.UseCustomForeColor = true;
            this.salir.UseSelectable = true;
            this.salir.UseStyleColors = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // seleccionar
            // 
            this.seleccionar.BackColor = System.Drawing.Color.LightGray;
            this.seleccionar.BackgroundImage = global::Proyecto_3.Properties.Resources.activar;
            this.seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seleccionar.Location = new System.Drawing.Point(215, 338);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(105, 39);
            this.seleccionar.Style = MetroFramework.MetroColorStyle.Blue;
            this.seleccionar.TabIndex = 20;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seleccionar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seleccionar.UseCustomBackColor = true;
            this.seleccionar.UseCustomForeColor = true;
            this.seleccionar.UseSelectable = true;
            this.seleccionar.UseStyleColors = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click_1);
            // 
            // tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 384);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.titulo1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.data);
            this.KeyPreview = true;
            this.Name = "tipo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Load += new System.EventHandler(this.tipo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel titulo1;
        private MetroFramework.Controls.MetroRadioButton nombre;
        private MetroFramework.Controls.MetroRadioButton codigo;
        private MetroFramework.Controls.MetroTextBox buscar;
        public MetroFramework.Controls.MetroGrid data;
        public MetroFramework.Controls.MetroGrid data1;
        private MetroFramework.Controls.MetroButton salir;
        private MetroFramework.Controls.MetroButton seleccionar;
    }
}