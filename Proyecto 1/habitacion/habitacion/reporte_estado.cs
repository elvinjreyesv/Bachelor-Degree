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
    public partial class reporte_estado : Form
    {
        public reporte_estado()
        {
            InitializeComponent();
        }

        private void reporte_estado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_estado' Puede moverla o quitarla según sea necesario.
            this.v_estadoTableAdapter.Fill(this.DataSet1.v_estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
