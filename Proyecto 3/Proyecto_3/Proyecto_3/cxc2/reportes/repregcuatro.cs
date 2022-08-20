using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Proyecto_3.cxc2.reportes
{
    public partial class repregcuatro : MetroForm
    {
        dtcompra _datosreporte;

        public repregcuatro(dtcompra datos)
        {
            InitializeComponent();

            reporte_regcon fr = new reporte_regcon();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");

        }

        private void repregcuatro_Load(object sender, EventArgs e)
        {

        }
    }
}
