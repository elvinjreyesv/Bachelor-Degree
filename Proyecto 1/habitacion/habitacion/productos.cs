using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace habitacion
{
    public partial class tipo_productos : Form
    {
        public tipo_productos()
        {
            InitializeComponent();
            string cmdd = "select max (codtipo+1) as Mayor from tipoproductos";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codtipo.Text = numfac;
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codtipo.Text.Trim()))
            {
                cmd = "select max(codtipo)as mayor from tipoproductos";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codtipo.Text = cod.ToString();
                }
            }
            cmd = "select * from tipoproductos where codtipo=" + codtipo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                descripprod.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripprod"]);

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
            if (string.IsNullOrEmpty(descripprod.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripprod.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec actualizartipprod " + codtipo.Text + ",'" + descripprod.Text + ",'" + System.DateTime.Now + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codtipo.Clear();
                    descripprod.Text="";
                    descripprod.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codtipo+1) as Mayor from tipoproductos";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codtipo.Text = numfac;
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codtipo.Clear();
            descripprod.Text="";
            descripprod.Focus();
            string cmdd = "select max (codtipo+1) as Mayor from tipoproductos";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codtipo.Text = numfac;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TIPO DE PRODUCTOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codtipo.Text);
                string cmd = "delete from tipoproductos where codtipo=" + codtipo.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codtipo.Clear();
                descripprod.Text="";
                codtipo.Text = Convert.ToString(c);
                descripprod.Focus();
            }
        }

        private void tipo_productos_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
            //tipo de cliente

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select descripprod from tipoproductos", con);
            da.Fill(ds1);
            descripprod.DataSource = ds1.Tables[0].DefaultView;
            descripprod.ValueMember = "descripprod";
            descripprod.Text = "";
            descripprod.Select();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ABANDONAR LA OPERACION ACTUAL? ", " PRODUCTOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void descripprod_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descripprod.Text.Trim()))
            {
                this.errorProvider1.SetError(descripprod, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(descripprod, "");
            }
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

        private void descripprod_KeyPress(object sender, KeyPressEventArgs e)
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
            consultar_art cp = new consultar_art();
            cp.ShowDialog();
            cp.Dispose();
        }
    }
}
