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
    public partial class consult_estadia : Form
    {
        public consult_estadia()
        {
            InitializeComponent();
        }

        private void consult_estadia_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            string cmd = "select * from estadia";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
            consultar.Clear();
            consultar.Focus();
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

        private void buscar_Click(object sender, EventArgs e)
        {
            if (nombre.Checked)
            {

                if (string.IsNullOrEmpty(consultar.Text.Trim()))
                {
                    MessageBox.Show("NO HAY TIPO DE ESTADIA PARA CONSULTAR");
                }
                if (string.IsNullOrEmpty(consultar.Text.Trim()) == false)
                {
                    string cmd = "select * from estadia";
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
                        MessageBox.Show("NO HAY TIPO DE ESTADIA  PARA CONSULTAR");
                    }
                    if (string.IsNullOrEmpty(consultar.Text.Trim()) == false)
                    {
                        string cmd = "select * from estadia";
                        cmd += " where codigo like('%" + consultar.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    consultar.Clear();
                    consultar.Focus();

                }
            if (todos.Checked)
            {

                DataSet ds = new DataSet();
                string cmd = "select * from estadia";
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
