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
using System.Data.Sql;
using System.Data.SqlClient;


namespace repuesto
{
    public partial class reporte : MetroForm
    {
        public reporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
