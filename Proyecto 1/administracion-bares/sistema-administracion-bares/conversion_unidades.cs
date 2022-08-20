using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using MetroFramework.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace sistema_administracion_bares
{
    public partial class conversion_unidades : MetroForm
    {
        public conversion_unidades()
        {
            InitializeComponent();
        }

        private void conversion_unidades_Load(object sender, EventArgs e)
        {
            cbounidad.Text = Convert.ToString(procesos.unidad_c);
            cbounidadf.Text = Convert.ToString(procesos.unidad_v);
            txtcantidad.Text =Convert.ToString( procesos.cantidad);
            {
                SqlConnection co = new SqlConnection(utilidades.UTILIDADES.cs);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from articulos", co);
                da.Fill(ds);
               
               cbounidad.Select();
            }
            
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            int d = 0;
            if (string.IsNullOrEmpty(txtcantidad.Text) || string.IsNullOrEmpty(cbounidad.Text) || string.IsNullOrEmpty(cbounidadf.Text))
            {
                ComponentFactory.Krypton.Toolkit.KryptonMessageBox.Show("FALTAN DATOS PARA CONTINUAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbounidad.Text.Trim() == "cajas pequenas" || cbounidad.Text.Trim() == "cajas grandes" && cbounidadf.Text.Trim() == "unidades")
            {

                String cmd = "select * from c_unidad where descripcion='" + cbounidad.Text.Trim() + "'";
               DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                   d = Convert.ToInt16(ds.Tables[0].Rows[0]["cant_und"]);
                }

                int s = Convert.ToInt16(txtcantidad.Text.Trim());
                int f = s * d;
                txtresultado.Text =Convert.ToString(f);
            }

            else
          if (cbounidadf.Text.Trim() == "cajas pequenas" || cbounidadf.Text.Trim() == "cajas grandes" && cbounidad.Text.Trim() == "unidades")
            {

                String cmd = "select * from c_unidad where descripcion='" + cbounidadf.Text.Trim() + "'";
               DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                   d = Convert.ToInt16(ds.Tables[0].Rows[0]["cant_und"]);
                }

                int s = Convert.ToInt16(txtcantidad.Text.Trim());
                int f = s / d;
                txtresultado.Text =Convert.ToString(f);
            }
          else
              if ( cbounidadf.Text.Trim() == "unidades" && cbounidad.Text.Trim() == "unidades")
              {
                  txtresultado.Text = txtcantidad.Text.Trim();
              }
            nombre.Text = cbounidadf.Text.Trim();

        }

        private void btnregresar_Click_1(object sender, EventArgs e)
        {
             this.Hide();
            procesos.resultado =Convert.ToDouble( txtresultado.Text);
            movimientos m = new movimientos();
            m.ShowDialog();
            

            this.Close();
        
        }
    }
}
