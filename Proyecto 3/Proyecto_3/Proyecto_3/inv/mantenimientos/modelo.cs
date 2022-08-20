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

namespace Proyecto_3.inv.mantenimientos
{
    public partial class modelo : MetroForm
    {
        int est = 0;
        int cod1 = 0;
        string desm= "";
        int cod3 = 0;

        public modelo()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            cod_modelo.Text = "";
            descripcion.Text = "";
            estado.Checked = false;
            des_marca.Text = "";

            codigo_mayor();
            cambia_estado();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_modelo+1) as Mayor from modelo";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_modelo.Text = numfac;
            descripcion.Select();
        }

        public void ejecutar(string dato)
        {
            valid.Text = dato;
            vali();
        }

        public void ejecutar1(string dato)
        {
            cod_marca.Text = dato;
            validating_marca();
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
            cod_modelo.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            descripcion.Enabled = true;
            cod_modelo.Enabled = true;
            estado.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from modelo where cod_modelo='" + cod_modelo.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
                cod_marca.Text= Convert.ToString(ds.Tables[0].Rows[0]["cod_marca"]);
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

        private void vali()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from modelo where cod_modelo='" + valid.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void validating_marca()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from marca where cod_marca='" + cod_marca.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void busca()
        {
            proceso.titulo = "Modelos";
            proceso.query = "select cod_modelo as 'Codigo', descripcion as 'Descripcion' from modelo where estado=1";
            proceso.query_cod = "select cod_modelo  as 'Codigo', descripcion as 'Descripcion' from modelo where estado=1 and cod_modelo ";
            proceso.query_desc = "select cod_modelo  as 'Codigo', descripcion as 'Descripcion' from modelo where estado=1 and descripcion ";

            proceso.query2 = "select cod_modelo  as 'Codigo', descripcion as 'Descripcion' from modelo where estado=5 and cod_modelo=";
        }


        private void modelo_Load(object sender, EventArgs e)
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
            cod_marca.Text = "";
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar);
            form2.ShowDialog();

            validating_ma();
        }

        private void cod_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void modelo_KeyPress(object sender, KeyPressEventArgs e)
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

            if (string.IsNullOrEmpty(cod_marca.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
               cod_marca.Focus();
                return;
            }
            else
            {
                try
                {
                    string cmd = "exec act_modelo '" + cod_modelo.Text + "','" + descripcion.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "','"+cod_marca.Text + "'";
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
            string cmd = "exec act_modelo '" + cod_modelo.Text + "','" + descripcion.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "','" + cod_marca.Text + "'";
            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();
        }

        private void cod_modelo_Validating(object sender, CancelEventArgs e)
        {
            validating();
            validating_marca();
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

        private void cod_marca_Validating(object sender, CancelEventArgs e)
        {
            validating_ma();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            busca_ma();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_ma);
            form2.ShowDialog();
        }

        private void validating_ma()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from marca where cod_marca='" + cod_marca.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
            }
            else
            {
                codigo_mayor();

                des_marca.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && descripcion.Text != "")
            {
                valida_estado();
            }

        }

        public void ejecutar_ma(string dato)
        {
            cod_marca.Text = dato;
            validating_ma();
        }

        private void busca_ma()
        {
            proceso.titulo = "Marcas";
            proceso.query = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1";
            proceso.query_cod = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and cod_marca";
            proceso.query_desc = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and descripcion ";
            proceso.query2 = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and cod_marca=";
        }

        private void vali_Validating(object sender, CancelEventArgs e)
        {
            vali();
        }

        private void cod_marca_Click(object sender, EventArgs e)
        {

        }
    }
}
