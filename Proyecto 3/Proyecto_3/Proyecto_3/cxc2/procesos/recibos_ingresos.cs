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
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace Proyecto_3.cxc2.procesos
{
    public partial class recibos_ingresos : MetroForm
    {
        CultureInfo us = new CultureInfo("en-US");
        string p1 = ""; float num41 = 0; string ll1 = ""; string p2 = ""; float num42 = 0; string ll2 = "";
        string p3 = ""; float num43 = 0; string ll3 = ""; int rg = 0;

        double s1; int m = 0; int ry = 0; int d = 0; string cob="";
        
        string query = "";
        

        public recibos_ingresos()
        {
            InitializeComponent();
        }

        private void insertar_data()
        {
            m = 1;
            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "SELECT CONVERT (char(10), fecreg, 103) as fecreg,CAST ( numreg AS varchar (50)) as numreg,floor(round(balreg,0)) as balreg,floor(round(totreg,0)) as totreg,codcli from cxcdbfregistros where balreg>0 and codcli='" + codcli.Text + "' order by fecreg";

            comando.CommandType = CommandType.Text;
            con.Open();
            data.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data.Rows.Add();
      data.Rows[renglon].Cells["factura"].Value = dr.GetString(dr.GetOrdinal("numreg")).ToString();
     data.Rows[renglon].Cells["fecha"].Value = dr.GetString(dr.GetOrdinal("fecreg"));
    string elvin1 = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("balreg"))).ToString();
     data.Rows[renglon].Cells["pendiente"].Value =elvin1;
            }
            con.Close();
        }

        private void valida_cliente()
        {
            DataSet ds = new DataSet();
            string cmd = "select per.nombre+' '+per.apellido as nombre, per.correo, per.telefono as telefono, per.celular as celular,per.direccion as direccion,per.rnc as rnc from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where cli.cod_cli='" + codcli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nomcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                rnccli.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
            }
            else
            {
                codcli.Text = "";
            }

            insertar_data();
            refcob.Select();
        }

        public void ejecutar_cli(string dato)
        {
            codcli.Text = dato;
            valida_cliente();
        }

        private void codigo_mayor()
        {
            string cmdd = "select MAX(numcob)+1 as mayor from cobro";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["mayor"].ToString();
            cobro.Text = numfac;
            codcli.Select();
        }

        private void busca1()
        {
            proceso.titulo = "Clientes";

            proceso.query = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1";
            proceso.query_cod = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli";
            proceso.query_desc = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and per.nombre+''+per.apellido ";
            proceso.query2 = "select per.rnc as 'RNC',per.correo as 'Correo',per.telefono as 'Teléfono',per.celular as 'Celular',per.direccion as 'Dirección' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli= ";
        }

        private void nuevos()
        {
            codcli.Text = "";
            nomcli.Text = "";
            rnccli.Text = "";
            refcob.Text = "";
            observacion.Text = "";
           data.Rows.Clear();
           tcob.Text = "";
        }

        private void save()
        {
            cob = cobro.Text;

            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            int f;
            string ven="01 / 01 / 1900";
                try
                {
                    string cmd = "act_cobro '" + cobro.Text + "','" + feccob.Text + "','" + codcli.Text + "','" + 1 + "','" + tcob.Text + "','" + 1 + "','" + ven + "','" + observacion.Text.Trim() + "','" + 1 + "','" + refcob.Text + "','" + tipo.Text + "','" + numero.Text + "'";


                        utilidades.UTILIDADES.ejecutar(cmd);

                   //----------------------------------detalle del cobro-------------------
                       for (f = 0; f <= data.Rows.Count - 1; f++)
                       {
                           if (Convert.ToInt16(data.Rows[f].Cells[4].Value) == 1)
                           {
                               string d = "act_det_cobro '" + cobro.Text + "','" + Convert.ToInt16(data.Rows[f].Cells[0].Value.ToString()) + "','" + Convert.ToInt16(data.Rows[f].Cells[3].Value.ToString()) + "','" + 0 + "','" + ven + "'";
                               
                               utilidades.UTILIDADES.ejecutar(d);
                  
                      int h = 0;
                      string cmd1 = "SELECT floor(round(balreg,0)) as balreg from cxcdbfregistros where numreg='" + data.Rows[f].Cells[0].Value.ToString() + "'";
               DataSet ds = utilidades.UTILIDADES.ejecutar(cmd1);
               if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
               {
                   h = Convert.ToInt16(ds.Tables[0].Rows[0]["balreg"]);
               }
               int p = h - Convert.ToInt16(data.Rows[f].Cells[3].Value.ToString());

               cmd1 = "update cxcdbfregistros set balreg='" + p + "' where numreg='" + data.Rows[f].Cells[0].Value.ToString() + "'";
               utilidades.UTILIDADES.ejecutar(cmd1);
               condicion_rep();

               nuevos();
                           }
                       }
                }
                catch (Exception er)
                {
                   // MessageBox.Show(er.ToString());
                }
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion1 = new dtcompra();
            foreach (DataGridViewRow row in data1.Rows)
            {
                dtcompra.DatosCobroRow rowDatosCliente = facturacion1.DatosCobro.NewDatosCobroRow();
                rowDatosCliente.numcob = Convert.ToString(row.Cells["numcob"].Value);
                rowDatosCliente.feccob = Convert.ToDateTime(row.Cells["feccob"].Value);
                rowDatosCliente.totcob = Convert.ToDouble(row.Cells["totcob"].Value);
                rowDatosCliente.refcob = Convert.ToString(row.Cells["refcob"].Value);
                rowDatosCliente.nombre = Convert.ToString(row.Cells["nombre"].Value);
                rowDatosCliente.numfac= Convert.ToString(row.Cells["numfac"].Value);
                rowDatosCliente.moncob = Convert.ToDouble(row.Cells["moncob"].Value);
                rowDatosCliente.mondes = Convert.ToDouble(row.Cells["mondes"].Value);
                rowDatosCliente.codcli = Convert.ToString(row.Cells["cod_cli"].Value);
                rowDatosCliente.balreg = Convert.ToDouble(row.Cells["balreg"].Value);
                rowDatosCliente.direccion = Convert.ToString(row.Cells["direccion"].Value);
                rowDatosCliente.telefono = Convert.ToString(row.Cells["telefono"].Value);
                facturacion1.DatosCobro.AddDatosCobroRow(rowDatosCliente);
            }
            return facturacion1;
        }

        private void cobros_factura_Load(object sender, EventArgs e)
        {
            tipo.SelectedIndex = 0;
            codigo_mayor();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            ry = 2;
            this.Close();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            busca1();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_cli);
            form2.ShowDialog();
        }

        private void codcli_Validating(object sender, CancelEventArgs e)
        {
            valida_cliente();

            string cmd = "SELECT CONVERT (char(10), fecreg, 103) as fecreg,numreg,floor(round(balreg,0)) as balreg,floor(round(totreg,0)) as totreg,codcli from cxcdbfregistros where codcli='" + codcli.Text + "' order by fecreg";

            DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
            int ry = ds.Tables[0].Rows.Count;
            if (ds.Tables[0].Rows.Count <= 0 && codcli.Text!="")
            {
                MetroMessageBox.Show(this, "Este cliente no tiene facturas pendientes", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codcli.Text = "";
                nomcli.Text = "";
                rnccli.Text = "";
                codcli.Select();

                return;
            }
        }

        private void recibos_ingresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void data_EditingControlShowing(object sender,
        DataGridViewEditingControlShowingEventArgs e)
        {
            if (data.CurrentCell.ColumnIndex == 3)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(data_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(data_KeyPress);
                }
            }
        }

        public static void AllowNumber(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }

        private void data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void metodo(object sender, DataGridViewCellEventArgs e)
        {
            if (data.Columns[e.ColumnIndex].Name == "val")
            {
                num42 = 0; num41 = 0;
                DataGridViewRow row = data.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["val"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    p1 = Convert.ToString(data.CurrentRow.Cells["pendiente"].Value);
                    num41 = float.Parse(p1, CultureInfo.InvariantCulture.NumberFormat);
                    ll1 = num41.ToString("0.00", us);

                    data.CurrentRow.Cells["aplicar"].Value = ll1;

                    p2 = Convert.ToString(data.CurrentRow.Cells["aplicar"].Value);
                    num42 = float.Parse(p2, CultureInfo.InvariantCulture.NumberFormat);
                    ll2 = num42.ToString("0.00", us);

                    float j = num41 - num42;
                    string ll9 = j.ToString("0.00", us);
                    data.CurrentRow.Cells["balance"].Value = ll9;

                    if (Convert.ToString(data.CurrentRow.Cells["balance"].Value) != "")
                    {
                        p3 = Convert.ToString(data.CurrentRow.Cells["balance"].Value);
                        num43 = float.Parse(p3, CultureInfo.InvariantCulture.NumberFormat);
                        ll3 = num43.ToString("0.00", us);
                    }
                }
                if (!Convert.ToBoolean(cellSelecion.Value))
                {
                    data.CurrentRow.Cells["aplicar"].Value = "";
                    data.CurrentRow.Cells["balance"].Value = "";
                }
            }
        }

        public void suma()
        {
            double sl = 0;
            foreach (DataGridViewRow row in data.Rows)
            {
                string elvin = Convert.ToString(row.Cells[3].Value);
                sl += Convert.ToDouble(row.Cells[3].Value);
            }
            tcob.Text = Convert.ToString(sl);
            s1 = sl;
        }

        private void data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //data.CurrentRow.Cells["balance"].ReadOnly.Equals(true);
            DataGridViewRow row;
            DataGridViewCheckBoxCell cellSelecion;
            string l = "";
         int ll7=0; float num48; decimal g = 0; double s = 0; double p = 0;

            if (data.Columns[e.ColumnIndex].Name == "val")
            {
               
                num42 = 0; num41 = 0;
                row = data.Rows[e.RowIndex];
                cellSelecion = row.Cells["val"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    p1 = Convert.ToString(data.CurrentRow.Cells["pendiente"].Value);
                    data.CurrentRow.Cells["aplicar"].Value = p1;
                    p2 = Convert.ToString(data.CurrentRow.Cells["aplicar"].Value);
                }
                else 
                {
                    data.CurrentRow.Cells["aplicar"].Value = "0";
                    data.CurrentRow.Cells["balance"].Value = "0";
                }

              if (!Convert.ToBoolean(cellSelecion.Value))
                {
                    data.CurrentRow.Cells["aplicar"].Value = "0";
                    data.CurrentRow.Cells["balance"].Value = "0";
                }
            }

            if (data.Rows.Count > 0)
            {
                s = Convert.ToDouble(data.CurrentRow.Cells["aplicar"].Value);
               rg = Convert.ToInt16(data.CurrentRow.Cells["aplicar"].Value);

                l = Convert.ToString(data.CurrentRow.Cells["aplicar"].Value);
            }

            if (data.Rows.Count > 0) //aqui
            {
                int uy = Convert.ToInt16(data.CurrentRow.Cells["pendiente"].Value);
                p = Convert.ToDouble(data.CurrentRow.Cells["pendiente"].Value);

              if (s > p)
              {
                  MetroMessageBox.Show(this, "El monto a aplicar no puede ser mayor que el balance del registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  data.CurrentRow.Cells["aplicar"].Value = Convert.ToString(data.CurrentRow.Cells["pendiente"].Value);
                  data.CurrentRow.Cells["val"].Value = 1;
                  return;
              }

              decimal j = Convert.ToDecimal(p) - Convert.ToDecimal(s);
              data.CurrentRow.Cells["balance"].Value = j;
            }

            if (data.Rows.Count > 0)
            {
                if (Convert.ToString(data.CurrentRow.Cells["balance"].Value) != "")
                {
                    p3 = Convert.ToString(data.CurrentRow.Cells["balance"].Value);

                }
                suma();
            }

           
            if (data.Rows.Count > 0 && Convert.ToDouble(data.CurrentRow.Cells["aplicar"].Value) > 0 )
            {
                    data.CurrentRow.Cells["val"].Value = 1;
                    for (int b = 0; b < 5; b++)
                    {
                        
                    }
                       
                    string h = l;
     data.CurrentRow.Cells["aplicar"].Value=h;
               
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
  
        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            string reg = Convert.ToString(cobro.Text);
            query = "SELECT     c.numcob, c.feccob, c.totcob, c.cod_cli, c.refcob, SUM(reg.balreg) AS balreg, p.nombre + '' + p.apellido AS nombre, p.direccion, p.telefono, d.numfac, d.moncob, d.mondes FROM         dbo.cobro AS c INNER JOIN dbo.det_cobro AS d ON c.numcob = d.numcob INNER JOIN dbo.cliente AS cli ON cli.cod_cli = c.cod_cli INNER JOIN dbo.persona AS p ON p.cod_persona = cli.cod_persona INNER JOIN dbo.cxcdbfregistros AS reg ON reg.numreg = d.numfac where c.numcob='" + reg + "' GROUP BY c.numcob, c.feccob, c.totcob, c.refcob, reg.balreg, p.nombre, p.apellido, d.numfac, d.moncob, d.mondes, c.cod_cli, p.direccion, p.telefono";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds.Tables[0];
            int f = data1.Rows.Count - 1;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codcli.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codcli.Select();
                return;
            }
            if (Convert.ToInt16(tcob.Text) == 0)
            {
                MetroMessageBox.Show(this, "No hay datos para procesar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                save();
                dtcompra datos = GenerarFactura();
                reging frm = new reging(datos);
                frm.Show();
                codigo_mayor();
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codcli.Text = "";
            nomcli.Text = "";
            rnccli.Text = "";
            refcob.Text = "";
            observacion.Text = "";

            data.Rows.Clear();
            tcob.Text = "";
            //nuevos();
            codcli.Select();
        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            numero.Text = "";
            if (tipo.SelectedIndex == 1)
            {//cheque
                pago.Text = "Número de cheque";
                numero.Visible = true;
                numero.Select();
            }
            else if (tipo.SelectedIndex == 2)
            {//transferencia
                pago.Text = "Número de Transferencia";
                numero.Visible = true;
                numero.Select();
            }
            else if (tipo.SelectedIndex == 3)
            {//tarjeta
                pago.Text = "Número de Tarjeta";
                numero.Visible = true;
                numero.Select();
            }
            else
            {//tarjeta
                pago.Text = "";
                numero.Visible = false;
                numero.Select();
            }
        }

        private void recibos_ingresos_KeyUp(object sender, KeyEventArgs e)
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
    }
}