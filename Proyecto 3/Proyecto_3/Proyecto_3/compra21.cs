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


namespace Proyecto_3
{
    public partial class compra21 : MetroForm
    {
          dtcompra _datosreporte;

         public compra21(dtcompra datos)
        {
            InitializeComponent();

           rep_compra fr = new rep_compra();
            crystalReportViewer1.ReportSource = fr;
            fr.SetDataSource(datos);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void compra21_Load(object sender, EventArgs e)
        {

        }
    }
}
