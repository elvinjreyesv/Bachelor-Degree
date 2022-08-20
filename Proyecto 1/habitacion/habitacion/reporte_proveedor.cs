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
    public partial class reporte_proveedor : Form
    {
        public reporte_proveedor()
        {
            InitializeComponent();
        }

        private void reporte_proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_proveedor' Puede moverla o quitarla según sea necesario.
            this.v_proveedorTableAdapter.Fill(this.DataSet1.v_proveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
