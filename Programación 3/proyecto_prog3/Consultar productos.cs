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
    public partial class Consultar_productos : Form
    {
        public Consultar_productos()
        {
            InitializeComponent();
        }

        public void cargarproducto()
        {
            Utilidades.metodos.conexion.Open();
            SqlDataAdapter daproducto = new SqlDataAdapter("select * from productos", Utilidades.metodos.conexion);
            DataSet dsproducto = new DataSet();

            daproducto.Fill(dsproducto,"productos");

            dgvproductos.DataSource = dsproducto;
            dgvproductos.DataMember = "productos";

            Utilidades.metodos.conexion.Close();
        }

        private void Consultar_productos_Load(object sender, EventArgs e)
        {
            cargarproducto();
        }
    }
}
