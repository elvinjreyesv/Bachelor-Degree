using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto_prog3
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //facturacion f = new facturacion();
            //f.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facturacion fac = new facturacion();
            fac.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_cliente cli = new Mantenimiento_cliente();
            cli.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_productos pro = new Mantenimiento_productos();
            pro.ShowDialog();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento_departamentos dep = new mantenimiento_departamentos();
            dep.ShowDialog();
        }

    
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_usuarios usu = new Mantenimiento_usuarios();

            usu.ShowDialog();
        }

        
    }
}
