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
    public partial class reporte_productos : Form
    {
        public reporte_productos()
        {
            InitializeComponent();
        }

        private void reporte_productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_productos' Puede moverla o quitarla según sea necesario.
            this.v_productosTableAdapter.Fill(this.DataSet1.v_productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
