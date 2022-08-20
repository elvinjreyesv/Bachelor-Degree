using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace repuesto
{
    public partial class principal : MetroForm
    {
        public principal()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cotizar ct = new cotizar();
            ct.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " SOFTWARE R&V ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            login log= new login();
            log.ShowDialog();

            label2.Text = procesos.usuario;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show( procesos.usuario);
        }
    }
}
