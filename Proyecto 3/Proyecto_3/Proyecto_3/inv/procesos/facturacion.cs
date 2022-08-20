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
    public partial class facturacion : MetroForm
    {

        CultureInfo us = new CultureInfo("en-US");
        double l3;
        double l1 = 0;
        int est;
        string nc;
        int dias=0;
        public delegate void pasar(string dato);
        public event pasar pasado;

        public facturacion()
        {
            InitializeComponent();
        }
        private void nuevos()
        {
            //factura, ncf
            cod1.Text = "";
            cod.Text = "";
            descrip.Text = "";
            mano.Text = "";
            descrip1.Text = "";
            cant1.Text = "";
            cant.Text = "";
            prec.Text = "";
            prec1.Text = "";
            data1.Rows.Clear();
            data.Rows.Clear();
            descuento.Text = "";
            repuestos.Text = "";
            sub.Text = "";
            itbis.Text = "";
            total.Text = "";
            cod_cli.Text = "";
            nombre.Text = "";
            rnc.Text = "";
            telefono.Text = "";
            presupuesto.Text = "";
            des_veh.Text = "";
        }

        private void busca_cli()
        {
            proceso.titulo = "Clientes";

            proceso.query = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1";
            proceso.query_cod = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli";
            proceso.query_desc = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and per.nombre+''+per.apellido ";
            proceso.query2 = "select per.rnc as 'RNC',per.correo as 'Correo',per.telefono as 'Teléfono',per.celular as 'Celular',per.direccion as 'Dirección' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli= ";
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

            foreach (DataGridViewRow row in data1.Rows)
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

            repuestos.Text = ll1;

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
            ll4 = tot_itbs.ToString("0.00",us);

            itbis.Text = ll4;
            mano.Text = ll1a;
            double su = sa + s;
            ll5 = su.ToString("0.00",us);
            sub.Text = ll5;

            double totales = su + tot_itbs;
            string h = totales.ToString("0.00",us);
            total.Text = h;

            if (string.IsNullOrEmpty(descuento.Text))
                descuento.Text = "0";

            string elvin3 = descuento.Text.Trim();
            float des = float.Parse(elvin3, CultureInfo.InvariantCulture.NumberFormat); //descuento

            double totgn = totales - des;
            string elvin33 = totgn.ToString();
          double  s3 = Convert.ToDouble(elvin33);
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
            
            if (condicion.SelectedIndex == 1)
                dias = 15;
            if (condicion.SelectedIndex == 2)
                dias = 30;
            if (condicion.SelectedIndex == 3)
                dias = 60;
            if (condicion.SelectedIndex == 4)
                dias = 90;

            DateTime s = Convert.ToDateTime(fecha.Text);
            DateTime tf =s.AddDays(dias);

            DataSet ds = new DataSet();
            int x;
            int y;
            int f;
           int val;
           est = 1;

           if (condicion.Text == "CONTADO") val = 0;
           else val = 1;

           if (string.IsNullOrEmpty(cod_cli.Text.Trim()) || string.IsNullOrEmpty(vehiculo.Text.Trim()) || data.Rows.Count==0  || data1.Rows.Count==0)
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {

                        string cmdd = "select descrip from ncf_general where numero='"+nc+"'";
                          ds = utilidades.UTILIDADES.ejecutar(cmdd);
                         string num = ds.Tables[0].Rows[0]["descrip"].ToString();

                         string ncf1 = "select ultimo+1 as mayor from ncf where numero='" + nc + "'";
                         ds = utilidades.UTILIDADES.ejecutar(ncf1);
                         string num1 = ds.Tables[0].Rows[0]["mayor"].ToString();

                         string com = num;
                         int op = 19 - com.Length;
                         string elvin =num+ num1.PadLeft(op, '0');

                         string cmd = "act_factura '" + factura.Text + "','" + fecha.Text + "','" + total.Text + "','" + descuento.Text + "','" + cod_cli.Text + "','" + 1 + "','" + 1 + "','" + sub.Text + "','" + est + "','" + 1 + "','" + 0 + "','" + "01/02/2013" + "','" + vehiculo.Text + "','" + elvin + "','" + condicion.Text + "','" + val + "','" + itbis.Text + "'";
                         utilidades.UTILIDADES.ejecutar(cmd);

                         if (condicion.SelectedIndex != 0)
                         {
                             string cmds = "act_cxcdbfregistros '" + factura.Text + "','" + fecha.Text + "','" + factura.Text + "','" + cod_cli.Text + "','" + 1 + "','" + total.Text + "','" + total.Text + "','" + itbis.Text + "','" + tf + "','" + elvin + "','" +est + "','" + "01/01/1900" + "','" + " " + "','" + 0 + "','" + 1 + "'";
                             utilidades.UTILIDADES.ejecutar(cmds);
 
                         }
                    
                    string ncf2 = "update ncf set ultimo='" + num1 + "' where numero='" + nc + "'";
                         ds = utilidades.UTILIDADES.ejecutar(ncf2);


       //-------------------------------------------- labores-------------------------
                         string cmd1 = "delete from det_fact where numfac=" + factura.Text.Trim();
                         utilidades.UTILIDADES.ejecutar(cmd1);

                         for (x = 0; x <= data1.Rows.Count - 1; x++)
                         {
                             string p = Convert.ToString(data1.Rows[x].Cells[4].Value);
                             float num4 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                             string ll4 = num4.ToString("0.00", us);

                             string p1 = Convert.ToString(data1.Rows[x].Cells[3].Value);
                             float num41 = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                             string ll41 = num41.ToString("0.00", us);

                             string h = "act_repuestos_vs_fact '" + factura.Text + "','" + data1.Rows[x].Cells[0].Value.ToString() + "','" + data1.Rows[x].Cells[2].Value.ToString() + "','" + ll41 + "','" + data1.Rows[x].Cells[1].Value.ToString() + "','" + ll4 + "'";

                             utilidades.UTILIDADES.ejecutar(h);
  
                         }
                    //----------------------------------fallas-------------------
                    string cmd2 = "delete from obra_vs_factura where numfac='" + factura.Text.Trim() + "'";
                        utilidades.UTILIDADES.ejecutar(cmd2);

                        for (y = 0; y <= data.Rows.Count - 1; y++)
                        {
                            string p1 = Convert.ToString(data.Rows[y].Cells[3].Value);
                            float numr = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                            string ll = numr.ToString("0.00", us);

                            string p = Convert.ToString(data.Rows[y].Cells[4].Value);
                            float num4 = float.Parse(p, CultureInfo.InvariantCulture.NumberFormat);
                            string ll4 = num4.ToString("0.00", us);

                            string g = "act_obra_vs_fact'" + data.Rows[y].Cells[0].Value.ToString() + "','" + data.Rows[y].Cells[1].Value.ToString() + "','" + data.Rows[y].Cells[2].Value.ToString() + "','" + ll + "','" + ll4 + "','" + factura.Text + "'";

                            utilidades.UTILIDADES.ejecutar(g);
                        }

                        if (condicion.SelectedIndex == 0)
                        {
                            proceso.costo = total.Text;
                            inv.procesos.det_pago form2 = new inv.procesos.det_pago();
                            form2.ShowDialog();
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
            string cmd = "select per.nombre+' '+per.apellido as nombre,per.telefono,per.cedula,cli.ncf from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where cli.cod_cli='" + cod_cli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                rnc.Text = Convert.ToString(ds.Tables[0].Rows[0]["cedula"]);
               telefono.Text = Convert.ToString(ds.Tables[0].Rows[0]["telefono"]);
               nc = Convert.ToString(ds.Tables[0].Rows[0]["ncf"]);
            }
            else
            {
                cod_cli.Text = "";
                nombre.Text = "";
                telefono.Text = "";
                rnc.Text = "";
           //     cod_cli.Select();
            }
        }

        public void ejecutar_cli(string dato)
        {
            cod_cli.Text = dato;
            valida_cliente();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (numfac+1) as Mayor from factura";
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

        private void busca()
        {
            proceso.titulo = "Vehículos";
            proceso.query = "select veh.cod_veh as 'Codigo', ma.descripcion+' '+mo.descripcion as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as mo on mo.cod_modelo=veh.cod_modelo where veh.estado=1";
            proceso.query_cod = "select veh.cod_veh as 'Codigo', ma.descripcion+' '+mo.descripcion as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as mo on mo.cod_modelo=veh.cod_modelo where veh.estado=1 and veh.cod_veh";
            proceso.query_desc = "select veh.cod_veh as 'Codigo', ma.descripcion+' '+mo.descripcion as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as mo on mo.cod_modelo=veh.cod_modelo where veh.estado=1 and veh.detalles ";
            proceso.query2 = "select distinct ma.descripcion as 'Marca',model.descripcion as 'Modelo',veh.motor as 'Motor', comentario as 'Comentario' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as model on model.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh= ";
        }

        public void ejecutar_labor(string dato)
        {
            cod1.Text = dato;
            valida_labores();
        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            condicion.SelectedIndex = 0;
            cod_cli.Select();
        }

        public void ejecutar_veh(string dato)
        {
           vehiculo.Text = dato;
            valida_vehiculo();
        }

        private void valida_vehiculo()
        {
            DataSet ds = new DataSet();
            string cmd = "select veh.cod_veh as 'Codigo', ma.descripcion+' '+mo.descripcion as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as mo on mo.cod_modelo=veh.cod_modelo where cod_veh='" + vehiculo.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_veh.Text = Convert.ToString(ds.Tables[0].Rows[0]["Descripcion"]);
            }
            else
            {
               vehiculo.Text = "";
                des_veh.Text = "";
            }
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
            cod.Text = dato;
            validating_art();
        }

        private void en_grid()
        {
            cod.Text = "";
            descrip.Text = "";
            prec.Text = "";
            cant.Text = "";
            descrip.Select();
           // suma();
        }

        private void validating_art()
        {
            CultureInfo us = new CultureInfo("en-US");
           
                DataSet ds = new DataSet();
                string cmd = "select * from articulos where cod_rep='" + cod.Text.Trim() + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                descrip.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);
                string elvin = Convert.ToString(ds.Tables[0].Rows[0]["precio_unidad"]);
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                prec.Text = ll2;
                cant.Select();
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

        private void valida_labores()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from labores where codlabor='" + cod1.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                descrip1.Text = Convert.ToString(ds.Tables[0].Rows[0]["descrip"]);

                l3 = Convert.ToDouble(ds.Tables[0].Rows[0]["precio"]);
                string ll7 = l3.ToString("0.00", us);
                prec1.Text = ll7;
            }
            else
            {
                cod1.Text = "";
               descrip1.Text = "";
            }
            cant1.Select();
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

        private void metroButton5_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_veh);
            form2.ShowDialog();
            cod1.Select();
        }

        private void factura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void vehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cant_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cant1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void presupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void rnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (prec.Text.Contains('.'))
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
            busca3();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_labor);
            form2.ShowDialog();
            cant1.Select();
        }

        private void cod1_Validating(object sender, CancelEventArgs e)
        {
            valida_labores();
            cant1.Select();
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            busca_art();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejec_art);
            form2.ShowDialog();
        }

        private void cod_Validating(object sender, CancelEventArgs e)
        {
            validating_art();
            cant.Select();
        }

        private void cod_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod.Text.Trim()) || string.IsNullOrEmpty(descrip.Text.Trim()) || string.IsNullOrEmpty(cant.Text.Trim()) || string.IsNullOrEmpty(prec.Text.Trim()))
            {
                MetroMessageBox.Show(this, "No hay datos para agregar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod.Select();
                return;
            }
            if (string.IsNullOrEmpty(cant.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores No Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cant.Select();
                return;
            }
            else
            {
                string elvin = prec.Text;
                float num3 = float.Parse(elvin, CultureInfo.InvariantCulture.NumberFormat);
                string p = Convert.ToString(num3);

                bool exist = data1.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["codigo1"].Value) == cod.Text);
                if (!exist)
                {
                    double imp = Convert.ToDouble(p) * Convert.ToDouble(cant.Text);
                    string ll2 = imp.ToString("0.00", us);

                    data1.Rows.Add(cod.Text.Trim(), descrip.Text.Trim(), cant.Text.Trim(), prec.Text.Trim(), ll2);
                    data1.Sort(codigo1, System.ComponentModel.ListSortDirection.Ascending);
                    en_grid();
                }
            }
            cod.Select();
            suma();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (data1.CurrentRow == null)
                return;
            data1.Rows.Remove(data1.CurrentRow);
           // en_grid();

            suma();
          //  sum = 0;
        }

        private void facturacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cod_cli_Validating_1(object sender, CancelEventArgs e)
        {
            valida_cliente();
        }

        private void cod_cli_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
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

        private void descuento_Validating(object sender, CancelEventArgs e)
        {
            
            //descuento.Text = "0";
        }

        private void facturacion_KeyUp(object sender, KeyEventArgs e)
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

        private void salvar_Click(object sender, EventArgs e)
        {
            save();

            rep_ventas r = new rep_ventas();
            r.ShowDialog();
        }

        private void vehiculo_Validated(object sender, EventArgs e)
        {

        }

        private void vehiculo_Validating(object sender, CancelEventArgs e)
        {
            valida_vehiculo();
        }

        private void descuento_Validated(object sender, EventArgs e)
        {
            suma();
            total.Select();
        }

        private void cod_cli_Click(object sender, EventArgs e)
        {

        }
    }
}
