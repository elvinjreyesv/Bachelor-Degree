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

namespace Proyecto_3.cxc2.reportes
{
    public partial class rep_recibo_ing : MetroForm
    {
        public rep_recibo_ing()
        {
            InitializeComponent();
        }

        string condi = "";
        bool fechai1 = false;
        bool fechaf1 = false;
        string ord = "";
        string query = "";
        int f;

        private void nuevos()
        {
            nomcli.Text = "";
            condicion.Text = "";
        }

        private void busca_cli()
        {
            proceso.titulo = "Clientes";

            proceso.query = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1";
            proceso.query_cod = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli";
            proceso.query_desc = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and per.nombre+''+per.apellido ";
            proceso.query2 = "select per.rnc as 'RNC',per.correo as 'Correo',per.telefono as 'Teléfono',per.celular as 'Celular',per.direccion as 'Dirección' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli= ";
        }

        private void valida_cliente()
        {

            DataSet ds = new DataSet();
            string cmd = "select per.nombre+' '+per.apellido as nombre,per.telefono,per.cedula,cli.ncf from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where cli.cod_cli='" + codcli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nomcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
            }
            else
            {
                codcli.Text = "";
                nomcli.Text = "";
            }
        }

        private void detalle_ventas_Load(object sender, EventArgs e)
        {
            condicion.SelectedIndex = 0;
            estado.SelectedIndex = 0;
            formato.SelectedIndex = 0;
            ordenado.SelectedIndex = 0;

        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            if (fechai1 == true)
            {
                condi = condi + " And Feccob >= '" + fechai.Text + "'";
            }

            if (fechaf1 == true)
            {
                condi = condi + " And Feccob <= '" + fechaf.Text + "'";
            }

            if (codcli.Text.Trim() != "")
            {
                condi = condi + " And cod_cli = '" + codcli.Text + "'";
            }

            //---------------------------------------------------
            if (estado.Text == "Activos")
                condi = condi + " And estado= '" + 1 + "'";
            if (estado.Text == "Cancelados")
                condi = condi + " And estado= '" + 0 + "'";
            //-------------------------------------------------------

            if (condi != "")
                condi = "where cod_cli>0 " + condi;

            if (ordenado.Text == "#Cobro")
                ord = "numcob";
            if (ordenado.Text == "Fecha")
                ord = "feccob";
            if (ordenado.Text == "#Cliente")
                ord = "cod_cli";

            query = " select * from registro_ing " + condi + " GROUP BY numcob,feccob,totcob,moneda,nombre,cod_cli,rnc,direccion  order by  " + ord + "";


            ds = utilidades.UTILIDADES.ejecutar(query);
            datos.DataSource = ds.Tables[0];
            f = datos.Rows.Count;
            condi = "";
        }

        public void ejecutar_cli(string dato)
        {
            codcli.Text = dato;
            valida_cliente();
        }

        private void rep_recibo_ing_Load(object sender, EventArgs e)
        {
            condicion.SelectedIndex = 0;
            estado.SelectedIndex = 0;
            formato.SelectedIndex = 0;
            ordenado.SelectedIndex = 0;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fechai_ValueChanged(object sender, EventArgs e)
        {
            fechai1 = true;
        }

        private void fechaf_ValueChanged(object sender, EventArgs e)
        {
            fechaf1 = true;
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in datos.Rows)
            {
                dtcompra.vistarecibosRow rowDatosCliente = facturacion.vistarecibos.NewvistarecibosRow();
                rowDatosCliente.numcob = Convert.ToString(row.Cells["numcob"].Value);
                rowDatosCliente.feccob = Convert.ToDateTime(row.Cells["feccob"].Value);
                rowDatosCliente.totcob = Convert.ToDouble(row.Cells["totcob"].Value);
                rowDatosCliente.moneda = Convert.ToString(row.Cells["moneda"].Value);
                rowDatosCliente.nombre = Convert.ToString(row.Cells["nombre"].Value);
                rowDatosCliente.cod_cli = Convert.ToString(row.Cells["cod_cli"].Value);
                rowDatosCliente.rnc = Convert.ToString(row.Cells["rnc"].Value);
                rowDatosCliente.direccion = Convert.ToString(row.Cells["direccion"].Value);

                facturacion.vistarecibos.AddvistarecibosRow(rowDatosCliente);
            }
            return facturacion;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            condicion_rep();

            if (f <= 0)
            {
                MetroMessageBox.Show(this, "No hay datos en los límites", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                    dtcompra datos = GenerarFactura();
                    cxc2.reportes.uno frm = new cxc2.reportes.uno(datos);
                    frm.Show();
            }
        }

        private void codcli_Validated(object sender, EventArgs e)
        {

        }

        private void codcli_Validating(object sender, CancelEventArgs e)
        {
            valida_cliente();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            
            busca_cli();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_cli);
            form2.ShowDialog();
        }
    }
}
