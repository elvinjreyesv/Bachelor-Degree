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
    public partial class almacen : MetroForm
    {
        int est;
        public almacen()
        {
            InitializeComponent();

        }


        private void almacen_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_almacen+1) as Mayor from almacen";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_almacen.Text = numfac;
            descripcion.Select();

            //{
            //    SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
            //    DataSet ds1 = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter("select descripcion from estado", con);
            //    da.Fill(ds1);
            //    estado.DataSource = ds1.Tables[0].DefaultView;
            //    estado.ValueMember = "descripcion";
            //    estado.Text = "";
            //    descripcion.Select();
            //}

            //{
            //    SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
            //    DataSet ds1 = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter("select cod_estado from estado", con);
            //    da.Fill(ds1);
            //    cod_estado.DataSource = ds1.Tables[0].DefaultView;
            //    cod_estado.ValueMember = "cod_estado";
            //    cod_estado.Text = "";
            //    descripcion.Select();
            //}

            mostrar();

        }

        public void mostrar()
        {
           DataSet ds = new DataSet();
            string cmd = "select * from almacen";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            descripcion.Clear();
           
            descripcion.Focus();
            activo.Checked=false;
            inactivo.Checked=false;
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_almacen.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_almacen.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
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
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                return;
            }

            else
            {
                try
                {


                    string cmd = "exec act_almacen '" + cod_almacen.Text + "','" + descripcion.Text + "','" + est + "','" + fecha.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_almacen+1) as Mayor from almacen";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_almacen.Text = numfac;
                descripcion.Select();

                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_almacen+1) as Mayor from almacen";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_almacen.Text = numfac;
            descripcion.Select();

            mostrar();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_almacen.Text);
                string cmd = "delete from almacen where cod_almacen='" + cod_almacen.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_almacen.Text = Convert.ToString(c);
                descripcion.Select();
            }

            mostrar();
        }

        private void actualizar1_Click(object sender, EventArgs e)
        {
            string cmd;
            string w;
            int es;
            DateTime fec;
            string vari = " ";
            DataSet ds = new DataSet();
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;

            if (string.IsNullOrEmpty(cod_almacen.Text) || string.IsNullOrEmpty(descripcion.Text) || string.IsNullOrEmpty(fecha.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (est == 0)
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                {

                    cmd = "select * from almacen where cod_almacen='" + cod_almacen.Text.Trim() + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {

                        w = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                        es = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                        fec = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_reg"]);


                        string k = "select max(cod_modif+1)as Mayor from modificacion";
                        ds = utilidades.UTILIDADES.ejecutar(k);
                        string num = ds.Tables[0].Rows[0]["Mayor"].ToString();
                        string j = "almacen";

                        if (Convert.ToString(descripcion.Text) != Convert.ToString(w))
                        {
                            vari += "descripcion,";
                        }
                        if (Convert.ToInt16(est) != Convert.ToInt16(es))
                        {
                            vari += "estado,";
                        }
                        if (Convert.ToDateTime(fecha.Text) != Convert.ToDateTime(fec))
                        {
                            vari += "fecha";
                        }
                        string t = "en esta tabla se modifico: " + vari;

                        cmd = string.Format("insert into modificacion (cod_modif, tabla, desc_modif, fecha_mod) values('{0}', '{1}', '{2}', '{3}')", num, j, t, Convert.ToDateTime(fecha.Text.Trim()));
                        utilidades.UTILIDADES.ejecutar(cmd);
                    }
                }

                cmd = "update almacen set cod_almacen='" + cod_almacen.Text.Trim() + "', " + "descripcion='" + descripcion.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "', " + "cod_estado='" + est + "' where cod_almacen ='" + cod_almacen.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);

                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_almacen+1) as Mayor from almacen";
                ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_almacen.Text = numfac;
                descripcion.Select();
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
                    string cmd = "select * from almacen";
                    cmd += " where cod_almacen like('%" + busca.Text.Trim() + "%')";
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
                        string cmd = "select * from almacen";
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
                    string cmd = "select * from almacen";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void cod_almacen_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_almacen.Text.Trim()))
            {
                cmd = "select max(cod_almacen)as mayor from almacen";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_almacen.Text = cod.ToString();
                }
            }

            cmd = "select * from almacen where cod_almacen='" + cod_almacen.Text.Trim() + "'";
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
            }
        }

    }
}
