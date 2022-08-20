using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace Proyecto_3.inv.mantenimientos
{
    public partial class articulos : MetroForm
    {
        int est = 0;
        string itb1 = "";

        public articulos()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            descrip.Text="";
            cod_categ.Text="";
            cod_alm.Text = "";
            marca.Text="";
            coment.Text="";
            cod_tipo.Text="";
            codigo_barra.Text="";
            descrip_corta.Text="";
            cod_unidad.Text="";
            costo.Text="";
            precio_unidad.Text="";
            precio_m.Text="";
            exist.Text="";
            exist_min.Text="";
            cod_itb.Text = "";
            des_categ.Text = "";
            des_alm.Text = "";
            des_tipo.Text = "";
            des_unidad.Text = "";
            estado.Checked = false;
            cambia_estado();
            codigo_mayor();

        }

        private void itb()
        {
            string cmdd = "select cod_itb as Mayor from itbis where tasa2='" + cod_itb.Text + "'";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            itb1 = ds.Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_rep+1) as Mayor from articulos";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_rep.Text = numfac;
            descrip.Select();

        }

        private void combo()
        {
            DataSet ds = new DataSet();
            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            SqlDataAdapter da = new SqlDataAdapter("select tasa from itbis where estado=1 order by tasa", co);
            da.Fill(ds);
            cod_itb.DataSource = ds.Tables[0].DefaultView;
            cod_itb.ValueMember = "tasa";
            cod_itb.Text = "";
            cod_itb.Select();
        }

        public void ejec_alm(string dato)
        {
           cod_alm.Text = dato;
            validating_alm();
        }

        public void ejec_art(string dato)
        {
            cod_rep.Text = dato;
            validating_alm();
        }

        public void ejec_tipo(string dato)
        {
            cod_tipo.Text = dato;
            validating_alm();
        }

        public void ejec_unidad(string dato)
        {
            cod_unidad.Text = dato;
            validating_uni();
        }

        private void activar()
        {
            nuevo.Enabled = false;
            activar2.Enabled = false;
            salvar.Enabled = false;
        }

        private void desactivar()
        {
            nuevo.Enabled = true;
            salvar.Enabled = true;
        }

        private void valida_estado()
        {
            salvar.Enabled = false;
            activar2.Enabled = true;
            cod_rep.Enabled = false;
            descrip.Enabled = false;
            cod_categ.Enabled = false;
            cod_alm.Enabled = false;
            marca.Enabled = false;
            coment.Enabled = false;
            cod_tipo.Enabled = false;
            codigo_barra.Enabled = false;
            descrip_corta.Enabled = false;
            cod_unidad.Enabled = false;
            estado.Enabled = false;
            costo.Enabled = false;
            precio_unidad.Enabled = false;
            precio_m.Enabled = false;
            exist.Enabled = false;
            exist_min.Enabled = false;
            cod_itb.Enabled = false;
            des_categ.Enabled = false;
            des_alm.Enabled = false;
            des_tipo.Enabled = false;
            des_unidad.Enabled = false;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;

            cod_rep.Enabled = true;
            descrip.Enabled = true;
            cod_categ.Enabled = true;
            cod_alm.Enabled = true;
            marca.Enabled = true;
            coment.Enabled = true;
            cod_tipo.Enabled = true;
            codigo_barra.Enabled = true;
            descrip_corta.Enabled = true;
            cod_unidad.Enabled = true;
            estado.Enabled = true;
            costo.Enabled = true;
            precio_unidad.Enabled = true;
            precio_m.Enabled = true;
            exist.Enabled = true;
            exist_min.Enabled = true;
            cod_itb.Enabled = true;
        }

        private void validating()
        {
            CultureInfo us = new CultureInfo("en-US");

            DataSet ds = new DataSet();
            string cmd = "select * from articulos where cod_rep='" + cod_rep.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descrip.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                cod_categ.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_categ"]);
                cod_alm.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_alm"]);
                marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["marca"]);
                coment.Text = Convert.ToString(ds.Tables[0].Rows[0]["coment"]);
                cod_tipo.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_tipo"]);
                codigo_barra.Text = Convert.ToString(ds.Tables[0].Rows[0]["codigo_barra"]);
                descrip_corta.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip_corta"]);
                cod_unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_unidad"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);

                double l1 = Convert.ToDouble(ds.Tables[0].Rows[0]["costo"]);
                string ll1 = l1.ToString("0.00", us);
                costo.Text = ll1;

                double l2 = Convert.ToDouble(ds.Tables[0].Rows[0]["precio_unidad"]);
                string ll2 = l2.ToString("0.00", us);
                precio_unidad.Text = ll2;

                double l3 = Convert.ToDouble(ds.Tables[0].Rows[0]["precio_m"]);
                string ll3 = l3.ToString("0.00", us);
                precio_m.Text =ll3;

                double l4 = Convert.ToDouble(ds.Tables[0].Rows[0]["exist"]);
                string ll4 = l4.ToString("0.00", us);
                exist.Text =ll4;

                double l5 = Convert.ToDouble(ds.Tables[0].Rows[0]["exist_min"]);
                string ll5 = l5.ToString("0.00", us);
                exist_min.Text = ll5;


                string fin = Convert.ToString(ds.Tables[0].Rows[0]["cod_itb"]);
                string cmdd = "select tasa as Mayor from itbis where cod_itb='" + fin + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_itb.Text = numfac;

            }
            else
            {
                codigo_mayor();

                cambia_estado();
                descrip.Text = "";
                cod_categ.Text = "";
                cod_alm.Text = "";
                marca.Text = "";
                coment.Text = "";
                cod_tipo.Text = "";
                codigo_barra.Text = "";
                descrip_corta.Text = "";
                cod_unidad.Text = "";
                costo.Text = "";
                precio_unidad.Text = "";
                precio_m.Text = "";
                exist.Text = "";
                exist_min.Text = "";
                cod_itb.Text = "";
                des_categ.Text = "";
                des_alm.Text = "";
                des_tipo.Text = "";
                des_unidad.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && descrip.Text != "")
            {
                valida_estado();
            }

        }

        private void validating_tipo()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from tipos_art where cod_tipo='" + cod_tipo.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_tipo.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
            }
            else
            {
                cod_tipo.Text = "";
                des_tipo.Text = "";
            }
        }

        private void validating_alm()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from almacen where cod_alm='" + cod_alm.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_alm.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                marca.Focus();
                 marca.Select();
            }
            else 
            {
                cod_alm.Text = "";
                des_alm.Text = "";

                  marca.Focus();
                 marca.Select();
            }
        }

        private void validating_uni()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from unidades where cod_unidad='" + cod_unidad.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_unidad.Text = Convert.ToString(ds.Tables[0].Rows[0]["des_unidad"]);
            }
            else
            {
                cod_unidad.Text = "";
                des_unidad.Text = "";
            }
        }

        private void busca_alm()
        {
            proceso.titulo = "Almacén";
            proceso.query = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where estado=1";
            proceso.query_cod = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where estado=1 and cod_alm";
            proceso.query_desc = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where estado=1 and descrip ";
        }

        private void busca_tipo()
        {
            proceso.titulo = "Tipos de Artículos";
            proceso.query = "select cod_tipo as 'Codigo', descrip as 'Descripcion' from tipos_art where estado=1";
            proceso.query_cod = "select cod_tipo as 'Codigo', descrip as 'Descripcion' from tipos_art where estado=1 and cod_tipo";
            proceso.query_desc = "select cod_tipo as 'Codigo', descrip as 'Descripcion' from tipos_art where estado=1 and descrip ";
        }

        private void busca_art()
        {
            proceso.titulo = "Artículos";
            proceso.query = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1";
            proceso.query_cod = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and cod_rep";
            proceso.query_desc = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and descrip ";
        }

        private void busca_unidad()
        {
            proceso.titulo = "Unidades";
            proceso.query = "select cod_unidad as 'Codigo', des_unidad as 'Descripcion' from unidades where estado=1";
            proceso.query_cod = "select cod_unidad as 'Codigo', des_unidad as 'Descripcion' from unidades where estado=1 and cod_unidad";
            proceso.query_desc = "select cod_unidad as 'Codigo', des_unidad as 'Descripcion' from unidades where estado=1 and des_unidad ";
        }

        private void busca_categ()
        {
            proceso.titulo = "Categorías";
            proceso.query = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen";
            proceso.query_cod = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where cod_alm";
            proceso.query_desc = "select cod_alm as 'Codigo', descrip as 'Descripcion' from almacen where descrip ";
        }

        private void articulos_Load(object sender, EventArgs e)
        {
            combo();
            codigo_mayor();
            activar();

            descrip.Select();
            descrip.Focus();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codigo_mayor();
            activar();
            salvar.Enabled = false;
        }

        private void articulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cod_rep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_categ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_alm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
              if (string.IsNullOrEmpty(descrip.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Descripción no válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                descrip.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_alm.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Almacén no válido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_alm.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_tipo.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Tipo de Artículo no válido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_tipo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_unidad.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Unidad no válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_unidad.Focus();
                return;
            }

            if (string.IsNullOrEmpty(costo.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Precio de Compra no válido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                costo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(precio_unidad.Text.Trim()))
            {
                MetroMessageBox.Show(this, " Precio de Venta no válido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                precio_unidad.Focus();
                return;
            }
            if (string.IsNullOrEmpty(exist.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Existencia Actual no válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exist.Focus();
                return;
            }
            if (string.IsNullOrEmpty(exist_min.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Existencia Mínima no válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exist_min.Focus();
                return;
            }

            string a = cod_itb.Text;

            CultureInfo us = new CultureInfo("en-US");
            double l = Convert.ToDouble(a);
            string ll = l.ToString("0.00", us);


            float num = float.Parse(costo.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll1 = num.ToString("0.00", us);

            float num1 = float.Parse(precio_unidad.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll2 = num1.ToString("0.00", us);

            float num3 = float.Parse(precio_m.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll3 = num3.ToString("0.00", us);

            float num4 = float.Parse(exist_min.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll4 = num4.ToString("0.00", us);

            float num5 = float.Parse(exist.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll5 = num5.ToString("0.00", us);


            string cmdd = "select cod_itb as Mayor from itbis where tasa='" + ll + "'";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            itb1 = ds.Tables[0].Rows[0]["Mayor"].ToString();

            if (estado.Checked == true)
                est = 1;
            else
                est = 0;
            if (string.IsNullOrEmpty(cod_itb.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Especifique el ITBIS a aplicar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_itb.Focus();
                return;
            }
            else
            {
                try//ll1
                {
                    string cmd = "exec act_articulos '" + cod_rep.Text.Trim() + "','" + descrip.Text.Trim() + "','" + cod_categ.Text.Trim() + "','" + cod_alm.Text.Trim() + "','" + ll1 + "','" + ll2 + "','" + ll3 + "','" + marca.Text.Trim() + "','" + ll4 + "','" + coment.Text.Trim() + "','" + cod_tipo.Text.Trim() + "','" + codigo_barra.Text.Trim() + "','" + descrip_corta.Text.Trim() + "','" + ll5 + "','" + cod_unidad.Text.Trim() + "','" + DateTime.Now.ToShortDateString() + "','" + Convert.ToInt16(itb1) + "','" + est + "'";

                    utilidades.UTILIDADES.ejecutar(cmd);
                    
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                nuevos();
                codigo_mayor();

            }
        }

        private void activar2_Click(object sender, EventArgs e)
        {
            string a = cod_itb.Text;
            CultureInfo us = new CultureInfo("en-US");
            double l = Convert.ToDouble(a);
            string ll = l.ToString("0.00", us);

            float num = float.Parse(costo.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll1 = num.ToString("0.00", us);

            float num1 = float.Parse(precio_unidad.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll2 = num1.ToString("0.00", us);

            float num3 = float.Parse(precio_m.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll3 = num3.ToString("0.00", us);

            float num4 = float.Parse(exist_min.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll4 = num4.ToString("0.00", us);

            float num5 = float.Parse(exist.Text, CultureInfo.InvariantCulture.NumberFormat);
            string ll5 = num5.ToString("0.00", us);


            string cmdd = "select cod_itb as Mayor from itbis where tasa='" + ll + "'";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            itb1 = ds.Tables[0].Rows[0]["Mayor"].ToString();

            est = 1;
            estado.Checked = true;

            string cmd = "exec act_articulos '" + cod_rep.Text.Trim() + "','" + descrip.Text.Trim() + "','" + cod_categ.Text.Trim() + "','" + cod_alm.Text.Trim() + "','" + ll1 + "','" + ll2 + "','" + ll3 + "','" + marca.Text.Trim() + "','" + ll4 + "','" + coment.Text.Trim() + "','" + cod_tipo.Text.Trim() + "','" + codigo_barra.Text.Trim() + "','" + descrip_corta.Text.Trim() + "','" + ll5 + "','" + cod_unidad.Text.Trim() + "','" + DateTime.Now.ToShortDateString() + "','" + Convert.ToInt16(itb1) + "','" + est + "'";

            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
             descrip_corta.Text.Trim() != ""  ||
                cod_categ.Text.Trim() != "" ||
               cod_alm.Text.Trim() != "" ||
              marca.Text.Trim() != "" ||
              cod_tipo.Text.Trim() != "" ||
               cod_unidad.Text.Trim() != "" ||
               costo.Text.Trim() != ""  ||
               precio_unidad.Text.Trim() != "" ||
                 precio_m.Text.Trim() != "" ||
                exist.Text.Trim() != "" ||
              exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
              coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }

        }

        private void cod_rep_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void articulos_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cod_alm_Validating(object sender, CancelEventArgs e)
        {
            validating_alm();
        }

        private void cod_alm_TextChanged(object sender, EventArgs e)
        {

            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
              descrip_corta.Text.Trim() != "" ||
                 cod_categ.Text.Trim() != "" ||
                cod_alm.Text.Trim() != "" ||
               marca.Text.Trim() != "" ||
               cod_tipo.Text.Trim() != "" ||
                cod_unidad.Text.Trim() != "" ||
                costo.Text.Trim() != "" ||
                precio_unidad.Text.Trim() != "" ||
                  precio_m.Text.Trim() != "" ||
                 exist.Text.Trim() != "" ||
               exist_min.Text.Trim() != "" ||
                 estado.Checked == true ||
               coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void cod_tipo_Validating(object sender, CancelEventArgs e)
        {
            validating_tipo();
        }

        private void cod_tipo_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
               estado.Checked == true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }

            validating_tipo();
           
        }

        private void cod_unidad_Validating(object sender, CancelEventArgs e)
        {
            validating_uni();
        }

        private void cod_unidad_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
           descrip_corta.Text.Trim() != "" ||
              cod_categ.Text.Trim() != "" ||
             cod_alm.Text.Trim() != "" ||
            marca.Text.Trim() != "" ||
            cod_tipo.Text.Trim() != "" ||
             cod_unidad.Text.Trim() != "" ||
             costo.Text.Trim() != "" ||
             precio_unidad.Text.Trim() != "" ||
               precio_m.Text.Trim() != "" ||
              exist.Text.Trim() != "" ||
            exist_min.Text.Trim() != "" ||
              estado.Checked == true ||
            coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }

            validating_uni();
           
        }

        private void cod_rep_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||

             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            busca_alm();
            consultas.tipo form1 = new consultas.tipo();
            form1.pasado += new consultas.tipo.pasar(ejec_alm);
            form1.ShowDialog();
        }

        private void cod_alm_Validating_1(object sender, CancelEventArgs e)
        {
            validating_alm();
        }

        private void cod_alm_TextChanged_1(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
               estado.Checked == true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }

            validating_alm();
        }

        private void cod_alm_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            busca_tipo();
            consultas.tipo form1 = new consultas.tipo();
            form1.pasado += new consultas.tipo.pasar(ejec_tipo);
            form1.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            busca_unidad();
            consultas.tipo form1 = new consultas.tipo();
            form1.pasado += new consultas.tipo.pasar(ejec_unidad);
            form1.ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca_art();
            consultas.tipo form1 = new consultas.tipo();
            form1.pasado += new consultas.tipo.pasar(ejec_art);
            form1.ShowDialog();
        }

        private void codigo_barra_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
             descrip_corta.Text.Trim() != "" ||
                cod_categ.Text.Trim() != "" ||
               cod_alm.Text.Trim() != "" ||
              marca.Text.Trim() != "" ||
              cod_tipo.Text.Trim() != "" ||
               cod_unidad.Text.Trim() != "" ||
               costo.Text.Trim() != "" ||
               precio_unidad.Text.Trim() != "" ||
                 precio_m.Text.Trim() != "" ||
                exist.Text.Trim() != "" ||
              exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
              coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void descrip_corta_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
               estado.Checked == true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void cod_categ_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
               estado.Checked == true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void marca_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||

             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void costo_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
             descrip_corta.Text.Trim() != "" ||
                cod_categ.Text.Trim() != "" ||
               cod_alm.Text.Trim() != "" ||
              marca.Text.Trim() != "" ||
              cod_tipo.Text.Trim() != "" ||
               cod_unidad.Text.Trim() != "" ||
               costo.Text.Trim() != "" ||
               precio_unidad.Text.Trim() != "" ||
                 precio_m.Text.Trim() != "" ||
                exist.Text.Trim() != "" ||
              exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
              coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void precio_unidad_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
             descrip_corta.Text.Trim() != "" ||
                cod_categ.Text.Trim() != "" ||
               cod_alm.Text.Trim() != "" ||
              marca.Text.Trim() != "" ||
              cod_tipo.Text.Trim() != "" ||
               cod_unidad.Text.Trim() != "" ||
               costo.Text.Trim() != "" ||
               precio_unidad.Text.Trim() != "" ||
                 precio_m.Text.Trim() != "" ||
                exist.Text.Trim() != "" ||
              exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
              coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void precio_m_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
             descrip_corta.Text.Trim() != "" ||
                cod_categ.Text.Trim() != "" ||
               cod_alm.Text.Trim() != "" ||
              marca.Text.Trim() != "" ||
              cod_tipo.Text.Trim() != "" ||
               cod_unidad.Text.Trim() != "" ||
               costo.Text.Trim() != "" ||
               precio_unidad.Text.Trim() != "" ||
                 precio_m.Text.Trim() != "" ||
                exist.Text.Trim() != "" ||
              exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
              coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void exist_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
               estado.Checked == true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void exist_min_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
             descrip_corta.Text.Trim() != "" ||
                cod_categ.Text.Trim() != "" ||
               cod_alm.Text.Trim() != "" ||
              marca.Text.Trim() != "" ||
              cod_tipo.Text.Trim() != "" ||
               cod_unidad.Text.Trim() != "" ||
               costo.Text.Trim() != "" ||
               precio_unidad.Text.Trim() != "" ||
                 precio_m.Text.Trim() != "" ||
                exist.Text.Trim() != "" ||
              exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
              coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void cod_itb_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
               estado.Checked == true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void coment_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
            descrip_corta.Text.Trim() != "" ||
               cod_categ.Text.Trim() != "" ||
              cod_alm.Text.Trim() != "" ||
             marca.Text.Trim() != "" ||
             cod_tipo.Text.Trim() != "" ||
              cod_unidad.Text.Trim() != "" ||
              costo.Text.Trim() != "" ||
              precio_unidad.Text.Trim() != "" ||
                precio_m.Text.Trim() != "" ||
               exist.Text.Trim() != "" ||
             exist_min.Text.Trim() != "" ||
             estado.Checked==true ||
             coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void estado_Click(object sender, EventArgs e)
        {
            if (descrip.Text.Trim() != "" || codigo_barra.Text.Trim() != "" ||
              descrip_corta.Text.Trim() != "" ||
                 cod_categ.Text.Trim() != "" ||
                cod_alm.Text.Trim() != "" ||
               marca.Text.Trim() != "" ||
               cod_tipo.Text.Trim() != "" ||
                cod_unidad.Text.Trim() != "" ||
                costo.Text.Trim() != "" ||
                precio_unidad.Text.Trim() != "" ||
                  precio_m.Text.Trim() != "" ||
                 exist.Text.Trim() != "" ||
               exist_min.Text.Trim() != "" ||
                estado.Checked == true ||
               coment.Text.Trim() != "")
            { desactivar(); }

            else { activar(); }
        }

        private void costo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar ==8 ) {
         e.Handled = false;
         return;
       }


       bool IsDec = false;
        int nroDec = 0;

       for (int i=0 ; i<costo.Text.Length; i++) {
         if ( costo.Text[i] == '.' )
            IsDec = true;

         if ( IsDec && nroDec++ >=2) {
            e.Handled = true;
            return;
         }


       }

       if ( e.KeyChar>=48 && e.KeyChar<=57)
         e.Handled = false;
       else if (e.KeyChar==46)         
         e.Handled = (IsDec) ? true:false;
       else
         e.Handled = true;

        }

        private void precio_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precio_unidad.Text.Length; i++)
            {
                if (precio_unidad.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void precio_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < precio_m.Text.Length; i++)
            {
                if (precio_m.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void exist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < exist.Text.Length; i++)
            {
                if (exist.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }

        private void exist_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < exist_min.Text.Length; i++)
            {
                if (exist_min.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }
    }
}
