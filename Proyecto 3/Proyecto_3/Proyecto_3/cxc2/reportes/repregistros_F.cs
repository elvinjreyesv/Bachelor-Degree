using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;

namespace Proyecto_3.cxc2.reportes
{
    public partial class repregistros_F : MetroForm
    {
        dtcompra _datosreporte;

        public repregistros_F(dtcompra datos)
        {
            InitializeComponent();

            regfcxc fr = new regfcxc();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void repregistros_F_Load(object sender, EventArgs e)
        {

        }
    }
}
