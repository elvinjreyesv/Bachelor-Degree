using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.IO;
using System.Data.SqlClient;

namespace habitacion
{
    public partial class estado : Form
    {
        public estado()
        {
            InitializeComponent();

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (disponible.Checked == true)
            {
                 string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion where codest='2'";
               // string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion";
                DataSet ds = new DataSet();
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                consulta.DataSource = ds.Tables[0];
                consulta.ClearSelection();
            }
            else
            if (todas.Checked == true)
            {
                // string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion where codest='2'";
                string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion";
                DataSet ds = new DataSet();
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                consulta.DataSource = ds.Tables[0];
                consulta.ClearSelection();
            }
            else
            {
                if (string.IsNullOrEmpty(tipos.Text.Trim()))
                {
                    MessageBox.Show("PARA CONTINUAR DEBE ESTABLECER LOS VALORES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion where codest='2'and descripcion='" + tipos.Text + "'";
                    DataSet ds = new DataSet();
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    consulta.DataSource = ds.Tables[0];
                    consulta.ClearSelection();
                    todas.Checked = false;
                }
            }
        }

        private void estado_Load(object sender, EventArgs e)
        {

            tiempo1.Enabled = true;
            SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select descripcion from tipohab", con);
            da.Fill(ds1);
            tipos.DataSource = ds1.Tables[0].DefaultView;
            tipos.ValueMember = "descripcion";
            tipos.Text = "";
            tipos.Select();

            DataSet ds = new DataSet(); 
            string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion";
            try
            {
                ds = utilidades.UTILIDADES.ejecutar(cmd);

                consulta.DataSource = ds.Tables[0];
            }
            catch { }

            foreach (DataGridViewRow dr in consulta.Rows)
            {
                if (Convert.ToInt16(dr.Cells[3].Value) == 1)
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                    if (Convert.ToInt16(dr.Cells[3].Value) == 2)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                        if (Convert.ToInt16(dr.Cells[3].Value) == 3)
                        {
                            dr.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                            if (Convert.ToInt16(dr.Cells[3].Value) == 4)
                            {
                                dr.DefaultCellStyle.BackColor = Color.Blue;
                            }

                consulta.ClearSelection();

            }


        }

        private void tiempo1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in consulta.Rows)
            {
                if (Convert.ToInt16(dr.Cells[3].Value) == 1)
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                    if (Convert.ToInt16(dr.Cells[3].Value) == 2)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                        if (Convert.ToInt16(dr.Cells[3].Value) == 3)
                        {
                            dr.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                            if (Convert.ToInt16(dr.Cells[3].Value) == 4)
                            {
                                dr.DefaultCellStyle.BackColor = Color.Blue;
                            }
                consulta.ClearSelection();
            }
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            hora_exacta.Text = DateTime.Now.ToLongTimeString();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            string cmd = "select a.codhab as [Codigo], a.descriphab as [Nombre],t.descripcion as [Tipo],a.estado as [Estado] from habitacion a inner join tipohab t on a.codtipo=t.codtipo ";
            DataSet ds = new DataSet();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            consulta.DataSource = ds.Tables[0];
            consulta.ClearSelection();

            foreach (DataGridViewRow dr in consulta.Rows)
            {
                if (Convert.ToInt16(dr.Cells[3].Value) == 1)
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                    if (Convert.ToInt16(dr.Cells[3].Value) == 2)
                    {
                        dr.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                        if (Convert.ToInt16(dr.Cells[3].Value) == 3)
                        {
                            dr.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                            if (Convert.ToInt16(dr.Cells[3].Value) == 4)
                            {
                                dr.DefaultCellStyle.BackColor = Color.Blue;
                            }
                consulta.ClearSelection();
            }
        }

        private void consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            consulta.ClearSelection();
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            consulta.ClearSelection();
        }

        private void todas_Click(object sender, EventArgs e)
        {
          /*  string cmd = "select codhab as [Codigo],descriphab as[Descripcion],estado as [Estado],precio as [Precio],descripcion as [Tipo],descriptem as [Tematica] from habitacion  a inner join tipohab t on a.tipo=t.codhab ";
            DataSet ds = new DataSet();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            consulta.DataSource = ds.Tables[0];
            consulta.ClearSelection();
            tipos.Text = "";*/
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " ESTADO ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //procesos.codhabb = consulta.CurrentRow.Cells[0].Value.ToString();
            //procesos.descripcion = consulta.CurrentRow.Cells[6].Value.ToString();
            //procesos.descriphab = consulta.CurrentRow.Cells[1].Value.ToString();
            //procesos.precio = consulta.CurrentRow.Cells[2].Value.ToString();
            //procesos.descriptem = consulta.CurrentRow.Cells[5].Value.ToString();
            change_state cs = new change_state();
            cs.ShowDialog();
            cs.Dispose();
        }

        private void consulta_DoubleClick(object sender, EventArgs e)
        {
           
            procesos.codhab = consulta.CurrentRow.Cells[0].Value.ToString();
            facturacion elegir = new facturacion();
            elegir.ShowDialog();
            consulta.ClearSelection();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
             string cmd = "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion";
             try
             {
                 DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);

                 consulta.DataSource = ds.Tables[0];
             }
             catch { }
        }

        private void tipos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void todas_CheckedChanged(object sender, EventArgs e)
        {
          disponible.Checked = false;
        }

        private void disponible_CheckedChanged(object sender, EventArgs e)
        {
            todas.Checked = false;
        }
    }
}
