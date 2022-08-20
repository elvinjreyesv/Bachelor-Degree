using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller
{
    public partial class facturacion2 : Form
    {
        public facturacion2()
        {
            InitializeComponent();
        }

        private void facturacion2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taller_fDataSet.rep_facturacion' Puede moverla o quitarla según sea necesario.
            this.rep_facturacionTableAdapter.Fill(this.taller_fDataSet.rep_facturacion);

         //   pago pg = new pago();
          //  pg.ShowDialog();
            this.reportViewer1.RefreshReport();

           
        }
    }
}
