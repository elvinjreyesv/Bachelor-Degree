using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace habitacion
{
    public partial class consult_reserv : Form
    {
        public consult_reserv()
        {
            InitializeComponent();
        }

        private void consult_reserv_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select * from reservacion";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
            consultar.Clear();
            consultar.Focus();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
                if (codigo.Checked)
                {

                    if (string.IsNullOrEmpty(consultar.Text.Trim()))
                    {
                        MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
                    }
                    if (string.IsNullOrEmpty(consultar.Text.Trim()) == false)
                    {
                        string cmd = "select * from reservacion";
                        cmd += " where codreserv like('%" + consultar.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    consultar.Clear();
                    consultar.Focus();

                }
            if (todos.Checked)
            {

                DataSet ds = new DataSet();
                string cmd = "select * from reservacion";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
                consultar.Clear();
                consultar.Focus();

            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void todos_CheckedChanged(object sender, EventArgs e)
        {
            codigo.Checked = false;
           
        }

        private void codigo_CheckedChanged(object sender, EventArgs e)
        {
           
            todos.Checked = false;
        }
    }
}
