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
    public partial class reporte_auditoria : Form
    {
        public reporte_auditoria()
        {
            InitializeComponent();
        }

        private void reporte_auditoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_auditoria' Puede moverla o quitarla según sea necesario.
            this.v_auditoriaTableAdapter.Fill(this.DataSet1.v_auditoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
