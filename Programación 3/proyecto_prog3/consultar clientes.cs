using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_prog3
{
    public partial class consultar_clientes : Form
    {
        public consultar_clientes()
        {
            InitializeComponent();
        }
        public void cargarclientes()
        {
            Utilidades.metodos.conexion.Open();
            
            SqlDataAdapter daclientes = new SqlDataAdapter("select * from clientes", Utilidades.metodos.conexion);
            DataSet dsproducto = new DataSet();

            daclientes.Fill(dsproducto, "clientes");

            dgvclientes.DataSource = dsproducto;
            dgvclientes.DataMember = "clientes";

            Utilidades.metodos.conexion.Close();
        }

        private void consultar_clientes_Load(object sender, EventArgs e)
        {
            cargarclientes();
        }
    }
}
