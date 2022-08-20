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
    public partial class tipo_empleado : Form
    {
        public tipo_empleado()
        {
            InitializeComponent();
            string cmdd = "select max (codtipo+1) as Mayor from tipoemp";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codtipo.Text = numfac;
        }

        private void codtipo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codtipo.Text.Trim()))
            {
                cmd = "select max(codtipo)as mayor from tipoemp";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codtipo.Text = cod.ToString();
                }
            }
            cmd = "select * from tipoemp where codtipo=" + codtipo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codtipo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codtipo.Focus();
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
                    string cmd = "exec actualizartipemp " + codtipo.Text + ",'" +descripcion.Text + ",'" +System.DateTime.Now+ "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codtipo.Clear();
                    descripcion.Clear();
                    descripcion.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codtipo+1) as Mayor from tipoemp";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codtipo.Text = numfac;
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codtipo.Clear();
            descripcion.Clear();
            string cmdd = "select max (codtipo+1) as Mayor from tipoemp";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codtipo.Text = numfac;
            descripcion.Focus();

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TIPO DE EMPLEADO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codtipo.Text);
                string cmd = "delete from tipoemp where codtipo=" + codtipo.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codtipo.Clear();
                descripcion.Clear();
                codtipo.Text = Convert.ToString(c);
                descripcion.Focus();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ABANDONAR LA OPERACION ACTUAL? ", " TIPO DE EMPLEADO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
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

        private void tipo_empleado_Load(object sender, EventArgs e)
        {
            descripcion.Select();
        }

        private void codtipo_KeyPress(object sender, KeyPressEventArgs e)
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
            consult_tipoemp cf = new consult_tipoemp();
            cf.ShowDialog();
            cf.Dispose();
        }
    }
}
