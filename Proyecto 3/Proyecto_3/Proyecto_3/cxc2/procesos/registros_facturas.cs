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

namespace Proyecto_3.cxc2.procesos
{
    public partial class registros_facturas : MetroForm
    {
        string numfac1 = ""; string h = "";
        string num1 = "";
        public registros_facturas()
        {
            InitializeComponent();
        }

        private void valida_cliente()
        {
            DataSet ds = new DataSet();
            string cmd = "select sum(cx.balreg) as balance,per.nombre+' '+per.apellido as nombre, per.correo, per.telefono as telefono, per.celular as celular,per.direccion as direccion,per.rnc as rnc from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona inner join cxcdbfregistros as cx on cx.codcli=cli.cod_cli where cli.cod_cli='" + codcli.Text.Trim() + "' group by per.nombre,per.apellido, per.correo, per.telefono, per.celular,per.direccion,per.rnc";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nomcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                rnccli.Text = Convert.ToString(ds.Tables[0].Rows[0]["rnc"]);
                balcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["balance"]);
            }
            else
            {
                codcli.Text = "";
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
            string cmdd = "select MAX(registro)+1 as mayor from cxcdbfregfac";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["mayor"].ToString();
            cobro.Text = numfac;
            codcli.Select();
        }

        private void codigo_mayor1()
        {
            string cmdd = "select MAX(numreg)+1 as mayor from cxcdbfregistros";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            numfac1 = ds.Tables[0].Rows[0]["mayor"].ToString();
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
        }

        private void save()
        {
            int val = 0;
            string ref1="";
            //registro,codcli,fecha,monto,observacion,referencia,concepto
            string cmd = "act_cxcdbfregfac '" + cobro.Text + "','" +codcli.Text + "','" + feccob.Text + "','" + monto.Text + "','" + observacion.Text + "','" + refcob.Text + "','" + concepto.Text + "'";
            utilidades.UTILIDADES.ejecutar(cmd);


            string cmds = "act_cxcdbfregistros '" + numfac1 + "','" + feccob.Text + "','" + ref1 + "','" + codcli.Text + "','" + 1 + "','" + monto.Text + "','" + monto.Text + "','" + val + "','" + "01/01/1900" + "','" + ncf.Text + "','" + 1 + "','" + "01/01/1900" + "','" + " " + "','" + 0 + "','" + cobro.Text + "'";
            utilidades.UTILIDADES.ejecutar(cmds);
            string ncf2 = "update ncf set ultimo='" + num1+ "' where numero='" + h + "'";
            utilidades.UTILIDADES.ejecutar(ncf2);

    string jk = "update cxcdbfregistros set reg='" + cobro.Text + "' where numreg='" + numfac1 + "'";
            utilidades.UTILIDADES.ejecutar(jk);
            condicion_rep();
            nuevos();
        }

      /*  private dtcompra GenerarFactura()
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
                rowDatosCliente.numfac = Convert.ToString(row.Cells["numfac"].Value);
                rowDatosCliente.moncob = Convert.ToDouble(row.Cells["moncob"].Value);
                rowDatosCliente.mondes = Convert.ToDouble(row.Cells["mondes"].Value);
                rowDatosCliente.codcli = Convert.ToString(row.Cells["cod_cli"].Value);
                rowDatosCliente.balreg = Convert.ToDouble(row.Cells["balreg"].Value);
                rowDatosCliente.direccion = Convert.ToString(row.Cells["direccion"].Value);
                rowDatosCliente.telefono = Convert.ToString(row.Cells["telefono"].Value);
                facturacion1.DatosCobro.AddDatosCobroRow(rowDatosCliente);
            }
            return facturacion1;
      }*/

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            string reg = Convert.ToString(cobro.Text);
         string   query = "select c.registro,c.fecha,c.monto,c.referencia,c.concepto,c.codcli,s.nom_sup,s.rnc,s.cod_sup,s.tel_sup from cxpdbfregfac as c inner join cxpdbfregistros  as r on r.reg=c.registro inner join suplidor as s on s.cod_sup=c.codcli where c.registro='" + reg + "'";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds.Tables[0];
            int f = data1.Rows.Count - 1;
        }

        private void devoluciones_ventas_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            codigo_mayor1();
      
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codcli_Validated(object sender, EventArgs e)
        {

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

        private void registros_facturas_KeyPress(object sender, KeyPressEventArgs e)
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
                cxc2.reportes.repregistros_F frm = new cxc2.reportes.repregistros_F(datos);
                frm.Show();*/
                codigo_mayor();
            }
        }

        private void nc_CheckedChanged(object sender, EventArgs e)
        {
          /*  if (nc.Checked == true)
            {
                string notac = "02";
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
            }*/
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
            ncf_reg form2 = new ncf_reg();
           form2.pasado += new ncf_reg.pasar(ejecutar);
            form2.ShowDialog();
          
        }

        private void registros_facturas_KeyUp(object sender, KeyEventArgs e)
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
