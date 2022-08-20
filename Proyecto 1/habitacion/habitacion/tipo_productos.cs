using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace habitacion
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
            string cmdd = "select max (codigo+1) as Mayor from productos";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            try
            {
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codigo.Text.Trim()))
            {
                cmd = "select max(codigo)as mayor from productos";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codigo.Text = cod.ToString();
                }
            }
            cmd = "select * from productos where codigo=" + codigo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                descripprod.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripprod"]);
                costo.Text = Convert.ToString(ds.Tables[0].Rows[0]["costo"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
                estado.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
                canexi.Text = Convert.ToString(ds.Tables[0].Rows[0]["canexi"]);

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
            if (string.IsNullOrEmpty(descripprod.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TIPO DE PRODUCTO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripprod.Focus();
                return;
            }
            if (string.IsNullOrEmpty(costo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE COSTO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                costo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(precio.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE PRECIO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                precio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(estado.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                estado.Focus();
                return;
            }
            if (string.IsNullOrEmpty(canexi.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO CANTIDAD EXISTENTE ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                canexi.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec actualizarpro '" + codigo.Text + "','" + descripcion.Text + "','" + descripprod.Text + "','" + costo.Text + "','" + precio.Text + "','" + estado.Text + "','" + canexi.Text + "','" +System.DateTime.Now + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codigo.Clear();
                    descripcion.Clear();
                    descripprod.Text = "";
                    costo.Clear();
                    precio.Clear();
                    estado.Clear();
                    canexi.Clear();
                    descripcion.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codigo+1) as Mayor from productos";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;
            }
        }

        private void tipo_productos_Load(object sender, EventArgs e)
        {
            //descripprod.Select();
            SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
            //tipo de cliente

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select descripprod from tipoproductos", con);
            da.Fill(ds1);
            descripprod.DataSource = ds1.Tables[0].DefaultView;
            descripprod.ValueMember = "descripprod";
            descripprod.Text = "";
            descripcion.Select();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
             codigo.Clear();
                    descripcion.Clear();
                    descripprod.Text = "";
                    costo.Clear();
                    precio.Clear();
                    estado.Clear();
                    canexi.Clear();
                    descripcion.Focus();
                string cmdd = "select max (codigo+1) as Mayor from productos";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;
                descripcion.Focus();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TEMATICA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codigo.Text);
                string cmd = "delete from productos where codigo=" + codigo.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codigo.Clear();
                descripcion.Clear();
                descripprod.Text = "";
                costo.Text = "";
                precio.Text = "";
                estado.Text = "";
                canexi.Text = "";
                codigo.Text = Convert.ToString(c);
                descripcion.Focus();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ABANDONAR LA OPERACION ACTUAL? ", " PRODUCTOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void costo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(costo.Text.Trim()))
            {
                this.errorProvider1.SetError(costo, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(costo, "");
            }
        }

        private void precio_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(precio.Text.Trim()))
            {
                this.errorProvider1.SetError(precio, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(precio, "");
            }
        }

        private void estado_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(estado.Text.Trim()))
            {
                this.errorProvider1.SetError(estado, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(estado, "");
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

        private void costo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void canexi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void consultar_Click(object sender, EventArgs e)
        {
            consult_tipprod cv = new consult_tipprod();
            cv.ShowDialog();
            cv.Dispose();
        }
    }
}
