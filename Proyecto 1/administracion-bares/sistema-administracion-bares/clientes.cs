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
    public partial class clientes : MetroForm
    {
        int est;
        public clientes()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_cliente+1) as Mayor from cliente";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_cli.Text = numfac;
            nombre.Select();

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from tipo_cliente", con);
                da.Fill(ds1);
                t_cli.DataSource = ds1.Tables[0].DefaultView;
                t_cli.ValueMember = "descripcion";
                t_cli.Text = "";
                nombre.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_tcli from tipo_cliente", con);
                da.Fill(ds1);
                codt_cli.DataSource = ds1.Tables[0].DefaultView;
                codt_cli.ValueMember = "cod_tcli";
                //ina.Text = "";
                nombre.Select();
            }

            mostrar();
        }

        public void limpiar()
        {
            cod_cli.Text = "";
            direccion.Text = "";
            telefono.Text = "";
            nom_cli.Text = "";
            ape_cli.Text = "";
            telefono.Text = "";
            codt_cli.Text = "";
            t_cli.Text = "";
            activo.Checked = false;
            ina.Checked = false;
            nom_cli.Focus();
        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from cliente";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
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
                    string cmd = "select * from cliente";
                    cmd += " where cod_cliente like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else

                if (nombre.Checked)
                {
                    if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                    {
                        string cmd = "select * from cliente";
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
                    string cmd = "select * from cliente";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_cli.Focus();
                return;

            }
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE NOMBRE ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                nombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ape_cli.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE APELLIDO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                ape_cli.Focus();
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
            if (string.IsNullOrEmpty(codt_cli.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO DE TIPO DE CLIENTE ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                ina.Focus();
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
                        if (ina.Checked == true)
                            est = 2;
                    string cmd = "exec act_cliente '" + cod_cli.Text + "','" + nom_cli.Text + "','" + ape_cli.Text + "','" + telefono.Text + "','" + correo.Text + "','" + direccion.Text + "','" + est + "','" + codt_cli.Text + "','" + fecha.Value.ToString() + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_cliente+1) as Mayor from cliente";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_cli.Text = numfac;
                nombre.Select();

                mostrar();
            }

        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_cliente+1) as Mayor from cliente";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_cli.Text = numfac;
            nombre.Select();

            mostrar();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_cli.Text);
                string cmd = "delete from cliente where cod_cliente='" + cod_cli.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_cli.Text = Convert.ToString(c);
                nombre.Select();
            }

            mostrar();
        }

        private void actualizar1_Click(object sender, EventArgs e)
        {
            //fecha.Value.Date.ToString("dd/MM/yyyy")

            if (activo.Checked == true)
                est = 1;
            else
                if (ina.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_cli.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(ape_cli.Text) || string.IsNullOrEmpty(correo.Text) || string.IsNullOrEmpty(direccion.Text) || string.IsNullOrEmpty(codt_cli.Text) || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(telefono.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (est == 0)
                MessageBox.Show("Faltan datos para continuar");
            else
            {


                string cmd = "update cliente set cod_cliente='" + cod_cli.Text.Trim() + "', " + "nombre='" + nom_cli.Text.Trim() + "', " + "apellidos='" + ape_cli.Text + "', " + "telefono='" + telefono.Text.Trim() + "', " + "correo='" + correo.Text.Trim() + "', " + "direccion='" + direccion.Text + "', " + "cod_estado='" + est + "', " + "cod_tcli='" + codt_cli.Text + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "' where cod_cliente ='" + cod_cli.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_cliente+1) as Mayor from cliente";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_cli.Text = numfac;
                nombre.Select();
            }
            mostrar();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_cli_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                cmd = "select max(cod_cliente)as mayor from cliente";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_cli.Text = cod.ToString();
                }
            }
            cmd = "select * from cliente where cod_cliente='" + cod_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                nom_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                ape_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellidos"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                correo.Text = Convert.ToString(ds.Tables[0].Rows[0]["correo"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        ina.Checked = true;
                codt_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_tcli"]);
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }

            cmd = "select * from tipo_cliente where cod_tcli='" + codt_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                t_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void codt_cli_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from tipo_cliente where cod_tcli='" + codt_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                t_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

            }
        }

        private void t_cli_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(codt_cli.Text.Trim()))
                return;
            string cmd = string.Format("select * from tipo_cliente where descripcion = '{0}'", t_cli.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                codt_cli.Text = ds.Tables[0].Rows[0]["cod_tcli"].ToString();
            }
            catch
            {
                MessageBox.Show("EL CLIENTE ACTUAL NO EXISTE");
            }
        }

    }
}
