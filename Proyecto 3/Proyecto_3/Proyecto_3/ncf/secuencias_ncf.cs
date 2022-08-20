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

namespace Proyecto_3.ncf
{
    public partial class secuencias_ncf : MetroForm
    {
        public secuencias_ncf()
        {
            InitializeComponent();
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd;

            cmd = "select * from ncf where numero='" + "01" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                a01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                a02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "02" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                b01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                b02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "03" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                c01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                c02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "04" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                d01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                d02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "11" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                e01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                e02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "12" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                f01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                f02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "13" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                g01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                g02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "14" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                h01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                h02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

            cmd = "select * from ncf where numero='" + "15" + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            {
                i01.Text = Convert.ToString(ds.Tables[0].Rows[0]["ultimo"]);
                i02.Text = Convert.ToString(ds.Tables[0].Rows[0]["hasta"]);
            }

        }

        private void secuencias_ncf_Load(object sender, EventArgs e)
        {
            validating();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void secuencias_ncf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd;

cmd = "update  ncf set hasta='" + a02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "01" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + b02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "02" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + c02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "03" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + d02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "04" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + e02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "11" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + f02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "12" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + g02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "13" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + h02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "14" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);

cmd = "update  ncf set hasta='" + i02.Text.Trim() + "', " + "fecreg='" + DateTime.Now.ToShortDateString() + "' where numero='" + "15" + "'";
ds = utilidades.UTILIDADES.ejecutar(cmd);
        
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
