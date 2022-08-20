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
using System.Globalization;
using MetroFramework.Forms;

namespace sistema_administracion_bares
{
    public partial class registro_usuarios : MetroForm
    {
        int est;
        public registro_usuarios()
        {
            InitializeComponent();
            cuenta.Select();
        }

        private void registro_usuarios_Load(object sender, EventArgs e)
        {

                cuenta.Select();
                {
                    SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                    DataSet ds1 = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("select nombre from empleado", con);
                    da.Fill(ds1);
                    empleado.DataSource = ds1.Tables[0].DefaultView;
                    empleado.ValueMember = "nombre";
                   empleado.Text = "";
                   empleado.Select();
                }
                mostrar();

        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from usuarios";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            empleado.Text = "";
            cuenta.Select();
            cuenta.Text = "";
            activo.Checked = false;
            cod_emp.Text = "";
            clave.Text = "";
            repetir.Text = "";
            nivel.Text = "";
            inactivo.Checked = false; 
            fecha.Text = "";
            busca.Text = "";
            nombre.Focus();
        }

        private void consultar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (nombre.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from usuarios";
                    cmd += " where usuario like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else
            {

                DataSet ds = new DataSet();
                string cmd = "select * from usuarios";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                data.DataSource = ds.Tables[0];
                busca.Clear();
                busca.Focus();

            }
        }

        private void salvar_Click_1(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cuenta.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cuenta.Focus();
                return;

            }
            if (string.IsNullOrEmpty(cod_emp.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_emp.Focus();
                return;
            }
            if (est == 0)
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                activo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nivel.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                nivel.Focus();
                return;
            }

            if (string.IsNullOrEmpty(clave.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                clave.Focus();
                return;

            }

            else
                if (clave.Text.Trim() != repetir.Text.Trim())
                {
                    MessageBox.Show("LAS CONTRASENAS INGRESADAS NO COINCIDEN");
                    clave.Text = "";
                    repetir.Text = "";
                    clave.Focus();
                    return;

                }
                else
                {
                    try
                    {
                        string cmd = "exec act_usuarios '" + cuenta.Text + "','" + utilidades.UTILIDADES.Encriptar(clave.Text) + "','" + fecha.Text + "','" + nivel.Text + "','" + cod_emp.Text + "','" + est + "'";
                        utilidades.UTILIDADES.ejecutar(cmd);
                        MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                        limpiar();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }
                    cuenta.Select();

                    mostrar();
                }
        }

        private void nuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            mostrar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string cmd = "delete from usuarios where usuario='" + cuenta.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

                cuenta.Select();
            }

            mostrar();
        }

        private void actualizar_Click_1(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cuenta.Text) || string.IsNullOrEmpty(cod_emp.Text) || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(clave.Text) || string.IsNullOrEmpty(nivel.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (est == 0)
                MessageBox.Show("Faltan datos para continuar");
            else
            {
                string cmd = "update usuarios set usuario='" + cuenta.Text.Trim() + "', " + "contrasena='" + clave.Text.Trim() + "', " + "fecha='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "', " + "nivel='" + nivel.Text.Trim() + "', " + "cod_empleado='" + cod_emp.Text.Trim() + "', " + "cod_estado='" + est + "' where usuario ='" + cuenta.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                cuenta.Select();
            }
            mostrar();
        }

        private void salir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuenta_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            if (string.IsNullOrEmpty(cuenta.Text.Trim()))
                return;
            string cmd = string.Format("select * from usuarios where usuario = '{0}'", cuenta.Text.Trim());
            try
            {
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                cod_emp.Text = ds.Tables[0].Rows[0]["cod_empleado"].ToString();
                clave.Text = utilidades.UTILIDADES.Desencriptar(ds.Tables[0].Rows[0]["contrasena"].ToString());
                repetir.Text = utilidades.UTILIDADES.Desencriptar(ds.Tables[0].Rows[0]["contrasena"].ToString());
                nivel.Text = ds.Tables[0].Rows[0]["nivel"].ToString();

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                fecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
            }
            catch
            {

            }



            cmd = "select * from empleado where cod_empleado='" + cod_emp.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                empleado.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
            }
        }
    }
}
