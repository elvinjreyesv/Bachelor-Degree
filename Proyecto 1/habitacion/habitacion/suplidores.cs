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
    public partial class suplidores : Form
    {
        public suplidores()
        {
            InitializeComponent();
            string cmdd = "select max (codigo+1) as Mayor from proveedor";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codigo.Text = numfac;
            proveedor.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codigo.Text.Trim()))
            {
                cmd = "select max(codigo)as mayor from proveedor";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codigo.Text = cod.ToString();
                }
            }
            cmd = "select * from proveedor where codigo=" + codigo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //proveedor(codigo,proveedor,apellido,direccion,telefono ,correo,descripcion ,fecha
                codigo.Text = Convert.ToString(ds.Tables[0].Rows[0]["codigo"]);
                proveedor.Text = Convert.ToString(ds.Tables[0].Rows[0]["proveedor"]);
                apellido.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellido"]);
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                correo.Text = Convert.ToString(ds.Tables[0].Rows[0]["correo"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);

            }
        }

        private void suplidores_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select descripcion from tiposupli", con);
            da.Fill(ds);
            descripcion.DataSource = ds.Tables[0].DefaultView;
            descripcion.ValueMember = "descripcion";
            descripcion.Text = "";
            proveedor.Select();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            //proveedor(codigo,proveedor,apellido,direccion,telefono ,correo,descripcion ,fecha
            codigo.Clear();
            proveedor.Clear();
            apellido.Clear();
            descripcion.Text = "";
            telefono.Clear();
            correo.Clear();
            direccion.Clear();
            string cmdd = "select max (codigo+1) as Mayor from proveedor";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codigo.Text = numfac;
            proveedor.Select();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " PROVEEDOR ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codigo.Text);
                string cmd = "delete from proveedor where codigo=" + codigo.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codigo.Clear();
                proveedor.Clear();
                apellido.Clear();
                descripcion.Text = "";
                telefono.Clear();
                correo.Clear();
               // cedula.Clear();
                direccion.Clear();
               // estado.Clear();
                codigo.Text = Convert.ToString(c);
                proveedor.Select();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codigo.Focus();
                return;

            }
            if (string.IsNullOrEmpty(proveedor.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                proveedor.Focus();
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
            else
            {
                try
                {
                                                                                        //proveedor(codigo,proveedor,apellido,direccion,telefono ,correo,descripcion ,fecha
                    string cmd = "exec actualizarprov '" + codigo.Text + "','" + proveedor.Text + "','" + apellido.Text + "','" + direccion.Text + "','" + telefono.Text + "','" + correo.Text + "','" + descripcion.Text + "','" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codigo.Clear();
                    proveedor.Clear();
                    apellido.Clear();
                    descripcion.Text = "";
                    telefono.Clear();
                    correo.Clear();
                    direccion.Clear();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codigo+1) as Mayor from proveedor";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codigo.Text = numfac;
                proveedor.Select();
            }
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consult_provee cp = new consult_provee();
            cp.ShowDialog();
            cp.Dispose();
        }
    }
}
