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
    public partial class reporte_tipoclient : Form
    {
        public reporte_tipoclient()
        {
            InitializeComponent();
        }

        private void reporte_tipoclient_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_tipocliente' Puede moverla o quitarla según sea necesario.
            this.v_tipoclienteTableAdapter.Fill(this.DataSet1.v_tipocliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
