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
    public partial class reservaciones : MetroForm
    {
        int est;
        public reservaciones()
        {
            InitializeComponent();
        }


        private void reservaciones_Load(object sender, EventArgs e)
        {
                string cmdd = "select max (cod_reservacion+1) as Mayor from reservacion";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_res.Text = numfac;
                cod_mes.Select();

                mostrar();

        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from reservacion";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            cod_res.Clear();
            activo.Checked = false;
            activo.Checked = false;
            cod_mes.Text = "";
            cod_cli.Text = "";
            fecha.Text = "";
            cod_cli.Focus();
        }

        private void consultar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from reservacion";
                    cmd += " where cod_reservacion like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else
            {

                DataSet ds = new DataSet();
                string cmd = "select * from reservacion";
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
            if (string.IsNullOrEmpty(cod_res.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_res.Focus();
                return;

            }
            if (string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_cli.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_mes.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_mes.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha.Focus();
                return;
            }
            if (est == 0)
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                activo.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec act_reservacion '" + cod_res.Text + "','" + cod_mes.Text + "','" + cod_cli.Text + "','" + fecha.Text + "','" + est + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_reservacion+1) as Mayor from reservacion";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_res.Text = numfac;
                cod_cli.Select();

                mostrar();
            }
        }

        private void nuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_reservacion+1) as Mayor from reservacion";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_res.Text = numfac;
            cod_cli.Select();

            mostrar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_res.Text);
                string cmd = "delete from reservacion where cod_reservacion='" + cod_res.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_res.Text = Convert.ToString(c);
                cod_cli.Select();
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
            if (string.IsNullOrEmpty(cod_res.Text) || string.IsNullOrEmpty(cod_cli.Text) || string.IsNullOrEmpty(cod_mes.Text) || string.IsNullOrEmpty(fecha.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (est == 0)
                MessageBox.Show("Fatan datos para continuar");
            else
            {
                string cmd = "update usuarios set cod_reservacion='" + cod_res.Text.Trim() + "', " + "cod_mesa='" + cod_mes.Text.Trim() + "', " + "cod_cliente='" + cod_cli.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "', " + "cod_estado='" + est + "' where cod_reservacion ='" + cod_res.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_reservacion+1) as Mayor from reservacion";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_res.Text = numfac;
                cod_cli.Select();
            }
            mostrar();
        }

        private void salir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_cli_Click(object sender, EventArgs e)
        {
            clientes cli = new clientes();
            cli.ShowDialog();
        }

        private void b_mesas_Click(object sender, EventArgs e)
        {
            mesass me = new mesass();
            me.ShowDialog();
        }

        private void cod_res_Validating_1(object sender, CancelEventArgs e)
        {

            //cod_reservacion from reservacion,cod_mesa,cod_cliente,cod_estado,fecha_reg
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_res.Text.Trim()))
            {
                cmd = "select max(cod_reservacion)as mayor from reservacion";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_res.Text = cod.ToString();
                }
            }
            cmd = "select * from reservacion where cod_reservacion='" + cod_res.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                cod_res.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_reservacion"]);
                cod_mes.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_mesa"]);
                cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_cliente"]);

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);

                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }

        }
    }
}
