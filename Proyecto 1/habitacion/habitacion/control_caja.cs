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
    public partial class control_caja : Form
    {
        public control_caja()
        {
            InitializeComponent();
        }

        private void control_caja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.fechas' Puede moverla o quitarla según sea necesario.
            this.fechasTableAdapter.Fill(this.DataSet1.fechas);

            this.reportViewer1.RefreshReport();
        }
    }
}
