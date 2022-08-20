using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.Reportes
{
    public partial class datos_sesiones : Form
    {
        public datos_sesiones()
        {
            InitializeComponent();
        }

        private void datos_sesiones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
