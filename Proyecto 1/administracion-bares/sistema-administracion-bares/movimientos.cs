using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using MetroFramework.Forms;


namespace sistema_administracion_bares
{
    public partial class movimientos : MetroForm
    {
        public DataTable consulta = new DataTable();

        public movimientos()
        {
            InitializeComponent();
            clear();
            consulta.Columns.Add("codigos");
            consulta.Columns.Add("descripcion");
            consulta.Columns.Add("cantidadd");
            consulta.Columns.Add("und_c");
            consulta.Columns.Add("und_v");
            consulta.Columns.Add("costos");
            consulta.Columns.Add("precio_v");
            consulta.Columns.Add("importes");

            data.AutoGenerateColumns = false;
            data.Columns[0].DataPropertyName = "codigos";
            data.Columns[1].DataPropertyName = "descripcion";
            data.Columns[2].DataPropertyName = "cantidadd";
            data.Columns[3].DataPropertyName = "und_c";
            data.Columns[4].DataPropertyName = "und_v";
            data.Columns[5].DataPropertyName = "costos";
            data.Columns[6].DataPropertyName = "precio_v";
            data.Columns[7].DataPropertyName = "importes";
            data.DataSource = consulta;


            totales.Enabled = false;
            DataSet ds = new DataSet();
            string cmd = "select max (num_mov+1) as Mayor from movimiento";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            cod_mov.Text = Convert.ToString(ds.Tables[0].Rows[0]["mayor"].ToString().Trim());
        }

        public static double st = 0;

        public void suma()
        {

            foreach (DataRow dr in consulta.Rows)
            {
                st += Convert.ToDouble(dr["importes"]);
            }
            double t = st;
            totales.Text = "$ " + st.ToString();
        }

        public void clear()
        {
            cod_mov.Clear();
            cod_sup.Text = "";
            tipo_mov.Clear();
            cod_almacen.Text = "";
            nom_sup.Text = "";
            almacen.Text = "";
            documento.Text = "";
            //fecha.Text = "";
            cod_art.Text = "";
            desc_art.Text = "";
            totales.Text = "";
            cantidad.Text = "";
            unidad_c.Text = "";
            unidad_v.Text = "";
            txtprecio.Text = "";
            costo.Text = "";

            data.DataSource = null;
            data.Rows.Clear();
        }

        private void movimientos_Load(object sender, EventArgs e)
        {
            btnunidad.Visible = false;
          //  txtc.Visible = false;
            
            {
                txtc.Text = Convert.ToString(procesos.resultado);
                cod_art.Text = Convert.ToString(procesos.cod_art);
                unidad_c.Text = Convert.ToString(procesos.unidad_c);
                unidad_v.Text = Convert.ToString(procesos.unidad_v);
                costo.Text = Convert.ToString(procesos.costo);
                txtprecio.Text = Convert.ToString(procesos.txtprecio);
                cantidad.Text = Convert.ToString(procesos.cantidad);
              //  cod_mov.Text = Convert.ToString(procesos.cod_mov);
                cod_sup.Text = Convert.ToString(procesos.cod_sup);
                tipo_mov.Text = Convert.ToString(procesos.tipo_mov);
                cod_almacen.Text = Convert.ToString(procesos.cod_almacen);
                //fecha.Value = Convert.ToDateTime(procesos.fecha);
                documento.Text = Convert.ToString(procesos.documento);
            }

            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_suplidor from suplidor", co);
                da.Fill(ds);
                cod_sup.DataSource = ds.Tables[0].DefaultView;
                cod_sup.ValueMember = "cod_suplidor";
                cod_sup.Text = "";
                cod_sup.Select();
            }

            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select nombre from suplidor", co);
                da.Fill(ds);
                nom_sup.DataSource = ds.Tables[0].DefaultView;
                nom_sup.ValueMember = "nombre";
                nom_sup.Text = "";
            }


            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_almacen from almacen", co);
                da.Fill(ds);
                cod_almacen.DataSource = ds.Tables[0].DefaultView;
                cod_almacen.ValueMember = "cod_almacen";
                cod_almacen.Text = "";
                cod_sup.Select();
            }

            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from almacen", co);
                da.Fill(ds);
                almacen.DataSource = ds.Tables[0].DefaultView;
                almacen.ValueMember = "descripcion";
                almacen.Text = "";
                cod_sup.Select();
            }

            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select cod_art from articulos", co);
                da.Fill(ds);
                cod_art.DataSource = ds.Tables[0].DefaultView;
                cod_art.ValueMember = "cod_art";
                cod_art.Text = "";
                cod_sup.Select();
            }

            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", co);
                da.Fill(ds);
                desc_art.DataSource = ds.Tables[0].DefaultView;
                desc_art.ValueMember = "descripcion";
                desc_art.Text = "";
                cod_sup.Select();
            }

            //{
            //    SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
            //    DataSet ds = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter("select und_invent from unidad", co);
            //    da.Fill(ds);
            //    unidad_c.DataSource = ds.Tables[0].DefaultView;
            //    unidad_c.ValueMember = "und_invent";
            //    unidad_c.Text = "";
            //    cod_sup.Select();
            //}

            //{
            //    SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
            //    DataSet ds = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter("select und_venta from unidad", co);
            //    da.Fill(ds);
            //    unidad_v.DataSource = ds.Tables[0].DefaultView;
            //    unidad_v.ValueMember = "und_venta";
            //    unidad_v.Text = "";
            //    cod_sup.Select();
            //}

        }

        private void btnunidad_Click_1(object sender, EventArgs e)
        {
            procesos.cod_art = Convert.ToString(cod_art.Text.Trim());
            procesos.unidad_c = Convert.ToString(unidad_c.Text.Trim());
            procesos.unidad_v = Convert.ToString(unidad_v.Text.Trim());
            procesos.costo = Convert.ToInt16(costo.Text.Trim());
            procesos.txtprecio = Convert.ToInt16(txtprecio.Text.Trim());
            procesos.cantidad = Convert.ToInt16(cantidad.Text.Trim());

          //  procesos.cod_mov = Convert.ToInt16(cod_mov.Text.Trim());
            procesos.cod_sup = Convert.ToInt16(cod_sup.Text.Trim());
            procesos.tipo_mov = Convert.ToString(tipo_mov.Text.Trim());
            procesos.cod_almacen = Convert.ToInt16(cod_almacen.Text.Trim());
          //  procesos.fecha = Convert.ToDateTime(fecha.Text.Trim());
            procesos.documento = Convert.ToString(documento.Text.Trim());
            
            this.Hide();
            conversion_unidades c = new conversion_unidades();
            c.Show();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (string.IsNullOrEmpty(cod_art.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "PARA CONTINUAR DEBES INGRESAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_art.Focus();
                return;
            }
            {
                if (string.IsNullOrEmpty(cantidad.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "PARA CONTINUAR DEBES INGRESAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cantidad.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(unidad_c.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "PARA CONTINUAR DEBES INGRESAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    unidad_c.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(unidad_v.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "PARA CONTINUAR DEBES INGRESAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    unidad_v.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(costo.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "PARA CONTINUAR DEBES INGRESAR LOS DATOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    costo.Focus();
                    return;
                }



                else
                {
                    consulta.Rows.Add();
                    int pos = consulta.Rows.Count - 1;
                    consulta.Rows[pos]["codigos"] = cod_art.Text.Trim();
                    consulta.Rows[pos]["descripcion"] = desc_art.Text.Trim();
                    consulta.Rows[pos]["cantidadd"] = cantidad.Text.Trim();
                    consulta.Rows[pos]["und_c"] = unidad_c.Text.Trim();
                    consulta.Rows[pos]["und_v"] = unidad_v.Text.Trim();
                    consulta.Rows[pos]["costos"] = costo.Text.Trim();
                    consulta.Rows[pos]["precio_v"] = txtprecio.Text.Trim();
                    consulta.Rows[pos]["importes"] = Convert.ToDouble(costo.Text) * Convert.ToDouble(cantidad.Text);
                    desc_art.Text = ""; cantidad.Text = ""; unidad_c.Text = ""; unidad_v.Text = ""; costo.Text = ""; cod_art.Text = ""; suma(); cod_art.Focus();
                }
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            int cant = 0; double s = 0; int tipo = 1; int cost_p = 0, cp = 0;

            int cc = 0;
            DataSet ds = new DataSet();
            if (data.Rows.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "NO HAY DATOS SUFICIENTES PARA CONTINUA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cod_mov.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE MOVIMIENTO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cod_mov.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_sup.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE SUPLIDOR ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE CAMPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cod_sup.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tipo_mov.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE TIPO DE MOVIMIENTO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE CAMPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tipo_mov.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_almacen.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE ALMACEN ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE CAMPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cod_almacen.Focus();
                return;
            }

          
            if (string.IsNullOrEmpty(documento.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "EL CAMPO DE DOCUMENTO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE CAMPO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                documento.Focus();
                return;
            }
            string cmd = "";

            //string cmd = string.Format("insert into movimiento (num_mov, cod_almacen, cod_suplidor, cod_tipo_mov, fecha, documento, usuario,cod_estado,total) values('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}')",Convert.ToInt16( cod_mov.Text.Trim()),Convert.ToInt16( cod_almacen.Text.Trim()),Convert.ToInt16( cod_sup.Text.Trim()),Convert.ToInt16( tipo), Convert.ToDateTime(fecha.Text.Trim()),Convert.ToString(documento.Text.Trim()),Convert.ToString( procesos.usuario),Convert.ToInt16(tipo), Convert.ToDouble(totales.Text.Trim()));
            cmd = string.Format("insert into movimiento (num_mov, cod_almacen, cod_suplidor, cod_tipo_mov,fecha, documento, usuario,cod_estado,total) values('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}')", Convert.ToInt16(cod_mov.Text.Trim()), Convert.ToInt16(cod_almacen.Text.Trim()), Convert.ToInt16(cod_sup.Text.Trim()), Convert.ToString(tipo), Convert.ToString(documento.Text.Trim()), Convert.ToString(procesos.usuario), Convert.ToString(tipo), Convert.ToDouble(st));
         //   MessageBox.Show(cmd);
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            try { }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }

            foreach (DataRow dr in consulta.Rows)
            {
                cmd = string.Format("insert into detalle_movimiento (num_mov, cod_art, cantidad, unidad_compra,unidad_venta, costo, valor) values('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}')", Convert.ToInt16(cod_mov.Text.Trim()), Convert.ToInt16(dr["codigos"]), Convert.ToInt16(dr["cantidadd"]), Convert.ToString(dr["und_c"]), Convert.ToString(dr["und_v"]), dr["costos"], dr["precio_v"]);
                // MessageBox.Show(cmd);
                ds = utilidades.UTILIDADES.ejecutar(cmd);

                cmd = "select * from existencia where cod_art='" + Convert.ToInt16(dr["Codigos"]) + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cant = Convert.ToInt16(ds.Tables[0].Rows[0]["cantidad"]);
                    cost_p = Convert.ToInt16(ds.Tables[0].Rows[0]["total"]);

                }

                s = Convert.ToInt16(dr["importes"]);//asignar el costo
                cc = cant + Convert.ToInt16(dr["cantidadd"]);//determinar la cantidad,para el c-c
                cp = Convert.ToInt16((cost_p + s) / cc);  //costo promedio
                int tt = cost_p + Convert.ToInt16(dr["importes"]);
                cmd = "update existencia set cod_almacen='" + tipo + "', " + "cod_art='" + Convert.ToInt16(dr["Codigos"]) + "', " + "costo_prom='" + Convert.ToInt16(cp) + "', " + "cantidad='" + cc + "', " + "cod_unidad='" + Convert.ToString(dr["und_v"]) + "', " + "total='" + Convert.ToInt16(tt) + "' where cod_art ='" + Convert.ToInt16(dr["Codigos"]) + "'";
                // MessageBox.Show(cmd);
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                try { }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                    return;
                }
            }
            clear();

            string cmdd = "select max (num_mov+1) as Mayor from movimiento";
            ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string textonum = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_mov.Text = textonum;   
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ACTUALMENTE NO HAY DATOS PARA BORRAR");
                return;
            }
            int pos = data.CurrentCell.RowIndex;
            consulta.Rows[pos].Delete();
            suma();
            cod_art.Focus();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            cod_art.Text = ""; desc_art.Text = ""; cantidad.Clear(); cod_art.Focus();
            if (data.Rows.Count == 0)
                return;
            data.DataSource = null;
            data.Rows.Clear();
            this.Close();
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_sup_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_sup.Text.Trim()))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_sup.Text = cod.ToString();
                }
            }
            cmd = "select * from suplidor where cod_suplidor='" + cod_sup.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nom_sup.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
            }
        }

        private void nom_sup_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nom_sup.Text.Trim()))
                return;
            string cmd = string.Format("select * from suplidor where nombre = '{0}'", nom_sup.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                cod_sup.Text = ds.Tables[0].Rows[0]["cod_suplidor"].ToString();
            }
            catch
            {
                MessageBox.Show("EL SUPLIDOR ACTUAL NO EXISTE");
            }
        }

        private void cod_almacen_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_almacen.Text.Trim()))
            {
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
                almacen.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void almacen_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(almacen.Text.Trim()))
                return;
            string cmd = string.Format("select * from almacen where descripcion = '{0}'", almacen.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                cod_almacen.Text = ds.Tables[0].Rows[0]["cod_almacen"].ToString();
            }
            catch
            {
                MessageBox.Show("EL ALMACEN ACTUAL NO EXISTE");
            }
        }

        private void cod_art_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_art.Text.Trim()))
            {
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
                desc_art.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                txtprecio.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
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

        private void unidad_v_Validating(object sender, CancelEventArgs e)
        {
            if (unidad_c.Text != unidad_v.Text)
            {
                btnunidad.Visible = true;
                txtc.Visible = true;
            }
            else
                if (unidad_c.Text == unidad_v.Text)
                {
                    btnunidad.Visible = false;
                    txtc.Visible = false;
                }
        }
    }
}
