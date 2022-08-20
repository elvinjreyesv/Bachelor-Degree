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
    public partial class ncf_general : MetroForm
    {
        public ncf_general()
        {
            InitializeComponent();
        }

        private void validating()
        {
            string cmd;
            DataSet ds = new DataSet();
           cmd = "select * from ncf_general where numero='"+"01"+"'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
                fiscal.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "02" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                final.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "04" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                credito.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "14" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                especiales.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "11" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                informales.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "13" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                menores.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "12" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                ingresos.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "15" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                gubernamentales.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                cmd = "select * from ncf_general where numero='" + "03" + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                debito.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
        }

        private void save()
        {
            var cadena = final.Text;
            var cadena1 = fiscal.Text;
            var cadena2 = gubernamentales.Text;
            var cadena3 = especiales.Text;
            var cadena4 = credito.Text;
            var cadena5 = informales.Text;
            var cadena6 = menores.Text;
            var cadena7 = debito.Text;
            var cadena8 = ingresos.Text;

            if (string.IsNullOrEmpty(final.Text.Trim()) || cadena.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                final.Select();
                return;
            }
            if (string.IsNullOrEmpty(fiscal.Text.Trim()) || cadena1.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fiscal.Select();
                return;
            }
            if (string.IsNullOrEmpty(gubernamentales.Text.Trim()) || cadena2.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gubernamentales.Select();
                return;
            }
            if (string.IsNullOrEmpty(especiales.Text.Trim()) || cadena3.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                especiales.Select();
                return;
            }
            if (string.IsNullOrEmpty(credito.Text.Trim()) || cadena4.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                credito.Select();
                return;
            }
            if (string.IsNullOrEmpty(informales.Text.Trim()) || cadena5.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                informales.Select();
                return;
            }
            if (string.IsNullOrEmpty(ingresos.Text.Trim()) || cadena8.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ingresos.Select();
                return;
            }
            if (string.IsNullOrEmpty(menores.Text.Trim()) || cadena6.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menores.Select();
                return;
            }
            if (string.IsNullOrEmpty(debito.Text.Trim()) || cadena7.Length != 11)
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                debito.Select();
                return;
            }
            else
            {
                try
                {
                    DataSet ds = new DataSet();
                    string cmd;

                    cmd = "update  ncf_general set descrip='" + fiscal.Text.Trim() + "' where numero='" + "01" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + final.Text.Trim() + "' where numero='" + "02" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + debito.Text.Trim() + "' where numero='" + "03" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + credito.Text.Trim() + "' where numero='" + "04" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + informales.Text.Trim() + "' where numero='" + "11" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + ingresos.Text.Trim() + "' where numero='" + "12" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + menores.Text.Trim() + "' where numero='" + "13" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + especiales.Text.Trim() + "' where numero='" + "14" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);

                    cmd = "update  ncf_general set descrip='" + gubernamentales.Text.Trim() + "' where numero='" + "15" + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                }

                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                validating();

            }
        }

        private void ncf_general_Load(object sender, EventArgs e)
        {
            validating();
       
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
