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
    public partial class marca : MetroForm
    {
        int est = 0;
        public marca()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            cod_marca.Text = "";
            descripcion.Text = "";
            estado.Checked = false;

            codigo_mayor();
            cambia_estado();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_marca+1) as Mayor from marca";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_marca.Text = numfac;
            descripcion.Select();
        }

        public void ejecutar(string dato)
        {
            cod_marca.Text = dato;
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
            descripcion.Enabled = false;
            cod_marca.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            descripcion.Enabled = true;
            cod_marca.Enabled = true;
            estado.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from marca where cod_marca='" + cod_marca.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
            }
            else
            {
                codigo_mayor();

                descripcion.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && descripcion.Text != "")
            {
                valida_estado();
            }

        }

        private void busca()
        {
            proceso.titulo = "Marcas";
            proceso.query = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1";
            proceso.query_cod = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and cod_marca";
            proceso.query_desc = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and descripcion ";
            proceso.query2 = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and cod_marca=";
        }

        private void marca_Load(object sender, EventArgs e)
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

        private void cod_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void marca_KeyPress(object sender, KeyPressEventArgs e)
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

            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                descripcion.Focus();
                return;
            }
            else
            {
                try
                {


                    string cmd = "exec act_marca '" + cod_marca.Text + "','" + descripcion.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "'";
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
            string cmd = "exec act_marca '" + cod_marca.Text + "','" + descripcion.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "'";
            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();
        }

        private void cod_marca_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {
            if (descripcion.Text.Trim() != "" || estado.Checked == true)
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
            if (descripcion.Text.Trim() != "" || estado.Checked == true)
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
