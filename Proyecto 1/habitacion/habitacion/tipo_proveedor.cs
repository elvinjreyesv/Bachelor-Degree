using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace habitacion
{
    public partial class tipo_proveedor : Form
    {
        public tipo_proveedor()
        {
            InitializeComponent();
            string cmdd = "select max (codigo+1) as Mayor from tiposupli";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codigo.Text = numfac;
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codigo.Text.Trim()))
            {
                cmd = "select max(codigo)as mayor from tiposupli";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codigo.Text = cod.ToString();
                }
            }
            cmd = "select * from tiposupli where codigo=" + codigo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codigo.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec actualizarsupli " + codigo.Text + ",'" + descripcion.Text + ",'" + System.DateTime.Now + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codigo.Clear();
                    descripcion.Clear();
                    descripcion.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codigo+1) as Mayor from tiposupli";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codigo.Clear();
            descripcion.Clear();
            string cmdd = "select max (codigo+1) as Mayor from tiposupli";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codigo.Text = numfac;
            descripcion.Select();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TIPO DE PROVEEDOR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codigo.Text);
                string cmd = "delete from tiposupli where codigo=" + codigo.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codigo.Clear();
                descripcion.Clear();
                codigo.Text = Convert.ToString(c);
                descripcion.Focus();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " TIPO DE PROVEEDOR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void tipo_proveedor_Load(object sender, EventArgs e)
        {
            descripcion.Select();
        }

        private void descripcion_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                this.errorProvider1.SetError(descripcion, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(descripcion, "");
            }
        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consult_tipprov cs = new consult_tipprov();
            cs.ShowDialog();
            cs.Dispose();
        }
    }
}
