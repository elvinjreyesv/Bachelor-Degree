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


    public partial class ncf_reg2 : MetroForm
    {

        public delegate void pasar(string dato);
        public event pasar pasado;

        public ncf_reg2()
        {
            InitializeComponent();
        }

        private void ncf_reg2_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
          string  ncf = "11";
            pasado(Convert.ToString(ncf));
            this.Close();
        }

        private void metroRadioButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
