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
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
            string cmdd = "select max (codigo+1) as Mayor from empleados";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codigo.Text = numfac;
            nombre.Select();
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codigo.Text.Trim()))
            {
                cmd = "select max(codigo)as mayor from empleados";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codigo.Text = cod.ToString();
                }
            }
            cmd = "select * from empleados where codigo=" + codigo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
               
                codigo.Text = Convert.ToString(ds.Tables[0].Rows[0]["codigo"]);
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                apellido.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellido"]);
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                cedula.Text = Convert.ToString(ds.Tables[0].Rows[0]["cedula"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                correo.Text = Convert.ToString(ds.Tables[0].Rows[0]["correo"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
                estado.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);

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
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                nombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(apellido.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE APELLIDO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                apellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(telefono.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TELEFONO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                telefono.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cedula.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TELEFONO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cedula.Focus();
                return;
            }


            if (string.IsNullOrEmpty(correo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CORREO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                correo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(direccion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                direccion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(estado.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                estado.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec actualizaremp '" + codigo.Text + "','" + nombre.Text + "','" + apellido.Text + "','" + descripcion.Text + "','" + cedula.Text + "','" + correo.Text + "','" + direccion.Text + "','" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "','" + estado.Text + "','" + telefono.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codigo.Clear();
                    nombre.Clear();
                    apellido.Clear();
                    descripcion.Text = "";
                    telefono.Clear();
                    correo.Clear();
                    direccion.Clear();
                    estado.Clear();
                    cedula.Clear();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codigo+1) as Mayor from empleados";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;
                nombre.Select();
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
             codigo.Clear();
                    nombre.Clear();
                    apellido.Clear();
                    descripcion.Text = "";
                    telefono.Clear();
                    correo.Clear();
                    direccion.Clear();
                    estado.Clear();
                    cedula.Clear();
                string cmdd = "select max (codigo+1) as Mayor from empleados";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;
                nombre.Select();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " CLIENTES ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codigo.Text);
                string cmd = "delete from empleados where codigo=" + codigo.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codigo.Clear();
                nombre.Clear();
                apellido.Clear();
                descripcion.Text = "";
                telefono.Clear();
                correo.Clear();
                cedula.Clear();
                direccion.Clear();
                estado.Clear();
                codigo.Text = Convert.ToString(c);
                nombre.Select();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " EMPLEADOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
            //tipo de cliente

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select descripcion from tipoemp", con);
            da.Fill(ds);
            descripcion.DataSource = ds.Tables[0].DefaultView;
            descripcion.ValueMember = "descripcion";
            descripcion.Text = "";
            nombre.Select();
        }

        private void nombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                this.errorProvider1.SetError(nombre, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(nombre, "");
            }
        }

        private void apellido_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(apellido.Text.Trim()))
            {
                this.errorProvider1.SetError(apellido, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(apellido, "");
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

        private void cedula_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cedula.Text.Trim()))
            {
                this.errorProvider1.SetError(cedula, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(cedula, "");
            }
        }

        private void telefono_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(telefono.Text.Trim()))
            {
                this.errorProvider1.SetError(telefono, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(telefono, "");
            }
        }

        private void direccion_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(direccion.Text.Trim()))
            {
                this.errorProvider1.SetError(direccion, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(direccion, "");
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

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
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
            consult_emple cem = new consult_emple();
            cem.ShowDialog();
            cem.Dispose();
        }
    }
}
