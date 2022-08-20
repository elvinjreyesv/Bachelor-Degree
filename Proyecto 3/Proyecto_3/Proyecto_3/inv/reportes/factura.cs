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

namespace Proyecto_3.inv.reportes
{
    public partial class factura : MetroForm
    {
        public factura()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            this.Refresh();
            //_factura.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }

        private void factura_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
