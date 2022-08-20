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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
namespace Proyecto_3.inv.procesos
{
    public partial class det_pago : MetroForm
    {
        public det_pago()
        {
            InitializeComponent();
        }

        CultureInfo us = new CultureInfo("en-US");

        private void det_pago_Load(object sender, EventArgs e)
        {
            total.Text = proceso.costo;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            inv.reportes.factura ds = new reportes.factura();
            ds.ShowDialog();
            this.Hide();


        }

        private void efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (efectivo.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '\b') { e.Handled = false; }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '.' || e.KeyChar == '\b') { e.Handled = false; }
            }
        }

        private void efectivo_Validated(object sender, EventArgs e)
        {
            string elvin = total.Text;
            float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
            string p = Convert.ToString(num3);

            string elvin1 = efectivo.Text;
            float num1 = float.Parse(elvin1, CultureInfo.InvariantCulture.NumberFormat);
            string p1 = Convert.ToString(num1);

            if (num1 >= num3)
            {
                double y = Convert.ToDouble(p1) - Convert.ToDouble(p);
                string ll2 = y.ToString("0.00", us);
                devolver.Text = ll2;
            }
            else
            {
                MetroMessageBox.Show(this, "Cantidad No válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                efectivo.Select();
                return;
            }
        }

        private void det_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
