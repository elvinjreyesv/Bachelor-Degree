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
    public partial class tip : MetroForm
    {
        public tip()
        {
            InitializeComponent();
        }

        private void salida_Click(object sender, EventArgs e)
        {

        }

        private void entrada_Click_1(object sender, EventArgs e)
        {
            this.Close();
            movimientos mov = new movimientos();
            mov.ShowDialog();
        }
    }
}
