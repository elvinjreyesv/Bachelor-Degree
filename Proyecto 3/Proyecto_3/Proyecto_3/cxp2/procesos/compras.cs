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


namespace Proyecto_3.cxp2.procesos
{
    public partial class compras : MetroForm
    {
        CultureInfo us = new CultureInfo("en-US");
        double l3;
        double l1 = 0;
        int est;
        string nc;
        int dias = 0;
        public delegate void pasar(string dato);
        public event pasar pasado;
        string palabra="";
        string numl = "";
        
        public compras()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            //factura, ncf
            cod1.Text = "";
            descrip1.Text = "";
            cant1.Text = "";
            prec1.Text = "";
            data.Rows.Clear();
            descuento.Text = "";
            sub.Text = "";
            itbis.Text = "";
            total.Text = "";
            cod_cli.Text = "";
            nombre.Text = "";
            rnc.Text = "";
            telefono.Text = "";
            ncf.Text = "";
            condicion.SelectedIndex = 0;
            marca.Checked = false;
        }

        private void busca_cli()
        {
            proceso.titulo = "Suplidores";

            proceso.query = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1";
            proceso.query_cod = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1 and cod_sup";
            proceso.query_desc = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1 and nom_sup ";
            proceso.query2 = " select cod_sup as 'Codigo',nom_sup as 'Suplidor',nom_rep as 'Representante',rnc as 'RNC',correo as 'Correo' from suplidor where estado=1 and cod_sup= ";
        }

        public void suma()
        {
            string ll1 = "";
            string ll2 = "";
            string ll3 = "";
            string ll4;
            string ll5;
            double s = 0;
            double i = 0;
            double t = 0;
            string ll1a = "";
            string ll2a = "";
            string ll3a = "";
            double sa = 0;
            double ia = 0;
            double ta = 0;

            foreach (DataGridViewRow row in data.Rows)
            {
                string elvin = Convert.ToString(row.Cells[4].Value);
                float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                sa += Convert.ToDouble(num3);
                ia = sa * 0.18;
                ta = sa + ia;
                ll1a = sa.ToString("0.00", us);
                ll2a = ia.ToString("0.00", us);
                ll3a = ta.ToString("0.00", us);
            }

            double tot_itbs = i + ia;
            ll4 = tot_itbs.ToString("0.00", us);

            itbis.Text = ll4;
            double su = sa + s;
            ll5 = su.ToString("0.00", us);
            sub.Text = ll5;

            double totales = su + tot_itbs;
            string h = totales.ToString("0.00", us);
            total.Text = h;

            if (string.IsNullOrEmpty(descuento.Text))
                descuento.Text = "0";

            string elvin3 = descuento.Text.Trim();
            float des = float.Parse(elvin3, CultureInfo.InvariantCulture.NumberFormat); //descuento

            double totgn = totales - des;
            string elvin33 = totgn.ToString();
            double s3 = Convert.ToDouble(elvin33);
            string ll23 = s3.ToString("0.00", us);

            if (des > totales)
            {
                MetroMessageBox.Show(this, "El monto del descuento no puede ser mayor que el total de Factura", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                descuento.Text = "";
                return;
            }
            else
            {
                total.Text = ll23.ToString();
            }
        }

        private void save()
        {
            numl = factura.Text;
            if (condicion.SelectedIndex == 1)
                dias = 15;
            if (condicion.SelectedIndex == 2)
                dias = 30;
            if (condicion.SelectedIndex == 3)
                dias = 60;
            if (condicion.SelectedIndex == 4)
                dias = 90;

            DateTime s = Convert.ToDateTime(fecha.Text);
            DateTime tf = s.AddDays(dias);

            DataSet ds = new DataSet();
            int x;
            int y;
            int f;
            int val;
            est = 1;

            if (condicion.Text == "CONTADO") val = 0;
            else val = 1;
            string cadena = ncf.Text;
            if (string.IsNullOrEmpty(cod_cli.Text.Trim()) || data.Rows.Count == 0 || ncf.Text == "" || cadena.Length != 19)
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    string num5 = "11";

                    string cmdd = "select descrip from ncf_general where numero='" +num5  + "'";
                    ds = utilidades.UTILIDADES.ejecutar(cmdd);
                    string num = ds.Tables[0].Rows[0]["descrip"].ToString();

                    string ncf1 = "select ultimo+1 as mayor from ncf where numero='" + num5 + "'";
                    ds = utilidades.UTILIDADES.ejecutar(ncf1);
                    string num1 = ds.Tables[0].Rows[0]["mayor"].ToString();

                    string cmd = "act_compra '" + factura.Text + "','" + fecha.Text + "','" + total.Text + "','" + descuento.Text + "','" + cod_cli.Text + "','" + 1 + "','" + 1 + "','" + sub.Text + "','" + est + "','" + 1 + "','" + 0 + "','" + "01/02/2013" + "','" + ncf.Text + "','" + condicion.Text + "','" + val + "','" + itbis.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);

                    //-------------------------------------------- detalle-------------------------

                    for (x = 0; x <= data.Rows.Count - 1; x++)
                    {
                        string p = Convert.ToString(data.Rows[x].Cells[4].Value);
                        float num4 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                        string ll4 = num4.ToString("0.00", us);

                        string p1 = Convert.ToString(data.Rows[x].Cells[3].Value);
                        float num41 = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                        string ll41 = num41.ToString("0.00", us);

                        string h = "act_det_compra '" + factura.Text + "','" + data.Rows[x].Cells[0].Value.ToString() + "','" + data.Rows[x].Cells[2].Value.ToString() + "','" + ll41 + "','" + data.Rows[x].Cells[1].Value.ToString() + "','" + ll4 + "'";

                        utilidades.UTILIDADES.ejecutar(h);

                    }

                    if (condicion.SelectedIndex != 0)
                    {
                        string cmds = "act_cxpdbfregistros '" + factura.Text + "','" + fecha.Text + "','" + factura.Text + "','" + cod_cli.Text + "','" + 1 + "','" + total.Text + "','" + total.Text + "','" + itbis.Text + "','" + tf + "','" + ncf.Text + "','" + est + "','" + "01/01/1900" + "','" + " " + "','" + 0 + "','" + 1 + "'";
                        utilidades.UTILIDADES.ejecutar(cmds);

                    }
                    if (marca.Checked == true)
                    {
                       
                        string ncf2 = "update ncf set ultimo='" + num1 + "' where numero='" +num5 + "'";
                        ds = utilidades.UTILIDADES.ejecutar(ncf2);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                nuevos();
                codigo_mayor();
                cod_cli.Select();
                factura.Enabled = false;
            }
        }

        private void valida_cliente()
        {

            DataSet ds = new DataSet();
            string cmd = "select cod_sup ,nom_sup ,rnc,tel_sup from suplidor where cod_sup='" + cod_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nom_sup"]);
                rnc.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
                telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["tel_sup"]);
            }
            else
            {
                cod_cli.Text = "";
                nombre.Text = "";
                telefono.Text = "";
                rnc.Text = "";
            }
        }

        public void ejecutar_cli(string dato)
        {
            cod_cli.Text = dato;
            valida_cliente();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (numcom+1) as Mayor from compras";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            factura.Text = numfac;
            factura.Enabled = false;
        }

        private void busca_art()
        {
            proceso.titulo = "Artículos";
            proceso.query = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1";
            proceso.query_cod = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and cod_rep";
            proceso.query_desc = "select cod_rep as 'Codigo', descrip as 'Descripcion' from articulos where estado=1 and descrip ";
            proceso.query2 = "select replace((round(exist,2)),',','.') as 'Existencia',marca as 'Marca',replace((round(precio_unidad,2)),',','.') as 'Precio',coment as 'Comentario' from articulos where estado=1  and cod_rep= ";
        }

        private void busca3()
        {
            proceso.titulo = "Labores";
            proceso.query = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1";
            proceso.query_cod = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1 and codlabor";
            proceso.query_desc = "select codlabor as 'Codigo',descrip as 'Descripcion' from labores where estado=1 and descrip ";
            proceso.query2 = "select codlabor as 'codigo',descrip as 'descripcion' from labores where estado=3 and codlabor= ";
        }

        public void ejec_art(string dato)
        {
            cod1.Text = dato;
            validating_art();
        }

        private void validating_art()
        {
            CultureInfo us = new CultureInfo("en-US");

            DataSet ds = new DataSet();
            string cmd = "select * from articulos where cod_rep='" + cod1.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descrip1.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                string elvin = Convert.ToString(ds.Tables[0].Rows[0]["precio_unidad"]);
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                prec1.Text = ll2;
                cant1.Select();
            }
        }

        private void en_grid3()
        {
            cod1.Text = "";
            descrip1.Text = "";
            cant1.Text = "";
            prec1.Text = "";
            cod1.Select();
            //  suma3();
        }

        private void compras_Load(object sender, EventArgs e)
        {

            codigo_mayor();
            condicion.SelectedIndex = 0;
            cod_cli.Select();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
        }

        private void habilitar_Click(object sender, EventArgs e)
        {
            factura.Enabled = true;
            factura.Select();
        }

        private void b5_Click(object sender, EventArgs e)
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

        private void compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
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

        private void cod1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void prec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (prec1.Text.Contains('.'))
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

        private void cant1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod1.Text.Trim()) || string.IsNullOrEmpty(descrip1.Text.Trim()) || string.IsNullOrEmpty(cant1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod1.Select();
                return;
            }
            if (string.IsNullOrEmpty(cant1.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Cantidad No Válida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cant1.Select();
                return;
            }
            else
            {

                string elvin = prec1.Text;
                float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                string p = Convert.ToString(num3);

                bool exist = data.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo"].Value) == cod1.Text);

                if (!exist)
                {
                    double imp = Convert.ToDouble(p) * Convert.ToDouble(cant1.Text);
                    string ll2 = imp.ToString("0.00", us);

                    data.Rows.Add(cod1.Text.Trim(), descrip1.Text.Trim(), cant1.Text.Trim(), prec1.Text, ll2);
                    data.Sort(codigo, System.ComponentModel.ListSortDirection.Ascending);
                    en_grid3();
                    suma();
                }

            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (data.CurrentRow == null)
                return;
            data.Rows.Remove(data.CurrentRow);
            suma();
        }

        private void cod1_Validating(object sender, CancelEventArgs e)
        {
            validating_art();
            cant1.Select();
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

        private void compras_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                save();
            }
            if (e.KeyCode == Keys.F4)
            {
                nuevos();
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

        private void descuento_Validated(object sender, EventArgs e)
        {
            suma();
            total.Select();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (marca.Checked == true)
            {
                string notac = "11";
                string cmdd = "select descrip from ncf_general where numero='" + notac + "'";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string num = ds.Tables[0].Rows[0]["descrip"].ToString();

                string ncf1 = "select ultimo+1 as mayor from ncf where numero='" + notac + "'";
                ds = utilidades.UTILIDADES.ejecutar(ncf1);
                string num1 = ds.Tables[0].Rows[0]["mayor"].ToString();

                string com = num;
                int op = 19 - com.Length;
                string elvin = num + num1.PadLeft(op, '0');
                ncf.Text = elvin;
                ncf.Enabled = false;
            }
            else 
            {
                ncf.Enabled = true;
                ncf.Text = "";
            }
        }

        private void ncf_TextChanged(object sender, EventArgs e)
        {
           // ncf.Text = ncf.Text.ToUpper();
        }

        private void ncf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void ncf_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            busca_art();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejec_art);
            form2.ShowDialog();
        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            string query = "select * from view_compra where numcom='" + numl + "'";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds.Tables[0];
            int f = data1.Rows.Count - 1;
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in data1.Rows)
            {
    dtcompra.DatosCompraRow rowDatosCompra = facturacion.DatosCompra.NewDatosCompraRow();

    rowDatosCompra.numcom = Convert.ToString(row.Cells["numcom"].Value);
    rowDatosCompra.feccom = Convert.ToDateTime(row.Cells["feccom"].Value);
    rowDatosCompra.nom_rep = Convert.ToString(row.Cells["nom_rep"].Value);
    rowDatosCompra.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
    rowDatosCompra.tel_sup = Convert.ToString(row.Cells["tel_sup"].Value);
    rowDatosCompra.codpro = Convert.ToString(row.Cells["codpro"].Value);
    rowDatosCompra.canven = Convert.ToString(row.Cells["canven"].Value);
    rowDatosCompra.descripcion = Convert.ToString(row.Cells["descripcion"].Value);
    rowDatosCompra.preven = Convert.ToDouble(row.Cells["preven"].Value);
    rowDatosCompra.importe = Convert.ToDouble(row.Cells["importe"].Value);
    rowDatosCompra.totcom = Convert.ToDouble(row.Cells["totcom"].Value);
    rowDatosCompra.totitb = Convert.ToDouble(row.Cells["totitb"].Value);
    rowDatosCompra.totdes = Convert.ToDouble(row.Cells["totdes"].Value);
    rowDatosCompra.subtot = Convert.ToDouble(row.Cells["subtot"].Value);
    rowDatosCompra.ncf = Convert.ToString(row.Cells["ncf"].Value);
    rowDatosCompra.tipo = Convert.ToString(row.Cells["tipo"].Value);
    rowDatosCompra.cod_tip = Convert.ToString(row.Cells["cod_tip"].Value);
    rowDatosCompra.estado = Convert.ToString(row.Cells["estado"].Value);

                facturacion.DatosCompra.AddDatosCompraRow(rowDatosCompra);
            }
            return facturacion;
        }

        private dtcompra GenerarFactura1()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in data1.Rows)
            {

                dtcompra.DatosCompraRow rowDatosCliente = facturacion.DatosCompra.NewDatosCompraRow();

                rowDatosCliente.numcom = Convert.ToString(row.Cells["numcom"].Value);
                rowDatosCliente.feccom = Convert.ToDateTime(row.Cells["feccom"].Value);
                rowDatosCliente.nom_rep = Convert.ToString(row.Cells["nom_rep"].Value);
                rowDatosCliente.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
                rowDatosCliente.tel_sup = Convert.ToString(row.Cells["tel_sup"].Value);
                rowDatosCliente.codpro = Convert.ToString(row.Cells["codpro"].Value);
                rowDatosCliente.canven = Convert.ToString(row.Cells["canven"].Value);
                rowDatosCliente.descripcion = Convert.ToString(row.Cells["descripcion"].Value);
                rowDatosCliente.preven = Convert.ToDouble(row.Cells["preven"].Value);
                rowDatosCliente.importe = Convert.ToDouble(row.Cells["importe"].Value);
                rowDatosCliente.totcom = Convert.ToDouble(row.Cells["totcom"].Value);
                rowDatosCliente.totitb = Convert.ToDouble(row.Cells["totitb"].Value);
                rowDatosCliente.totdes = Convert.ToDouble(row.Cells["totdes"].Value);
                rowDatosCliente.subtot = Convert.ToDouble(row.Cells["subtot"].Value);
                rowDatosCliente.ncf = Convert.ToString(row.Cells["ncf"].Value);
                rowDatosCliente.tipo = Convert.ToString(row.Cells["tipo"].Value);
                rowDatosCliente.cod_tip = Convert.ToString(row.Cells["cod_tip"].Value);
                rowDatosCliente.estado = Convert.ToString(row.Cells["estado"].Value);
                facturacion.DatosCompra.AddDatosCompraRow(rowDatosCliente);
            }
            return facturacion;
        }      

        private void salvar_Click(object sender, EventArgs e)
        {
            save();
            condicion_rep();
            dtcompra datos = GenerarFactura();
           compra21 frm = new compra21(datos);
            frm.Show();
        }


        
    }
}
