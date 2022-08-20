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
    public partial class entrada_talle : MetroForm
    {

         int est = 0;
         int combusti = 0;
         string com ="";
         int combustible = 0;
         string precio ="";
         double precio1 = 0;
         int cod_ad = 0;
         string cod_a = "";
         CultureInfo us = new CultureInfo("en-US");

         DataSet ds = new DataSet();

        public entrada_talle()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            nombre.Text = "";
            estado.Checked = false;
            cod_veh.Text = "";
            codcom.Text = "";
            cod_cli.Text = ""; 
            otros_det.Text = "";
            des_labor.Text = "";
            telefono.Text = "";
            celular.Text = "";
            correo.Text = "";
            direccion.Text = "";
            des_veh.Text = "";
            placa.Text = "";
            des_seguro.Text = "";
           seguro.Text = "";
            cod_ent.Enabled = false;

            data.Rows.Clear();
            data1.Rows.Clear();
            data2.Rows.Clear();

            codigo_mayor();
            cambia_estado();
            activar();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_ent+1) as Mayor from ent_taller";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_ent.Text = numfac;
        }

        public void ejecutar(string dato)
        {
            cod_veh.Text = dato;
            valida_vehiculo();
        }

        public void ejecutar_cli(string dato)
        {
            cod_cli.Text = dato;
            valida_cliente();
        }

        public void ejecutar_fal(string dato)
        {
            datos_averia.Text = dato;
            valida_averia();
        }

        public void ejecutar_labor(string dato)
        {
            cod_labor.Text = dato;
            valida_labores();
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
            nombre.Enabled = false;
            cod_cli.Enabled = false;
            cod_ent.Enabled = false;
            cod_veh.Enabled = false;
            codcom.Enabled = false;
             placa.Enabled = false;
             datos_averia.Enabled = false;
             des_falla.Enabled = false;
             otros_det.Enabled = false;
              data.Enabled = false;
              data2.Enabled = false;
              telefono.Enabled = false;
              celular.Enabled = false;
              correo.Enabled = false;
              direccion.Enabled = false;
              cod_labor.Enabled = false;
              des_labor.Enabled = false;
              data1.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
           ad.Enabled = false;
           re.Enabled = false;
            bu.Enabled = false;
            can_prod.Enabled = false;
            des_prod.Enabled = false;
            cod_prod.Enabled = false;
            buscar.Enabled = false;
            can_prod.Enabled = false;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            nombre.Enabled = true;
            cod_cli.Enabled = true;
            cod_ent.Enabled = true;
            cod_veh.Enabled = true;
            codcom.Enabled = true;
            placa.Enabled = true;
            datos_averia.Enabled = true;
            otros_det.Enabled = true;
            data.Enabled = true;
            data1.Enabled = true;
            data2.Enabled = true;
            cod_labor.Enabled = true;
            estado.Enabled = true;
            activar2.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            ad.Enabled = true;
            re.Enabled = true;
            bu.Enabled = true;
            can_prod.Enabled = true;
            des_prod.Enabled = true;
            cod_prod.Enabled = true;
            buscar.Enabled = true;
        }

        private void insertar_data()
        {
            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
             SqlConnection con = new SqlConnection();
             SqlCommand comando = new SqlCommand();
             SqlDataReader dr;
             con.ConnectionString = cadenaconexion;
             comando.Connection = con;
             comando.CommandText = "select cod_falla,des_falla from fallas_vs_entrada where cod_ent='" + cod_ent.Text + "' order by cod_falla";
             comando.CommandType = CommandType.Text;
             con.Open();
             data.Rows.Clear();
             dr = comando.ExecuteReader();
             while (dr.Read())
             {
                 int renglon = data.Rows.Add();
                 data.Rows[renglon].Cells["codigo1"].Value = dr.GetInt32(dr.GetOrdinal("cod_falla")).ToString();
                 data.Rows[renglon].Cells["descripcion1"].Value = dr.GetString(dr.GetOrdinal("des_falla"));
                 
             }
             con.Close();
        }

        private void insertar_data1()
        {

            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "select cod_labor,des_labor,cantidad,precio from labores_vs_entrada where cod_ent='" + cod_ent.Text + "' order by cod_labor";
            comando.CommandType = CommandType.Text;
            con.Open();
            data1.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data1.Rows.Add();
                data1.Rows[renglon].Cells["codigo"].Value = dr.GetInt32(dr.GetOrdinal("cod_labor")).ToString();
                data1.Rows[renglon].Cells["descripcion"].Value = dr.GetString(dr.GetOrdinal("des_labor")).ToString();
                data1.Rows[renglon].Cells["cantidad"].Value = dr.GetInt32(dr.GetOrdinal("cantidad")).ToString();
                string elvin =Convert.ToString( dr.GetDecimal(dr.GetOrdinal("precio"))).ToString();
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                data1.Rows[renglon].Cells["precio2"].Value = ll2;

               // MessageBox.Show("elvin:"+elvin);
             //   MessageBox.Show("s:"+Convert.ToString(s));
              //  MessageBox.Show("ll2:"+ll2);
            }
            con.Close();
        }

        private void insertar_data2()
        {
            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "select cod_rep,descripcion,cantidad from repuestos_traidos where cod_ent='" + cod_ent.Text + "' order by cod_rep";
            comando.CommandType = CommandType.Text;
            con.Open();
            data2.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data2.Rows.Add();
                data2.Rows[renglon].Cells["codigo2"].Value = dr.GetInt32(dr.GetOrdinal("cod_rep")).ToString();
                data2.Rows[renglon].Cells["descripcion2"].Value = dr.GetString(dr.GetOrdinal("descripcion"));
                data2.Rows[renglon].Cells["cantidad2"].Value = dr.GetInt32(dr.GetOrdinal("cantidad")).ToString();

            }
            con.Close();
        }

        private void validating()
        {
            int cod = 0;
            string numfac = "";
            DataSet ds = new DataSet();
            string cmd = "select * from ent_taller where cod_ent='" + cod_ent.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_cli"]);
                placa.Text = Convert.ToString(ds.Tables[0].Rows[0]["placa"]);
                otros_det.Text = Convert.ToString(ds.Tables[0].Rows[0]["otros_det"]);
                cod_veh.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_veh"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
                seguro.Text = Convert.ToString(ds.Tables[0].Rows[0]["codcom"]);
                string fin = Convert.ToString(ds.Tables[0].Rows[0]["cod_combus"]);
                string cmdd = " select descrip from combustible where cod_combus='" + fin + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac1 = ds.Tables[0].Rows[0]["descrip"].ToString();
                codcom.Text = numfac1;

                valida_averia();
                valida_vehiculo();
                valida_labores();
                valida_cliente();
                valida_seguro();
                cod_veh.Select();
            }
            else
            {
                codigo_mayor();

                nombre.Text = "";
                estado.Checked = false;
                cod_veh.Text = "";
                codcom.Text = "";
                cod_cli.Text = "";
                otros_det.Text = "";
                des_labor.Text = "";
                telefono.Text = "";
                celular.Text = "";
                correo.Text = "";
                direccion.Text = "";
            }

            if (estado.Checked == false && nombre.Text != "")
            {
                valida_estado();
            }

            cod_ent.Enabled = false;

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

        private void valida_seguro()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from comp_seg where codcom='" + seguro.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_seguro.Text = Convert.ToString(ds.Tables[0].Rows[0]["nom_con"]);
            }
            else
            {
                des_seguro.Text = "";
                seguro.Text = "";
            }
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

        private void valida_labores()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from labores where codlabor='" + cod_labor.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_labor.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                precio1 = Convert.ToDouble(ds.Tables[0].Rows[0]["precio"]);
            }
            else 
            {
                cod_labor.Text = "";
                des_labor.Text = "";
            }
        }

        private void combo()
        {

            DataSet ds = new DataSet();
            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            SqlDataAdapter da = new SqlDataAdapter("select descrip,cod_combus from combustible where estado=1 order by descrip", co);
            da.Fill(ds);
            codcom.DataSource = ds.Tables[0].DefaultView;
            codcom.ValueMember = "descrip";
            combusti = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_combus"]); ;
            codcom.Text = "";
            codcom.Select();
        }

        private void valida_cliente()
        {
            DataSet ds = new DataSet();
            string cmd = "select per.nombre+' '+per.apellido as nombre, per.correo, per.telefono as telefono, per.celular as celular,per.direccion as direccion from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where cli.cod_cli='" + cod_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                celular.Text = Convert.ToString(ds.Tables[0].Rows[0]["celular"]);
                correo.Text = Convert.ToString(ds.Tables[0].Rows[0]["correo"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
            }
            else
            {
                cod_cli.Text = "";
                telefono.Text = "";
                celular.Text = "";
                correo.Text = "";
                direccion.Text = "";
            }
        }

        private void busca()
        {
            proceso.titulo = "Vehículos";
            proceso.query = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1";
            proceso.query_cod = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh";
            proceso.query_desc = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1 and veh.detalles ";
            proceso.query2 = "select distinct ma.descripcion as 'Marca',model.descripcion as 'Modelo',veh.motor as 'Motor', comentario as 'Comentario' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as model on model.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh= ";
        }

        private void busca1()
        {
            proceso.titulo = "Clientes";

            proceso.query = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1";
            proceso.query_cod = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli";
            proceso.query_desc = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and per.nombre+''+per.apellido ";
            proceso.query2 = "select per.rnc as 'RNC',per.correo as 'Correo',per.telefono as 'Teléfono',per.celular as 'Celular',per.direccion as 'Dirección' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli= ";
        }

        private void busca2()
        {
            proceso.titulo = "Averías";
            proceso.query = "select cod_falla as 'Codigo',desc_falla as 'Descripcion' from fallas where estado=1";
            proceso.query_cod = "select cod_falla as 'Codigo',desc_falla as 'Descripcion' from fallas where estado=1 and cod_falla";
            proceso.query_desc = "select cod_falla as 'Codigo',desc_falla as 'Descripcion' from fallas where estado=1 and desc_falla ";
            proceso.query2 = "select cod_falla as 'codigo',desc_falla as 'descripcion' from fallas where estado=3 and cod_falla= ";
        }

        private void busca3()
        {
            proceso.titulo = "Labores";
            proceso.query = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1";
            proceso.query_cod = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1 and codlabor";
            proceso.query_desc = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1 and descrip ";
            proceso.query2 = "select codlabor as 'codigo',descrip as 'descripcion' from labores where estado=3 and codlabor= ";
        }

        private void busca4()
        {
            proceso.titulo = "Compañías de Seguro";
            proceso.query = "select codcom as 'Codigo',nom_con as 'Descripcion',telcom as 'Teléfono' from comp_seg where estado=1";
       proceso.query_cod = "select codcom as 'Codigo',nom_con as 'Descripcion',telcom as 'Teléfono' from comp_seg where estado=1 and codcom";
    proceso.query_desc = "select codcom as 'Codigo',nom_con as 'Descripcion',telcom as 'Teléfono' from comp_seg where estado=1 and nom_con ";
    proceso.query2= "select email as 'Correo',dircom as 'Dirección',comentario as 'Comentario' from comp_seg where estado=1 and codcom= ";
        }

        private void save()
        {
            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            int x;
            int y;
            int f ;

            if (estado.Checked == true)
                est = 1;
            else
                est = 0;

           if (string.IsNullOrEmpty(cod_veh.Text.Trim()) || string.IsNullOrEmpty(codcom.Text.Trim()) || string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           else
            {
                try
                {

                    string cmdd = " select cod_combus from combustible where descrip='" +codcom.Text + "'";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                    com = ds.Tables[0].Rows[0]["cod_combus"].ToString();
                   
string cmd = "act_ent_taller '" + cod_ent.Text + "','" + DateTime.Now.ToShortDateString() + "','" + cod_veh.Text + "','" + seguro.Text + "','" + cod_cli.Text + "','" + 1 + "','" + est + "','" + placa.Text + "','" + otros_det.Text + "','" + proceso.usuario + "','" + com + "'";
             utilidades.UTILIDADES.ejecutar(cmd);

//-------------------------------------------- labores-------------------------
           string cmd1 = "delete from labores_vs_entrada where cod_ent=" + cod_ent.Text.Trim();
             utilidades.UTILIDADES.ejecutar(cmd1);

             for (x = 0; x <= data1.Rows.Count - 1; x++)
             {
               string p = Convert.ToString(data1.Rows[x].Cells[3].Value);
              float num4 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                string ll4 = num4.ToString("0.00", us);

                 string h = "act_labores_ent '" + cod_ent.Text + "','" + data1.Rows[x].Cells[0].Value.ToString() + "','" + data1.Rows[x].Cells[1].Value.ToString() + "','" + data1.Rows[x].Cells[2].Value.ToString() + "','" + ll4 + "'";


                     utilidades.UTILIDADES.ejecutar(h);

             }
           
//----------------------------------fallas-------------------
           string cmd2 = "delete from fallas_vs_entrada where cod_ent='" + cod_ent.Text.Trim()+"'";
             utilidades.UTILIDADES.ejecutar(cmd2);

          for (y = 0; y <= data.Rows.Count - 1; y++)
             {
                 string g = "act_fallas_ent '" + cod_ent.Text + "','" + data.Rows[y].Cells[0].Value.ToString() + "','" + data.Rows[y].Cells[1].Value.ToString() + "'";
                 
                     utilidades.UTILIDADES.ejecutar(g);
             }

          //----------------------------------repuestos traidos por el cliente-------------------
          string cmd3 = "delete from repuestos_traidos where cod_ent='" + cod_ent.Text.Trim() + "'";
          utilidades.UTILIDADES.ejecutar(cmd3);
         
          for (f = 0; f<= data2.Rows.Count - 1; f++)
          {
              string d = "act_rep_traidos '" + cod_ent.Text + "','" + data2.Rows[f].Cells[0].Value.ToString() + "','" + data2.Rows[f].Cells[1].Value.ToString() + "','" + data2.Rows[f].Cells[2].Value.ToString() + "'";

              utilidades.UTILIDADES.ejecutar(d);
            //  MessageBox.Show("repuestos:"+d);
          }  
       }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                nuevos();
                codigo_mayor();
                activar();
                cod_veh.Select();
                cod_ent.Enabled = false;
            }
        }

        private void busca_art()
        {
            proceso.titulo = "Artículos";
            proceso.query = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1";
            proceso.query_cod = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and cod_rep";
            proceso.query_desc = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and descrip ";
            proceso.query2 = "select replace((round(exist,2)),',','.') as 'Existencia',marca as 'Marca',replace((round(precio_unidad,2)),',','.') as 'Precio',coment as 'Comentario' from articulos where estado=1  and cod_rep= ";
        }

        public void ejec_art(string dato)
        {
            cod_prod.Text = dato;
            validating_art();
        }

        public void ejec_seguro(string dato)
        {
           seguro.Text = dato;
            valida_seguro();
        }

        private void validating_art()
        {
            CultureInfo us = new CultureInfo("en-US");

            DataSet ds = new DataSet();
            string cmd = "select * from articulos where cod_rep='" + cod_prod.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_prod.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
            }
        }

        private void cuenta_celdas()
        {
            string cod_a1 = data2.Rows.Count.ToString();
            cod_ad = Convert.ToInt16(cod_a1) + 1;
            cod_a = cod_ad.ToString();
            cod_prod.Text = cod_a;
        }

        private void activar_registro()
        {
            est = 1;

            string cmdd = " select cod_combus from combustible where descrip='" + codcom.Text + "'";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            com = ds.Tables[0].Rows[0]["cod_combus"].ToString();

            if (string.IsNullOrEmpty(cod_veh.Text.Trim()) || string.IsNullOrEmpty(codcom.Text.Trim()) || string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string cmdd1 = " select cod_combus from combustible where descrip='" + codcom.Text + "'";
                DataSet de = utilidades.UTILIDADES.ejecutar(cmdd1);
                com = de.Tables[0].Rows[0]["cod_combus"].ToString();

                //string cmd = "act_ent_taller '" + cod_ent.Text + "','" + DateTime.Now.ToShortDateString() + "','" + cod_veh.Text + "','" + seguro.Text + "','" + cod_cli.Text + "','" + 1 + "','" + est + "','" + placa.Text + "','" + otros_det.Text + "','" + proceso.usuario + "','" + com + "'";

                string cmd = "update ent_taller set estado=1 where cod_ent='"+cod_ent.Text+"'";

                utilidades.UTILIDADES.ejecutar(cmd);
                estado.Checked = true;
                cambia_estado();
            }
        }

        private void entrada_talle_Load(object sender, EventArgs e)
        {
            cod_ent.Enabled = false;
            this.control1.Focus();
            combo();
            codigo_mayor();
            activar();

            cod_veh.Select();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            cod_ent.Enabled = false;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            busca3();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_labor);
            form2.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar);
            form2.ShowDialog();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            busca2();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_fal);
            form2.ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca1();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_cli);
            form2.ShowDialog();
        }

        private void datos_averia_Validating(object sender, CancelEventArgs e)
        {
            valida_averia();
        }

        private void cod_veh_Validating(object sender, CancelEventArgs e)
        {
            valida_vehiculo();
        }

        private void cod_cli_Validating(object sender, CancelEventArgs e)
        {
            valida_cliente();
        }

        private void cod_labor_Validating(object sender, CancelEventArgs e)
        {
            valida_labores();
        }

        private void entrada_talle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cod_ent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_veh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void datos_averia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_cli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_labor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            proceso.vehiculo =cod_veh.Text.Trim();

            if (proceso.vehiculo == "")
            {
                MetroMessageBox.Show(this, "No hay Ningun Vehiculo Seleccionado Para Continuar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                inv.mantenimientos.vehiculos veh = new mantenimientos.vehiculos();
                veh.ShowDialog();
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.fallas veh = new mantenimientos.fallas();
            veh.ShowDialog();
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            //cxc2.mantenimientos.clientes cli = new cxc2.mantenimientos.clientes();
           // cli.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cod_labor.Text.Trim()) || string.IsNullOrEmpty(des_labor.Text.Trim()) || string.IsNullOrEmpty(cantidad1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_labor.Select();
                return;
            }
            if (string.IsNullOrEmpty(cantidad1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Cantidad No Válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad1.Select();
                return;
            }
            else
            {
             bool exist = data1.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo"].Value) == cod_labor.Text);
          
                if (!exist)
                {
                    double s = Convert.ToDouble(precio1);
                    string ll2 = s.ToString("0.00", us);

                    data1.Rows.Add(cod_labor.Text.Trim(), des_labor.Text.Trim(), cantidad1.Text.Trim(),ll2);
                     data1.Sort(codigo, System.ComponentModel.ListSortDirection.Ascending);
                     cod_labor.Text = "";
                     des_labor.Text = "";
                     cantidad1.Text = "";
                     precio1 = 0;
                     cod_labor.Select();
                }
               
            }


        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (data1.CurrentRow == null)
                return;
            data1.Rows.Remove(data1.CurrentRow);

            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }

            cod_labor.Select();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(datos_averia.Text.Trim()) || string.IsNullOrEmpty(des_falla.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datos_averia.Select();
                return;
            }
            else
            {
     bool exist = data.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo1"].Value) == datos_averia.Text);
                  if (!exist)
                  {
                      data.Rows.Add(datos_averia.Text.Trim(), des_falla.Text.Trim());
                      data.Sort(codigo1, System.ComponentModel.ListSortDirection.Ascending);
                      datos_averia.Text = "";
                      des_falla.Text = "";
                      datos_averia.Select();
                  }
            }
        }

        private void activar2_Click(object sender, EventArgs e)
        {
            activar_registro(); 
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void cod_ent_Validating(object sender, CancelEventArgs e)
        {
            validating();
            insertar_data();
            insertar_data1();
            insertar_data2();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (data.CurrentRow == null)
                return;
            data.Rows.Remove(data.CurrentRow);

            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
            datos_averia.Select();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void codcom_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cod_labor_TextChanged(object sender, EventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void cod_veh_TextChanged(object sender, EventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void otros_det_TextChanged(object sender, EventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void cod_cli_TextChanged(object sender, EventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void data1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void data_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "" || data2.Rows.Count != 0)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void data_Sorted(object sender, EventArgs e)
        {
           
        }

        private void entrada_talle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                save();
            }
            if (e.KeyCode == Keys.F4)
            {
                nuevos();
            }
            if (e.KeyCode == Keys.F7)
            {
                activar_registro(); 
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            cod_ent.Enabled = true;
            cod_ent.Select();
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_prod.Text.Trim()) || string.IsNullOrEmpty(des_prod.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_labor.Select();
                return;
            }
            if (string.IsNullOrEmpty(can_prod.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Cantidad No Válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                can_prod.Select();
                return;
            }
            else
            {
                bool exist = data2.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo2"].Value) == cod_prod.Text);

                if (!exist)
                {
                    data2.Rows.Add(cod_prod.Text.Trim(), des_prod.Text.Trim(), can_prod.Text.Trim());
                    data2.Sort(codigo2, System.ComponentModel.ListSortDirection.Ascending);
                    cod_prod.Text = "";
                    des_prod.Text = "";
                    can_prod.Text = "";
                    cod_prod.Select();
                }

            }

          
        }

        private void data2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || data2.Rows.Count != 0 || seguro.Text.Trim() != "")
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            if (data2.CurrentRow == null)
                return;
            data2.Rows.Remove(data2.CurrentRow);

            if (cod_veh.Text.Trim() != "" || placa.Text.Trim() != "" || estado.Checked == true || otros_det.Text.Trim() != "" || cod_cli.Text.Trim() != "" || data.Rows.Count != 0 || data1.Rows.Count != 0 || seguro.Text.Trim() != "")
            {
                desactivar();
            }
            else
            {
                activar();
            }

           cod_prod.Select();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            busca_art();
            consultas.tipo form1 = new consultas.tipo();
            form1.pasado += new consultas.tipo.pasar(ejec_art);
            form1.ShowDialog();
            can_prod.Select();
        }

        private void cod_prod_Validating(object sender, CancelEventArgs e)
        {
            validating_art();
            can_prod.Select();
        }

        private void can_prod_Validating(object sender, CancelEventArgs e)
        {

        }

        private void seguro_Validating(object sender, CancelEventArgs e)
        {
            valida_seguro();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            busca4();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejec_seguro);
            form2.ShowDialog();
        }

        private void seguro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void can_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cantidad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
