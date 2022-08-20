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

namespace taller.Procesos
{
    public partial class factura : Form
    {
        double s = 0, sub = 0,k=0;

        double l = 0;

        int subtotal = 0;

        public DataTable consulta = new DataTable();

        DataSet ds = new DataSet();

        public factura()
        {
            InitializeComponent();

            fecha.Text = Convert.ToString(System.DateTime.Now);
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


            int can=0;
            string cmd = "select max (cod_fact+1) as Mayor from factura";
            // string cmd = string.Format("select * from productos where codigo='{0}'", codprod.Text.Trim());
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
               can = Convert.ToInt16(ds.Tables[0].Rows[0]["mayor"].ToString().Trim());
            }
            cod.Text = Convert.ToString(can);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " FACTURACION ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void factura_Load(object sender, EventArgs e)
        {

            label20.Text = prcesos.usuario;
            cod_recep.Text = prcesos.recep;
            cod_cli.Text= prcesos.cod_cli;
            cliente.Text= prcesos.nombre; 
            rnc.Text=  prcesos.rnc ;
            ncf.Text = prcesos.ncf;
            direccion.Text = prcesos.direccion; 
            eliminar.Enabled = false;
            procesar.Enabled = false;

            timer1.Enabled = true;
            timer1.Interval = 25;

            {
                SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller_f; Integrated security=true;");
                SqlDataAdapter da = new SqlDataAdapter("select descrip_trab from trabajos order by descrip_trab", co);
                da.Fill(ds);
                detalle.DataSource = ds.Tables[0].DefaultView;
                detalle.ValueMember = "descrip_trab";
                detalle.Text = "";
                detalle.Select();
            }
        }

        public void suma()
        {
          
            double s = 0;
            foreach (DataRow dr in consulta.Rows)
            {
                s += Convert.ToDouble(dr["importe"]);
            }
            double j = s * 0.18;
            itbiss.Text = Convert.ToString(j);
            sub_total.Text = s.ToString();
            total.Text =Convert.ToString( (s + j));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            cod_tra.Text = ""; detalle.Text = ""; can_tra.Clear(); cod_tra.Focus();
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
            cod_tra.Focus();
        }

        private void detalle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(detalle.Text.Trim()))
                return;
            string cmd = string.Format("select * from trabajos where descrip_trab = '{0}'", detalle.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                // MessageBox.Show(cmd);
                cod_tra.Text = ds.Tables[0].Rows[0]["cod_trab"].ToString();
                pre_tra.Text = ds.Tables[0].Rows[0]["precio"].ToString();
                can_tra.Select();
            }
            catch
            {
              //  MessageBox.Show("EL CLIENTE ACTUAL NO EXIXTE");
            }
        }

        private void cod_tra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cod_tra.Text.Trim()))
                return;
            string cmd = string.Format("select * from trabajos where cod_trab = '{0}'", cod_tra.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                pre_tra.Text = ds.Tables[0].Rows[0]["precio"].ToString();
                detalle.Text = ds.Tables[0].Rows[0]["descrip_trab"].ToString();
            }
            catch
            {
               // MessageBox.Show("EL ARTICULO ACTUAL NO EXISTE");
            }
        }

        private void can_tra_Validating(object sender, CancelEventArgs e)
        {
            eliminar.Enabled = true;
            agregar.Enabled = true;
            procesar.Enabled = true;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int can = 0, c = 0;
            DataSet ds = new DataSet();
            if (string.IsNullOrEmpty(cod_tra.Text))
            {
                MessageBox.Show("PARA CONTINUAR DEBE DIGITAR LOS DATOS");
                cod_tra.Focus();
                return;
            }
            {
                if (string.IsNullOrEmpty(detalle.Text))
                {
                    MessageBox.Show("EL CAMPO DE DETALLE ESTA VACIO");
                    detalle.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(can_tra.Text))
                {
                    MessageBox.Show("EL CAMPO DE CANTIDAD ESTA VACIO");
                    can_tra.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(pre_tra.Text))
                {
                    MessageBox.Show("EL CAMPO DE PRECIO ESTA VACIO");
                    pre_tra.Focus();
                    return;
                }

                else
                {

                    consulta.Rows.Add();
                    int pos = consulta.Rows.Count - 1;
                    consulta.Rows[pos]["codigo"] = cod_tra.Text.Trim();
                    consulta.Rows[pos]["descripcion"] = detalle.Text.Trim();
                    consulta.Rows[pos]["cantidad"] = can_tra.Text.Trim();
                    consulta.Rows[pos]["precio"] = pre_tra.Text.Trim();
                    consulta.Rows[pos]["importe"] = Convert.ToDouble(pre_tra.Text) * Convert.ToDouble(can_tra.Text);
                    pre_tra.Text = " "; cod_tra.Text = " "; detalle.Text = ""; can_tra.Clear(); cod_tra.Focus();
                    //  sub_total.Text = "";
                    suma();
                }
                
            }
        }

        private void can_tra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nuevos()
        {
            cliente.Text = "";
            cod_recep.Text = "";
            ncf.Text = "";
            descuento.Text = "";
            cod_tra.Text = "";
            detalle.Text = "";
            can_tra.Text = "";
            pre_tra.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            cod_cli.Text = "";
            rnc.Text = "";
            direccion.Text = "";

            int can = 0;
            string cmd = "select max (cod_fact+1) as Mayor from factura";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                can = Convert.ToInt16(ds.Tables[0].Rows[0]["mayor"].ToString().Trim());
            }
            cod.Text = Convert.ToString(can);
        }

        private void procesar_Click(object sender, EventArgs e)
        {
            Double sd;
            subtotal = Convert.ToInt16(s);
            string cmd = "";
            DataSet ds = new DataSet();
            if (dataGridView1.Rows.Count == 0 || string.IsNullOrEmpty(cod_cli.Text.Trim()))
            {
                MessageBox.Show("NO HAY DATOS SUFICIENTES PARA PROCESAR LA FACTURA ACTUAL");
                return;
            }
            else
                sd = 0;
            
                cmd = string.Format("insert into factura (cod_fact,fec_fact,cod_cli,cod_est,cod_ncf,cod_rnc,desc_fact,tipo_pago,subtotal,total,cod_itbis,usuario) values('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}','{8}', '{9}', '{10}','{11}')", cod.Text.Trim(), System.DateTime.Now.ToString(), cod_cli.Text.Trim(), 1, ncf.Text.Trim(), rnc.Text.Trim(), sd, 1,sub_total.Text, total.Text.Trim(),itbis.Text.Trim(),prcesos.usuario);
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                   // MessageBox.Show(""+cmd);

             foreach (DataRow dr in consulta.Rows)
                {
                    cmd = string.Format("insert into det_fact (cod_fact, desc_fact, precio, cant,descripcion) values('{0}', '{1}', '{2}', '{3}','{4}')", cod.Text.Trim(), dr["codigo"], dr["precio"], dr["cantidad"], dr["descripcion"]);
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    try { }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }
                   
             }

             nuevos();
             prcesos.numerof = cod.Text;
             prcesos.total =total.Text;

             if (check1.Checked == true)
             {
                 facturacion fac = new facturacion();
                 fac.ShowDialog();
             }

             if (check1.Checked == false)
             {
                 facturacion2 fac2 = new facturacion2();
                 fac2.ShowDialog();
             }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();

            int can = 0;
            string cmd = "select max (cod_fact+1) as Mayor from factura";
            // string cmd = string.Format("select * from productos where codigo='{0}'", codprod.Text.Trim());
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                can = Convert.ToInt16(ds.Tables[0].Rows[0]["mayor"].ToString().Trim());
            }
            cod.Text = Convert.ToString(can);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            consultas.consult_cli gf = new consultas.consult_cli();
            gf.ShowDialog();
            

           // this.Close();
            //gf.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            prcesos.cod = cod_cli.Text;

            this.Visible = false;
            consultas.consult_recep cr = new consultas.consult_recep();
            cr.ShowDialog();
        }

        private void descuento_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(descuento.Text.Trim()))
            { 
                l = 0; 
            }
            else

            { 
                l = Convert.ToDouble(descuento.Text) / 100;
               // MessageBox.Show(""+l);
            }
           
            des.Text = Convert.ToString(l * Convert.ToDouble(total.Text));
            double q=Convert.ToDouble(total.Text);
            total.Text =Convert.ToString( q - Convert.ToDouble(des.Text));
            
        }

        private void cod_cli_Validating(object sender, CancelEventArgs e)
        {
            string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.ncf as ncf,cliente.dir_cli as direccion,cliente.rnc as rnc from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero where cod_cli='" + cod_cli.Text.Trim() + "'";

            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cliente.Text = Convert.ToString(ds.Tables[0].Rows[0]["Nombre"]);
                rnc.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
                ncf.Text = Convert.ToString(ds.Tables[0].Rows[0]["ncf"]);

            }
            else {// MessageBox.Show("el valor ingresado es incorrecto"); 
            }
        }

        private void cliente_Validating(object sender, CancelEventArgs e)
        {
            string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.ncf,cliente.rnc from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero";
            cmd += " where tercero.nombre + ' ' + cliente.apellido  like ('%" + cliente.Text.Trim() + "%')";

            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["Codigo_Clinte"]);
                rnc.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
                ncf.Text = Convert.ToString(ds.Tables[0].Rows[0]["ncf"]);

            }
            else {// MessageBox.Show("el valor ingresado es incorrecto");
            }
        }

        private void rnc_Validating(object sender, CancelEventArgs e)
        {
            string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.ncf as ncf,cliente.dir_cli as direccion,cliente.rnc as rnc from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero where rnc='" + rnc.Text.Trim() + "'";

            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cliente.Text = Convert.ToString(ds.Tables[0].Rows[0]["Nombre"]);
                cod_cli.Text = Convert.ToString(ds.Tables[0].Rows[0]["Codigo_Clinte"]);
                direccion.Text = Convert.ToString(ds.Tables[0].Rows[0]["direccion"]);
                ncf.Text = Convert.ToString(ds.Tables[0].Rows[0]["ncf"]);

            }
            else {// MessageBox.Show("el valor ingresado es incorrecto"); 
            }
        }
       
    }
}
