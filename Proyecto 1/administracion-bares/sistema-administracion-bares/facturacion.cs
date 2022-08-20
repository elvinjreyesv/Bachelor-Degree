using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework.Forms;

namespace sistema_administracion_bares
{
    public partial class facturacion : MetroForm
    {
        public facturacion()
        {
            InitializeComponent();

            precio.Enabled = false;
            totales.Enabled = false;

            string fecc = Convert.ToString(System.DateTime.Now);
            string fe = Convert.ToString(System.DateTime.Now);
            try
            {
                fechas.Text = fecc;
                f.Text = fe;
            }
            catch (Exception er)
            { MessageBox.Show(er.ToString()); }
        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 25;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f.Text = DateTime.Now.ToShortDateString();
            fechas.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
