using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using MetroFramework;


namespace WindowsFormsApplication1
{
    public partial class principal : MetroForm
    {
        public principal()
        {
            InitializeComponent();

            localizacion();
        }

        private void cerrar()
        {
            panel.Controls.Clear();
        }

        private void localizacion()
        {
            label.Location = new Point(450, 10);
            panel.Location = new Point(239, 73);
            panel.Size = new Size(1100, 580);
            panel.Controls.Add(new imagen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTileItem9_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Desea Salir de la Aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                cerrar();
                this.Close();
                Application.Exit();
                Application.Exit();
                Application.Exit();
            }
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            cerrar();
           localizacion();

           metroTileItem1.Click -= metroTileItem1_Click;
           metroTileItem2.Click += metroTileItem2_Click;
           metroTileItem3.Click += metroTileItem3_Click;

        }

        private void Form1_StyleChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {

            MetroMessageBox.Show(this, "En Desarrollo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
            cerrar();

            panel.Controls.Add(new consultas());
            var child = new consultas();
            child.Location = new Point(239, 73);
            child.Size = new Size(1100, 580);
            child.Visible = true; this.Controls.Add(child);

            metroTileItem3.Click -= metroTileItem3_Click;
            metroTileItem1.Click += metroTileItem1_Click;
            metroTileItem2.Click += metroTileItem2_Click;
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            cerrar();

            panel.Controls.Add(new Reportes());

            var child = new Reportes();
            child.Location = new Point(239, 73);
            child.Size = new Size(1100, 580);
            child.Visible = true; this.Controls.Add(child);

            metroTileItem2.Click -= metroTileItem2_Click;
            metroTileItem3.Click += metroTileItem3_Click;
            metroTileItem1.Click += metroTileItem1_Click;
        }

    }
}
