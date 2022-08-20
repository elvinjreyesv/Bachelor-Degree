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
    public partial class repnotdebcrecxp : MetroForm
    {
        public repnotdebcrecxp()
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
                condi = condi + " And Fecreg >= '" + fechai.Text + "'";
            }

            if (fechaf1 == true)
            {
                condi = condi + " And Fecreg <= '" + fechaf.Text + "'";
            }

            if (codcli.Text.Trim() != "")
            {
                condi = condi + " And cod_sup = '" + codcli.Text + "'";
            }

            //**************************************

            //---------------------------------------------------
            if (tipo.Text == "Credito")
                condi = condi + " And tipreg= '" + 1 + "'";
            if (tipo.Text == "Debito")
                condi = condi + " And tipreg= '" + 0 + "'";

            //---------------------------------------------------
            if (estado.Text == "Activos")
                condi = condi + " And estado= '" + 1 + "'";
            if (estado.Text == "Cancelados")
                condi = condi + " And estado= '" + 0 + "'";
            //Noas Credito
            //---------------------------------------------------

            if (condi != "")
                condi = "where cod_sup>0 " + condi;

            if (ordenado.Text == "#Registro")
                ord = "numreg";
            if (ordenado.Text == "Fecha")
                ord = "fecreg";
            if (ordenado.Text == "#Suplidor")
                ord = "cod_sup";

            query = " select numreg,numcom,totitb,totreg,ncfreg,fecreg,tipreg,nom_sup,cod_sup,dir_sup from view_cxpdebcre " + condi + " GROUP BY numreg,numcom,totitb,totreg,ncfreg,fecreg,tipreg,nom_sup,cod_sup,dir_sup  order by  " + ord + "";

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
                dtcompra.vistanotacxpRow rowDatosCliente = facturacion.vistanotacxp.NewvistanotacxpRow();
                rowDatosCliente.numreg = Convert.ToString(row.Cells["numreg"].Value);
                rowDatosCliente.numcom = Convert.ToString(row.Cells["numcom"].Value);
                rowDatosCliente.totitb = Convert.ToDouble(row.Cells["totitb"].Value);
                rowDatosCliente.totreg = Convert.ToDouble(row.Cells["totreg"].Value);
                rowDatosCliente.ncfreg = Convert.ToString(row.Cells["ncfreg"].Value);
                rowDatosCliente.fecreg = Convert.ToDateTime(row.Cells["fecreg"].Value);
                rowDatosCliente.dir_sup = Convert.ToString(row.Cells["dir_sup"].Value);
                rowDatosCliente.tipreg = Convert.ToString(row.Cells["tipreg"].Value);
                rowDatosCliente.nom_sup = Convert.ToString(row.Cells["nom_sup"].Value);
                rowDatosCliente.cod_sup = Convert.ToString(row.Cells["cod_sup"].Value);
                rowDatosCliente.dir_sup = Convert.ToString(row.Cells["dir_sup"].Value);
                facturacion.vistanotacxp.AddvistanotacxpRow(rowDatosCliente);
            }
            return facturacion;
        }

        private void repnotdebcrecxp_Load(object sender, EventArgs e)
        {

        }
    }
}
