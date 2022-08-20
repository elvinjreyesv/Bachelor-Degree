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
    public partial class reporte_empleados : Form
    {
        public reporte_empleados()
        {
            InitializeComponent();
        }

        private void reporte_empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_empleados' Puede moverla o quitarla según sea necesario.
            this.v_empleadosTableAdapter.Fill(this.DataSet1.v_empleados);

            this.reportViewer1.RefreshReport();
        }
    }
}
