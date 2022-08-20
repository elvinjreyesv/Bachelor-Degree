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
    public partial class empleados : MetroForm
    {
        int est;
        public empleados()
        {
            InitializeComponent();
        }


        private void empleados_Load(object sender, EventArgs e)
        {

            string cmdd = "select max (cod_empleado+1) as Mayor from empleado";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_emp.Text = numfac;
            nombre.Select();

            mostrar();

        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from empleado";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
          
        }

        public void limpiar()
        {
            cod_emp.Clear();
            nombre.Text = "";
            apellido.Text = "";
            correo.Clear();
            direccion.Text = "";
            telefono.Text = "";
            activo.Checked = false;
            inactivo.Checked = false;
            cargo.Text = "";
            cedula.Text = "";
            busca.Text = "";
            nombre.Focus();
        }

        private void consultar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from empleado";
                    cmd += " where cod_empleado like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else

                if (nombree.Checked)
                {
                    if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                    {
                        string cmd = "select * from empleado";
                        cmd += " where nombre like('%" + busca.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        data.DataSource = ds.Tables[0];
                    }
                    busca.Clear();
                    busca.Focus();
                }
                else
                {

                    DataSet ds = new DataSet();
                    string cmd = "select * from empleado";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_emp.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_emp.Focus();
                return;

            }
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE NOMBRE ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                nombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(apellido.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE APELLIDO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                apellido.Focus();
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
                MessageBox.Show("EL CAMPO DE DIRECCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                direccion.Focus();
                return;
            }

            if (est == 0)
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                activo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cargo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CARGO  ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cargo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cedula.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CEDULA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cedula.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha.Focus();
                return;
            }

            else
            {
                try
                {
                    if (activo.Checked == true)
                        est = 1;
                    else
                        if (inactivo.Checked == true)
                            est = 2;
                    string cmd = "exec act_empleado '" + cod_emp.Text + "','" + nombre.Text + "','" + apellido.Text + "','" + telefono.Text + "','" + correo.Text + "','" + direccion.Text + "','" + cargo.Text + "','" + cedula.Text + "','" + est + "','" + fecha.Value.ToString() + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_empleado+1) as Mayor from empleado";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_emp.Text = numfac;
                nombre.Select();

                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_empleado+1) as Mayor from empleado";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_emp.Text = numfac;
            nombre.Select();

            mostrar();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_emp.Text);
                string cmd = "delete from empleado where cod_empleado='" + cod_emp.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_emp.Text = Convert.ToString(c);
                nombre.Select();
            }

            mostrar();
        }

        private void actualizar1_Click(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_emp.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(apellido.Text) || string.IsNullOrEmpty(correo.Text) || string.IsNullOrEmpty(direccion.Text) || string.IsNullOrEmpty(telefono.Text) || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(cedula.Text) || string.IsNullOrEmpty(cargo.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (est == 0)
                MessageBox.Show("Faltan datos para continuar");
            else
            {
                string cmd = "update empleado set cod_empleado='" + cod_emp.Text.Trim() + "', " + "nombre='" + nombre.Text.Trim() + "', " + "apellidos='" + apellido.Text + "', " + "telefono='" + telefono.Text.Trim() + "', " + "correo='" + correo.Text.Trim() + "', " + "direccion='" + direccion.Text + "', " + "cargo='" + cargo.Text.Trim() + "', " + "cedula='" + cedula.Text + "', " + "cod_estado='" + est + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "' where cod_empleado ='" + cod_emp.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_empleado+1) as Mayor from empleado";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_emp.Text = numfac;
                nombre.Select();
            }
            mostrar();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_emp_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_emp.Text.Trim()))
            {
                cmd = "select max(cod_empleado)as mayor from empleado";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_emp.Text = cod.ToString();
                }
            }
            cmd = "select * from empleado where cod_empleado='" + cod_emp.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                apellido.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellidos"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                correo.Text = Convert.ToString(ds.Tables[0].Rows[0]["correo"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                cedula.Text = Convert.ToString(ds.Tables[0].Rows[0]["cedula"]);
                cargo.Text = Convert.ToString(ds.Tables[0].Rows[0]["cargo"]);
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }
        }
    }
}
