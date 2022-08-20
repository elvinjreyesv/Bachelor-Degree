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

namespace Proyecto_3.otros
{
    public partial class principal2 : MetroForm
    {
        public principal2()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = false;
        }

        private void inicial()
        {
            string cmdd = "select * from empresa";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string  nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
            string telefono = ds.Tables[0].Rows[0]["tel_emp"].ToString();
            string direccion = ds.Tables[0].Rows[0]["dir_emp"].ToString();
        }

        private void principal2_Load(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
            this.Hide();
        }
    }
}
