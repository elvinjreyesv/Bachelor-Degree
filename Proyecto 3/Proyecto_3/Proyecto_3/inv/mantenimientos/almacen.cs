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
    public partial class almacen : MetroForm
    {
        int est = 0;

        public almacen()
        {
            InitializeComponent();
            codigo.Select();
        }

        private void nuevos()
        {
            nombre.Text = "";
            ubic.Text = "";
            estado.Checked = false;

            codigo_mayor();
            cambia_estado();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_alm+1) as Mayor from almacen";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codigo.Text = numfac;
            nombre.Select();
        }

        public void ejecutar(string dato)
        {
            codigo.Text = dato;
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
            nombre.Enabled = false;
            codigo.Enabled = false;
            ubic.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            nombre.Enabled = true;
            codigo.Enabled = true;
            ubic.Enabled = true;
            estado.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from almacen where cod_alm='" + codigo.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                ubic.Text = Convert.ToString(ds.Tables[0].Rows[0]["ubicacion"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
            }
            else
            {
                codigo_mayor();

                nombre.Text = "";
                ubic.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && nombre.Text != "")
            {
                valida_estado();
            }

        }

        private void busca()
        {
            proceso.titulo = "Almacén";
            proceso.query = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where estado=1";
            proceso.query_cod = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where estado=1 and cod_alm";
            proceso.query_desc = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where estado=1 and descrip ";
        }

        private void almacen_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            activar();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar);
            form2.ShowDialog();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codigo_mayor();
            activar();
            salvar.Enabled = false;
        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void almacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            //  SendKeys.Send("{TAB}");
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (estado.Checked == true)
                est = 1;
            else
                est = 0;

            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nombre.Focus();
                return;
            }
            else
            {
                try
                {


                    string cmd = "exec act_almacen '" + codigo.Text + "','" + nombre.Text + "','" + DateTime.Now.ToShortDateString() + "','" + ubic.Text + "','" + est + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                nuevos();
                codigo_mayor();
                activar();
            }
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void activar_Click(object sender, EventArgs e)
        {
            est = 1;
            estado.Checked = true;

            string cmd = "exec act_almacen '" + codigo.Text + "','" + nombre.Text + "','" + DateTime.Now.ToShortDateString() + "','" + ubic.Text + "','" + est + "'";
            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();

        }

        private void codigo_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            if (nombre.Text.Trim() != "" || ubic.Text.Trim() != "" || estado.Checked==true)
            {
                desactivar();
            }
            else
            {
                activar();
            }

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
            validating();
        }

        private void nombre_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void ubic_TextChanged(object sender, EventArgs e)
        {
            if (nombre.Text.Trim() != "" || ubic.Text.Trim() != "" || estado.Checked == true)
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
            if (nombre.Text.Trim() != "" || ubic.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
