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
    public partial class reporte_estadia : Form
    {
        public reporte_estadia()
        {
            InitializeComponent();
        }

        private void reporte_estadia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_estadia' Puede moverla o quitarla según sea necesario.
            this.v_estadiaTableAdapter.Fill(this.DataSet1.v_estadia);

            this.reportViewer1.RefreshReport();
        }
    }
}
