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


namespace Proyecto_3.inv.reportes
{
    public partial class detalle_ventas : MetroForm
    {
        public detalle_ventas()
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
            ncf.SelectedIndex = 0;
            formato.SelectedIndex = 0;
            ordenado.SelectedIndex = 0;
           
        }

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            if(fechai1==true)
             {
                 condi = condi + " And FecFac >= '" + fechai.Text + "'";
             }

            if (fechaf1 == true)
            {
                condi = condi + " And FecFac <= '" + fechaf.Text + "'";
            }

            if (codcli.Text.Trim()!="")
            {
                condi = condi + " And codcli = '" + codcli.Text + "'";
            }

                if (condicion.Text == "Crédito")
                      condi = condi + " And cod_tip= '" + 1 + "'";
                if (condicion.Text == "Contado")
                        condi = condi + " And cod_tip= '" + 0+ "'";
            //---------------------------------------------------
                if (estado.Text == "Activos")
                    condi = condi + " And estado= '" + 1 + "'";
                if (estado.Text == "Cancelados")
                    condi = condi + " And estado= '" + 0 + "'";
            //-------------------------------------------------------
                if (ncf.Text == "Consumidor Final")
                    condi = condi + " And substring(ncf,9,3)= '" + 102 + "'";
                if (ncf.Text == "Crédio Fiscal")
                    condi = condi + " And substring(ncf,9,3)= '" + 101 + "'";
                if (ncf.Text == "Régimen Especial")
                    condi = condi + " And substring(ncf,9,3)= '" + 115 + "'";
                if (ncf.Text == "Gubernamental")
                    condi = condi + " And substring(ncf,9,3)= '" + 114 + "'";

                if (condi != "")
                    condi = "where codcli>0 " + condi;

            if(ordenado.Text=="#Factura")
                ord="numfac";
                  if(ordenado.Text=="Fecha")
                       ord="fecfac";
                        if(ordenado.Text=="#Cliente")
                            ord = "codcli";

                         query = " select * from facturascio " + condi + " GROUP BY numfac, fecfac, totdes, codcli, subtot, ncf, cedula, telefono, celular, cod_tip, tipo, totfac, totitb, estado,  cliente ORDER BY " + ord+"" ;
                         ds = utilidades.UTILIDADES.ejecutar(query);
                         datos.DataSource = ds.Tables[0];
                         f= datos.Rows.Count-1;
                         condi = "";
        }

        public void ejecutar_cli(string dato)
        {
            codcli.Text = dato;
            valida_cliente();
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

        private  dtcompra  GenerarFactura()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in datos.Rows)
            {
  dtcompra.DatosClienteRow rowDatosCliente = facturacion.DatosCliente.NewDatosClienteRow();
                    rowDatosCliente.numfac = Convert.ToString(row.Cells["numfac"].Value);
                    rowDatosCliente.fecfac = Convert.ToString(row.Cells["fecfac"].Value);
                    rowDatosCliente.totdes = Convert.ToDouble(row.Cells["totdes"].Value);
                    rowDatosCliente.codcli = Convert.ToString(row.Cells["codcli"].Value);
                    rowDatosCliente.subtot = Convert.ToDouble(row.Cells["subtot"].Value);
                    rowDatosCliente.ncf = Convert.ToString(row.Cells["ncf"].Value);
                    rowDatosCliente.cliente = Convert.ToString(row.Cells["cliente"].Value);
                    rowDatosCliente.cedula = Convert.ToString(row.Cells["cedula"].Value);
                    rowDatosCliente.telefono = Convert.ToString(row.Cells["telefono"].Value);
                    rowDatosCliente.celular = Convert.ToString(row.Cells["celular"].Value);
                    rowDatosCliente.cod_tip = Convert.ToString(row.Cells["cod_tip"].Value);
                    rowDatosCliente.tipo = Convert.ToString(row.Cells["tipo"].Value);
                    rowDatosCliente.totfac = Convert.ToDouble(row.Cells["totfac"].Value);
                    rowDatosCliente.totitb = Convert.ToDouble(row.Cells["totitb"].Value);
                    rowDatosCliente.estado = Convert.ToString(row.Cells["estado"].Value);
                    facturacion.DatosCliente.AddDatosClienteRow(rowDatosCliente);
            }
         return facturacion;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            condicion_rep();

            if (f <=0) 
                {
                    MetroMessageBox.Show(this, "No hay datos en los límites", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
          
            else
                {

                if (formato.Text == "Listado de Ventas")
                {
                    dtcompra datos = GenerarFactura();
                    prueba frm = new prueba(datos);
                    frm.Show();
                }
                if (formato.Text == "Ventas Por Cliente")
                {
                    dtcompra datos = GenerarFactura();
                    vcli frm = new vcli(datos);
                    frm.Show();
                }

                if (formato.Text == "Ventas Por Día")
                {
                    dtcompra datos = GenerarFactura();
                    vdia frm = new vdia(datos);
                    frm.Show();
                }
              
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
    }
}
