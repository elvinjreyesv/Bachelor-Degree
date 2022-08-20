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
    public partial class notadc : MetroForm
    {
        public notadc()
        {
            InitializeComponent();
        }

        CultureInfo us = new CultureInfo("en-US");
        string p1 = ""; float num41 = 0; string ll1 = ""; string p2 = ""; float num42 = 0; string ll2 = "";
        string p3 = ""; float num43 = 0; string ll3 = ""; int rg = 0;
        string notac;
        double s1; int m = 0; int ry = 0; int d = 0; string cob = "";
        string query = "";
        string num1 = "";
        string con = "";
        DataSet ds = new DataSet();

        private void insertar_data()
        {
            m = 1;
            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = "SELECT CONVERT (char(10), fecreg, 103) as fecreg,CAST ( numreg AS varchar (50)) as numreg,floor(round(balreg,0)) as balreg,floor(round(totreg,0)) as totreg,cod_sup,CONVERT (char(10), fecven, 103) as fecven from cxpdbfregistros where balreg>0 and cod_sup='" + codcli.Text + "' order by fecreg";

            comando.CommandType = CommandType.Text;
            con.Open();
            data.Rows.Clear();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                int renglon = data.Rows.Add();
                data.Rows[renglon].Cells["factura"].Value = dr.GetString(dr.GetOrdinal("numreg")).ToString();

                data.Rows[renglon].Cells["fecha"].Value = dr.GetString(dr.GetOrdinal("fecreg"));
                data.Rows[renglon].Cells["fecven"].Value = dr.GetString(dr.GetOrdinal("fecven"));
                string elvin1 = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("balreg"))).ToString();
                data.Rows[renglon].Cells["pendiente"].Value = elvin1;

                string elvin2 = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("totreg"))).ToString();
                data.Rows[renglon].Cells["monto"].Value = elvin2;
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
                nomcli.Text = "";
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
            string cmdd = "select MAX(numreg)+1 as mayor from cxpdbfdebcre";
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
            subtot.Text = "";
            ncf.Text = "";
            nomcli.Text = "";
            rnccli.Text = "";
            refcob.Text = "";
            observacion.Text = "";
            data.Rows.Clear();
            tcob.Text = "";
            codcli.Select();
        }

        private void save()
        {
            cob = cobro.Text;

            SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            int f;
            string ven = "01 / 01 / 1900";
         
          /*  if (string.IsNullOrEmpty(observacion.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Especifique el concepto de la nota", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                observacion.Select();
                return;
                return;
            }*/
           // else
            {
                try
                {
                    if (Convert.ToInt16(tcob.Text) == 0)
                    {

                        MetroMessageBox.Show(this, "No hay datos para procesar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                    else
                        //numreg,numfac,codcli,refreg,totitb,totreg,ncfreg,ncffac,balcli,estado
                        //----------------------------------detalle del cobro-------------------
                        for (f = 0; f <= data.Rows.Count - 1; f++)
                        {
                            if (Convert.ToInt16(data.Rows[f].Cells[7].Value) == 1)
                            {
                                int tip = 0;
                                if (nd.Checked == true)
                                    tip = 0;
                                else tip = 1;
                                string t = "select ncf from compras where numcom='" + data.Rows[f].Cells[0].Value.ToString() + "'";
                                DataSet ds5 = utilidades.UTILIDADES.ejecutar(t);
                                string ncffac = Convert.ToString(ds5.Tables[0].Rows[0]["ncf"]); ;

                                string cmd = "act_notacxp '" + cobro.Text + "','" + Convert.ToInt16(data.Rows[f].Cells[0].Value) + "','" + codcli.Text + "','" + refcob.Text + "','" + itcob.Text + "','" + Convert.ToInt16(data.Rows[f].Cells[5].Value) + "','" + ncf.Text + "','" + ncffac + "','" + Convert.ToInt16(data.Rows[f].Cells[4].Value) + "','" + 1 + "','" + tip + "','" + feccob.Text + "'";

                                utilidades.UTILIDADES.ejecutar(cmd);

                                int h = 0;
                                string cmd1 = "SELECT floor(round(balreg,0)) as balreg from cxpdbfregistros where numreg='" + data.Rows[f].Cells[0].Value.ToString() + "'";
                                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd1);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    h = Convert.ToInt16(ds.Tables[0].Rows[0]["balreg"]);
                                }

                                int p = 0;
                                if (tip == 0)
                                    p = h - Convert.ToInt16(data.Rows[f].Cells[5].Value.ToString());
                                else
                                    p = h + Convert.ToInt16(data.Rows[f].Cells[5].Value.ToString());

                                cmd1 = "update cxpdbfregistros set balreg='" + p + "' where numreg='" + data.Rows[f].Cells[0].Value.ToString() + "'";
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
        }

        private void devoluciones_compras_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            nd.Checked = true;
        }

        private void nc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            ry = 2;
            this.Close();
        }

        private void notadc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
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
            double sl = 0; double s2 = 0, s3 = 0;
            foreach (DataGridViewRow row in data.Rows)
            {
                string elvin = Convert.ToString(row.Cells[5].Value);
                sl += Convert.ToDouble(row.Cells[5].Value);

                string elvin2 = Convert.ToString(row.Cells[6].Value);
                s2 += Convert.ToDouble(row.Cells[6].Value);
                s3 = sl - s2;
            }
            subtot.Text = Convert.ToString(s3);
            itcob.Text = Convert.ToString(s2);
            tcob.Text = Convert.ToString(sl);
        }

        private void busca_data()
        {
            query = " select * from bal_pagos where numreg='" + cob + "'";
            DataSet ds1 = new DataSet();
            ds1 = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds1.Tables[0];

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codcli.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codcli.Select();
                return;
            }
            if (string.IsNullOrEmpty(ncf.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ncf.Select();
                return;
            }
            if (string.IsNullOrEmpty(observacion.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Especifique el concepto de la nota", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                observacion.Select();
                return;
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
                manoob frm = new manoob(datos);
                frm.Show();

                codigo_mayor();
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codcli.Select();
        }

        private void data_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (data.CurrentCell.ColumnIndex == 5)
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

        private void data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
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
            int df = data.Rows.Count;
            if (df > 0 && Convert.ToInt16(data.CurrentRow.Cells["val"].Value) == 1)
            {

                double y = Convert.ToDouble(data.CurrentRow.Cells["aplicar"].Value);
                int h = Convert.ToInt16(data.CurrentRow.Cells["itbis"].Value);
                if (h > y || h == y)
                {
                    MetroMessageBox.Show(this, "El Itbis no puede ser mayor que 18% de " + y, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.CurrentRow.Cells["itbis"].Value = 0;
                }
            }
            if (data.Rows.Count > 0)
            {
                s = Convert.ToDouble(data.CurrentRow.Cells["aplicar"].Value);
                rg = Convert.ToInt16(data.CurrentRow.Cells["aplicar"].Value);
                l = Convert.ToString(data.CurrentRow.Cells["aplicar"].Value);
            }

            if (data.Rows.Count > 0 && nc.Checked == true)
            {

                double y = Convert.ToDouble(data.CurrentRow.Cells["aplicar"].Value);
                int h = Convert.ToInt16(data.CurrentRow.Cells["pendiente"].Value);
                if (y > h)
                {
                    MetroMessageBox.Show(this, "El monto especificado no es correcto ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.CurrentRow.Cells["aplicar"].Value = data.CurrentRow.Cells["pendiente"].Value;
                    return;
                }
            }


            if (data.Rows.Count > 0) //aqui
            {
                int uy = Convert.ToInt16(data.CurrentRow.Cells["pendiente"].Value);
                p = Convert.ToDouble(data.CurrentRow.Cells["pendiente"].Value);
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
                { }
                string h = l;
                data.CurrentRow.Cells["aplicar"].Value = h;

            }
        }

        private void data_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in data.Rows)
            {
                int df = data.Rows.Count;
                if (!(fila == data.Rows[data.CurrentCell.RowIndex]))
                {
                    fila.Cells[7].Value = false;
                    fila.Cells[5].Value = 0;
                    fila.Cells[6].Value = 0;
                }
            }  
        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            string reg = Convert.ToString(cobro.Text);
            query = "SELECT   su.nom_sup, su.rnc, su.tel_sup, cre.numreg, cre.fecreg, cre.totitb, cre.totreg, cre.ncfreg, cre.ncffac, cre.tipreg, cre.estado, cre.cod_sup FROM  dbo.cxpdbfdebcre AS cre INNER JOIN dbo.suplidor AS su ON su.cod_sup = cre.cod_sup where numreg='" + reg + "'";
            ds = utilidades.UTILIDADES.ejecutar(query);
            datos.DataSource = ds.Tables[0];
            int f = data1.Rows.Count - 1;
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in datos.Rows)
            {
                dtcompra.DatosNotacxpRow rowDatosCliente = facturacion.DatosNotacxp.NewDatosNotacxpRow();
                rowDatosCliente.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
                rowDatosCliente.rnc = Convert.ToString(row.Cells["rnc"].Value);
                rowDatosCliente.tel_sup = Convert.ToString(row.Cells["tel_sup"].Value);
                rowDatosCliente.numreg = Convert.ToString(row.Cells["numreg"].Value);
                rowDatosCliente.fecreg = Convert.ToDateTime(row.Cells["fecreg"].Value);
                rowDatosCliente.totitb = Convert.ToDouble(row.Cells["totitb"].Value);
                rowDatosCliente.totreg = Convert.ToDouble(row.Cells["totreg"].Value);
                rowDatosCliente.ncfreg = Convert.ToString(row.Cells["ncfreg"].Value);
                rowDatosCliente.ncffac = Convert.ToString(row.Cells["ncffac"].Value);
                rowDatosCliente.tipreg = Convert.ToString(row.Cells["tipreg"].Value);
                rowDatosCliente.estado = Convert.ToString(row.Cells["estado"].Value);
                rowDatosCliente.cod_sup = Convert.ToString(row.Cells["cod_sup"].Value);
             
                facturacion.DatosNotacxp.AddDatosNotacxpRow(rowDatosCliente);
            }
            return facturacion;
        }

        private void notadc_KeyUp(object sender, KeyEventArgs e)
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
