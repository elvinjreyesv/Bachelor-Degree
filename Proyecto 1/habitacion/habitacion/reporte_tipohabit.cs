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
    public partial class reporte_tipohabit : Form
    {
        public reporte_tipohabit()
        {
            InitializeComponent();
        }

        private void reporte_tipohabit_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_tipohab' Puede moverla o quitarla según sea necesario.
            this.v_tipohabTableAdapter.Fill(this.DataSet1.v_tipohab);

            this.reportViewer1.RefreshReport();
        }
    }
}
