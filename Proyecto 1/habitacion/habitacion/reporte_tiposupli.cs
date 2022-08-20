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
    public partial class reporte_tiposupli : Form
    {
        public reporte_tiposupli()
        {
            InitializeComponent();
        }

        private void reporte_tiposupli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_tiposupli' Puede moverla o quitarla según sea necesario.
            this.v_tiposupliTableAdapter.Fill(this.DataSet1.v_tiposupli);

            this.reportViewer1.RefreshReport();
        }
    }
}
