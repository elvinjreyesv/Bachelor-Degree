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
    public partial class proveedores : MetroForm
    {
        int est;
        public proveedores()
        {
            InitializeComponent();

        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from suplidor";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_suplidor+1) as Mayor from suplidor";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_prov.Text = numfac;
            nombre.Select();

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_tsup from tipo_sup", con);
                da.Fill(ds1);
                cod_tippro.DataSource = ds1.Tables[0].DefaultView;
                cod_tippro.ValueMember = "cod_tsup";
                cod_tippro.Text = "";
                nombre.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from tipo_sup", con);
                da.Fill(ds1);
                det_tipro.DataSource = ds1.Tables[0].DefaultView;
                det_tipro.ValueMember = "descripcion";
                det_tipro.Text = "";
                nombre.Select();
            }

            mostrar();
        }

        public void limpiar()
        {
            cod_prov.Clear();
            nombre.Clear();
            direccion.Clear();
            telefono.Clear();
            fax.Clear();
            correo.Clear();
            cod_prov.Text = "";
            cod_tippro.Text = "";
            inactivo.Checked = false;
            fecha.Text = "";
            activo.Checked = false;
            det_tipro.Text = "";
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cod_prov.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_prov.Focus();
                return;

            }
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE NOMBRE ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                nombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(direccion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DIRECCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                direccion.Focus();
                return;

            }
            if (string.IsNullOrEmpty(telefono.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TELEFONO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                telefono.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fax.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FAX ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fax.Focus();
                return;

            }
            if (string.IsNullOrEmpty(correo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CORREO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                correo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cod_tippro.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TIPO DE SUPLIDOR ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_tippro.Focus();
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
                    string cmd = "exec act_suplidor '" + cod_prov.Text + "','" + nombre.Text + "','" + direccion.Text + "','" + telefono.Text.Trim() + "','" + fax.Text + "','" + correo.Text + "','" + est+ "','" + cod_tippro.Text + "','" + fecha.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_suplidor+1) as Mayor from suplidor";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_prov.Text = numfac;
                nombre.Select();
                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {

            limpiar();
            string cmdd = "select max (cod_suplidor+1) as Mayor from suplidor";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_prov.Text = numfac;
            nombre.Select();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " SUPLIDORES ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_prov.Text);
                string cmd = "delete from suplidor where cod_suplidor='" + cod_prov.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_prov.Text = Convert.ToString(c);
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
            if (string.IsNullOrEmpty(cod_prov.Text) || string.IsNullOrEmpty(nombre.Text)  || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(telefono.Text) || string.IsNullOrEmpty(direccion.Text) || string.IsNullOrEmpty(correo.Text) || string.IsNullOrEmpty(fax.Text) || string.IsNullOrEmpty(cod_tippro.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cmd = "update suplidor set cod_suplidor='" + cod_prov.Text.Trim() + "', " + "nombre='" + nombre.Text.Trim() + "', " + "direccion='" + direccion.Text + "', " + "telefono='" + telefono.Text.Trim() + "', " + "fax='" + fax.Text.Trim() + "', " + "correo='" + correo.Text.Trim() + "', " + "cod_estado='" + est + "', " + "cod_tsup='" + cod_tippro.Text.Trim() + "', " + "fecha_reg='" + fecha.Text.Trim() + "' where cod_suplidor ='" + cod_prov.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_suplidor+1) as Mayor from suplidor";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_prov.Text = numfac;
                nombre.Select();
            }
            mostrar();
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
                    string cmd = "select * from suplidor";
                    cmd += " where cod_suplidor like('%" + busca.Text.Trim() + "%')";
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
                        string cmd = "select * from suplidor";
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
                    string cmd = "select * from suplidor";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_prov_Validating_1(object sender, CancelEventArgs e)
        {
            
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_prov.Text.Trim()))
            {
                cmd = "select max(cod_suplidor)as mayor from suplidor";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_prov.Text = cod.ToString();
                }
            }
            cmd = "select * from suplidor where cod_suplidor='" + cod_prov.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                fax.Text = Convert.ToString(ds.Tables[0].Rows[0]["fax"]);
                correo.Text = Convert.ToString(ds.Tables[0].Rows[0]["correo"]);

                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);

                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                cod_tippro.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_tsup"]);
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }

        }

        private void cod_tippro_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from tipo_sup where cod_tsup='" + cod_tippro.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                det_tipro.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

            }
        }

        private void det_tipro_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(det_tipro.Text.Trim()))
                return;
            string cmd = string.Format("select * from tipo_sup where descripcion = '{0}'", det_tipro.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                cod_tippro.Text = ds.Tables[0].Rows[0]["cod_tsup"].ToString();
            }
            catch
            {
                MessageBox.Show("EL TIPO ACTUAL NO EXISTE");
            }
        }

    }
}
