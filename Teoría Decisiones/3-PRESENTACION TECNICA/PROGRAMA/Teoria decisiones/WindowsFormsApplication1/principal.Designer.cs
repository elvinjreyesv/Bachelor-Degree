namespace WindowsFormsApplication1
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem9 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTilePanel1.ForeColor = System.Drawing.Color.Black;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(2, 7);
            this.metroTilePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(215, 454);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1,
            this.metroTileItem2,
            this.metroTileItem3,
            this.metroTileItem9});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.itemContainer1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleStyle.TextColor = System.Drawing.Color.Black;
            this.itemContainer1.TitleText = " Opciones";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.Text = "Inicio";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TileStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem1.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.metroTileItem1.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem1.Click += new System.EventHandler(this.metroTileItem1_Click);
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.Text = "Reportes";
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.metroTileItem2.TileStyle.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.reporter;
            this.metroTileItem2.TileStyle.BackgroundImageAlpha = ((byte)(250));
            this.metroTileItem2.TileStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TileStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem2.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.metroTileItem2.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem2.Click += new System.EventHandler(this.metroTileItem2_Click);
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.Text = "Consultas";
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.search102;
            this.metroTileItem3.TileStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TileStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem3.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.metroTileItem3.Click += new System.EventHandler(this.metroTileItem3_Click);
            // 
            // metroTileItem9
            // 
            this.metroTileItem9.Name = "metroTileItem9";
            this.metroTileItem9.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.metroTileItem9.TileStyle.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sign4;
            this.metroTileItem9.TileStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.metroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem9.TileStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem9.TileStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Far;
            this.metroTileItem9.TileStyle.TextShadowColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroTileItem9.TitleText = "Salir";
            this.metroTileItem9.Click += new System.EventHandler(this.metroTileItem9_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(234)))), ((int)(((byte)(240))))), System.Drawing.Color.DarkTurquoise);
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 520);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(777, 22);
            this.metroStatusBar1.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.ForeColor = System.Drawing.Color.Black;
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(422, 184);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(81, 88);
            this.panel.Style = MetroFramework.MetroColorStyle.Blue;
            this.panel.TabIndex = 6;
            this.panel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panel.UseCustomBackColor = true;
            this.panel.UseCustomForeColor = true;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.label.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(242, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(418, 47);
            this.label.TabIndex = 9;
            this.label.Text = "Ebanistería Manuel Díaz";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(777, 542);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.metroTilePanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "principal";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.StyleChanged += new System.EventHandler(this.Form1_StyleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem9;
        public DevComponents.DotNetBar.ItemContainer itemContainer1;
        public DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        public DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private MetroFramework.Controls.MetroPanel panel;
        private System.Windows.Forms.Label label;
    }
}

