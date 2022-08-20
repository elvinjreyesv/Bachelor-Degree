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
    public partial class dos : MetroForm
    {
        dtcompra _datosreporte;

        public dos(dtcompra datos)
        {
            InitializeComponent();

            dos1 fr = new dos1();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void dos_Load(object sender, EventArgs e)
        {

        }
    }
}
