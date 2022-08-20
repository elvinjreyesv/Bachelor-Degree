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

    public partial class articulos : MetroForm
    {
        
        int est;
        public articulos()
        {
            InitializeComponent();
        }

        //--------------------------
        //articulos

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from articulos";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void mostrar1()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from articulos";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            datos.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            descripcion.Clear();
            activo.Checked = false;
            marca.Text = "";
            des_marca.Text = "";
            categoria.Text = "";
            desc_cat.Text = "";
            inactivo.Checked = false;
            buscar.Text = "";
            fecha.Text = "";
            unidad.Text="";
            precio.Text = "";
            descripcion.Focus();
        }

        private void articulos_Load_1(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_art+1) as Mayor from articulos";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_art.Text = numfac;
            descripcion.Select();

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select und_venta from unidad", con);
                da.Fill(ds1);
                unidad.DataSource = ds1.Tables[0].DefaultView;
                unidad.ValueMember = "und_venta";
                unidad.Text = "";
                descripcion.Select();
            }
            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_marca from marca", con);
                da.Fill(ds1);
                marca.DataSource = ds1.Tables[0].DefaultView;
                marca.ValueMember = "cod_marca";
                marca.Text = "";
                descripcion.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from marca", con);
                da.Fill(ds1);
                des_marca.DataSource = ds1.Tables[0].DefaultView;
                des_marca.ValueMember = "descripcion";
                des_marca.Text = "";
                descripcion.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_categoria from categoria", con);
                da.Fill(ds1);
                categoria.DataSource = ds1.Tables[0].DefaultView;
                categoria.ValueMember = "cod_categoria";
                categoria.Text = "";
                descripcion.Select();
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from categoria", con);
                da.Fill(ds1);
                desc_cat.DataSource = ds1.Tables[0].DefaultView;
                desc_cat.ValueMember = "descripcion";
                desc_cat.Text = "";
                descripcion.Select();
            }
            //--------------------------------

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", con);
                da.Fill(ds1);
                articulo1.DataSource = ds1.Tables[0].DefaultView;
                articulo1.ValueMember = "descripcion";
                articulo1.Text = "";
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", con);
                da.Fill(ds1);
                articulo2.DataSource = ds1.Tables[0].DefaultView;
                articulo2.ValueMember = "descripcion";
                articulo2.Text = "";
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", con);
                da.Fill(ds1);
                articulo3.DataSource = ds1.Tables[0].DefaultView;
                articulo3.ValueMember = "descripcion";
                articulo3.Text = "";
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", con);
                da.Fill(ds1);
                articulo4.DataSource = ds1.Tables[0].DefaultView;
                articulo4.ValueMember = "descripcion";
                articulo4.Text = "";
            }

            {
                SqlConnection con = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", con);
                da.Fill(ds1);
                articulo_t.DataSource = ds1.Tables[0].DefaultView;
                articulo_t.ValueMember = "descripcion";
                articulo_t.Text = "";
            }

            //---------------------------------------

            mostrar();
            mostrar1();
        }

        private void salvar1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unidad.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE UNIDAD ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unidad.Focus();
                return;
            }
            if (string.IsNullOrEmpty(precio.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE PRECIO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                precio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                descripcion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(marca.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE MARCA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                marca.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fecha.Focus();
                return;
            }
            if (string.IsNullOrEmpty(categoria.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE CATEGORIA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoria.Focus();
                return;
            }

            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
                else
                    est = 0;
            if (est == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE ESTADO ESTA VACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string cmd = "exec act_articulos '" + cod_art.Text + "','" + descripcion.Text + "','" + marca.Text + "','" + categoria.Text + "','" + fecha.Text + "','" + est + "','" + unidad.Text + "','" + precio.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MetroFramework.MetroMessageBox.Show(this, "DATOS ALMACENADOS CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_art+1) as Mayor from articulos";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_art.Text = numfac;
                descripcion.Select();

                mostrar();
            }
        }

        private void nuevo1_Click_1(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_art+1) as Mayor from articulos";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_art.Text = numfac;
            descripcion.Select();

            mostrar();
        }

        private void eliminar1_Click_1(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "SEGURO QUE DESEAS ELIMINAR ESTE REGISTRO", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_art.Text);
                string cmd = "delete from articulos where cod_art='" + cod_art.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MetroFramework.MetroMessageBox.Show(this, "REGISTRO ELIMINADO CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                cod_art.Text = Convert.ToString(c);
                descripcion.Select();
            }

            mostrar();
        }

        private void actualizar1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_art.Text) || string.IsNullOrEmpty(descripcion.Text) || string.IsNullOrEmpty(marca.Text) || string.IsNullOrEmpty(categoria.Text) || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(unidad.Text) || string.IsNullOrEmpty(precio.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "FALTAN DATOS PARA CONTINUAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (est == 0)
                MetroFramework.MetroMessageBox.Show(this, "FALTAN DATOS PARA CONTINUAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                if (activo.Checked == true)
                    est = 1;
                else
                    if (inactivo.Checked == true)
                        est = 2;
                string cmd = "update articulos set cod_art='" + cod_art.Text.Trim() + "', " + "descripcion='" + descripcion.Text.Trim() + "', " + "cod_marca='" + marca.Text.Trim() + "', " + "cod_categoria='" + categoria.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.ToString() + "', " + "cod_estado='" + est + "', " + "und_invent='" + unidad.Text + "', " + "precio='" + precio.Text + "' where cod_art ='" + cod_art.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MetroFramework.MetroMessageBox.Show(this, "ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_art+1) as Mayor from articulos";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_art.Text = numfac;
                descripcion.Select();
            }
            mostrar();
        }

        private void salir1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultar1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(buscar.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(buscar.Text.Trim()) == false)
                {
                    string cmd = "select * from articulos";
                    cmd += " where cod_art like('%" + buscar.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                buscar.Clear();
                buscar.Focus();
            }
            else

                if (nombre.Checked)
                {
                    if (string.IsNullOrEmpty(buscar.Text.Trim()) == false)
                    {
                        string cmd = "select * from articulos";
                        cmd += " where descripcion like('%" + buscar.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        data.DataSource = ds.Tables[0];
                    }
                    buscar.Clear();
                    buscar.Focus();
                }
                else
                {

                    DataSet ds = new DataSet();
                    string cmd = "select * from articulos";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    buscar.Clear();
                    buscar.Focus();

                }
        }

        private void cod_art_Validating(object sender, CancelEventArgs e)
        {

            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_art.Text.Trim()))
            {
                cmd = "select max(cod_art)as mayor from articulos";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_art.Text = cod.ToString();
                }
            }
            cmd = "select * from articulos where cod_art='" + cod_art.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_marca"]);
                categoria.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_categoria"]);
                unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["und_invent"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);
                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;

                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }

            cmd = "select * from marca where cod_marca='" + marca.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }

            cmd = "select * from categoria where cod_categoria='" + categoria.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                desc_cat.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void marca_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from marca where cod_marca='" + marca.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                des_marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

            }
        }

        private void des_marca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(des_marca.Text.Trim()))
                return;
            string cmd = string.Format("select * from marca where descripcion = '{0}'", des_marca.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                marca.Text = ds.Tables[0].Rows[0]["cod_marca"].ToString();
            }
            catch
            {
                // MessageBox.Show("LA MARCA ACTUAL NO EXISTE");
            }
        }

        private void categoria_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from categoria where cod_categoria='" + categoria.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                desc_cat.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);

            }
        }

        private void desc_cat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(desc_cat.Text.Trim()))
                return;
            string cmd = string.Format("select * from estado where descripcion = '{0}'", desc_cat.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                categoria.Text = ds.Tables[0].Rows[0]["cod_categoria"].ToString();
            }
            catch
            {
                // MessageBox.Show("EL ESTADO ACTUAL NO EXISTE");
            }
        }

      //--------------------------------------------------------------
        //combos

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevo4();
        }

        public void nuevo4()
        {
             articulo1.Text = "";
            articulo2.Text = "";
            articulo3.Text = "";
            articulo4.Text = "";
            cantidad1.Text = "";
            cantidad2.Text = "";
            cantidad3.Text = "";
            cantidad4.Text = "";
            cantidad_c.Text = "";
        }

        private void salir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvar3_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------
        //combos

        private void salvar2_Click(object sender, EventArgs e)
        {

        }

        public void nuevo3()
        {
            articulo_t.Text = "";
            cantidad_t.Text = "";
            precio_t.Text = "";
        }

        private void nuevo2_Click(object sender, EventArgs e)
        {
            nuevo3();
           
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
