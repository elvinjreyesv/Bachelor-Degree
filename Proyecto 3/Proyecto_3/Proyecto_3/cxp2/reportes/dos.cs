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

namespace Proyecto_3.cxp2.reportes
{
    public partial class dos : MetroForm
    {
        public dos()
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

        }

        private void busca_cli()
        {
            proceso.titulo = "Suplidores";

            proceso.query = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1";
            proceso.query_cod = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1 and cod_sup";
            proceso.query_desc = "select cod_sup as 'Codigo',nom_sup as 'Nombre' from suplidor where estado=1 and nom_sup ";
            proceso.query2 = " select cod_sup as 'Codigo',nom_sup as 'Suplidor',nom_rep as 'Representante',rnc as 'RNC',correo as 'Correo' from suplidor where estado=1 and cod_sup= ";
        }

        private void valida_cliente()
        {

            DataSet ds = new DataSet();
            string cmd = "select cod_sup ,nom_sup ,rnc,tel_sup from suplidor where cod_sup='" + codcli.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nomcli.Text = Convert.ToString(ds.Tables[0].Rows[0]["nom_sup"]);
            }
            else
            {
                codcli.Text = "";
                nomcli.Text = "";
            }
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
                condi = condi + " And cod_sup = '" + codcli.Text + "'";
            }

            //---------------------------------------------------

            if (condi != "")
                condi = "where cod_sup>0 " + condi;

            if (ordenado.Text == "#Pago")
                ord = "numpag";
            if (ordenado.Text == "Fecha")
                ord = "fecha";
            if (ordenado.Text == "#Suplidor")
                ord = "cod_sup";

            query = " select numpag,feccob,cod_sup,estado,tipo_pago,observacion,nom_sup,dir_sup,tel_sup,totcob from pag " + condi + " GROUP BY numpag,feccob,cod_sup,estado,tipo_pago,observacion,nom_sup,dir_sup,tel_sup,totcob  order by  " + ord + "";


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

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in datos.Rows)
            {
                dtcompra.vistapagosfactRow rowDatosCliente = facturacion.vistapagosfact.NewvistapagosfactRow();
                rowDatosCliente.numpag = Convert.ToString(row.Cells["numpag"].Value);
                rowDatosCliente.feccob = Convert.ToDateTime(row.Cells["feccob"].Value);
                rowDatosCliente.cod_sup = Convert.ToString(row.Cells["cod_sup"].Value);
                rowDatosCliente.estado = Convert.ToString(row.Cells["estado"].Value);
                rowDatosCliente.tipo_pago = Convert.ToString(row.Cells["tipo_pago"].Value);
                rowDatosCliente.observacion = Convert.ToString(row.Cells["observacion"].Value);
                rowDatosCliente.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
                rowDatosCliente.dir_sup = Convert.ToString(row.Cells["dir_sup"].Value);
                rowDatosCliente.tel_sup = Convert.ToString(row.Cells["tel_sup"].Value);
                rowDatosCliente.totcob = Convert.ToDouble(row.Cells["totcob"].Value);
                facturacion.vistapagosfact.AddvistapagosfactRow(rowDatosCliente);
            }
            return facturacion;
        }

        private void dos_Load(object sender, EventArgs e)
        {
            formato.SelectedIndex = 0;
            ordenado.SelectedIndex = 0;
        }

        private void fechai_ValueChanged(object sender, EventArgs e)
        {
            fechai1 = true;
        }

        private void fechaf_ValueChanged(object sender, EventArgs e)
        {
            fechaf1 = true;
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
                cxp2.reportes.report_pagos frm = new cxp2.reportes.report_pagos(datos);
                frm.Show();
            }
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

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
