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
    public partial class unidades : MetroForm
    {

        int est = 0;
        public unidades()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            cod_unidad.Text = "";
            des_unidad.Text = "";
            estado.Checked = false;
        }


        private void codigo_mayor()
        {
            string cmdd = "select max (cod_unidad+1) as Mayor from unidades";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_unidad.Text = numfac;
            des_unidad.Select();
        }

        public void ejecutar(string dato)
        {
            cod_unidad.Text = dato;
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
            des_unidad.Enabled = false;
            cod_unidad.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            des_unidad.Enabled = true;
            cod_unidad.Enabled = true;
            estado.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from unidades where cod_unidad='" + cod_unidad.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["des_unidad"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
            }
            else
            {
                codigo_mayor();

                des_unidad.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && des_unidad.Text != "")
            {
                valida_estado();
            }

        }

        private void busca()
        {
            proceso.titulo = "Unidades";
            proceso.query = "select cod_unidad as 'Codigo', des_unidad as 'Descripcion' from unidades where estado=1";
            proceso.query_cod = "select cod_unidad as 'Codigo', des_unidad as 'Descripcion' from unidades where estado=1 and cod_unidad";
            proceso.query_desc = "select cod_unidad as 'Codigo', des_unidad as 'Descripcion' from unidades where estado=1 and des_unidad ";
        }

        private void unidades_Load(object sender, EventArgs e)
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

        private void cod_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void unidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (estado.Checked == true)
                est = 1;
            else
                est = 0;

            if (string.IsNullOrEmpty(des_unidad.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                des_unidad.Focus();
                return;
            }
            else
            {
                try
                {


                    string cmd = "exec act_unidades '" + cod_unidad.Text + "','" + des_unidad.Text + "','" + est + "','" + DateTime.Now.ToShortDateString() + "'";
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

        private void activar2_Click(object sender, EventArgs e)
        {
            est = 1;
            estado.Checked = true;
            string cmd = "exec act_unidades '" + cod_unidad.Text + "','" + des_unidad.Text + "','" + est + "','" + DateTime.Now.ToShortDateString() + "'";
            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();
        }

        private void cod_unidad_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void des_unidad_TextChanged(object sender, EventArgs e)
        {
            if (des_unidad.Text.Trim() != "" || estado.Checked == true)
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
            if (des_unidad.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }
    }
}
