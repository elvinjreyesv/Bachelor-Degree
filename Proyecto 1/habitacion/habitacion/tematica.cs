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
    public partial class tematica : Form
    {
        public tematica()
        {
            InitializeComponent();
            string cmdd = "select max (codtem+1) as Mayor from tematica";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            try
            {
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codtem.Text = numfac;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TEMATICA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codtem.Text);
                string cmd = "delete from tematica where codtem=" + codtem.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codtem.Clear();
                descriptem.Clear();
                precio_t.Clear();
                codtem.Text = Convert.ToString(c);
                descriptem.Focus();
            }
        }

        private void codtem_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codtem.Text.Trim()))
            {
                cmd = "select max(codtem)as mayor from tematica";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codtem.Text = cod.ToString();
                }
            }
            cmd = "select * from tematica where codtem=" + codtem.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                precio_t.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio_t"]);
                descriptem.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriptem"]);

            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codtem.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codtem.Focus();
                return;

            }
            if (string.IsNullOrEmpty(precio_t.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE PRECIO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                precio_t.Focus();
                return;
            }
            if (string.IsNullOrEmpty(descriptem.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descriptem.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec actualizartem '" + codtem.Text + "','" + descriptem.Text + "','" + precio_t.Text + "','" + System.DateTime.Now + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codtem.Clear();
                    descriptem.Clear();
                    precio_t.Clear();
                    descriptem.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codtem+1) as Mayor from tematica";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                // try
                // {
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codtem.Text = numfac;

                // }
                /* catch (Exception er)
                 {
                     MessageBox.Show(er.ToString());
                 }*/

            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codtem.Clear();
            descriptem.Clear();
            precio_t.Clear();
            string cmdd = "select max (codtem+1) as Mayor from tematica";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codtem.Text = numfac;
            descriptem.Focus();
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " TEMATICA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void tematica_Load(object sender, EventArgs e)
        {
            descriptem.Select();
        }

        private void descriptem_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptem.Text.Trim()))
            {
                this.errorProvider1.SetError(descriptem, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(descriptem, " ");
            }
        }

        private void descriptem_Validating(object sender, CancelEventArgs e)
        {
           /* DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codtem.Text.Trim()))
            {
                cmd = "select max(descriptem)as mayor from tematica";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; descriptem.Text = cod.ToString();
                }
            }
            cmd = "select * from tematica where descriptem=" + descriptem.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
               // descriptem.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriptem"]);

            }*/
          
        }

        private void codtem_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codtem.Text.Trim()))
            {
                this.errorProvider1.SetError(codtem, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(codtem, "");
            }
        }

        private void descriptem_TextChanged(object sender, EventArgs e)
        {

        }

        private void codtem_KeyPress(object sender, KeyPressEventArgs e)
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

        private void descriptem_KeyPress(object sender, KeyPressEventArgs e)
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
            consult_temat ct = new consult_temat();
            ct.ShowDialog();
            ct.Dispose();
        }
    }
}
