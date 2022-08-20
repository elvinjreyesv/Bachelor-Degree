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
using System.Windows.Input;
using System.Windows;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace Proyecto_3
{
    public partial class ncf_reg : MetroForm
    {
        string ncf = "";

        public delegate void pasar(string dato);
        public event pasar pasado;

        public ncf_reg()
        {
            InitializeComponent();
        }

        private void ncf_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ncf = "01";
            pasado(Convert.ToString(ncf));
            this.Close();
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ncf = "02";
            pasado(Convert.ToString(ncf));
            this.Close();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            ncf = "14";
            pasado(Convert.ToString(ncf));
            this.Close();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ncf = "15";
            pasado(Convert.ToString(ncf));
            this.Close();
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ncf = "14";
            pasado(Convert.ToString(ncf));
            this.Close();
        }
    }
}
