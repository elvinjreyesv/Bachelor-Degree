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

namespace habitacion
{
    public partial class reservaciones : Form
    {
        public reservaciones()
        {
            InitializeComponent();
            entrada.Text = DateTime.Now.ToString("HH:mm:ss");
            salida.Enabled = true;

            string cmdd = "select max (codreserv+1) as Mayor from reservacion";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codreserv.Text = numfac;
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consult_reserv rm = new consult_reserv();
            rm.Dispose();
            rm.ShowDialog();
        }

        private void reservaciones_Load(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                //tipo de cliente

                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from estadia", con);
                da.Fill(ds1);
                estadia.DataSource = ds1.Tables[0].DefaultView;
                estadia.ValueMember = "descripcion";
                estadia.Text = "";
                estadia.Select();
            }
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                //tipo de cliente

                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select codhab from habitacion", con);
                da.Fill(ds1);
                codhab.DataSource = ds1.Tables[0].DefaultView;
                codhab.ValueMember = "codhab";
                codhab.Text = "";
                codhab.Select();
            }
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                //tipo de cliente

                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select nombre from cliente", con);
                da.Fill(ds1);
                nombre.DataSource = ds1.Tables[0].DefaultView;
                nombre.ValueMember = "nombre";
                nombre.Text = "";
                nombre.Select();
            }
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                //tipo de cliente

                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select codigo from cliente", con);
                da.Fill(ds1);
                codcli.DataSource = ds1.Tables[0].DefaultView;
                codcli.ValueMember = "codigo";
                codcli.Text = "";
                codcli.Select();
            }
             tipo.Enabled = false; preccio.Enabled = false; precio.Enabled = false; tematica.Enabled = false; porciento.Enabled = false; horas.Enabled = false; precio_t.Enabled = false;
        }

        private void codcli_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codcli.Text.Trim()))
            {
                cmd = "select max(codigo)as mayor from cliente";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codcli.Text = cod.ToString();
                }
            }
            cmd = "select * from cliente where codigo='" + codcli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                apellido.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellido"]);

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
                codcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["codigo"]);
                apellido.Text = Convert.ToString(ds.Tables[0].Rows[0]["apellido"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);

            }
            catch
            {
                MessageBox.Show("EL CLIENTE ACTUAL NO EXISTE");
            }
        }

        private void codhab_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codhab.Text.Trim()))
            {
                cmd = "select max(codhab)as mayor from habitacion";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codcli.Text = cod.ToString();
                }
            }
            cmd = "select * from habitacion where codhab='" + codhab.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                tipo.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
                tematica.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriptem"]);
              //  precio_h.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);

            }

            {
                if (string.IsNullOrEmpty(tematica.Text.Trim()))
                    return;
                string cmn = string.Format("select * from tematica where descriptem = '{0}'", tematica.Text.Trim());
                try
                {
                    DataSet du = utilidades.UTILIDADES.ejecutar(cmn);
                    preccio.Text = Convert.ToString(du.Tables[0].Rows[0]["precio_t"]);

                }
                catch
                {
                    MessageBox.Show("LA TEMATICA ACTUAL NO EXISTE");
                }
            }
        }

        private void tematica_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(tematica.Text.Trim()))
            //    return;
            //string cmn = string.Format("select * from tematica where descriptem = '{0}'", tematica.Text.Trim());
            //try
            //{
            //    DataSet du = utilidades.UTILIDADES.ejecutar(cmn);
            //    preccio.Text = Convert.ToString(du.Tables[0].Rows[0]["precio_t"]);

            //}
            //catch
            //{
            //    MessageBox.Show("LA TEMATICA ACTUAL NO EXISTE");
            //}
        }

        private void estadia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(estadia.Text.Trim()))
                return;
            string cmd = string.Format("select * from estadia where descripcion = '{0}'", estadia.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                porciento.Text = Convert.ToString(ds.Tables[0].Rows[0]["porciento"]);
                horas.Text = ds.Tables[0].Rows[0]["horas"].ToString();

            }
            catch
            {
                MessageBox.Show("LA ESTADIA ACTUAL NO EXISTE");
            }
            int num = 2000; 

            if (porciento.Text == "0")
            {
                precio_t.Text = (Convert.ToInt16(preccio.Text) + Convert.ToInt16(precio.Text) + Convert.ToInt16(num)).ToString();
            }
            else
            {
                int numero = (Convert.ToInt16(preccio.Text) + Convert.ToInt16(precio.Text));
                double porc = numero * (Convert.ToDouble(porciento.Text));
                precio_t.Text = (Convert.ToInt16(preccio.Text) + Convert.ToInt16(precio.Text) + Convert.ToInt16(num) + porc).ToString();
            }
              if(string.IsNullOrEmpty(entrada.Text.Trim()))
               {
                   MessageBox.Show("Para continuar debe especificar la hora de entrada");
                   entrada.Focus();
               }
               else
               {
               string horass = DateTime.Now.ToString("hh:mm:ss");
               DateTime hora1 = Convert.ToDateTime(horass);
               // salida.Text = DateTime.Now.ToString("hh:mm:ss") + (Convert.ToInt16(horas.Text));
               hora1 = DateTime.Now.AddHours(Convert.ToInt16(horas.Text));
               salida.Text = hora1.ToString("hh:mm:ss");
               }
           /* {
                if (estadia.Text == "pasada")
                {
                    try
                    {
                        DateTime inicio = Convert.ToDateTime(fecha_entrada.Value.ToShortDateString());
                        DateTime anadir = Convert.ToDateTime(entrada.Text);
                        string ad = anadir.ToString("HH:mm:ss");
                        TimeSpan t2 = new TimeSpan(Convert.ToInt16(ad), 0, 0);
                        DateTime tiempo = inicio.Add(t2);
                        int horatotal = 4;
                        TimeSpan t1 = new TimeSpan(horatotal, 0, 0);
                        DateTime combinado = tiempo.Add(t1);
                        salida.Text = combinado.ToString("hh:mm:ss");
                        fecha_salida.Value = combinado.Date;
                    }
                    catch { }
                }
                else if (estadia.Text == "amanecida")
                {
                    try
                    {
                        DateTime inicio = Convert.ToDateTime(fecha_entrada.Value.ToShortDateString());
                        DateTime anadir = Convert.ToDateTime(entrada.Text);
                        string ad = anadir.ToString("HH:mm:ss");
                        TimeSpan t2 = new TimeSpan(Convert.ToInt16(ad), 0, 0);
                        DateTime tiempo = inicio.Add(t2);
                        int horatotal = 24;
                        TimeSpan t1 = new TimeSpan(horatotal, 0, 0);
                        DateTime combinado = tiempo.Add(t1);
                        salida.Text = combinado.ToString("hh:mm:ss");
                        fecha_salida.Value = combinado.Date;
                    }
                    catch { }
                }
                else if (estadia.Text == "mediodia")
                {
                    try
                    {
                        DateTime inicio = Convert.ToDateTime(fecha_entrada.Value.ToShortDateString());
                        DateTime anadir = Convert.ToDateTime(entrada.Text);
                        string ad = anadir.ToString("HH:mm:ss");
                        TimeSpan t2 = new TimeSpan(Convert.ToInt16(ad), 0, 0);
                        DateTime tiempo = inicio.Add(t2);
                        int horatotal = 12;
                        TimeSpan t1 = new TimeSpan(horatotal, 0, 0);
                        DateTime combinado = tiempo.Add(t1);
                        salida.Text = combinado.ToString("hh:mm:ss");
                        fecha_salida.Value = combinado.Date;
                    }
                    catch { }
                }
            }*/

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codcli.Text = ""; nombre.Text = ""; apellido.Text = ""; telefono.Text = ""; codhab.Text = ""; tematica.Text = "";// preccio.Text = "";
            estadia.Text = ""; porciento.Text = ""; horas.Text = ""; precio_t.Text = ""; entrada.Text = ""; salida.Text = ""; fecha_entrada.Text = "";
        }

        public void limpiar()
        {
            codcli.Text = ""; nombre.Text = ""; apellido.Text = ""; telefono.Text = ""; codhab.Text = "";  tipo.Text = ""; tematica.Text = ""; preccio.Text = "";
            precio.Text = ""; estadia.Text = ""; porciento.Text = ""; horas.Text = ""; precio_t.Text = ""; entrada.Text = ""; salida.Text = ""; fecha_entrada.Text = "";
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TEMATICA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codreserv.Text);
                string cmd = "delete from reservacion where codreserv=" + codreserv.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codcli.Text = "";
                codreserv.Text = "";
                nombre.Text = "";
                apellido.Text = "";
                telefono.Text = "";
                codhab.Text = "";
                //precio_h.Text = "";
                tipo.Text = "";
                tematica.Text = "";
                preccio.Text = "";
                estadia.Text = "";
                porciento.Text = "";
                horas.Text = "";
                precio_t.Text = "";
                entrada.Text = "";
                salida.Text = "";
                fecha_entrada.Text = "";
                codreserv.Text = Convert.ToString(c);
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codcli.Text.Trim()) || string.IsNullOrEmpty(codhab.Text.Trim()) || string.IsNullOrEmpty(estadia.Text.Trim()))
            {
                MessageBox.Show("PARA CONTINUAR DEBE COMPLETAR LOS CAMPOS QUE ESTAN VACIOS");
                return;   
            }

            else
            {
                try
                {
                                       
                    string cmd = string.Format("insert into reservacion (codreserv, codcli,nombre,apellido,telefono,codhab,precio, estadia,fecha,entrada,salida) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", codreserv.Text.Trim(), codcli.Text.Trim(), nombre.Text.Trim(), apellido.Text.Trim(), telefono.Text.Trim(), codhab.Text.Trim(), precio.Text.Trim(), estadia.Text.Trim(),Convert.ToDateTime( fecha_entrada.Text.Trim()),Convert.ToDateTime( entrada.Text.Trim()),Convert.ToDateTime( salida.Text.Trim()));
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LA RESERVACION SE REALIZO CORRECTAMENTE");
                    string estad = "reservada"; int cod = 4;
                     cmd = "update habitacion set estado='" +estad + "', " + "codest='" + cod + "' where codhab='" + codhab.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                   
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codreserv+1) as Mayor from reservacion";
                DataSet dd = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = dd.Tables[0].Rows[0]["Mayor"].ToString();
                limpiar();
            }

        }

        private void entrada_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}