using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Proyecto_3.cxp2.procesos
{
    public partial class registros_fact : MetroForm
    {
        public registros_fact()
        {
            InitializeComponent();
        }

        string numfac1 = ""; string num1 = ""; string h = ""; string query = "";

        private void valida_cliente()
        {
            DataSet ds = new DataSet();

            string cmd = "select sup.cod_sup ,sup.nom_sup ,sup.rnc,sup.tel_sup from suplidor as sup where sup.cod_sup='" + codcli.Text.Trim() + "'group by sup.cod_sup ,sup.nom_sup ,sup.rnc,sup.tel_sup";
            
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nomcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nom_sup"]);
                rnccli.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
            }

            string cmd1 = "select SUM(balreg) as balance from cxpdbfregistros where cod_sup='" + codcli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd1);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                balcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["balance"]);
            }

            refcob.Select();
        }

        public void ejecutar_cli(string dato)
        {
            codcli.Text = dato;
            valida_cliente();
        }

        private void codigo_mayor()
        {
            string cmdd = "select MAX(registro)+1 as mayor from cxpdbfregfac";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["mayor"].ToString();
            cobro.Text = numfac;
            codcli.Select();
        }

        private void codigo_mayor1()
        {
            string cmdd = "select MAX(numreg)+1 as mayor from cxpdbfregistros";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            numfac1 = ds.Tables[0].Rows[0]["mayor"].ToString();
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
            balcli.Text = "";
            nomcli.Text = "";
            rnccli.Text = "";
            refcob.Text = "";
            observacion.Text = "";
            concepto.Text = "";
           monto.Text = "";
           feccob.Text = "";
           ncf.Text = "";
           codigo_mayor();
           nc.Checked = false;
        }

        private void save()
        {
            int val = 0;
            string ref1 = "";
            //registro,codcli,fecha,monto,observacion,referencia,concepto
            string cmd = "act_cxpdbfregfac '" + cobro.Text + "','" + codcli.Text + "','" + feccob.Text + "','" + monto.Text + "','" + observacion.Text + "','" + refcob.Text + "','" + concepto.Text + "'";
            utilidades.UTILIDADES.ejecutar(cmd);


            string cmds = "act_cxpdbfregistros '" + numfac1 + "','" + feccob.Text + "','" + ref1 + "','" + codcli.Text + "','" + 1 + "','" + monto.Text + "','" + monto.Text + "','" + val + "','" + "01/01/1900" + "','" + ncf.Text + "','" + 1 + "','" + "01/01/1900" + "','" + " " + "','" + 0 + "','" + cobro.Text + "'";
            utilidades.UTILIDADES.ejecutar(cmds);


            string ncf2 = "update ncf set ultimo='" + num1 + "' where numero='" + h + "'";
            utilidades.UTILIDADES.ejecutar(ncf2);

   string jk = "update cxpdbfregistros set reg='" + cobro.Text + "' where numreg='" + numfac1 + "'";
            utilidades.UTILIDADES.ejecutar(jk);

            condicion_rep();
            nuevos();
        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            string reg = Convert.ToString(cobro.Text);
            query = "select c.registro,c.fecha,c.monto,c.referencia,c.concepto,c.codcli,s.nom_sup,s.rnc,s.cod_sup,s.tel_sup from cxpdbfregfac as c inner join cxpdbfregistros  as r on r.reg=c.registro inner join suplidor as s on s.cod_sup=c.codcli where c.registro='" + reg + "'";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds.Tables[0];
            int f = data1.Rows.Count - 1;
            query = "";
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion1 = new dtcompra();
            foreach (DataGridViewRow row in data1.Rows)
            {
     dtcompra.DatosRegcxpRow rowDatosCliente = facturacion1.DatosRegcxp.NewDatosRegcxpRow();
                rowDatosCliente.registro = Convert.ToString(row.Cells["registro"].Value);
                rowDatosCliente.fecha = Convert.ToDateTime(row.Cells["fecha"].Value);
                rowDatosCliente.monto = Convert.ToDouble(row.Cells["monto"].Value);
                rowDatosCliente.referencia = Convert.ToString(row.Cells["referencia"].Value);
                rowDatosCliente.concepto = Convert.ToString(row.Cells["concepto"].Value);
                rowDatosCliente.codcli = Convert.ToString(row.Cells["codcli"].Value);
                rowDatosCliente.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
                rowDatosCliente.rnc = Convert.ToString(row.Cells["rnc"].Value);
                rowDatosCliente.cod_sup = Convert.ToString(row.Cells["cod_sup"].Value);
                rowDatosCliente.tel_sup = Convert.ToString(row.Cells["tel_sup"].Value);
                facturacion1.DatosRegcxp.AddDatosRegcxpRow(rowDatosCliente);
            }
            return facturacion1;
        }

        private void registros_fact_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            codigo_mayor1();
        }

        private void codcli_Validating(object sender, CancelEventArgs e)
        {
            valida_cliente();
        }

        private void codcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            busca1();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_cli);
            form2.ShowDialog();
        }

        private void registros_fact_KeyUp(object sender, KeyEventArgs e)
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

        private void registros_fact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (monto.Text.Contains('.'))
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

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codcli.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Cliente no Válido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codcli.Select();
                return;
            }
            if (string.IsNullOrEmpty(monto.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Monto no Valido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                monto.Select();
                return;
            }
            if (string.IsNullOrEmpty(concepto.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Debe especificar el conceptoValores no Válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                concepto.Select();
                return;
            }
            else
            {
                save();

             /*   dtcompra datos = GenerarFactura();
                prueb32 frm = new prueb32(datos);
                frm.Show();*/

                codigo_mayor();
            }
        }

        public void ejecutar2(string dato)
        {
            h = dato;
            string cmdd = "select descrip from ncf_general where numero='" + dato + "'";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string num = ds.Tables[0].Rows[0]["descrip"].ToString();

            string ncf1 = "select ultimo+1 as mayor from ncf where numero='" + dato + "'";
            ds = utilidades.UTILIDADES.ejecutar(ncf1);
            num1 = ds.Tables[0].Rows[0]["mayor"].ToString();

            string com = num;
            int op = 19 - com.Length;
            string elvin = num + num1.PadLeft(op, '0');
            ncf.Text = elvin;
        }

        public void ejecutar(string dato)
        {
            h = dato;
            string cmdd = "select descrip from ncf_general where numero='" + dato + "'";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string num = ds.Tables[0].Rows[0]["descrip"].ToString();

            string ncf1 = "select ultimo+1 as mayor from ncf where numero='" + dato + "'";
            ds = utilidades.UTILIDADES.ejecutar(ncf1);
            num1 = ds.Tables[0].Rows[0]["mayor"].ToString();

            string com = num;
            int op = 19 - com.Length;
            string elvin = num + num1.PadLeft(op, '0');
            ncf.Text = elvin;
        }

        private void nc_Click(object sender, EventArgs e)
        {
            ncf_reg2 form3 = new ncf_reg2();
            form3.pasado += new ncf_reg2.pasar(ejecutar2);
            form3.ShowDialog();
        }

        private void nc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
