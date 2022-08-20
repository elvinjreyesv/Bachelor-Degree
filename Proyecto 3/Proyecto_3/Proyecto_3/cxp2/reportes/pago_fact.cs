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

namespace Proyecto_3.cxp2.reportes
{
    public partial class pago_fact : MetroForm
    {
         dtcompra _datosreporte;

        public pago_fact(dtcompra datos)
        {
            InitializeComponent();

            pago_fact_rep fr = new pago_fact_rep();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void pago_fact_Load(object sender, EventArgs e)
        {

        }
    }
}
