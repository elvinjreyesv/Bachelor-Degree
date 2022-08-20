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

namespace Proyecto_3.inv.reportes
{
    public partial class detalle : MetroForm
    {
        dtcompra _datosreporte;

        public detalle()
        {
            InitializeComponent();
        }
        public detalle(dtcompra datos): this()
        {
           _datosreporte = datos;
        }
    
        private void detalle_Load(object sender, EventArgs e)
        {
         elvin _factura = new elvin();
          _factura.SetDataSource(_datosreporte);
          _factura.SetDatabaseLogon("sa", "1110145", "ELVIN-PC", "taller");
        }
    }
}
