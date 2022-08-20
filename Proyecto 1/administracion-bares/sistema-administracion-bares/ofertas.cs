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
    public partial class ofertas : MetroForm
    {
        int est;

        public ofertas()
        {
            InitializeComponent();
        }


        private void ofertas_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_oferta+1) as Mayor from ofertas";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_ofert.Text = numfac;
            fecha_in.Select();

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_art from articulos", con);
                da.Fill(ds1);
                cod_art.DataSource = ds1.Tables[0].DefaultView;
                cod_art.ValueMember = "cod_art";
                cod_art.Text = "";
                fecha_in.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", con);
                da.Fill(ds1);
                desc_art.DataSource = ds1.Tables[0].DefaultView;
                desc_art.ValueMember = "descripcion";
                desc_art.Text = "";
                fecha_in.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_unidad from unidad", con);
                da.Fill(ds1);
                unidad.DataSource = ds1.Tables[0].DefaultView;
                unidad.ValueMember = "cod_unidad";
                unidad.Text = "";
                fecha_in.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select und_invent from unidad", con);
                da.Fill(ds1);
                des_unidad.DataSource = ds1.Tables[0].DefaultView;
                des_unidad.ValueMember = "und_invent";
                des_unidad.Text = "";
                fecha_in.Select();
            }

            mostrar();
        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from ofertas";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            descripcion.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            cod_art.Text = "";
            desc_art.Text = "";
            fecha_fn.Text = "";
            unidad.Text = "";
            des_unidad.Text = "";
            precio.Text = "";
           fecha_in.Focus();
        }

        private void salvar_Click_1(object sender, EventArgs e)
        {
             if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_ofert.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_ofert.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }
            if (est==0)
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                activo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha_in.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha_in.Focus();
                return;
            }
            if (string.IsNullOrEmpty(fecha_fn.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha_fn.Focus();
                return;
            }

            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cod_art.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_art.Focus();
                return;
            }
            if (string.IsNullOrEmpty(unidad.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                unidad.Focus();
                return;
            }

            else
            {
                try
                {

                    //string cmd = "exec act_detalofert '" + cod_ofert.Text + "','" + descripcion.Text + "','" + cod_art.Text + "','" + precio.Text + "','" + unidad.Text + "'";
                    string cmd = string.Format("exec act_detalofert '" + cod_ofert.Text + "','" + descripcion.Text + "','" + cod_art.Text + "','" + precio.Text + "','" + unidad.Text + "'");
                    utilidades.UTILIDADES.ejecutar(cmd);


                    cmd = "exec act_ofertas '" + cod_ofert.Text + "','" + fecha_in.Text + "','" + fecha_fn.Text + "','" + est + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_oferta+1) as Mayor from ofertas";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_ofert.Text = numfac;
                fecha_in.Select();

                mostrar();
            }
        }

        private void nuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_oferta+1) as Mayor from ofertas";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_ofert.Text = numfac;
            fecha_in.Select();

            mostrar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_ofert.Text);
                string cmd = "delete from ofertas where cod_oferta='" + cod_ofert.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                cmd = "delete from detall_ofert where cod_oferta='" + cod_ofert.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_ofert.Text = Convert.ToString(c);
                fecha_in.Select();
            }

            mostrar();
        }

        private void salir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_ofert_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_ofert.Text.Trim()))
            {
                cmd = "select max(cod_oferta)as mayor from ofertas";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_ofert.Text = cod.ToString();
                }
            }
            cmd = "select * from ofertas where cod_oferta='" + cod_ofert.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;

                fecha_in.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_inicio"]);
                fecha_fn.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_fin"]);
            }

            cmd = "select * from detall_ofert where cod_oferta='" + cod_ofert.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["Detalle_oferta"]);
                cod_art.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_art"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["prec_ofert"]);
                unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_unidad"]);
            }


            cmd = "select * from unidad where cod_unidad='" + unidad.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["und_invent"]);
            }
        }

        private void cod_art_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from articulos where cod_art='" + cod_art.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                desc_art.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

            }
        }

        private void desc_art_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(desc_art.Text.Trim()))
                return;
            string cmd = string.Format("select * from articulos where descripcion = '{0}'", desc_art.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                cod_art.Text = ds.Tables[0].Rows[0]["cod_art"].ToString();
            }
            catch
            {
                MessageBox.Show("EL ARTICULO ACTUAL NO EXISTE");
            }
        }

        private void unidad_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from unidad where cod_unidad='" + unidad.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                des_unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["und_invent"]);

            }
        }

        private void des_unidad_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(des_unidad.Text.Trim()))
                return;
            string cmd = string.Format("select * from unidad where und_invent = '{0}'", des_unidad.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                unidad.Text = ds.Tables[0].Rows[0]["cod_unidad"].ToString();
            }
            catch
            {
                MessageBox.Show("EL ESTADO ACTUAL NO EXISTE");
            }
        }

    }
}
