using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using MetroFramework.Forms;

namespace repuesto
{
    public partial class cotizar : Form
    {
        double s = 0;
        int subtotal = 0;
        int kn = 0;
        string mo = "", ma = ""; int y = 0, z = 0;
        
        int canv = 0, cant = 0;
        public DataTable consulta = new DataTable();

        public cotizar()
        {
            InitializeComponent();

            int yu = 0;
            string cmd = "select max (num_cot+1) as Mayor from cotizacion";
            // string cmd = string.Format("select * from productos where codigo='{0}'", codprod.Text.Trim());
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                yu = Convert.ToInt16(ds.Tables[0].Rows[0]["mayor"].ToString().Trim());
            }
            num_cot.Text = Convert.ToString(yu);
           

            consulta.Columns.Add("codigo");
            consulta.Columns.Add("descripcion");
            consulta.Columns.Add("cantidadd");
            consulta.Columns.Add("precios");
            consulta.Columns.Add("importe");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "codigo";
            dataGridView1.Columns[1].DataPropertyName = "descripcion";
            dataGridView1.Columns[2].DataPropertyName = "cantidadd";
            dataGridView1.Columns[3].DataPropertyName = "precios";
            dataGridView1.Columns[4].DataPropertyName = "importe";
            dataGridView1.DataSource = consulta;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        public void suma()
        {

            foreach (DataRow dr in consulta.Rows)
            {
                s += Convert.ToDouble(dr["importe"]);
            }
            kn =Convert.ToInt16( 0.18 * s);
            sub_total.Text=Convert.ToString(( 0.18 * s)+s);
            total.Text = s.ToString();

        } //calculo del total y sub-total

        private void cotizar_Load(object sender, EventArgs e)
        {

            cod_veh.Text = procesos.vehiculo;
            cod_art.Text = procesos.articulo;
            detalle.Text = procesos.descripcion;

            ncf.Text = procesos.ncf;
            cod_cli.Text = procesos.cod_cli;
           nom_cli.Text = procesos.nombre;


          cod_art.Text= procesos.recomendacion;
          cantidad.Text =procesos.cantidad ;
         //  =procesos.gastos;
          precio.Text =procesos.precioventa;

         //  procesos.codigo_articulo = consultar.CurrentRow.Cells[4].Value.ToString();

            timer1.Enabled = true;
            timer1.Interval = 25;

            label.Text = procesos.usuario;
            itbis.Text = "18%";

            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descrip from articulo", co);
                da.Fill(ds);
                detalle.DataSource = ds.Tables[0].DefaultView;
                detalle.ValueMember = "descrip";
                detalle.Text = "";
                detalle.Select();
            }


            {//"select vehiculo.cod_veh as Codigo, marca.descrip_mar as Marca from vehiculo inner join marca on marca.cod_mar=vehiculo.cod_mar";
                DataSet ds = new DataSet();//, modelo.descrip_model as Modelo, tipo_veh.descrip_tipo as Tipo,combustible.descrip_com as Tipo_Combustible from vehiculo inner join marca on vehiculo.cod_mar=marca.cod_mar inner join modelo on modelo.cod_model=vehiculo.cod_model  inner join combustible on vehiculo.cod_com=combustible.cod_com inner join tipo_veh on vehiculo.cod_tipo=tipo_veh.cod_tipo
                string cmd = "select * from marca";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                consultar.DataSource = ds.Tables[0];
               // consultar.Clear();
                //consultar.Focus();
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " SOFTWARE R&V ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        } // solo acepte numeros

        private void metroTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        } // solo acepte numeros

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        } //solo acepte letras

        private void metroTextBox1_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from cliente where cod_cli='" + cod_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                nom_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellido"]);
                ncf.Text = Convert.ToString(ds.Tables[0].Rows[0]["ncf"]);

            }
        } //buscar por el codigo

        private void nom_cli_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from cliente where apellido='" + nom_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_cli"]);
                ncf.Text = Convert.ToString(ds.Tables[0].Rows[0]["ncf"]);

            }
        } //buscar por el nombre del cliente

        private void ncf_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from cliente where ncf='" + ncf.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_cli"]);
                nom_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellido"]);

            }
        }//buscar por ncf

        private void cod_veh_Validating(object sender, CancelEventArgs e)
        {
            String n = "";
            DataSet ds = new DataSet();//"select vehiculo.cod_veh as CODIGO, marca.descrip_mar AS MARCA, modelo.descrip_model AS MODELO, tipo_veh.descrip_tipo AS TIPO_VEHICULO,combustible.descrip_com AS TIPO_COMBUSTIBLE from vehiculo inner join marca on vehiculo.cod_mar=marca.cod_mar inner join modelo on modelo.cod_model=vehiculo.cod_model  inner join combustible on vehiculo.cod_com=combustible.cod_com inner join tipo_veh on vehiculo.cod_tipo=tipo_veh.cod_tipo where cod_veh='" + cod_veh.Text.Trim() + "'";
            string cmd = "select vehiculo.cod_veh as CODIGO, marca.descrip_mar AS MARCA,marca.cod_mar as PO, modelo.descrip_model AS MODELO, tipo_veh.descrip_tipo AS TIPO_VEHICULO,combustible.descrip_com AS TIPO_COMBUSTIBLE from vehiculo inner join marca on vehiculo.cod_mar=marca.cod_mar inner join modelo on modelo.cod_model=vehiculo.cod_model  inner join combustible on vehiculo.cod_com=combustible.cod_com inner join tipo_veh on vehiculo.cod_tipo=tipo_veh.cod_tipo where cod_veh='" + cod_veh.Text.Trim() + "'";
           // String cmd = "select * from cliente where ncf='" + ncf.Text.Trim() + "'";

            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                marc.Text = Convert.ToString(ds.Tables[0].Rows[0]["MARCA"]);
               // model.Text = Convert.ToString(ds.Tables[0].Rows[0]["MODELO"]);
              //  tipo.Text = Convert.ToString(ds.Tables[0].Rows[0]["TIPO_COMBUSTIBLE"]);
                n = Convert.ToString(ds.Tables[0].Rows[0]["po"]);

            }

        } //validar el vehiculo

        private void consultar_DoubleClick(object sender, EventArgs e)
        {
           procesos.marca_veh = consultar.CurrentRow.Cells[1].Value.ToString();
           //procesos.modelo_veh = consultar.CurrentRow.Cells[2].Value.ToString();
           procesos.codigo_veh = consultar.CurrentRow.Cells[0].Value.ToString();
           //procesos.tipo_combus = consultar.CurrentRow.Cells[4].Value.ToString();

           marc.Text = procesos.marca_veh;
         //  model.Text = procesos.modelo_veh;
           cod_veh.Text = procesos.codigo_veh;
         //  tipo.Text = procesos.tipo_combus;

         /*  int p = 0, q = 0;
           DataSet ds = new DataSet(); //
           string cmd = "";
           cmd = "select cod_mar from marca where descrip_mar='" + marc.Text.Trim() + "'";
           ds = utilidades.UTILIDADES.ejecutar(cmd);
           if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
           {
               p = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_mar"]);
           }

           cmd = "select cod_model from marca_vs_modelo where cod_mar='" + p + "'";
           ds = utilidades.UTILIDADES.ejecutar(cmd);
           if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
           {
               q = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_model"]);
           }


           {
               SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);

               SqlDataAdapter da = new SqlDataAdapter("select modelo.descrip_model as modelt from modelo inner join  marca_vs_modelo on marca_vs_modelo.cod_model=modelo.cod_model where marca_vs_modelo.cod_mar= '" + q + "'", co); 
               da.Fill(ds);
               model.DataSource = ds.Tables[0].DefaultView;
               model.ValueMember = "modelt";
               ano.Select();
           }*/
        }

        private void cod_art_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from articulo where cod_art='" + cod_art.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                detalle.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["prec_ven"]);

            }
        }

        private void metroComboBox2_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            String cmd = "select * from articulo where descrip='" + detalle.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                cod_art.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_art"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["prec_ven"]);

            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string cmd = "";
            
            DataSet ds = new DataSet();
            if (string.IsNullOrEmpty(cod_art.Text))
            {
                MessageBox.Show("PARA CONTINUAR DEBE DIGITAR LOS DATOS");
                cod_art.Focus();
                return;
            }
            {
                if (string.IsNullOrEmpty(detalle.Text))
                {
                    MessageBox.Show("EL CAMPO DE DETALLE ESTA VACIO");
                    detalle.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(model.Text))
                {
                    MessageBox.Show("DEBES INGRESAR EL MODELO DEL VEHICULO");
                    model.Focus();
                    return;
                }


                if (string.IsNullOrEmpty(ano.Text))
                {
                    MessageBox.Show("DEBES INGRESAR EL AÑO DEL VEHICULO");
                    ano.Focus();
                    return;
                }

  
               
                if (string.IsNullOrEmpty(cantidad.Text))
                {
                    MessageBox.Show("EL CAMPO DE CANTIDAD ESTA VACIO");
                    cantidad.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(precio.Text))
                {
                    MessageBox.Show("EL CAMPO DE PRECIO ESTA VACIO");
                    precio.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cod_veh.Text))
                {
                    MessageBox.Show("EL CAMPO DE CODIGO DE VEHICULO ESTA VACIO");
                    cod_veh.Focus();
                    return;
                }

                cmd = "select cod_model from modelo where descrip_model='" + model.Text.Trim() + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    y = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_model"]);
                }

                cmd = "select cod_mar from marca where descrip_mar='" + marc.Text.Trim() + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    z = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_mar"]);
                }

                 cmd = string.Format("select articulo.descrip,articulo.cod_art,vehiculo_vs_articulo.canexi as cantidadd,vehiculo_vs_articulo.cod_veh from articulo inner join vehiculo_vs_articulo on articulo.cod_art=vehiculo_vs_articulo.cod_art inner join vehiculo on vehiculo.cod_veh=vehiculo_vs_articulo.cod_veh where articulo.cod_art='" + cod_art.Text.Trim() + "' and vehiculo.cod_veh='" + cod_veh.Text + "' and vehiculo.cod_model='" + y + "' and vehiculo.cod_mar='" + z + "'");
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    canv = Convert.ToInt16(ds.Tables[0].Rows[0]["cantidadd"].ToString().Trim());

                }
                cant = Convert.ToInt16(cantidad.Text);
                
                
               
               if (cant > canv)
               {

                   // procesos.codigo_articulo = consultar.CurrentRow.Cells[4].Value.ToString();
                    procesos.vehiculo = cod_veh.Text;
                    procesos.articulo = cod_art.Text;
                    procesos.descripcion = detalle.Text;
                    procesos.cani = cantidad.Text;
                  //  if(canv==0)
                  //  {
                        MessageBox.Show("LA CANTIDAD SOLICITADA DE  " + detalle.Text + "  ES MAYOR QUE LA EXISTENTE; EN ALMACEN SOLO QUEDAN  " + canv);
                        dataGridView2.Visible = true;
                        label3.Visible = true;

                     //   {
                           // DataSet ds = new DataSet();
                            cmd = "select recomendaciones.descrip as Recomendacion,riesgos.cantidad,riesgos.gastos,riesgos.prec_ven,riesgos.descrip as Riesgos from recomend_vs_riesgo inner join riesgos on recomend_vs_riesgo.cod_riesgo=riesgos.cod_riesgo inner join recomendaciones on recomend_vs_riesgo.cod_recom=recomendaciones.cod_recom inner join vehiculo on riesgos.cod_veh=vehiculo.cod_veh where riesgos.cod_art='" + procesos.articulo + "' and riesgos.cod_veh ='" + procesos.vehiculo + "'";
                            ds = utilidades.UTILIDADES.ejecutar(cmd);
                            dataGridView2.DataSource = ds.Tables[0];
                            
                      //  }
                        //  oferta cli = new oferta();
                        // cli.ShowDialog();

                        cantidad.Clear();
                        cantidad.Focus();
                        return;
                  ///  }
                   //else
                   // {
                       // MessageBox.Show("LA CANTIDAD SOLICITADA DE  " + detalle.Text + "  ES MAYOR QUE LA EXISTENTE; EN ALMACEN SOLO QUEDAN  " + canv);


                         //   cantidad.Clear();
                        //    cantidad.Focus();
                        //    return;
                      //  }
               }
                else
                {
                    consulta.Rows.Add();
                    int pos = consulta.Rows.Count - 1;
                    consulta.Rows[pos]["codigo"] = cod_art.Text.Trim();
                    consulta.Rows[pos]["descripcion"] = detalle.Text.Trim();
                    consulta.Rows[pos]["cantidadd"] = cantidad.Text.Trim();
                    consulta.Rows[pos]["precios"] = precio.Text.Trim();
                    consulta.Rows[pos]["importe"] = Convert.ToDouble(precio.Text) * Convert.ToDouble(cantidad.Text);
                    precio.Text = " "; cod_art.Text = " "; detalle.Text = ""; cantidad.Clear(); cod_art.Focus(); suma();
                }

            }
        }  //agregar al datagrid

        private void quitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("ACTUALMENTE HAY DATOS PARA BORRAR");
                return;
            }
            int pos = dataGridView1.CurrentCell.RowIndex;
            consulta.Rows[pos].Delete();
            suma();
            cod_art.Focus();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            cod_art.Text = ""; detalle.Text = ""; cantidad.Clear(); cod_art.Focus();
            if (dataGridView1.Rows.Count == 0)
                return;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
           // cotizar c = new cotizar();
           // c.Hide();
           
            consult_cli ci = new consult_cli();
            ci.ShowDialog();
            ci.Dispose();
        }

        private void marc_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void consultar_Validating(object sender, CancelEventArgs e)
        {

        }

       // private void nuevos()
      //  {
            //cod_cli.Clear() ;
          //  nom_cli.Clear();
          //  ncf.Clear();
          //  total.Clear();
         //   sub_total.Clear();
          //  detalle.Text = "";
         //   precio.Clear();
         //   cantidad.Clear();
          //  dataGridView1.DataSource = null;
          // dataGridView1.Rows.Clear();
           // cod_cli.Clear();
          //  ano.Clear();
          //  cod_veh.Clear();
          //  marc.Clear();
          //  model.Clear();

           //nuevos();
      //  }

        private void metroButton4_Click(object sender, EventArgs e) //procesar
        {
            int user = 1; string estado = "activo";
            subtotal = Convert.ToInt32(s);
            string cmd = "";
            DataSet ds = new DataSet();
            if (dataGridView1.Rows.Count == 0 || string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                MessageBox.Show("NO HAY DATOS SUFICIENTES PARA PROCESAR LA FACTURA ACTUAL");
                return;
            }
              if (string.IsNullOrEmpty(cod_cli.Text))
            
            { MessageBox.Show("FAVOR DIGITAR LOS DATOS DEL CLIENTE"); }
            else

                  cmd = string.Format("insert into cotizacion (num_cot,cod_cli,cod_usu,fec_cot,estado,totalitbis,cod_veh,riesgos,recomendaciones,gastos) values('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}','{8}','{9}')", num_cot.Text.Trim(), cod_cli.Text.Trim(), user, System.DateTime.Now.ToString(), estado, kn, cod_veh.Text.Trim(), Convert.ToDouble(subtotal), total.Text.Trim(), procesos.riesgos, procesos.recomendacion, procesos.gastos);
            ds = utilidades.UTILIDADES.ejecutar(cmd);

            foreach (DataRow dr in consulta.Rows)
            {
                cmd = string.Format("insert into detalle_cot (num_cot,descripcion,cant,precio,codigo) values('{0}', '{1}', '{2}', '{3}', '{4}')", num_cot.Text.Trim(), dr["descripcion"], dr["cantidadd"], dr["precios"], dr["codigo"]);
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                try { }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
               
               
            }
           // nuevos();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            procesos.recomendacion = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            procesos.cantidad = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            procesos.gastos = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            procesos.precioventa = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            procesos.riesgos = dataGridView2.CurrentRow.Cells[4].Value.ToString();

           // string n = "6";
            cantidad.Text = procesos.cani;
            precio.Text = procesos.precioventa;

            dataGridView2.Visible = false;
            label3.Visible = false;

            consulta.Rows.Add();
            int pos = consulta.Rows.Count - 1;
            consulta.Rows[pos]["codigo"] = cod_art.Text.Trim();
            consulta.Rows[pos]["descripcion"] = detalle.Text.Trim();
            consulta.Rows[pos]["cantidadd"] = cantidad.Text.Trim();
            consulta.Rows[pos]["precios"] = precio.Text.Trim();
            consulta.Rows[pos]["importe"] = Convert.ToDouble(precio.Text) * Convert.ToDouble(cantidad.Text);
            precio.Text = " "; cod_art.Text = " "; detalle.Text = ""; cantidad.Clear(); cod_art.Focus(); suma();
          //  canv = 6;

        }

    }
}
