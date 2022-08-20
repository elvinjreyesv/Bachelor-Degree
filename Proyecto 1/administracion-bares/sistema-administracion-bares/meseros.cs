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
    public partial class meseros : MetroForm
    {
        int est;
        public meseros()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meseros_Load(object sender, EventArgs e)
        {

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select nombre from empleado", con);
                SqlDataAdapter dg = new SqlDataAdapter("select apellidos from empleado", con);
                da.Fill(ds1);
                nombree.DataSource = ds1.Tables[0].DefaultView;
                nombree.ValueMember = "nombre";
                nombree.Text = "";
                fecha.Select();
            }

            string cmdd = "select max (cod_mesero+1) as Mayor from mesero";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_mesero.Text = numfac;
            cod_emp.Select();

           
            mostrar();
        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from mesero";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            cod_emp.Clear();
            activo.Checked = false;
            nombree.Text = "";
            inactivo.Checked = false;
            fecha.Text = "";
            busca.Text = "";
            cod_emp.Focus();
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_mesero.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_mesero.Focus();
                return;

            }
            if (string.IsNullOrEmpty(cod_emp.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO DE EMPLEADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
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

            else
            {
                try
                {
                    string cmd = "exec act_mesero '" + cod_mesero.Text + "','" + cod_emp.Text + "','" + fecha.Text + "','" + est + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_mesero+1) as Mayor from mesero";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_mesero.Text = numfac;
                cod_emp.Select();

                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_mesero+1) as Mayor from mesero";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_mesero.Text = numfac;
            cod_emp.Select();

            mostrar();
        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " MESERO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_mesero.Text);
                string cmd = "delete from mesero where cod_mesero='" + cod_mesero.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_mesero.Text = Convert.ToString(c);
                cod_emp.Select();
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
            if (string.IsNullOrEmpty(cod_mesero.Text) || string.IsNullOrEmpty(cod_emp.Text) || string.IsNullOrEmpty(fecha.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (est == 0)
                MessageBox.Show("Faltan datos para continuar");
            else
            {
                string cmd = "update mesero set cod_mesero='" + cod_mesero.Text.Trim() + "', " + "cod_empleado='" + cod_emp.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "', " + "cod_estado='" + est + "' where cod_mesero ='" + cod_mesero.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_mesero+1) as Mayor from mesero";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_mesero.Text = numfac;
                cod_emp.Select();
            }
            mostrar();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string cmd = "select * from mesero";
                    cmd += " where cod_mesero like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else
            {

                DataSet ds = new DataSet();
                string cmd = "select * from mesero";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                data.DataSource = ds.Tables[0];
                busca.Clear();
                busca.Focus();

            }

        }

        private void cod_mesero_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_mesero.Text.Trim()))
            {
                cmd = "select max(cod_mesero)as mayor from mesero";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_mesero.Text = cod.ToString();
                }
            }
            cmd = "select * from mesero where cod_mesero='" + cod_mesero.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                cod_emp.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_empleado"]);

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }

            cmd = "select * from empleado where cod_empleado='" + cod_emp.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombree.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellidos"]) + " " + Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                // nombree.Text +=" "+ Convert.ToString(ds.Tables[0].Rows[0]["apellidos"]);
            }
        }

        private void cod_emp_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select * from empleado where cod_empleado='" + cod_emp.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombree.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                // nombree.Text +=" "+ Convert.ToString(ds.Tables[0].Rows[0]["apellidos"]);
            }
        }

        private void nombree_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nombree.Text.Trim()))
                return;
            string cmd = string.Format("select * from empleado where nombre = '{0}'", nombree.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                cod_emp.Text = ds.Tables[0].Rows[0]["cod_empleado"].ToString();
            }
            catch
            {
                MessageBox.Show("EL ESTADO ACTUAL NO EXISTE");
            }
        }

        }
    }
