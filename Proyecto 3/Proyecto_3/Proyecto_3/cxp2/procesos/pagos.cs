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

namespace Proyecto_3.cxp2.procesos
{
    public partial class pagos : MetroForm
    {
        CultureInfo us = new CultureInfo("en-US");
   string p1 = ""; float num41 = 0; string ll1 = ""; string p2 = ""; float num42 = 0; string ll2 = "";
        string p3 = ""; float num43 = 0; string ll3 = ""; int rg = 0;
        double s1; int m = 0; int ry = 0; int d = 0; string cob = "";
        string query = "";

        public pagos()
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
            comando.CommandText = "SELECT CONVERT (char(10), fecreg, 103) as fecreg,CAST ( numreg AS varchar (50)) as numreg,floor(round(balreg,0)) as balreg,floor(round(totreg,0)) as totreg,cod_sup from cxpdbfregistros where balreg>0 and cod_sup='" + codcli.Text + "' order by fecreg";

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
                data.Rows[renglon].Cells["pendiente"].Value = elvin1;
            }
            con.Close();
        }

        private void valida_cliente()
        {
            DataSet ds = new DataSet();
            string cmd = "select cod_sup ,nom_sup ,rnc,tel_sup from suplidor where cod_sup='" + codcli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nomcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nom_sup"]);
                rnccli.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
            }
            else
            {
                codcli.Text = "";
                rnccli.Text = "";
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
            string cmdd = "select MAX(numpag)+1 as mayor from pagos1";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["mayor"].ToString();
            cobro.Text = numfac;
            codcli.Select();
        }

        private void busca1()
        {
            proceso.titulo = "Suplidores";

            proceso.query = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1";
            proceso.query_cod = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1 and cod_sup";
            proceso.query_desc = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1 and nom_sup ";
            proceso.query2 = " select cod_sup as 'Codigo',nom_sup as 'Suplidor',nom_rep as 'Representante',rnc as 'RNC',correo as 'Correo' from suplidor where estado=1 and cod_sup= ";
        }

        private void nuevos()
        {
            codcli.Text = "";
            nomcli.Text = "";
            des.Text = "";
            neto.Text = "";
            rnccli.Text = "";
            refcob.Text = "";
            observacion.Text = "";
            numero.Visible = false;
            pago.Visible = false;
            data.Rows.Clear();
            tcob.Text = "";
        }

        private void save()
        {
            cob = cobro.Text;
            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            int f;
            string ven = "01 / 01 / 1900";

            {
                try
                {
                        string numeros = numero.Text;
                        string cmd = "act_pagos '" + cobro.Text + "','" + feccob.Text + "','" + codcli.Text + "','" + 1 + "','" + tcob.Text + "','" + 1 + "','" + ven + "','" + observacion.Text.Trim() + "','" + 1 + "','" + refcob.Text + "','" + tipo.Text + "','" + numeros + "'";

                        utilidades.UTILIDADES.ejecutar(cmd);

                        //----------------------------------detalle del cobro-------------------
                        for (f = 0; f <= data.Rows.Count;f++)
                        {
                            int vp=Convert.ToInt16(data.Rows[f].Cells[7].Value);
                            if (Convert.ToInt16(data.Rows[f].Cells[7].Value) == 1)
                            {

                      int uno = Convert.ToInt16(data.Rows[f].Cells[0].Value);//numero
                      int dos = Convert.ToInt16(data.Rows[f].Cells[6].Value);//monto
                      int tres = Convert.ToInt16(data.Rows[f].Cells[3].Value);//desc
                      int cuatro = Convert.ToInt16(data.Rows[f].Cells[4].Value);//renta
                      int cinco = Convert.ToInt16(data.Rows[f].Cells[5].Value);//itbis

  string d = "act_det_pagos1 '" + cobro.Text + "','" + uno + "','" + dos + "','" + tres + "','" + feccob.Text + "','" + cuatro + "','" + cinco + "'";
                                utilidades.UTILIDADES.ejecutar(d);

                                int h = 0;
                                string cmd1 = "SELECT floor(round(balreg,0)) as balreg from cxpdbfregistros where numreg='" + data.Rows[f].Cells[0].Value.ToString() + "'";
                                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd1);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    h = Convert.ToInt16(ds.Tables[0].Rows[0]["balreg"]);
                                }

                                int p = h - Convert.ToInt16(data.Rows[f].Cells[6].Value.ToString());
                                cmd1 = "update cxpdbfregistros set balreg='" + p + "' where numreg='" + data.Rows[f].Cells[0].Value.ToString() + "'";
                                utilidades.UTILIDADES.ejecutar(cmd1);
                                
                            }
                            
                        }
                        condicion_rep();
                        nuevos();
                }
                catch (Exception er)
                {
                  // MessageBox.Show(er.ToString());
                }

            }
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion1 = new dtcompra();
            foreach (DataGridViewRow row in data1.Rows)
            {
                dtcompra.DatosPagosRow rowDatosCliente = facturacion1.DatosPagos.NewDatosPagosRow();
                rowDatosCliente.numcom = Convert.ToString(row.Cells["numcom"].Value);
                rowDatosCliente.mondes = Convert.ToDouble(row.Cells["mondes"].Value);
                rowDatosCliente.moncob = Convert.ToDouble(row.Cells["moncob"].Value);
                rowDatosCliente.retisr = Convert.ToDouble(row.Cells["retisr"].Value);
                rowDatosCliente.retitb = Convert.ToDouble(row.Cells["retitb"].Value);
                rowDatosCliente.numpag = Convert.ToString(row.Cells["numpag"].Value);
                rowDatosCliente.feccob = Convert.ToDateTime(row.Cells["feccob"].Value);
                rowDatosCliente.cod_sup = Convert.ToString(row.Cells["cod_sup"].Value);
                rowDatosCliente.totcob = Convert.ToDouble(row.Cells["totcob"].Value);
                rowDatosCliente.estado = Convert.ToString(row.Cells["estado"].Value);
                rowDatosCliente.refcob = Convert.ToString(row.Cells["refcob"].Value);
                rowDatosCliente.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
                rowDatosCliente.rnc = Convert.ToString(row.Cells["rnc"].Value);
                rowDatosCliente.telsup = Convert.ToString(row.Cells["tel_sup"].Value);
                facturacion1.DatosPagos.AddDatosPagosRow(rowDatosCliente);
            }
            return facturacion1;
        }

        private void pagos_Load(object sender, EventArgs e)
        {
            codcli.Focus();
            codigo_mayor();
            tipo.SelectedIndex = 0;
            codcli.Select();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

            string cmd = "SELECT CONVERT (char(10), fecreg, 103) as fecreg,numreg,floor(round(balreg,0)) as balreg,floor(round(totreg,0)) as totreg,cod_sup from cxpdbfregistros where cod_sup='" + codcli.Text + "' order by fecreg";

            DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
            int ry = ds.Tables[0].Rows.Count;
            if (ds.Tables[0].Rows.Count <= 0 && codcli.Text != "")
            {
                MetroMessageBox.Show(this, "Este Suplidor no tiene facturas pendientes", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codcli.Text = "";
                nomcli.Text = "";
                rnccli.Text = "";
                codcli.Select();

                return;
            }
        }

        private void pagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void data_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            double desc = 0, totales = 0;
            double sl = 0; double s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0;
            foreach (DataGridViewRow row in data.Rows)
            {
                s2 += Convert.ToDouble(row.Cells[6].Value);

                s3 += Convert.ToDouble(row.Cells[5].Value);
                s4 += Convert.ToDouble(row.Cells[3].Value);
                s5 += Convert.ToDouble(row.Cells[4].Value);
                s6 = s3 + s4 + s5;
                totales = s2 - s6;
                des.Text = Convert.ToString(s6);
                tcob.Text = Convert.ToString(s2);

                desc = s2 - s4;
                if (s4 > s2)
                {
                    MetroMessageBox.Show(this, "Descuento Incorrecto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.CurrentRow.Cells["descuento"].Value = 0;
                    return;
                }
                else
                {
                    neto.Text = Convert.ToString(totales);
                }
            }

        }

        private void data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //data.CurrentRow.Cells["balance"].ReadOnly.Equals(true);
            DataGridViewRow row;
            DataGridViewCheckBoxCell cellSelecion;
            string l = "";
            int ll7 = 0; float num48; decimal g = 0; double s = 0; double p = 0;

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


            if (data.Rows.Count > 0 && Convert.ToDouble(data.CurrentRow.Cells["aplicar"].Value) > 0)
            {
                data.CurrentRow.Cells["val"].Value = 1;
                for (int b = 0; b < 5; b++)
                {

                }

                string h = l;
                data.CurrentRow.Cells["aplicar"].Value = h;

            }
        }

        private void busca_data()
        {
            query = " select * from view_pagos where numpag='" + cob + "'";
            DataSet ds1 = new DataSet();
            ds1 = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds1.Tables[0];

        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            string reg = Convert.ToString(cobro.Text);
            query = "SELECT   su.nom_sup, su.rnc, su.tel_sup, cre.numreg, cre.fecreg, cre.totitb, cre.totreg, cre.ncfreg, cre.ncffac, cre.tipreg, cre.estado, cre.cod_sup FROM  dbo.cxpdbfdebcre AS cre INNER JOIN dbo.suplidor AS su ON su.cod_sup = cre.cod_sup where numreg='" + reg + "'";
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
            if (string.IsNullOrEmpty(tipo.Text.Trim()))
            {
                MetroMessageBox.Show(this, "especifique el tipo de pago", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tipo.Select();
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
                busca_data();

                dtcompra datos = GenerarFactura();
                cxp2.reportes.pago_fact frm = new cxp2.reportes.pago_fact(datos);
                frm.Show();
                codigo_mayor();
                nuevos();
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codcli.Select();
            codigo_mayor();
        }

        private void codcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void pagos_KeyUp(object sender, KeyEventArgs e)
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
