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
    public partial class consult_tipcliente : Form
    {
        public consult_tipcliente()
        {
            InitializeComponent();
        }

        private void nombre_CheckedChanged(object sender, EventArgs e)
        {
            codigo.Checked = false;
            todos.Checked = false;
        }

        private void todos_CheckedChanged(object sender, EventArgs e)
        {
            codigo.Checked = false;
            nombre.Checked = false;
        }

        private void codigo_CheckedChanged(object sender, EventArgs e)
        {
            nombre.Checked = false;
            todos.Checked = false;
        }

        private void consult_tipcliente_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select * from tipocliente";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
            consultar.Clear();
            consultar.Focus();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (nombre.Checked)
            {

                if (string.IsNullOrEmpty(consultar.Text.Trim()))
                {
                    MessageBox.Show("NO HAY TIPO DE CLIENTE PARA CONSULTAR");
                }
                if (string.IsNullOrEmpty(consultar.Text.Trim()) == false)
                {
                    string cmd = "select * from tipocliente";
                    cmd += " where descripcion like ('%" + consultar.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                    consultar.Clear();
                    consultar.Focus();

                }
            }
            else
                if (codigo.Checked)
                {

                    if (string.IsNullOrEmpty(consultar.Text.Trim()))
                    {
                        MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
                    }
                    if (string.IsNullOrEmpty(consultar.Text.Trim()) == false)
                    {
                        string cmd = "select * from tipocliente";
                        cmd += " where codtipo like('%" + consultar.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    consultar.Clear();
                    consultar.Focus();

                }
            if (todos.Checked)
            {

                DataSet ds = new DataSet();
                string cmd = "select * from tipocliente";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
                consultar.Clear();
                consultar.Focus();

            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
