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
    public partial class reporte_cliente : Form
    {
        public reporte_cliente()
        {
            InitializeComponent();
        }

        private void reporte_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_cliente' Puede moverla o quitarla según sea necesario.
            this.v_clienteTableAdapter.Fill(this.DataSet1.v_cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
