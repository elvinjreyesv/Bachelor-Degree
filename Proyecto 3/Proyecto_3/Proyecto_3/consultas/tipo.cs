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
using System.Windows.Input;
using System.Windows;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace Proyecto_3.consultas
{
    public partial class tipo : MetroForm
    {
        int i = 0;
        string valor1 = "";

        public delegate void pasar(string dato);
        public event pasar pasado;
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public tipo()
        {
            InitializeComponent();
        }

        private void clic()
        {
            buscar.Clear();
            buscar.Select();
        }

        public void mostrar()
        {
            titulo1.Text = "Búsqueda de "+proceso.titulo;
            clic();
            DataSet ds = new DataSet();
            ds = utilidades.UTILIDADES.ejecutar(proceso.query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                data.DataSource = ds.Tables[0];
            }
            else
            {
                data.DataSource = ds.Tables[0];
                data.Enabled = false;
            }
         
            
        }

        private void activar()
        {
            seleccionar.Enabled = true;
        }

        private void desactivar()
        {
            seleccionar.Enabled = false;
        }

        private void tipo_Load(object sender, EventArgs e)
        {
            mostrar();
            desactivar();
            data.Columns[1].Width = 350;
        }

        private void data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            i = Convert.ToInt16(data.CurrentRow.Cells[0].Value.ToString());
            pasado(Convert.ToString(i));
            proceso.query2 = "";
            this.Close();
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            pasado(Convert.ToString(data.CurrentRow.Cells[0].Value.ToString()));
            this.Close();
        }

        public void mostrar1()
        {
            DataSet ds1 = new DataSet();
            string cmd = proceso.query2 + "'" + valor1 + "'"; 
            ds1 = utilidades.UTILIDADES.ejecutar(cmd);
          if (ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
          {
                data1.DataSource = ds1.Tables[0];
           }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            DataGridViewRow row = data.Rows[e.RowIndex];
            valor1 = Convert.ToString(row.Cells[0].Value);
           mostrar1();
        }

        private void buscar_KeyUp(object sender, KeyEventArgs e)
        {
            valor1 = "";
            mostrar1();
            SqlConnection conexion = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;");
            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            if (nombre.Checked)
            {
                string cmd1 = proceso.query_desc+" like('%" + buscar.Text + "%')";
                cmd.CommandText = cmd1;
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                data.DataSource = dt;

            }
            else
                if (codigo.Checked)
                {
                    string cmd1 = proceso.query_cod + " like('" + buscar.Text + "%')";
                    cmd.CommandText = cmd1;
                    cmd.ExecuteNonQuery();
                    da.Fill(dt);
                    data.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Elija el tipo de busqueda");
                    clic();
                    return;
                }
            conexion.Close();
            mostrar1();
        }

        private void data_Click(object sender, EventArgs e)
        {
            activar();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            clic();
        }

        private void codigo_Click(object sender, EventArgs e)
        {
            clic();
        }

        private void buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            valor1 = "";
            mostrar1();
            if(codigo.Checked==true)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (nombre.Checked == true)
                {
                 
                    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                    {
                        e.Handled = true;
                        return;
                    }
                }
            mostrar1();
            }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            proceso.query2 = "";
        }

        private void seleccionar_Click_1(object sender, EventArgs e)
        {
            i = Convert.ToInt16(data.CurrentRow.Cells[0].Value.ToString());
            pasado(Convert.ToString(i));
            proceso.query2 = "";
            this.Close();
        }

        private void tipo_KeyDown(object sender, KeyEventArgs e)
        {
    
        }

        private void data_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void data_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            DataGridViewRow row = data.Rows[e.RowIndex];
            valor1 = Convert.ToString(row.Cells[0].Value);
            mostrar1();
        }

        private void data_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void data_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        }
    }

