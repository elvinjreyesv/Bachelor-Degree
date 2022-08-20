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
    public partial class reporte_tipoemp : Form
    {
        public reporte_tipoemp()
        {
            InitializeComponent();
        }

        private void reporte_tipoemp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_tipoemp' Puede moverla o quitarla según sea necesario.
            this.v_tipoempTableAdapter.Fill(this.DataSet1.v_tipoemp);

            this.reportViewer1.RefreshReport();
        }
    }
}
