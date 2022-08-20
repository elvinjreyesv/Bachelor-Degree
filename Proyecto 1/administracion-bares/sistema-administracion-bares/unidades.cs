﻿using System;
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
    public partial class unidades : MetroForm
    {
        int est;
        public unidades()
        {
            InitializeComponent();
        }


        private void unidades_Load(object sender, EventArgs e)
        {
            string cmdd = "select max (cod_unidad+1) as Mayor from unidad";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_unidad.Text = numfac;
            unidad_almacen.Select();

            mostrar();

        }

        public void mostrar()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from unidad";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            data.DataSource = ds.Tables[0];
        }

        public void limpiar()
        {
            unidad_almacen.Clear();
            unidad_venta.Clear();
            activo.Checked = false;
           inactivo.Checked = false;
            fecha.Text = "";
            busca.Text = "";
            unidad_almacen.Focus();
        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DESEAS ELIMINAR EL REGISTRO ACTUAL? ", " ALMACEN ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(cod_unidad.Text);
                string cmd = "delete from unidad where cod_unidad='" + cod_unidad.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                cod_unidad.Text = Convert.ToString(c);
                unidad_almacen.Select();
            }

            mostrar();
        }

        private void actualizar_Click_1(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_unidad.Text) || string.IsNullOrEmpty(unidad_almacen.Text) || string.IsNullOrEmpty(fecha.Text) || string.IsNullOrEmpty(unidad_venta.Text))
            {
                MessageBox.Show("FALTAN DATOS PARA LA ACTUALIZACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (est == 0)
                MessageBox.Show(" Faltan datos para continuar");
            else
            {
                string cmd = "update unidad set cod_unidad='" + cod_unidad.Text.Trim() + "', " + "und_invent='" + unidad_almacen.Text.Trim() + "', " + "und_venta='" + unidad_venta.Text.Trim() + "', " + "fecha_reg='" + fecha.Value.Date.ToString("dd/MM/yyyy") + "', " + "cod_estado='" + est + "' where cod_unidad ='" + cod_unidad.Text.Trim() + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("ACTUALIZACION FINALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

                string cmdd = "select max (cod_unidad+1) as Mayor from unidad";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_unidad.Text = numfac;
                unidad_almacen.Select();
            }
            mostrar();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvar_Click_1(object sender, EventArgs e)
        {
            if (activo.Checked == true)
                est = 1;
            else
                if (inactivo.Checked == true)
                    est = 2;
            if (string.IsNullOrEmpty(cod_unidad.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                cod_unidad.Focus();
                return;

            }
            if (string.IsNullOrEmpty(unidad_venta.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                unidad_venta.Focus();
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
                    string cmd = "exec act_unidad '" + cod_unidad.Text + "','" + unidad_almacen.Text + "','" + unidad_venta.Text + "','" + fecha.Text + "','" + est + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("DATOS ALMACENADOS EXITOSAMENTE");
                    limpiar();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (cod_unidad+1) as Mayor from unidad";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                cod_unidad.Text = numfac;
                unidad_almacen.Select();

                mostrar();
            }
        }

        private void nuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            string cmdd = "select max (cod_unidad+1) as Mayor from unidad";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_unidad.Text = numfac;
            unidad_almacen.Select();

            mostrar();
        }

        private void consultar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(busca.Text.Trim()))
            {
                MessageBox.Show("NO HAY TIPO DE CLIENTE  PARA CONSULTAR");
            }
            if (cod.Checked)
            {
                if (string.IsNullOrEmpty(busca.Text.Trim()) == false)
                {
                    string cmd = "select * from unidad";
                    cmd += " where cod_unidad like('%" + busca.Text.Trim() + "%')";
                    DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                    data.DataSource = ds.Tables[0];
                }
                busca.Clear();
                busca.Focus();
            }
            else
            {

                DataSet ds = new DataSet();
                string cmd = "select * from unidad";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                data.DataSource = ds.Tables[0];
                busca.Clear();
                busca.Focus();

            }
        }

        private void cod_unidad_Validating_1(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(cod_unidad.Text.Trim()))
            {
                cmd = "select max(cod_unidad)as mayor from unidad";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; cod_unidad.Text = cod.ToString();
                }
            }
            cmd = "select * from unidad where cod_unidad='" + cod_unidad.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                unidad_venta.Text = Convert.ToString(ds.Tables[0].Rows[0]["und_venta"]);
                unidad_almacen.Text = Convert.ToString(ds.Tables[0].Rows[0]["und_invent"]);

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
