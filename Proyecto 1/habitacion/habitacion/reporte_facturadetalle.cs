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
    public partial class reporte_facturadetalle : Form
    {
        public reporte_facturadetalle()
        {
            InitializeComponent();
        }

        private void reporte_facturadetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_facturadetalle' Puede moverla o quitarla según sea necesario.
            this.v_facturadetalleTableAdapter.Fill(this.DataSet1.v_facturadetalle);

            this.reportViewer1.RefreshReport();
        }
    }
}
