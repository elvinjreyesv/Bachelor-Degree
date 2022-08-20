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
    public partial class repconfact : MetroForm
    {
        dtcompra _datosreporte;

        public repconfact(dtcompra datos, dtcompra datos1)
        {
            InitializeComponent();

           com_fac fr = new com_fac();
          // manorepcon fm = new manorepcon();
           
            crystalReportViewer1.ReportSource = fr;
           // crystalReportViewer1.ReportSource = fm;
           // fr.SetDataSource(datos);
          fr.SetDataSource(datos1);
            fr.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }
    }
}
