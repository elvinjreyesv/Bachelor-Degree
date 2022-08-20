using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller
{
    public partial class pago : Form
    {
        public pago()
        {
            InitializeComponent();
        }

        private void pago_Load(object sender, EventArgs e)
        {
            cod_fact.Text = prcesos.numerof;
            total.Text = prcesos.total;
        }

        private void recibido_Validating(object sender, CancelEventArgs e)
        {
            int g=Convert.ToInt16(recibido.Text);
            int s=Convert.ToInt16(total.Text);
            if (g < s)
            { MessageBox.Show("valores incorrectos"); }
            else
            {
                devolver.Text = Convert.ToString(s-g);
                label5.Text = "0.00";
            }
        }
    }
}
