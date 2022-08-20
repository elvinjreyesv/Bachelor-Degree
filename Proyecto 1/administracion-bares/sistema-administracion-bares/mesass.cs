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
    public partial class mesass : MetroForm
    {
        int est;
        public mesass()
        {
            InitializeComponent();
        }

        private void mesass_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_mesa+1) as Mayor from mesa";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_mesa.Text = numfac;
            descripcion.Select();

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_tipo from tipo_mesa", con);
                da.Fill(ds1);
                tipo_mesa.DataSource = ds1.Tables[0].DefaultView;
                tipo_mesa.ValueMember = "cod_tipo";
                tipo_mesa.Text = "";
                descripcion.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from tipo_mesa", con);
                da.Fill(ds1);
                des_tmesa.DataSource = ds1.Tables[0].DefaultView;
                des_tmesa.ValueMember = "descripcion";
                des_tmesa.Text = "";
                descripcion.Select();
            }

            mostrar();
        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from mesa";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            descripcion.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            tipo_mesa.Text = "";
            des_tmesa.Text = "";
            sillas.Text = "";
            ubicacion.Text = "";
            descripcion.Focus();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from mesa";
                    cmd += " where cod_mesa like('%" + busca.Text.Trim() + "%')";
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
                        string cmd = "select * from mesa";
                        cmd += " where descripcion like('%" + busca.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        data.DataSource = ds.Tables[0];
                    }
                    busca.Clear();
                    busca.Focus();
                }
                else
                {

                    DataSet ds = new DataSet();
                    string cmd = "select * from mesa";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_mesa.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_mesa.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(sillas.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CANTIDAD DE SILLAS ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                sillas.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ubicacion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE UBICACION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                ubicacion.Focus();
                return;

            }
            if (string.IsNullOrEmpty(tipo_mesa.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TIPO DE MESA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                tipo_mesa.Focus();
                return;
            }
            if (est == 0)
            {
                MessageBox.Show("EL CAMPO DE CODIGO DE ESTADO DE SILLAS ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
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

                    string cmd = "exec act_mesa '" + cod_mesa.Text + "','" + descripcion.Text + "','" + sillas.Text + "','" + ubicacion.Text + "','" + tipo_mesa.Text + "','" + est + "','" + fecha.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_mesa+1) as Mayor from mesa";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_mesa.Text = numfac;
                descripcion.Select();

                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_mesa+1) as Mayor from mesa";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_mesa.Text = numfac;
            descripcion.Select();

            mostrar();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_mesa.Text);
                string cmd = "delete from mesa where cod_mesa='" + cod_mesa.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_mesa.Text = Convert.ToString(c);
                descripcion.Select();
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
            if (string.IsNullOrEmpty(cod_mesa.Text) || string.IsNullOrEmpty(descripcion.Text) || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(sillas.Text) || string.IsNullOrEmpty(ubicacion.Text) || string.IsNullOrEmpty(tipo_mesa.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cmd = "update mesa set cod_mesa='" + cod_mesa.Text.Trim() + "', " + "descripcion='" + descripcion.Text.Trim() + "', " + "cantidad_sillas='" + sillas.Text.Trim() + "', " + "ubicacion='" + ubicacion.Text.Trim() + "', " + "cod_tipo='" + tipo_mesa.Text.Trim() + "', " + "cod_estado='" + est + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "' where cod_mesa ='" + cod_mesa.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_mesa+1) as Mayor from mesa";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_mesa.Text = numfac;
                descripcion.Select();
            }
            mostrar();
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_mesa_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_mesa.Text.Trim()))
            {
                cmd = "select max(cod_mesa)as mayor from mesa";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_mesa.Text = cod.ToString();
                }
            }
            cmd = "select * from mesa where cod_mesa='" + cod_mesa.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
                tipo_mesa.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_tipo"]);
                sillas.Text = Convert.ToString(ds.Tables[0].Rows[0]["cantidad_sillas"]);
                ubicacion.Text = Convert.ToString(ds.Tables[0].Rows[0]["ubicacion"]);
            }

            cmd = "select * from tipo_mesa where cod_tipo='" + tipo_mesa.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_tmesa.Text = " " + Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void des_tmesa_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select * from tipo_mesa where descripcion='" + des_tmesa.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                tipo_mesa.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_tipo"]);
            }
        }

        private void tipo_mesa_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select * from tipo_mesa where cod_tipo='" + tipo_mesa.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_tmesa.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }
    }
}
