using System;
using System.Collections.Generic;
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

namespace Proyecto_3
{
    public partial class prueba : MetroForm
    {

        dtcompra _datosreporte;

        public prueba(dtcompra datos)
        {
            InitializeComponent();

            ultimo fr = new ultimo();
            crystalReportViewer2.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");

        }

        private void prueba_Load(object sender, EventArgs e)
        {
         //   ReportDocument o = new ReportDocument();
          //  o.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void prueba_Load_1(object sender, EventArgs e)
        {

        }
    }
}
