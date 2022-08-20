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
    public partial class categoria : MetroForm
    {
        int est;
        public categoria()
        {
            InitializeComponent();
        }


        private void categoria_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_categoria+1) as Mayor from categoria";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_categoria.Text = numfac;
            descripcion.Select();

            mostrar();
        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from categoria";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            descripcion.Clear();
            activo.Checked = false;
            inactivo.Checked = false;
            descripcion.Focus();
        }

        private void salvar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_categoria.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_categoria.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descripcion.Focus();
                return;
            }
            if (est == 0)
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                activo.Focus();
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
                    if (activo.Checked == true)
                        est = 1;
                    else
                        if (inactivo.Checked == true)
                            est = 2;

                    string cmd = "exec act_categoria '" + cod_categoria.Text + "','" + descripcion.Text + "','" + est + "','" + fecha.Text + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_categoria+1) as Mayor from categoria";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_categoria.Text = numfac;
                descripcion.Select();

                mostrar();
            }
        }

        private void nuevo1_Click(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_categoria+1) as Mayor from categoria";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_categoria.Text = numfac;
            descripcion.Select();

            mostrar();
        }

        private void eliminar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_categoria.Text);
                string cmd = "delete from categoria where cod_categoria='" + cod_categoria.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_categoria.Text = Convert.ToString(c);
                descripcion.Select();
            }

            mostrar();
        }

        private void actualizar1_Click(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_categoria.Text) || string.IsNullOrEmpty(descripcion.Text) || string.IsNullOrEmpty(fecha.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (est == 0)
                MessageBox.Show("Faltan datos para continuar");
            else
            {
                string cmd = "update categoria set cod_categoria='" + cod_categoria.Text.Trim() + "', " + "descripcion='" + descripcion.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "', " + "cod_estado='" + est + "' where cod_categoria ='" + cod_categoria.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_categoria+1) as Mayor from categoria";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_categoria.Text = numfac;
                descripcion.Select();
            }
            mostrar();
        }

        private void salir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultar1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from categoria";
                    cmd += " where cod_categoria like('%" + busca.Text.Trim() + "%')";
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
                        string cmd = "select * from categoria";
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
                    string cmd = "select * from categoria";
                    ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                    busca.Clear();
                    busca.Focus();

                }
        }

        private void cod_categoria_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_categoria.Text.Trim()))
            {
                cmd = "select max(cod_categoria)as mayor from categoria";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_categoria.Text = cod.ToString();
                }
            }
            cmd = "select * from categoria where cod_categoria='" + cod_categoria.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                est = Convert.ToInt16(ds.Tables[0].Rows[0]["cod_estado"]);

                if (Convert.ToInt16(est) == 1)
                    activo.Checked = true;
                else
                    if (Convert.ToInt16(est) == 2)
                        inactivo.Checked = true;
                fecha.Text = Convert.ToString(ds.Tables[0].Rows[0]["fecha_reg"]);
            }
        }
    }
}
