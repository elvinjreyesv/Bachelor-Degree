using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework.Forms;

namespace sistema_administracion_bares
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }


        private void principal_Load(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.ShowDialog();
            rectangulo.Enabled = false;
            rectangulos.Enabled = false;
        }

        private void SALIR_Click_1(object sender, EventArgs e)
        {
            string cmd = string.Format("insert into auditoria (usuario,fechain,fechafn) values('{0}', '{1}', '{2}')", (procesos.usuario), Convert.ToDateTime(procesos.fechain), Convert.ToDateTime(System.DateTime.Now));
            utilidades.UTILIDADES.ejecutar(cmd);
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
        }

        private void rticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            articulos art = new articulos();
            art.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria cat = new categoria();
            cat.ShowDialog();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            almacen alm = new almacen();
            alm.ShowDialog();
        }

        private void suplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedores prov = new proveedores();
            prov.ShowDialog();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unidades un = new unidades();
            un.ShowDialog();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tiposDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tip tipo = new tip();
            tipo.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marca mar = new marca();
            mar.ShowDialog();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

 