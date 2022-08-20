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
    public partial class reporte_tipoproduct : Form
    {
        public reporte_tipoproduct()
        {
            InitializeComponent();
        }

        private void reporte_tipoproduct_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_tipoproductos' Puede moverla o quitarla según sea necesario.
            this.v_tipoproductosTableAdapter.Fill(this.DataSet1.v_tipoproductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
