using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace habitacion
{
    public partial class reporte_fact : Form
    {
        public reporte_fact()
        {
            InitializeComponent();
        }

        private void reporte_fact_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.facturacion' Puede moverla o quitarla según sea necesario.
            this.facturacionTableAdapter.Fill(this.DataSet1.facturacion);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.Refresh();
        }
    }
}
