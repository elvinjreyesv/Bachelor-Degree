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

namespace Proyecto_3.inv.consultas_fact
{
    public partial class consulta_factura : MetroForm
    {
        public consulta_factura()
        {
            InitializeComponent();
        }

        CultureInfo us = new CultureInfo("en-US");
        bool fechai1 = false;
        bool fechaf1 = false;
        string ord = "";
        string query = "";
        string condic = "";
        string valf = "";
       
        int f;

        private void busca_cli()
        {
            proceso.titulo = "Clientes";

            proceso.query = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1";
            proceso.query_cod = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli";
            proceso.query_desc = "select cli.cod_cli as 'Codigo',per.nombre+' '+per.apellido as 'Nombre' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and per.nombre+''+per.apellido ";
            proceso.query2 = "select per.rnc as 'RNC',per.correo as 'Correo',per.telefono as 'Teléfono',per.celular as 'Celular',per.direccion as 'Dirección' from cliente as cli inner join persona as per on cli.cod_persona=per.cod_persona where estado=1 and cli.cod_cli= ";
        }

        public void ejecutar_cli(string dato)
        {
            codcli.Text = dato;
            valida_cliente();
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

        private void condicion_rep()
        {
            DataSet ds = new DataSet();
            if (fechai1 == true)
            {
                condic = condic + " And FecFac >= '" + fechai.Text + "'";
            }

            if (fechaf1 == true)
            {
                condic = condic + " And FecFac <= '" + fechaf.Text + "'";
            }

            if (codcli.Text.Trim() != "")
            {
                condic = condic + " And codcli = '" + codcli.Text + "'";
            }

            if (condicion.Text == "Crédito")
                condic = condic + " And cod_tip= '" + 1 + "'";
            if (condicion.Text == "Contado")
                condic = condic + " And cod_tip= '" + 0 + "'";

            if (nulas.Checked == false)
                condic = condic + " And estado= '" + 1 + "'";

            if (condic != "")
                condic = "where codcli>0 " + condic;

           

           /* query = " select numfac,ncf,fecfac,cliente+' ['+ltrim(str( codcli))+']' as cliente,tipo,totfac from facturascio " + condic + " GROUP BY numfac, fecfac, codcli, ncf, tipo, totfac,cliente ORDER BY numfac";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data.DataSource = ds.Tables[0];
            f = data.Rows.Count - 1;
            condic = "";*/
          
        }

        private void insertar_data2()
        {
            condicion_rep();
            string cadenaconexion = @"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;";
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            comando.CommandText = " select numfac,ncf,CONVERT (char(10), fecfac, 103) as fecfac,cliente+' ['+ltrim(str( codcli))+']' as cliente,estado,tipo,totfac,cliente,estado from facturascio " + condic + " GROUP BY numfac, fecfac, codcli, ncf, tipo, totfac,cliente,estado ORDER BY numfac";
            comando.CommandType = CommandType.Text;
            con.Open();
            data.Rows.Clear();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
 int renglon = data.Rows.Add();

 bool est = (bool)dr["estado"];
 if (est == false)
     data.Rows[renglon].DefaultCellStyle.BackColor = Color.Gainsboro;

 data.Rows[renglon].Cells["factura"].Value = dr.GetInt32(dr.GetOrdinal("numfac")).ToString();
 data.Rows[renglon].Cells["ncf"].Value = dr.GetString(dr.GetOrdinal("ncf")).ToString();
 data.Rows[renglon].Cells["fecha"].Value = dr.GetString(dr.GetOrdinal("fecfac")).ToString();
 data.Rows[renglon].Cells["cliente"].Value = dr.GetString(dr.GetOrdinal("cliente")).ToString();
 data.Rows[renglon].Cells["condi"].Value = dr.GetString(dr.GetOrdinal("tipo")).ToString();


                string elvin = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("totfac"))).ToString();
                double s = Convert.ToDouble(elvin);
                string ll2 = s.ToString("0.00", us);
                data.Rows[renglon].Cells["monto"].Value = ll2;
               
                condic = "";
            }
           
            con.Close();
        }

        private void condicion_busqueda()
        {
            DataSet ds = new DataSet();
            valf = Convert.ToString(data.CurrentRow.Cells["factura"].Value);

            //con_mano   con_factura
            query = "select * from con_mano where numfac='" + valf + "'";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data1.DataSource = ds.Tables[0];
            f = data1.Rows.Count - 1;

            query = "select * from  con_factura where numfac='" + valf + "'";
            ds = utilidades.UTILIDADES.ejecutar(query);
            data2.DataSource = ds.Tables[0];

           valf = "";
        }

        private dtcompra GenerarFactura()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in data1.Rows)
            {
                dtcompra.DatosManoRow rowDatosCliente = facturacion.DatosMano.NewDatosManoRow();
                rowDatosCliente.cantidad = Convert.ToString(row.Cells["cantidad"].Value);
                rowDatosCliente.cod_man = Convert.ToString(row.Cells["cod_man"].Value);
                rowDatosCliente.descripcion = Convert.ToString(row.Cells["descripcion"].Value);
                rowDatosCliente.importe = Convert.ToDouble(row.Cells["importe"].Value);
                rowDatosCliente.precio = Convert.ToDouble(row.Cells["precio"].Value);
                facturacion.DatosMano.AddDatosManoRow(rowDatosCliente);
            }
            return facturacion;
        }

        private dtcompra GenerarFactura1()
        {
            dtcompra facturacion = new dtcompra();
            foreach (DataGridViewRow row in data2.Rows)
            {
          dtcompra.DatosFacturaRow rowDatosCliente = facturacion.DatosFactura.NewDatosFacturaRow();
                rowDatosCliente.descripcion = Convert.ToString(row.Cells["descripcion"].Value);
                rowDatosCliente.numfac = Convert.ToString(row.Cells["numfac"].Value);
                rowDatosCliente.fecfac = Convert.ToString(row.Cells["fecfac"].Value);
                rowDatosCliente.totdes = Convert.ToDouble(row.Cells["totdes"].Value);
                rowDatosCliente.totitb = Convert.ToDouble(row.Cells["totitb"].Value);
                rowDatosCliente.subtot = Convert.ToDouble(row.Cells["subtot"].Value);
                rowDatosCliente.estado = Convert.ToString(row.Cells["estado"].Value);
                rowDatosCliente.ncf = Convert.ToString(row.Cells["ncf"].Value);
                rowDatosCliente.tipo = Convert.ToString(row.Cells["tipo"].Value);
                rowDatosCliente.vehiculo = Convert.ToString(row.Cells["vehiculo"].Value);
                rowDatosCliente.nombre = Convert.ToString(row.Cells["nombre"].Value);
                rowDatosCliente.canven = Convert.ToString(row.Cells["canven"].Value);
                rowDatosCliente.codpro = Convert.ToString(row.Cells["codpro"].Value);
                rowDatosCliente.importe = Convert.ToDouble(row.Cells["importe"].Value);
                rowDatosCliente.preven = Convert.ToDouble(row.Cells["preven"].Value);
                rowDatosCliente.totfac = Convert.ToDouble(row.Cells["totfac"].Value);
                facturacion.DatosFactura.AddDatosFacturaRow(rowDatosCliente);
            }
            return facturacion;
        }

        private void consulta_factura_Load(object sender, EventArgs e)
        {
            condicion.SelectedIndex = 0;
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codcli.Text = "";
            nomcli.Text = "";
            data.Rows.Clear();
            fechai.Text = "";
            fechaf.Text = "";
            nulas.Checked = false;
            condicion.SelectedIndex = 0;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca_cli();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_cli);
            form2.ShowDialog();
        }

        private void codcli_Validating(object sender, CancelEventArgs e)
        {
            valida_cliente();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consulta_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void fechai_ValueChanged(object sender, EventArgs e)
        {
            fechai1 = true;
        }

        private void fechaf_ValueChanged(object sender, EventArgs e)
        {
            fechaf1 = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            insertar_data2();
            f = data.Rows.Count;
            if (f <= 0)
            {
                MetroMessageBox.Show(this, "No hay datos en los límites", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void data_GridColorChanged(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            /*condicion_busqueda();

            dtcompra datos1 = GenerarFactura1();
          dtcompra datos = GenerarFactura();
            repconfact frm = new repconfact(datos,datos1);
            frm.Show();*/
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
