using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace repuesto
{
    public partial class consult_cli : Form
    {
        public DataTable consulta = new DataTable();
        public consult_cli()
        {
            
            InitializeComponent();

            consulta.Columns.Add("codigo");
            consulta.Columns.Add("nombre");
            consulta.Columns.Add("cedula");
            consulta.Columns.Add("ncf");
            consulta.Columns.Add("correo");
            consulta.Columns.Add("celular");

            consultar.AutoGenerateColumns = false;
            consultar.Columns[0].DataPropertyName = "codigo";
            consultar.Columns[1].DataPropertyName = "nombre";
            consultar.Columns[2].DataPropertyName = "cedula";
            consultar.Columns[3].DataPropertyName = "ncf";
            consultar.Columns[4].DataPropertyName = "correo";
            consultar.Columns[4].DataPropertyName = "celular";
            consultar.DataSource = consulta;
        }

        private void consult_cli_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select cod_cli as Codigo, apellido as Nombre, cedula as Cedula,ncf as NCF, correo as Correo, cel as Celular, cod_ter from cliente";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            consultar.DataSource = ds.Tables[0];
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string cmd = "select cod_cli as Codigo, apellido as Nombre, cedula as Cedula,ncf as NCF, correo as Correo, cel as Celular from cliente";
            cmd += " where apellido like ('%" + rte.Text.Trim() + "%')";
           
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
            consultar.DataSource = ds.Tables[0];
            buscar.Text = "";
            buscar.Focus();
        }

        private void consultar_DoubleClick(object sender, EventArgs e)
        {

            procesos.cod_cli = consultar.CurrentRow.Cells[0].Value.ToString();
            procesos.nombre = consultar.CurrentRow.Cells[1].Value.ToString();
           procesos.ncf = consultar.CurrentRow.Cells[3].Value.ToString();
            cotizar cot = new cotizar();
            cot.Show();

           
        }
    }
}
