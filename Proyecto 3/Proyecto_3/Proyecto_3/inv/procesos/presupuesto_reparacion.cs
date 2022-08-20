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
namespace Proyecto_3.inv.procesos
{
    public partial class presupuesto_reparacion : MetroForm
    {
        public presupuesto_reparacion()
        {
            InitializeComponent();

            consulta.Columns.Add("codigo1");
            consulta.Columns.Add("descripcion1");
            consulta.Columns.Add("cantidad");
            consulta.Columns.Add("precio1");
            consulta.Columns.Add("importe");
        }

        double l1 = 0;
        int poc = 0;
        int poc1 = 0;
        int sum = 0;
        int est = 0;
        int valor = 1;
        int sum1 = 0;
        int cod_ad = 0;
        string cod_a = "";
        double precio3;
        double l3;
        double pl = 0;
        double s3 = 0;
        string h = "";
        float to1 = 0;
       
        DataSet ds = new DataSet();
        CultureInfo us = new CultureInfo("en-US");
        public DataTable consulta = new DataTable();

         // string fecha = Convert.ToString(System.DateTime.Now);
         //fecc.Text = fecha;

        private void busca_cli()
        {
            proceso.titulo = "Clientes";

            proceso.query = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1";
            proceso.query_cod = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli";
            proceso.query_desc = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and per.nombre+''+per.apellido ";
            proceso.query2 = "select per.rnc as 'RNC',per.correo as 'Correo',per.telefono as 'Teléfono',per.celular as 'Celular',per.direccion as 'Dirección' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli= ";
        }

        private void cerrar()
        {
          /*  if (descuento.Text.Trim() != "" || mano_obra.Text.Trim() != "" || repuestos.Text.Trim() != "" || externos.Text.Trim() != "" || cod_veh.Text.Trim() != "" || cod_cli.Text!="" )
            {
                if (MetroMessageBox.Show(this, "Hay datos para procesar. Desea Salir?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {*/
                this.Close(); 
        //    }
        }

        private void nuevos()
        {
            fecha.Text = Convert.ToString(System.DateTime.Now);
            cod_cli.Text = "";
            cod_veh.Text = "";
            nombre_cli.Text = "";
            des_veh.Text = "";
            fecha_ent.Text = "";
            cod_ent.Text = "";
            descuento.Text = "0";

            data.Rows.Clear();
            data5.Rows.Clear();
            data2.Rows.Clear();
            data4.Rows.Clear();

          sumar_presupuesto();
            suma();
            suma3();
            suma2();

            cod_ent.Enabled = false;
            codigo_mayor();
            cambia_estado();
            desactivar();
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
            nombre_cli.Enabled = false;
            cod_cli.Enabled = false;
            cod_ent.Enabled = false;
            cod_veh.Enabled = false;
            des_veh.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            b10.Enabled = false;
            b11.Enabled = false;
            b12.Enabled = false;
            b13.Enabled = false;
            externos.Enabled = false;
            datos_averia.Enabled = false;
            des_falla.Enabled = false;
            repuestos.Enabled = false;
            data.Enabled = false;
            data2.Enabled = false;
            mano_obra.Enabled = false;
            descuento.Enabled = false;
            total_itbis.Enabled = false;
            general.Enabled = false;
            fecha.Enabled = false;
            fecha_ent.Enabled = false;
            data.Enabled = false;
            data2.Enabled = false;
            data4.Enabled = false;
            data5.Enabled = false;
            cod_ent.Enabled = false;
            habilitar.Enabled = false;
            codigo_a.Enabled = false;
            descripcion.Enabled = false;
            des_prod.Enabled = false;
            cod_prod.Enabled = false;
            des_prod.Enabled = false;
            cantidad1.Enabled = false;
            precio.Enabled = false;
            codigo4_1.Enabled = false;
            labor4_1.Enabled = false;
            cantidad4_1.Enabled = false;
            precio4_1.Enabled = false;
            datos_averia.Enabled = false;
            des_falla.Enabled = false;
            cantidad2_1.Enabled = false;
            precio2_1.Enabled = false;
            cantidad1.Enabled = false;
            cod_prep.Enabled = false;

            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            cod_ent.Enabled = true;
            cod_cli.Enabled = true;
            cod_veh.Enabled = true;
            estado.Enabled = true;
            activar2.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b10.Enabled = true;
            b11.Enabled = true;
            b12.Enabled = true;
            b13.Enabled = true;
            datos_averia.Enabled = true;
            des_falla.Enabled = true;
            data.Enabled = true;
            data2.Enabled = true;
            fecha.Enabled = true;
            data.Enabled = true;
            data2.Enabled = true;
            data4.Enabled = true;
            data5.Enabled = true;
            cod_ent.Enabled = true;
            habilitar.Enabled = true;
            codigo_a.Enabled = true;
            descripcion.Enabled = true;
            des_prod.Enabled = true;
            cod_prod.Enabled = true;
            des_prod.Enabled = true;
            cantidad1.Enabled = true;
            precio.Enabled = true;
            codigo4_1.Enabled = true;
            labor4_1.Enabled = true;
            cantidad4_1.Enabled = true;
            precio4_1.Enabled = true;
            datos_averia.Enabled = true;
            des_falla.Enabled = true;
            cantidad2_1.Enabled = true;
            precio2_1.Enabled = true;
            cantidad1.Enabled = true;
            cod_prep.Enabled = true;

            activar2.Enabled = false;
        }

        public void ejecutar(string dato)
        {
            cod_prod.Text = dato;
            valida_productos();
        }

        private void buscar()
        {
            proceso.titulo = "Productos";
            proceso.query = "select cod_rep as 'Codigo',descrip as 'Descripcion',precio_unidad as 'Precio' from articulos where estado=1";
            proceso.query_cod = "cod_rep as 'Codigo',descrip as 'Descripcion',precio_unidad as 'Precio' from articulos where estado=1 and cod_rep";
            proceso.query_desc = "cod_rep as 'Codigo',descrip as 'Descripcion',precio_unidad as 'Precio' from articulos where estado=1 and descrip ";
        }

        private void busca_art()
        {
            proceso.titulo = "Artículos";
            proceso.query = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1";
            proceso.query_cod = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and cod_rep";
            proceso.query_desc = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and descrip ";
            proceso.query2 = "select replace((round(exist,2)),',','.') as 'Existencia',marca as 'Marca',replace((round(precio_unidad,2)),',','.') as 'Precio',coment as 'Comentario' from articulos where estado=1  and cod_rep= ";
        }

        private void busca2()
        {
            proceso.titulo = "Averías";
            proceso.query = "select cod_falla as 'Codigo',desc_falla as 'Descripcion' from fallas where estado=1";
            proceso.query_cod = "select cod_falla as 'Codigo',desc_falla as 'Descripcion' from fallas where estado=1 and cod_falla";
            proceso.query_desc = "select cod_falla as 'Codigo',desc_falla as 'Descripcion' from fallas where estado=1 and desc_falla ";
            proceso.query2 = "select cod_falla as 'codigo',desc_falla as 'descripcion' from fallas where estado=3 and cod_falla= ";
        }

        private void busca()
        {
            proceso.titulo = "Vehículos";
            proceso.query = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1";
            proceso.query_cod = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh";
            proceso.query_desc = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1 and veh.detalles ";
            proceso.query2 = "select distinct ma.descripcion as 'Marca',model.descripcion as 'Modelo',veh.motor as 'Motor', comentario as 'Comentario' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as model on model.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh= ";
        }

        private void valida_averia()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from fallas where cod_falla='" + datos_averia.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_falla.Text = Convert.ToString(ds.Tables[0].Rows[0]["desc_falla"]);
            }
            else
            {
                des_falla.Text = "";
                datos_averia.Text = "";
            }
        }

        public void ejecutar_fal(string dato)
        {
            datos_averia.Text = dato;
            valida_averia();
        }

        public void ejec_art(string dato)
        {
            cod_prod.Text = dato;
            validating_art();
        }

        public void ejecutar_veh(string dato)
        {
            cod_veh.Text = dato;
            valida_vehiculo();
        }

        private void validating_art()
        {
            CultureInfo us = new CultureInfo("en-US");

            DataSet ds = new DataSet();
            string cmd = "select * from articulos where cod_rep='" + cod_prod.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);

                des_prod.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                string elvin= Convert.ToString(ds.Tables[0].Rows[0]["precio_unidad"]);
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                precio.Text =ll2;
                cantidad1.Select();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_pres+1) as Mayor from presupuesto_reparacion";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_prep.Text = numfac;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from presupuesto_reparacion where cod_pres='" + cod_prep.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
               cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_cli"]);
                DateTime ti=(Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]));
               fecha.Text = ti.ToShortDateString();
               fecha_ent.Text = Convert.ToString(Convert.ToDateTime(ds.Tables[0].Rows[0]["fec_ent"]));
               cod_veh.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_veh"]);
               estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);

               valida_vehiculo();
               valida_cliente();

               insertar_data4();
                insertar_data3();
               insertar_data2();
               insertar_data();
              

               string elvin1 = ds.Tables[0].Rows[0]["total_desc"].ToString();
               double s1 = Convert.ToDouble(elvin1);
               string ll1 = s1.ToString("0.00", us);
               descuento.Text = ll1;
               sumar_presupuesto();
            }
           else
            {
                codigo_mayor();

               cod_cli.Text = "";
                estado.Checked = false;
                cod_veh.Text = "";
                fecha_ent.Text = "";
               descuento.Text = "";
               fecha.Text = "";
               estado.Checked = false;
            }

            if (estado.Checked == false)
            {
                valida_estado();
            }

           cod_prep.Enabled = false;
           cod_cli.Select();
           cod_cli.Focus();

        }

        public void ejecutar_cli(string dato)
        {
            cod_cli.Text = dato;
            valida_cliente();
        }

        private void valida_vehiculo()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from vehiculo where cod_veh='" + cod_veh.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_veh.Text = Convert.ToString(ds.Tables[0].Rows[0]["detalles"]);
            }
            else
            {
                cod_veh.Text = "";
                des_veh.Text = "";
            }
        }

        private void valida_cliente()
        {
            DataSet ds = new DataSet();
            string cmd = "select per.nombre+' '+per.apellido as nombre from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where cli.cod_cli='" + cod_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
            }
            else
            {
                cod_cli.Text = "";
                nombre_cli.Text = "";
            }
        }

        public void suma()
        {
            string ll1 = "";
            string ll2 = "";
            string ll3 = "";
            double s = 0;
            double i = 0;
            double t = 0;
            foreach (DataGridViewRow row in data.Rows)
            {
               
                string elvin = Convert.ToString(row.Cells[4].Value);
                float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                s += Convert.ToDouble(num3);
                i = s * 0.18;
                t = s + i;

                ll1 = s.ToString("0.00", us);
                ll2 = i.ToString("0.00", us);
                ll3 = t.ToString("0.00", us);

            }
            total.Text = ll1;
            itbis.Text =ll2;
            totg.Text = ll3;
            sumar_presupuesto();
        }

        public void suma2()
        {
            string ll1 = "";
            string ll2 = "";
            string ll3 = "";
            double s = 0;
            double i = 0;
            double t = 0;
            foreach (DataGridViewRow row in data2.Rows)
            {
                string elvin = Convert.ToString(row.Cells[4].Value);
                float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                s += Convert.ToDouble(num3);
                i = s * 0.18;
                t = s + i;

                ll1 = s.ToString("0.00", us);
                ll2 = i.ToString("0.00", us);
                ll3 = t.ToString("0.00", us);

            }
            total2.Text = ll1;
            itbis2.Text = ll2;
            totg2.Text = ll3;
            sumar_presupuesto();

        }

        public void suma3()
        {
            string ll1 = "";
            string ll2 = "";
            string ll3 = "";
            double s = 0;
            double i = 0;
            double t = 0;
            foreach (DataGridViewRow row in data4.Rows)
            {
                string elvin = Convert.ToString(row.Cells[4].Value);
                float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                s += Convert.ToDouble(num3);
                i = s * 0.18;
                t = s + i;

                ll1 = s.ToString("0.00", us);
                ll2 = i.ToString("0.00", us);
                ll3 = t.ToString("0.00", us);

            }
            subtot4.Text = ll1;
            itbis4.Text = ll2;
            total4.Text = ll3;
            sumar_presupuesto();

        }

        private void en_grid()
        {
            cod_prod.Text = "";
            des_prod.Text = "";
            precio.Text = "";
            cantidad1.Text = "";
            des_prod.Select();
            suma();
        }

        private void en_grid2()
        {
            descripcion.Text = "";
            precio2_1.Text = "";
            cantidad2_1.Text = "";
            codigo_a.Text = "";
            descripcion.Select();
            suma2();
        }

        private void en_grid3()
        {
            codigo4_1.Text = "";
            labor4_1.Text = "";
            cantidad4_1.Text = "";
            precio4_1.Text = "";
            codigo4_1.Select();
            suma3();
        }

        private void sumar_presupuesto()
        {
            float tot_it = 0;
            float des = 0;
            float cal = 0;
            float t = 0;
            float d = 0;
            float w = 0;
            string p ="";
            string q = "";
            string r = "";
            string s = "";
            string u = "";
            string v = "";
            float num3 = 0;
            float num4 = 0;
            float num5 = 0;
            float num6 = 0;
            float num7 = 0;
            float num8 = 0;

             if (string.IsNullOrEmpty(itbis2.Text.Trim()))
                 itbis2.Text = "0";
             if (string.IsNullOrEmpty(itbis.Text.Trim()))
                 itbis.Text = "0";
             if (string.IsNullOrEmpty(itbis4.Text))
                 itbis4.Text = "0";
             if (string.IsNullOrEmpty(descuento.Text))
                 descuento.Text = "0";
             if (string.IsNullOrEmpty(totg2.Text))
                 totg2.Text = "0";
             if (string.IsNullOrEmpty(totg.Text))
                 totg.Text = "0";
             if (string.IsNullOrEmpty(total4.Text.Trim()))
                 total4.Text = "0";

                string elvin = itbis4.Text.Trim();
                float numf = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                string elvin1 = itbis2.Text.Trim();
                float numf1 = float.Parse(elvin1, CultureInfo.InvariantCulture.NumberFormat);
                string elvin2 = itbis.Text.Trim();
                float numf2 = float.Parse(elvin2, CultureInfo.InvariantCulture.NumberFormat);

                string elvin3 = descuento.Text.Trim();
                des = float.Parse(elvin3, CultureInfo.InvariantCulture.NumberFormat); //descuento

                string tot1 = totg2.Text.Trim();
                 to1 = float.Parse(tot1, CultureInfo.InvariantCulture.NumberFormat);
                string ll1 = to1.ToString("0.00", us);
               
                string tot2 = totg.Text.Trim();
                float to2 = float.Parse(tot2, CultureInfo.InvariantCulture.NumberFormat);
                string ll4 = to2.ToString("0.00", us);  

                string tot3 = total4.Text.Trim();
                float to3 = float.Parse(tot3, CultureInfo.InvariantCulture.NumberFormat);
                 h = to3.ToString();

                tot_it = numf + numf1 + numf2;
                p = tot_it.ToString();
                pl = Convert.ToDouble(p);
                string ll2 = pl.ToString("0.00", us);

                cal = to1 + to2 + to3; ;
                r = Convert.ToString(cal);
                num5 = float.Parse(r, CultureInfo.InvariantCulture.NumberFormat);

                float totgn = cal - des;
                string elvin33 = totgn.ToString();
                 s3 = Convert.ToDouble(elvin33);
                string ll23 = s3.ToString("0.00", us);

            if (des > cal)
            {
  MetroMessageBox.Show(this, "El monto del descuento no puede ser mayor que el total del presupueso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
  descuento.Text = "";
                    return;
            }
            else
            {
               general.Text =ll23.ToString() ;
            }

           total_itbis.Text = ll2;
            externos.Text = ll1;
            repuestos.Text =ll4;
            mano_obra.Text =tot3;
        }

        private void insertar_data() 
        {
            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "select cod_falla,des_falla from fallas_vs_presupuesto where cod_prep='" + cod_prep.Text + "' order by cod_falla";
            comando.CommandType = CommandType.Text;
            con.Open();
            data5.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data5.Rows.Add();
                data5.Rows[renglon].Cells["codigo5"].Value = dr.GetInt32(dr.GetOrdinal("cod_falla")).ToString();
                data5.Rows[renglon].Cells["descripcion5"].Value = dr.GetString(dr.GetOrdinal("des_falla")).ToString();

            }
            con.Close();
        }//fallas

        private void insertar_data2()
        {

            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "select cod_rep,descrip,precio,cantidad,importe from repuestos_vs_presupuesto where cod_prep='" + cod_prep.Text + "' order by cod_rep";
            comando.CommandType = CommandType.Text;
            con.Open();
            data.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data.Rows.Add();
                data.Rows[renglon].Cells["codigo1"].Value = dr.GetInt32(dr.GetOrdinal("cod_rep")).ToString();
                data.Rows[renglon].Cells["descripcion1"].Value = dr.GetString(dr.GetOrdinal("descrip")).ToString();
                data.Rows[renglon].Cells["cantidad"].Value = dr.GetInt32(dr.GetOrdinal("cantidad")).ToString();
                string elvin = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("precio"))).ToString();
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                data.Rows[renglon].Cells["precio1"].Value = ll2;

                string elvin1 = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("importe"))).ToString();
                double s1 = Convert.ToDouble(elvin1);
                string ll1 = s1.ToString("0.00", us);
                data.Rows[renglon].Cells["importe"].Value = ll1;

                //  sumar_presupuesto();
                suma();
                suma2();
                suma3();
            }
            con.Close();
        } //repuestos

        private void insertar_data4()
        {

            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "select cod_labor,des_labor,cantidad,precio,importe from labores_vs_presupuesto where cod_prep='" + cod_prep.Text + "' order by cod_labor";
            comando.CommandType = CommandType.Text;
            con.Open();
            data4.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data4.Rows.Add();
                data4.Rows[renglon].Cells["codigo4"].Value = dr.GetInt32(dr.GetOrdinal("cod_labor")).ToString();
                data4.Rows[renglon].Cells["labor4"].Value = dr.GetString(dr.GetOrdinal("des_labor")).ToString();
                data4.Rows[renglon].Cells["cantidad4"].Value = dr.GetInt32(dr.GetOrdinal("cantidad")).ToString();
                string elvin = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("precio"))).ToString();
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                data4.Rows[renglon].Cells["precio4"].Value = ll2;

                string elvin1 = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("importe"))).ToString();
                double s1 = Convert.ToDouble(elvin1);
                string ll1 = s1.ToString("0.00", us);
                data4.Rows[renglon].Cells["importe4"].Value = ll1;

                //  sumar_presupuesto();
                suma();
                suma2();
                suma3();
            }
            con.Close();
        } //repuestos

        private void insertar_data3()
        {

            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "select cod_man,descrip,cantidad,precio,importe from trab_externos_vs_presupuesto where cod_pres='" + cod_prep.Text + "' order by cod_man";
            comando.CommandType = CommandType.Text;
            con.Open();
            data2.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data2.Rows.Add();
                data2.Rows[renglon].Cells["codigo2"].Value = dr.GetInt32(dr.GetOrdinal("cod_man")).ToString();
                data2.Rows[renglon].Cells["descripcion2"].Value = dr.GetString(dr.GetOrdinal("descrip")).ToString();
                data2.Rows[renglon].Cells["cantidad2"].Value = dr.GetInt32(dr.GetOrdinal("cantidad")).ToString();
                string elvin = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("precio"))).ToString();
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                data2.Rows[renglon].Cells["precio2"].Value = ll2;

                string elvin1 = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("importe"))).ToString();
                double s1 = Convert.ToDouble(elvin1);
                string ll1 = s1.ToString("0.00", us);
                data2.Rows[renglon].Cells["importe2"].Value = ll1;

                //  sumar_presupuesto();
                suma();
                suma2();
                suma3();
            }
            con.Close();
        } //trabajos externos

        private void cuenta_celdas()
        {
            string cod_a1 = data2.Rows.Count.ToString();
            cod_ad = Convert.ToInt16(cod_a1) + 1;
            cod_a = cod_ad.ToString();
            codigo_a.Text=cod_a;
        }

        private void valida_productos()
        {
            string cmd = "select * from articulos where cod_rep='" + cod_prod.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_prod.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                l1 = Convert.ToDouble(ds.Tables[0].Rows[0]["precio_unidad"]);
                string ll1 = l1.ToString("0.00", us);
                precio.Text = ll1;

                cantidad1.Select();
                cantidad1.Focus();
            }
            else
            {
                cod_prod.Text = "";
                des_prod.Text = "";
                precio.Text = "";
            }
        }

        private void valida_labores()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from labores where codlabor='" + codigo4_1.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                labor4_1.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                 l3 = Convert.ToDouble(ds.Tables[0].Rows[0]["precio"]);
                string ll7 = l3.ToString("0.00", us);
                precio4_1.Text = ll7;
            }
            else
            {
                codigo4_1.Text = "";
                labor4_1.Text = "";
            }
            cantidad4_1.Select();
        }

        private void busca3()
        {
            proceso.titulo = "Labores";
            proceso.query = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1";
            proceso.query_cod = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1 and codlabor";
            proceso.query_desc = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1 and descrip ";
            proceso.query2 = "select codlabor as 'codigo',descrip as 'descripcion' from labores where estado=3 and codlabor= ";
        }

        public void ejecutar_labor(string dato)
        {
            codigo4_1.Text = dato;
            valida_labores();
        }

        private void save()
        {
            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            int x;
            int y;
            int f;
            int l;

            if (estado.Checked == true)
                   est = 1;
               else
                   est = 0;

               if (string.IsNullOrEmpty(general.Text.Trim()) || string.IsNullOrEmpty(cod_cli.Text.Trim()) || string.IsNullOrEmpty(cod_veh.Text.Trim()))
               {
                   MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return;
               }
              else
               {
                     try // DateTime.Now.ToShortDateString() 
                       {
                     string fd = Convert.ToString(descuento.Text);
                      float num4 = float.Parse(fd, CultureInfo.InvariantCulture.NumberFormat);

                      string cmd = "act_presupuesto_reparacion '" + cod_prep.Text + "','" + cod_veh.Text + "','" + cod_cli.Text + "','" + est + "','" + fecha.Text + "','" + total_itbis.Text.Trim() + "','" + descuento.Text.Trim() + "','" + general.Text.Trim() + "','" + mano_obra.Text.Trim() + "','" + externos.Text.Trim() + "','" + 1 + "','" + 1 + "','" + proceso.usuario + "','" + 1 + "','" +Convert.ToDateTime(fecha_ent.Text.Trim()) + "'";
                      utilidades.UTILIDADES.ejecutar(cmd);

                 //-------------------------------------------- externos-------------------------
                   string cmd1 = "delete from trab_externos_vs_presupuesto where cod_pres=" + cod_prep.Text.Trim();
                           utilidades.UTILIDADES.ejecutar(cmd1);

                           for (x = 0; x <= data2.Rows.Count - 1; x++)
                           {
                               string p = Convert.ToString(data2.Rows[x].Cells[3].Value);
                               float num45 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                               string ll4 = num45.ToString("0.00", us);

                               string p1 = Convert.ToString(data2.Rows[x].Cells[4].Value);
                               float num41 = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                               string ll1 = num41.ToString("0.00", us);

                               string hd = "act_trab_externos_vs_presupuesto '" + cod_prep.Text + "','" + data2.Rows[x].Cells[1].Value.ToString() + "','" + data2.Rows[x].Cells[2].Value.ToString() + "','" + ll4 + "','" + ll1 + "','" + data2.Rows[x].Cells[0].Value.ToString() + "'";

                           
                               utilidades.UTILIDADES.ejecutar(hd);
                            

                           }

                     //----------------------------------repuestos-------------------
                    string cmd2 = "delete from repuestos_vs_presupuesto where cod_prep='" + cod_prep.Text.Trim() + "'";
                    utilidades.UTILIDADES.ejecutar(cmd2);

                    for (y = 0; y <= data.Rows.Count - 1; y++)
                    {
                        string p = Convert.ToString(data.Rows[y].Cells[3].Value);
                        float num45 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                        string ll4 = num45.ToString("0.00", us);

                        string p1 = Convert.ToString(data.Rows[y].Cells[4].Value);
                        float num41 = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                        string ll1 = num41.ToString("0.00", us);

                        string g = "act_repuestos_vs_presupuesto '" + cod_prep.Text + "','" + data.Rows[y].Cells[0].Value.ToString() + "','" + data.Rows[y].Cells[1].Value.ToString() + "','" + ll4 + "','" + data.Rows[y].Cells[2].Value.ToString() + "','" + ll1+ "'";

                        utilidades.UTILIDADES.ejecutar(g);
                    }

            //----------------------------------mano de obra-------------------
               string cmd3 = "delete from labores_vs_presupuesto where cod_prep='" + cod_prep.Text.Trim() + "'";
               utilidades.UTILIDADES.ejecutar(cmd3);

               for (f = 0; f <= data4.Rows.Count - 1; f++)
               {
                   string p = Convert.ToString(data4.Rows[f].Cells[3].Value);
                   float num45 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                   string ll4 = num45.ToString("0.00", us);

                   string p1 = Convert.ToString(data4.Rows[f].Cells[4].Value);
                   float num41 = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                   string ll1 = num41.ToString("0.00", us);

                   string d = "act_labores_vs_presupuesto '" + cod_prep.Text + "','" + data4.Rows[f].Cells[0].Value.ToString() + "','" + data4.Rows[f].Cells[1].Value.ToString() + "','" + data4.Rows[f].Cells[2].Value.ToString() + "','" + ll4 + "','" + ll1 + "'";

                   utilidades.UTILIDADES.ejecutar(d);
               }


             //----------------------------------repuestos traidos por el cliente-------------------
            string cmd6 = "delete from fallas_vs_presupuesto where cod_prep='" + cod_prep.Text.Trim() + "'";
            utilidades.UTILIDADES.ejecutar(cmd6);
            for (l = 0; l <= data5.Rows.Count - 1; l++)
            {
                string d = "act_fallas_vs_presupuesto '" + cod_prep.Text + "','" + data5.Rows[l].Cells[0].Value.ToString() + "','" + data5.Rows[l].Cells[1].Value.ToString() + "'";

                utilidades.UTILIDADES.ejecutar(d);
            }

           }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            nuevos();
            codigo_mayor();
            desactivar();
            cod_veh.Select();
            cod_ent.Enabled = false;
       }
            }

        private void activar_registro()
        {
            est = 1;
                string cmd = "update presupuesto_reparacion set estado=1 where cod_pres='" + cod_prep.Text + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                estado.Checked = true;
                cambia_estado();
                estado.Checked = true;
                activar2.Enabled = false;
        }

        private void presupuesto_reparacion_Load(object sender, EventArgs e)
        {
            cuenta_celdas();
            codigo_mayor();
       sumar_presupuesto();

           activar2.Enabled = false;
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void b4_Click(object sender, EventArgs e)
        {

            string elvin = precio.Text;
            float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
            string p = Convert.ToString(num3);

            if (string.IsNullOrEmpty(cod_prod.Text.Trim()) || string.IsNullOrEmpty(des_prod.Text.Trim()) || string.IsNullOrEmpty(cantidad1.Text.Trim()) || string.IsNullOrEmpty(precio.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_prod.Select();
                return;
            }
            if (string.IsNullOrEmpty(cantidad1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores No Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad1.Select();
                return;
            }
            else
            {
                bool exist = data.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo1"].Value) == cod_prod.Text);
                if (!exist)
                {
                    double imp = Convert.ToDouble(p) * Convert.ToDouble(cantidad1.Text);
                    string ll2 = imp.ToString("0.00", us);

                    data.Rows.Add(cod_prod.Text.Trim(), des_prod.Text.Trim(), cantidad1.Text.Trim(), precio.Text.Trim(), ll2);
                    data.Sort(codigo1, System.ComponentModel.ListSortDirection.Ascending);
                    en_grid();
                 //   sumar_presupuesto();
                }
                if (sum==1)
                {
                    foreach (DataGridViewRow fila in data.Rows)
                    {
                        if (fila.Cells[codigo1.Name].Value.ToString() == cod_prod.Text.Trim())
                        {
                            fila.Cells[codigo1.Name].Value = cod_prod.Text.Trim();
                            fila.Cells[descripcion1.Name].Value = des_prod.Text.Trim();
                            fila.Cells[cantidad.Name].Value = Convert.ToInt32(cantidad1.Text.Trim());
                            fila.Cells[precio1.Name].Value = precio.Text.Trim();
                            double imp = Convert.ToDouble(l1) * Convert.ToDouble(cantidad1.Text);
                            string ll2 = imp.ToString("0.00", us);
                            fila.Cells[importe.Name].Value = ll2;
                            en_grid();
                            sum = 0;
                          //  sumar_presupuesto();
                        }
                    } 
                }

            if (exist)
                {

                    foreach (DataGridViewRow fila in data.Rows)
                    {
                        if (fila.Cells[codigo1.Name].Value.ToString() == cod_prod.Text.Trim())
                        {
                 fila.Cells[codigo1.Name].Value = cod_prod.Text.Trim();
                 fila.Cells[descripcion1.Name].Value = des_prod.Text.Trim();
                 fila.Cells[cantidad.Name].Value = Convert.ToInt32(fila.Cells[cantidad.Name].Value) + Convert.ToInt32(cantidad1.Text.Trim());
                 fila.Cells[precio1.Name].Value = precio.Text.Trim();
                 double imp = Convert.ToDouble(l1) * Convert.ToDouble(cantidad1.Text);
                 string ll2 = imp.ToString("0.00", us);
                 fila.Cells[importe.Name].Value =ll2;
                 en_grid();
              //   sumar_presupuesto();
                        }
                    } 
                }
            }
            cod_prod.Select();
          
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (data.CurrentRow == null)
                return;
            data.Rows.Remove(data.CurrentRow);
            en_grid();
            sum = 0;
           // sumar_presupuesto();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            busca_art();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejec_art);
            form2.ShowDialog();
        }

        private void presupuesto_reparacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cod_labor_Validating(object sender, CancelEventArgs e)
        {
            valida_productos();
            cantidad1.Select();
            cantidad1.Focus();
        }

        private void precio_Validating(object sender, CancelEventArgs e)
        {
            b4.Select();
        }

        private void cantidad1_Validating(object sender, CancelEventArgs e)
        {
            precio.Select();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = data.CurrentRow.Index;
            sum = 1;
            cod_prod.Text = Convert.ToString(data.Rows[poc].Cells[0].Value);
            des_prod.Text = Convert.ToString(data.Rows[poc].Cells[1].Value);
            cantidad1.Text = Convert.ToString(data.Rows[poc].Cells[2].Value);
            precio.Text = Convert.ToString(data.Rows[poc].Cells[3].Value);
        }

        private void data_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
                cuenta_celdas();

            if (string.IsNullOrEmpty(descripcion.Text.Trim()) || string.IsNullOrEmpty(cantidad2_1.Text.Trim()) || string.IsNullOrEmpty(precio2_1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                descripcion.Select();
                return;
            }
            if (string.IsNullOrEmpty(cantidad2_1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores No Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad2_1.Select();
                return;
            }
                 

            else
            {
                bool exist = data2.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo2"].Value) == codigo_a.Text);
                if (!exist)
                {

                    string elvin = precio2_1.Text;
                    float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                    string p = Convert.ToString(num3);

                    double imp = Convert.ToDouble(p) * Convert.ToDouble(cantidad2_1.Text);
                    string ll2 = imp.ToString("0.00", us);

                    data2.Rows.Add(codigo_a.Text, descripcion.Text.Trim(), cantidad2_1.Text.Trim(), precio2_1.Text.Trim(), ll2);
                    data2.Sort(codigo2, System.ComponentModel.ListSortDirection.Ascending);
                    en_grid2();
                 //   sumar_presupuesto();
                }
                if (sum == 1)
                {
                    foreach (DataGridViewRow fila in data2.Rows)
                    {
                        if (fila.Cells[codigo1.Name].Value.ToString() == codigo_a.Text)
                        {
                            fila.Cells[codigo2.Name].Value = codigo_a.Text;
                            fila.Cells[descripcion2.Name].Value = descripcion.Text.Trim();
                            fila.Cells[cantidad2.Name].Value = Convert.ToInt32(cantidad2_1.Text.Trim());
                            fila.Cells[precio2.Name].Value = precio2_1.Text.Trim();
                            double imp = Convert.ToDouble(l3) * Convert.ToDouble(cantidad2_1.Text);
                            string ll5 = imp.ToString("0.00", us);
                            fila.Cells[importe2.Name].Value = ll5;
                            en_grid2();
                            sum1 = 0;
                           // sumar_presupuesto();
                        }
                    }
                }

                if (exist)
                {

                    foreach (DataGridViewRow fila in data2.Rows)
                    {
                        if (fila.Cells[codigo2.Name].Value.ToString() == codigo_a.Text)
                        {
                            fila.Cells[codigo2.Name].Value = codigo_a.Text;
                            fila.Cells[descripcion2.Name].Value = descripcion.Text.Trim();
                            fila.Cells[cantidad2.Name].Value = Convert.ToInt32(fila.Cells[cantidad2.Name].Value) + Convert.ToInt32(cantidad2_1.Text.Trim());
                            fila.Cells[precio2.Name].Value = precio2_1.Text.Trim();
                            double imp = Convert.ToDouble(l3) * Convert.ToDouble(cantidad2_1.Text);
                            string ll2 = imp.ToString("0.00", us);
                            fila.Cells[importe2.Name].Value = ll2;
                            en_grid2();
                          //  sumar_presupuesto();
                        }
                    }
                }
            }

            cuenta_celdas();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (data2.CurrentRow == null)
                return;
            data2.Rows.Remove(data2.CurrentRow);
            en_grid2();
            sum1 = 0;
        }

        private void data2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc1 = data2.CurrentRow.Index;
            sum1 = 1;
            codigo_a.Text = Convert.ToString(data2.Rows[poc1].Cells[0].Value);
            descripcion.Text = Convert.ToString(data2.Rows[poc1].Cells[1].Value);
            cantidad2_1.Text = Convert.ToString(data2.Rows[poc1].Cells[2].Value);
            precio2_1.Text = Convert.ToString(data2.Rows[poc1].Cells[3].Value);
        }

        private void cod_ent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_prep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metroTextBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metroTextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cantidad2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void codigo_a_Click(object sender, EventArgs e)
        {

        }

        private void codigo_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cantidad1_Click(object sender, EventArgs e)
        {

        }

        private void cantidad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void precio2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (precio2_1.Text.Contains('.'))
           {
               if (!char.IsDigit(e.KeyChar)) { e.Handled = true;}
               if (e.KeyChar == '\b'){e.Handled = false;} 
           }
           else
           {
               if(!char.IsDigit(e.KeyChar)){e.Handled = true;}
               if(e.KeyChar=='.' || e.KeyChar=='\b'){e.Handled = false;}
            }
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (precio.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '\b') { e.Handled = false; }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '.' || e.KeyChar == '\b') { e.Handled = false; }
            }
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (precio4_1.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '\b') { e.Handled = false; }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '.' || e.KeyChar == '\b') { e.Handled = false; }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string elvin = precio4_1.Text;
            float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
            string p = Convert.ToString(num3);

            if (string.IsNullOrEmpty(codigo4_1.Text.Trim()) || string.IsNullOrEmpty(labor4_1.Text.Trim()) || string.IsNullOrEmpty(cantidad4_1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codigo4_1.Select();
                return;
            }
            if (string.IsNullOrEmpty(cantidad4_1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Cantidad No Válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad4_1.Select();
                return;
            }
            else
            {
                bool exist = data4.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo4"].Value) == codigo4_1.Text);

                if (!exist)
                {
                    double imp = Convert.ToDouble(p) * Convert.ToDouble(cantidad4_1.Text);
                    string ll2 = imp.ToString("0.00", us);

                    data4.Rows.Add(codigo4_1.Text.Trim(), labor4_1.Text.Trim(), cantidad4_1.Text.Trim(), precio4_1.Text,ll2);
                    data4.Sort(codigo4, System.ComponentModel.ListSortDirection.Ascending);
                    en_grid3();
                  //  sumar_presupuesto();
                }

            }
           
        }

        private void codigo4_1_Validating(object sender, CancelEventArgs e)
        {
            valida_labores();
            cantidad4_1.Select();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (data4.CurrentRow == null)
                return;
            data4.Rows.Remove(data4.CurrentRow);
            en_grid3();
            sum = 0;
            //sumar_presupuesto();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            busca3();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_labor);
            form2.ShowDialog();
            cantidad4_1.Select();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            cod_cli.Select();
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            cod_prep.Enabled = true;
            cod_prep.Select();
        }

        private void habilitar_TextChanged(object sender, EventArgs e)
        {
            cod_prep.Enabled = false;
            cod_prep.Select();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(datos_averia.Text.Trim()) || string.IsNullOrEmpty(des_falla.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datos_averia.Select();
                return;
            }
            else
            {
        bool exist = data5.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo5"].Value) == datos_averia.Text);
                if (!exist)
                {
                    data5.Rows.Add(datos_averia.Text.Trim(), des_falla.Text.Trim());
                    data5.Sort(codigo5, System.ComponentModel.ListSortDirection.Ascending);
                    datos_averia.Text = "";
                    des_falla.Text = "";
                    datos_averia.Select();
                }
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (data5.CurrentRow == null)
                return;
            data5.Rows.Remove(data5.CurrentRow);
            datos_averia.Select();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            busca2();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_fal);
            form2.ShowDialog();
        }

        private void datos_averia_Validating(object sender, CancelEventArgs e)
        {
            valida_averia();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.fallas veh = new mantenimientos.fallas();
            veh.ShowDialog();
        }

        private void metroTabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void datos_averia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            save();
            cod_cli.Select();
        }

        private void descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (descuento.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '\b') { e.Handled = false; }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
                if (e.KeyChar == '.' || e.KeyChar == '\b') { e.Handled = false; }
            }
        }

        private void subtot4_TextChanged(object sender, EventArgs e)
        {
            suma();
        }

        private void subtot4_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void itbis4_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void total4_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void descuento_Validating(object sender, CancelEventArgs e)
        {
            sumar_presupuesto();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            busca_cli();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_cli);
            form2.ShowDialog();
        }

        private void cod_cli_Validating(object sender, CancelEventArgs e)
        {
            valida_cliente();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_veh);
            form2.ShowDialog();
        }

        private void cod_veh_Validating(object sender, CancelEventArgs e)
        {
            valida_vehiculo();
        }

        private void cod_prep_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void activar2_Click(object sender, EventArgs e)
        {
            activar_registro();
            cambia_estado();
            cod_cli.Select();
            activar2.Enabled = false;
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
