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

namespace Proyecto_3.inv.mantenimientos
{
    public partial class fallas : MetroForm
    {
        public fallas()
        {
            InitializeComponent();
        }

        int est = 0;

        private void nuevos()
        {
            cod_falla.Text = "";
            desc_falla.Text = "";
            estado.Checked = false;

            codigo_mayor();
            cambia_estado();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_falla+1) as Mayor from fallas";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_falla.Text = numfac;
            desc_falla.Select();
        }

        public void ejecutar(string dato)
        {
            cod_falla.Text = dato;
            validating();
        }

        private void activar()
        {
            nuevo.Enabled = false;
            activar2.Enabled = false;
            salvar.Enabled = false;
        }

        private void desactivar()
        {
            nuevo.Enabled = true;
            salvar.Enabled = true;
        }

        private void valida_estado()
        {
            salvar.Enabled = false;
            desc_falla.Enabled = false;
            cod_falla.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            desc_falla.Enabled = true;
            cod_falla.Enabled = true;
            estado.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from fallas where cod_falla='" + cod_falla.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                desc_falla.Text = Convert.ToString(ds.Tables[0].Rows[0]["desc_falla"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
            }
            else
            {
                codigo_mayor();

                desc_falla.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && desc_falla.Text != "")
            {
                valida_estado();
            }

        }

        private void busca()
        {
            proceso.titulo = "Fallas en Vehículos";
            proceso.query = "select cod_falla as 'Codigo', desc_falla as 'Descripcion' from fallas where estado=1";
            proceso.query_cod = "select cod_falla as 'Codigo', desc_falla as 'Descripcion' from fallas where estado=1 and cod_falla";
            proceso.query_desc = "select cod_falla as 'Codigo', desc_falla as 'Descripcion' from fallas where estado=1 and desc_falla ";
        }

        private void fallas_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            activar();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codigo_mayor();
            activar();
            salvar.Enabled = false;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar);
            form2.ShowDialog();
        }

        private void cod_falla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void desc_falla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void activar2_Click(object sender, EventArgs e)
        {
            est = 1;
            estado.Checked = true;
            string cmd = "exec act_fallas '" + cod_falla.Text + "','" + desc_falla.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "'";
            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();
        }

        private void cod_falla_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void desc_falla_TextChanged(object sender, EventArgs e)
        {
            if (desc_falla.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void estado_Click(object sender, EventArgs e)
        {
            if (desc_falla.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (estado.Checked == true)
                est = 1;
            else
                est = 0;

            if (string.IsNullOrEmpty(desc_falla.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desc_falla.Focus();
                return;
            }
            else
            {
                try
                {


                    string cmd = "exec act_fallas '" + cod_falla.Text + "','" + desc_falla.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                nuevos();
                codigo_mayor();

            }
        }
    }
}
