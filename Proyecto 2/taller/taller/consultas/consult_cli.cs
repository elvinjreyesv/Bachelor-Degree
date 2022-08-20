using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.consultas
{
    public partial class consult_cli : Form
    {
        public consult_cli()
        {
            InitializeComponent();
        }

        private void consult_cli_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.rnc,cliente.ncf from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero"; //cliente.ncf
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            consultar.DataSource = ds.Tables[0];
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(rte.Text.Trim()))
            {
                string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.rnc,cliente.ncf from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero"; //,cliente.ncf
                cmd += " where tercero.nombre + ' ' + cliente.apellido  like ('%" + rte.Text.Trim() + "%')";

                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                consultar.DataSource = ds.Tables[0];
                buscar.Text = "";
                buscar.Focus();
            }

            else

                if (!string.IsNullOrEmpty(codigo.Text.Trim()))
                {
                    string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.rnc,cliente.ncf from cliente inner join tercero on cliente.cod_tercero=tercero.cod_tercero"; //,cliente.ncf
                    cmd += " where cod_cli='"+ codigo.Text.Trim()+ "'";

                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    consultar.DataSource = ds.Tables[0];
                    buscar.Text = "";
                    buscar.Focus();
                }

                else

                    if (!string.IsNullOrEmpty(rnc.Text.Trim()))
                    {
                        string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.rnc,cliente.ncf from cliente inner join tercero on cliente.cod_tercero=tercero.cod_tercero"; //,cliente.ncf
                        cmd += " where rnc='" + rnc.Text.Trim() + "'";

                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        consultar.DataSource = ds.Tables[0];
                        buscar.Text = "";
                        buscar.Focus();
                    }

                    else
                        if (!string.IsNullOrEmpty(rnc.Text.Trim()) && !string.IsNullOrEmpty(codigo.Text.Trim()) && !string.IsNullOrEmpty(rte.Text.Trim()) || string.IsNullOrEmpty(rnc.Text.Trim()) && string.IsNullOrEmpty(codigo.Text.Trim()) && string.IsNullOrEmpty(rte.Text.Trim()))
                    {
                        DataSet ds = new DataSet();
                        string cmd = "select cliente.cod_cli as Codigo_Clinte, tercero.nombre + ' ' + cliente.apellido as Nombre,cliente.ced_cli as Cedula,cliente.correo as Correo,cliente.cel_cli as Celular,cliente.dir_cli as Direccion,cliente.rnc,cliente.ncf from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero"; //cliente.ncf
                        ds = utilidades.UTILIDADES.ejecutar(cmd);
                        consultar.DataSource = ds.Tables[0];
                    }
        }

        private void consultar_DoubleClick(object sender, EventArgs e)
        {
            prcesos.cod_cli = consultar.CurrentRow.Cells[0].Value.ToString();
            prcesos.nombre = consultar.CurrentRow.Cells[1].Value.ToString();
            prcesos.rnc = consultar.CurrentRow.Cells[6].Value.ToString();
            prcesos.ncf = consultar.CurrentRow.Cells[7].Value.ToString();
            prcesos.direccion = consultar.CurrentRow.Cells[5].Value.ToString();
            this.Visible = false;
            Procesos.factura cot = new Procesos.factura();
            cot.Show();
        }

        private void rte_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
