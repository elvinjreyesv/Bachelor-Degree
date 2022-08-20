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

namespace habitacion
{
    public partial class facturacion : Form
    {
        public DataTable consulta = new DataTable();

        public facturacion()
        {
            InitializeComponent();
            entrada.Text = DateTime.Now.ToString("HH:mm:ss");
          //  salida.Text = DateTime.Now.ToString("HH:mm:ss");
            consulta.Columns.Add("codigo");
            consulta.Columns.Add("descripcion");
            consulta.Columns.Add("cantidad");
            consulta.Columns.Add("precio");
            consulta.Columns.Add("importe");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "codigo";
            dataGridView1.Columns[1].DataPropertyName = "descripcion";
            dataGridView1.Columns[2].DataPropertyName = "cantidad";
            dataGridView1.Columns[3].DataPropertyName = "precio";
            dataGridView1.Columns[4].DataPropertyName = "importe";
            dataGridView1.DataSource = consulta;

            DataSet ds = new DataSet();
            int can = 0, c = 0;
            string cmd = "select max (numfac+1) as Mayor from factura";
            // string cmd = string.Format("select * from productos where codigo='{0}'", codprod.Text.Trim());
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                can = Convert.ToInt16(ds.Tables[0].Rows[0]["mayor"].ToString().Trim());
            }
            
            string cmds = "select max (numfac+1) as Mayo from factura2";
            ds = utilidades.UTILIDADES.ejecutar(cmds);
            {
                c = Convert.ToInt16(ds.Tables[0].Rows[0]["mayo"].ToString().Trim());
            }
            if (c > can)
            {

                numfac.Text = Convert.ToString(c);

            }
            else
            { 
                numfac.Text = Convert.ToString(can);
            }


          //  string cmdd = "select max (numfac+1) as Mayor from factura";
          //  ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string fecha = Convert.ToString(System.DateTime.Now);
            try
            {
               // string textonum = ds.Tables[0].Rows[0]["Mayor"].ToString();
              //  numfac.Text = textonum;
                fecc.Text = fecha;
            }
            catch (Exception er)
            { MessageBox.Show(er.ToString()); }
        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            codprod.Enabled = false;
            descripprod.Enabled = false;
            canven.Enabled = false;
            preccio.Enabled = false;
            salvar.Enabled = false;
            dataGridView1.Enabled = false;
            eliminar.Enabled = false;
            cancelar.Enabled = false;
            consultar.Enabled = false;

            timer1.Enabled = true;
            timer1.Interval = 25;
            codhab.Text = procesos.codhab.ToString();
            {
                SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select codigo from cliente", co);
                da.Fill(ds);
                codcli.DataSource = ds.Tables[0].DefaultView;
                codcli.ValueMember = "codigo";
                codcli.Text = "";
                codcli.Select();
            }
            {
                SqlConnection cn = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet d = new DataSet();
                SqlDataAdapter dad = new SqlDataAdapter("select nombre from cliente", cn);
                dad.Fill(d);
                nombre.DataSource = d.Tables[0].DefaultView;
                nombre.ValueMember = "nombre";
                nombre.Text = "";
            }
            {
                SqlConnection cc = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet dq = new DataSet();
                SqlDataAdapter df = new SqlDataAdapter("select descripcion from estadia", cc);
                df.Fill(dq);
                estadia.DataSource = dq.Tables[0].DefaultView;
                estadia.ValueMember = "descripcion";
                estadia.Text = "";
            }
            {
                SqlConnection cp = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet dw = new DataSet();
                SqlDataAdapter dk = new SqlDataAdapter("select codigo from productos", cp);
                dk.Fill(dw);
                codprod.DataSource = dw.Tables[0].DefaultView;
                codprod.ValueMember = "codigo";
                codprod.Text = "";
            }
            {
                SqlConnection cl = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet dx = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from productos", cl);
                da.Fill(dx);
                descripprod.DataSource = dx.Tables[0].DefaultView;
                descripprod.ValueMember = "descripcion";
                descripprod.Text = "";
            }
        }

        private void nombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
                return;
            string cmd = string.Format("select * from cliente where nombre = '{0}'", nombre.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
               // MessageBox.Show(cmd);
                codcli.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                canven.Select();
            }
            catch
            {
                MessageBox.Show("EL CLIENTE ACTUAL NO EXIXTE");
            }
        }

        private void codprod_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codprod.Text.Trim()))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codprod.Text = cod.ToString();
                }
            }
            cmd = "select * from productos where codigo='" + codprod.Text.Trim()+"'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
           // MessageBox.Show(cmd);
             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descripprod.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                preccio.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
                canven.Select();
            }
        }

        private void descripprod_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(descripprod.Text.Trim()))
                return;
            string cmd = string.Format("select * from productos where descripcion = '{0}'", descripprod.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                codprod.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                preccio.Text = ds.Tables[0].Rows[0]["precio"].ToString();
            }
            catch
            {
                MessageBox.Show("EL ARTICULO ACTUAL NO EXISTE");
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            int can = 0, c = 0;
            DataSet ds = new DataSet();
            if (string.IsNullOrEmpty(codprod.Text))
            {
                MessageBox.Show("PARA CONTINUAR DEBE DIGITAR LOS DATOS");
                codprod.Focus();
                return;
            }
            {
                if (string.IsNullOrEmpty(canven.Text))
                {
                    MessageBox.Show("EL CAMPO DE CANTIDAD ESTA VACIO");
                    canven.Focus();
                    return;
                }
                string cmd = string.Format("select * from productos where codigo='"+ codprod.Text.Trim()+"'");
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    can = Convert.ToInt16(ds.Tables[0].Rows[0]["canexi"].ToString().Trim());

                }
                c = Convert.ToInt16(canven.Text);
                if (c > can)
                {
                    MessageBox.Show("LA CANTIDAD SOLICITADA DE  " + descripprod.Text + "  ES MAYOR QUE LA EXISTENTE; EN ALMACEN SOLO QUEDAN  " + can);
                    canven.Clear();
                    canven.Focus();
                    return;
                }
                else
                {
                    consulta.Rows.Add();
                    int pos = consulta.Rows.Count - 1;
                    consulta.Rows[pos]["codigo"] = codprod.Text.Trim();
                    consulta.Rows[pos]["descripcion"] = descripprod.Text.Trim();
                    consulta.Rows[pos]["cantidad"] = canven.Text.Trim();
                    consulta.Rows[pos]["precio"] = preccio.Text.Trim();
                    consulta.Rows[pos]["Importe"] = Convert.ToDouble(preccio.Text) * Convert.ToDouble(canven.Text);
                    preccio.Text = " "; codprod.Text = " "; descripprod.Text = ""; canven.Clear(); codprod.Focus(); suma();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            fecc.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        public void suma()
        {
            double s = 0;
            foreach (DataRow dr in consulta.Rows)
            {
                s += Convert.ToDouble(dr["importe"]);
            }
            total.Text = s.ToString();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            codprod.Text = ""; descripprod.Text = ""; canven.Clear(); codprod.Focus();
            if (dataGridView1.Rows.Count == 0)
             return;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            this.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("ACTUALMENTE HAY DATOS PARA BORRAR");
                return;
            }
            int pos = dataGridView1.CurrentCell.RowIndex;
            consulta.Rows[pos].Delete();
            suma();
            codprod.Focus();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consultar_art csa = new consultar_art();
            csa.ShowDialog();
            csa.Dispose();
        }

        private void codhab_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codhab.Text.Trim()))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codhab.Text = cod.ToString();
                }
            }
            cmd = "select * from habitacion where codhab='" + codhab.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                precion.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
                tipohabi.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriphab"]);
                descriptem.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriptem"]);
                estadia.Select();
            }
            {
                if (string.IsNullOrEmpty(descriptem.Text.Trim()))
                    return;
                 cmd = string.Format("select * from tematica where descriptem = '{0}'", descriptem.Text.Trim());
                try
                {
                     ds = utilidades.UTILIDADES.ejecutar(cmd);
                    precio_t.Text = ds.Tables[0].Rows[0]["precio_t"].ToString();
                }
                catch
                {
                    MessageBox.Show("LA TEMATICA ACTUAL NO EXISTE");
                }
            }
        }

        private void codcli_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codcli.Text.Trim()))
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codcli.Text = cod.ToString();
                }
            }
            cmd = "select * from cliente where codigo='" + codcli.Text.Trim()+"'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
            }
        }

        private void procesar_Click(object sender, EventArgs e)
        {
            if (product.Checked == true)
            {

                DataSet ds = new DataSet();
                if (dataGridView1.Rows.Count == 0 || string.IsNullOrEmpty(codcli.Text.Trim()) || string.IsNullOrEmpty(codhab.Text.Trim()))
                {
                    MessageBox.Show("NO HAY DATOS SUFICIENTES PARA PROCESAR LA FACTURA ACTUAL");
                    return;
                }
              //  string estad = "disponible";
                try
                {

                    //string cmb = "select estado from habitacion where codhab='" + codhab.Text + "'"; ;
                    //DataSet da = utilidades.UTILIDADES.ejecutar(cmb);
                    //string inicio = da.Tables[0].Rows[0]["estado"].ToString();

                    //if (Convert.ToString(inicio) != Convert.ToString(estad))
                    //{
                    //    MessageBox.Show("Esta Habitacion no esta disponible para facturar");
                    //    codhab.Focus();
                    //    codhab.Text = "";
                    //    descriptem.Text = "";
                    //    precion.Text="";
                    //    precio_t.Text = "";
                    //    horas.Text = "";
                    //    porciento.Text = "";
                    //    estadia.Text = "";
                    //    preciob.Text = "";
                    //    tipohabi.Text = "";
                    //}
                    //else
                    //{
                        string d = "procesada";
                        // string cmd = string.Format("insert into factura (numfac,codcli,fecfac, estado,numhab,horaentrada,horasalida,estadia) values('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}')", numfac.Text.Trim(), codcli.Text.Trim(), System.DateTime.Now.ToString("yyyyMMdd hh:mm:ss tt"), 0,codhab.Text,entrada.Text,salida.Text,estadia.Text);
                        string cmd = "exec act_factura '" + numfac.Text + "','" + codcli.Text + "','" + System.DateTime.Now.ToString() + "','" + d + "','" + estadia.Text + "','" + entrada.Text + "','" + salida.Text + "','" + codhab.Text + "','" + preciob.Text + "'";
                        ds = utilidades.UTILIDADES.ejecutar(cmd);
                        string est = "ocupada";
                        int cod = 1;
                        cmd = "exec actocupadas '" + codhab.Text + "','" + codcli.Text + "','" + entrada.Text + "','" + entrada.Text + "','" + salida.Text + "'";
                        utilidades.UTILIDADES.ejecutar(cmd);
                        // cmd = "update habitacion set codest='1',estado='ocupada', where codhab='" + codhab.Text + "'";
                        cmd = "update habitacion set estado='" + est + "', " + "codest='" + cod + "' where codhab='" + codhab.Text + "'";
                        utilidades.UTILIDADES.ejecutar(cmd);
                    }
                //}
                catch
                {
                    MessageBox.Show("EL PROGRAMA HA SIDO IMTERRUMPIDO POR FALLOS DURANTE EL PROCESAMIENTO");
                    return;
                }
                foreach (DataRow dr in consulta.Rows)
                {
                    string cmd = string.Format("insert into detalle (numfac, codigo, canven, preven) values('{0}', '{1}', '{2}', '{3}')", numfac.Text.Trim(), dr["codigo"], dr["cantidad"], dr["precio"], dr["descripcion"]);
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    try { }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }


                    cmd = string.Format("update productos set canexi = canexi-'{0}' where codigo = '{1}'", dr["cantidad"], dr["codigo"]);
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    try { }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                        return;
                    } //ESTA LLAVE CERRABA ABAJO
                    //insert into detalle(numfac,canven,preven,codigo,horaentrada,horatranscurrida,horasalida,estadia,precio)
                }
                codcli.Text = ""; nombre.Text = ""; total.Clear(); tipohabi.Clear(); codhab.Text = ""; tipohabi.Text = ""; precion.Text = ""; estadia.Text = ""; descriptem.Text = "";
                preciob.Text = ""; codprod.Text = ""; descripprod.Text = ""; canven.Text = ""; preccio.Text = ""; precio_t.Text = ""; horas.Text = ""; porciento.Text = ""; entrada.Text = ""; salida.Text = "";
                entrada.Text = DateTime.Now.ToString("HH:mm:ss");
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                string cmdd = "select max (numfac+1) as Mayor from factura";
                ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string textonum = ds.Tables[0].Rows[0]["Mayor"].ToString();
                numfac.Text = textonum;

                reporte_fact pr = new reporte_fact();
                pr.Show();
                //   }
            }
            else   //ESTA ES LA FACTURACIN DE HABITACION
            {
                if (string.IsNullOrEmpty(codcli.Text.Trim()) || string.IsNullOrEmpty(codhab.Text.Trim()) || string.IsNullOrEmpty(estadia.Text.Trim()))
                {
                    MessageBox.Show("Para continuar debe digitar todos los datos");
                    return;
                }
                //string estad = "disponible";
                //string cmb = "select estado from habitacion where codhab='" + codhab.Text + "'"; ;
                //DataSet da = utilidades.UTILIDADES.ejecutar(cmb);
                //string inicio = da.Tables[0].Rows[0]["estado"].ToString();
               
                //if (Convert.ToString(inicio) != Convert.ToString(estad))
                //{
                //    MessageBox.Show("Esta Habitacion no esta disponible para facturar");
                //    codhab.Focus();
                //    codhab.Text = "";
                //    descriptem.Text = "";
                //    precion.Text = "";
                //    precio_t.Text = "";
                //    horas.Text = "";
                //    porciento.Text = "";
                //    estadia.Text = "";
                //    preciob.Text = "";
                //    tipohabi.Text = "";
                //}
                //else
                //{

                    string d = "procesada";
                    string cmd = string.Format("insert into factura2 (numfac, codhab,fecha,horaentrada,horasalida,codcli,estadia,costohab, estado) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", numfac.Text.Trim(), codhab.Text.Trim(), System.DateTime.Now.ToString(), entrada.Text.Trim(), salida.Text.Trim(), codcli.Text.Trim(), estadia.Text.Trim(), preciob.Text.Trim(), d);
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    string est = "ocupada";
                    int cod = 1;
                    cmd = "exec actocupadas '" + codhab.Text + "','" + codcli.Text + "','" + entrada.Text + "','" + entrada.Text + "','" + salida.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    cmd = "update habitacion set estado='" + est + "', " + "codest='" + cod + "' where codhab='" + codhab.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    codcli.Text = ""; nombre.Text = ""; total.Clear(); tipohabi.Clear(); codhab.Text = ""; tipohabi.Text = ""; precion.Text = ""; estadia.Text = ""; descriptem.Text = ""; entrada.Text = ""; salida.Text = "";
                    entrada.Text = DateTime.Now.ToString("HH:mm:ss");
                    preciob.Text = ""; codprod.Text = ""; descripprod.Text = ""; canven.Text = ""; preccio.Text = ""; precio_t.Text = ""; hora.Text = ""; porciento.Text = ""; horas.Text = ""; salida.Text = "";
                    reporte_factura2 gr = new reporte_factura2();
                    gr.Show();
                //}
            }
        }
        
        private void codcli_KeyPress(object sender, KeyPressEventArgs e)
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

        }

        private void codprod_KeyPress(object sender, KeyPressEventArgs e)
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

        }

        private void canven_KeyPress(object sender, KeyPressEventArgs e)
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

        }

        private void codhab_KeyPress(object sender, KeyPressEventArgs e)
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

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                e.Handled = true;
        }

        private void descripprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void estadia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void estadia_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(estadia.Text.Trim()))
                return;
            string cmd = string.Format("select * from estadia where descripcion = '{0}'", estadia.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                porciento.Text = ds.Tables[0].Rows[0]["porciento"].ToString();
                horas.Text = ds.Tables[0].Rows[0]["horas"].ToString();

            }
            catch
            {
                MessageBox.Show("LA ESTADIA ACTUAL NO EXISTE");
            }

            {
                if (porciento.Text == "0")
                {
                    preciob.Text = (Convert.ToInt16(precio_t.Text) + Convert.ToInt16(precion.Text)).ToString();
                }
                else
                {
                    int numero = (Convert.ToInt16(precio_t.Text) + Convert.ToInt16(precion.Text));
                    double porc = numero * (Convert.ToDouble(porciento.Text));
                    preciob.Text = (Convert.ToInt16(precio_t.Text) + Convert.ToInt16(precion.Text) + porc).ToString();


                }
            }
             string horass = DateTime.Now.ToString("hh:mm:ss");
              DateTime hora1 = Convert.ToDateTime(horass);
             // salida.Text = DateTime.Now.ToString("hh:mm:ss") + (Convert.ToInt16(horas.Text));
             hora1 = DateTime.Now.AddHours(Convert.ToInt16(horas.Text));
              salida.Text = hora1.ToString("hh:mm:ss"); 

        }

        private void descriptem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(descriptem.Text.Trim()))
                return;
            string cmd = string.Format("select * from tematica where descriptem = '{0}'", descriptem.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                precio_t.Text = ds.Tables[0].Rows[0]["precio_t"].ToString();
            }
            catch
            {
                MessageBox.Show("LA TEMATICA ACTUAL NO EXISTE");
            }
        }

        private void porciento_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void salida_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void product_CheckedChanged(object sender, EventArgs e)
        {
            if (product.Checked == true)
            {
                codprod.Enabled = true;
                descripprod.Enabled = true;
                canven.Enabled = true;
                salvar.Enabled = true;
                dataGridView1.Enabled = true;
                eliminar.Enabled = true;
                cancelar.Enabled = true;
                consultar.Enabled = true;
            }
            else
            if (product.Checked == false)
            {
                codprod.Enabled = false;
                descripprod.Enabled = false;
                canven.Enabled = false;
                preccio.Enabled = false;
                salvar.Enabled = false;
                dataGridView1.Enabled = false;
                eliminar.Enabled = false;
                cancelar.Enabled = false;
                consultar.Enabled = false;
            }
        }

        private void salida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
