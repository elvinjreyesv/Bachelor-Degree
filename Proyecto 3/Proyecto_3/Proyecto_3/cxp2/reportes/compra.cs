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


namespace Proyecto_3.cxp2.reportes
{
    public partial class compra : MetroForm
    {
           dtcompra _datosreporte;

        public compra(dtcompra datos)
        {
            InitializeComponent();

            rep_compra fr = new rep_compra();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }
    }
}
