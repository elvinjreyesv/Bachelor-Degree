using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;
using MetroFramework.Forms;

namespace sistema_administracion_bares
{
    public partial class estado : MetroForm
    {
        public estado()
        {
            InitializeComponent();
        }

        private void estado_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_estado+1) as Mayor from estado";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_estado.Text = numfac;
            descripcion.Select();
            mostrar();
        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from estado";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            descripcion.Clear();
            cod_estado.Text = "";
            fecha.Text = "";
            descripcion.Focus();
        }

        private void eliinar_Click(object sender, EventArgs e)
        {
           
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY ESTADO PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from estado";
                    cmd += " where cod_estado like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else

                if (nombre.Checked)
                {
                    if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                    {
                        string cmd = "select * from estado";
                        cmd += " where descripcion like('%" + busca.Text.Trim() + "%')";
                        DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                        data.DataSource = ds.Tables[0];
                    }
                    busca.Clear();
                    busca.Focus();
                }
                else
                {

                    DataSet ds = new DataSet();
                    string cmd = "select * from estado";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_estado.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_estado.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fecha.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE FECHA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                fecha.Focus();
                return;
            }

            else
            {
                try
                {
                    string cmd = "exec act_estado '" + cod_estado.Text + "','" + descripcion.Text + "','" + fecha.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_estado+1) as Mayor from estado";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_estado.Text = numfac;
                descripcion.Select();

                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_estado+1) as Mayor from estado";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_estado.Text = numfac;
            descripcion.Select();

            mostrar();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ESTADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_estado.Text);
                string cmd = "delete from estado where cod_estado='" + cod_estado.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_estado.Text = Convert.ToString(c);
                descripcion.Select();
            }

            mostrar();
        }

        private void actualizar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_estado.Text) || string.IsNullOrEmpty(descripcion.Text) || string.IsNullOrEmpty(fecha.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cmd = "update estado set cod_estado='" + cod_estado.Text.Trim() + "', " + "descripcion='" + descripcion.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "' where cod_estado ='" + cod_estado.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_estado+1) as Mayor from estado";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_estado.Text = numfac;
                descripcion.Select();
            }
            mostrar();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_estado_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_estado.Text.Trim()))
            {
                cmd = "select max(cod_estado)as mayor from estado";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_estado.Text = cod.ToString();
                }
            }
            cmd = "select * from estado where cod_estado='" + cod_estado.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }
        }
    }
}
