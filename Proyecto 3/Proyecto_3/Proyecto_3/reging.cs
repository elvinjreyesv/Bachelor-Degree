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

namespace Proyecto_3
{
    public partial class reging : MetroForm
    {
        dtcompra _datosreporte;

        public reging(dtcompra datos)
        {
            InitializeComponent();

            recibo_ing fr = new recibo_ing();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }


        private void reging_Load(object sender, EventArgs e)
        {

        }
    }
}
