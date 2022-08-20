using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace Proyecto_3.cxp2.reportes
{
    public partial class report_pagos : MetroForm
    {
        public report_pagos(dtcompra datos)
        {
            InitializeComponent();

            reppagosrep fr = new reppagosrep();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void report_pagos_Load(object sender, EventArgs e)
        {

        }
    }
}
