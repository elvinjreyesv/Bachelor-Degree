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


namespace habitacion
{
    public partial class habitacion : Form
    {
        public habitacion()
        {
            InitializeComponent();
            string cmdd = "select max (codhab+1) as Mayor from habitacion";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codhab.Text = numfac;
        }

        private void codhab_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codhab.Text.Trim()))
            {
                cmd = "select max(codhab)as mayor from habitacion";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codhab.Text = cod.ToString();
                }
            }
            cmd = "select * from habitacion where codhab=" + codhab.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                codtipo.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtipo"]);
                descriphab.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriphab"]);
                estado.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
                precio.Text = Convert.ToString(ds.Tables[0].Rows[0]["precio"]);
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                descriptem.Text = Convert.ToString(ds.Tables[0].Rows[0]["descriptem"]);
                codest.Text = Convert.ToString(ds.Tables[0].Rows[0]["codest"]);


            }
        }

        private void habitacion_Load(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                //tipo de cliente

                DataSet ds1 = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select descripcion from tipohab", con);
                da.Fill(ds1);
                descripcion.DataSource = ds1.Tables[0].DefaultView;
                descripcion.ValueMember = "descripcion";
                descripcion.Text = "";
                 descriphab.Select();
            }

            {
                SqlConnection co = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                //tipo de cliente

                DataSet ds = new DataSet();
                SqlDataAdapter dad = new SqlDataAdapter("select descriptem from tematica", co);
                dad.Fill(ds);
                descriptem.DataSource = ds.Tables[0].DefaultView;
                descriptem.ValueMember = "descriptem";
                descriptem.Text = "";
                // descripcion.Select();
            }

            {
                SqlConnection c = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet dsa = new DataSet();
                SqlDataAdapter di = new SqlDataAdapter("select estado from estado", c);
                di.Fill(dsa);
                estado.DataSource = dsa.Tables[0].DefaultView;
                estado.ValueMember = "estado";
                estado.Text = "";
                // 
            }
          

            {
                  SqlConnection cnn = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                  DataSet dssa = new DataSet();
                  SqlDataAdapter dis = new SqlDataAdapter("select codest from estado", cnn);
                  dis.Fill(dssa);
                  codest.DataSource = dssa.Tables[0].DefaultView;
                  codest.ValueMember = "codest";
                  codest.Text = "";
                  // descripcion.Select();
            }

            {
                SqlConnection cnn = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet dssa = new DataSet();
                SqlDataAdapter dis = new SqlDataAdapter("select codtipo from tipohab", cnn);
                dis.Fill(dssa);
                codtipo.DataSource = dssa.Tables[0].DefaultView;
                codtipo.ValueMember = "codtipo";
                codtipo.Text = "";
                // descripcion.Select();
            }
            descriphab.Select();
        }

      /*  private void codest_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codest.Text.Trim()))
            {
                cmd = "select max(codest)as mayor from estado";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codest.Text = cod.ToString();
                }
            }
            cmd = "select * from estado where codest=" + codest.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                estado.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);

            }
        }*/

     /*   private void estado_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(estado.Text.Trim()))
            {
                cmd = "select max(estado)as mayor from estado";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; estado.Text = cod.ToString();
                }
            }
            cmd = "select * from estado where estado=" + estado.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                codest.Text = Convert.ToString(ds.Tables[0].Rows[0]["codest"]);

            }
        }*/

        private void salvar_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(codhab.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codhab.Focus();
                return;

            }
            if (string.IsNullOrEmpty(descriphab.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE DESCRIPCION ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                descriphab.Focus();
                return;
            }
             if (string.IsNullOrEmpty(estado.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                estado.Focus();
                return;
            }
             if (string.IsNullOrEmpty(precio.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE PRECIO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                precio.Focus();
                return;
            }
                  if (string.IsNullOrEmpty(codtipo.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE TIPO DE HABITACION  ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codtipo.Focus();
                return;
            }
               if (string.IsNullOrEmpty(codest.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CODIGO TEMATICA  ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                codest.Focus();
                return;
            }
                  

            else
            {
                try
                {
                    string cmd = "exec actualizarhabitacion '" + codhab.Text + "','" + descriphab.Text + "','" + estado.Text + "','" + precio.Text + "','" + descripcion.Text + "','" + descriptem.Text + "','" + codest.Text + "','" + codtipo.Text + "','" + System.DateTime.Now + "'";  // "','" + codest.Text
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    codhab.Clear();
                    descriphab.Text="";
                    estado.Text="";
                    precio.Clear();
                    descripcion.Text="";
                    descriptem.Text="";
                    codtipo.Text = "";
                   codest.Text="";
                    descriphab.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                string cmdd = "select max (codhab+1) as Mayor from habitacion";
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
                string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
                codhab.Text = numfac;
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            codhab.Clear();
            descriphab.Text = "";
            estado.Text = "";
            precio.Clear();
            descripcion.Text = "";
            descriptem.Text = "";
            codest.Text = "";
            codtipo.Text = "";
            string cmdd = "select max (codhab+1) as Mayor from habitacion";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codhab.Text = numfac;
            descriphab.Focus();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TEMATICA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int c = Convert.ToInt16(codhab.Text);
                string cmd = "delete from habitacion where codhab=" + codhab.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                codhab.Clear();
                descriphab.Text = "";
                estado.Text = "";
                precio.Clear();
                descripcion.Text = "";
                descriptem.Text = "";
                codest.Text = "";
                codtipo.Text = "";
                codhab.Text = Convert.ToString(c);
                descriphab.Focus();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ABANDONAR LA OPERACION ACTUAL? ", " HABITACIONES ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void descriphab_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriphab.Text.Trim()))
            {
                this.errorProvider1.SetError(descriphab, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(descriphab, "");
            }
        }

        private void precio_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(precio.Text.Trim()))
            {
                this.errorProvider1.SetError(precio, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(precio, "");
            }
        }

        private void descripcion_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
            {
                this.errorProvider1.SetError(descripcion, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(descripcion, "");
            }
        }

        private void descriptem_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptem.Text.Trim()))
            {
                this.errorProvider1.SetError(descriptem, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(descriptem, "");
            }
        }

        private void estado_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(estado.Text.Trim()))
            {
                this.errorProvider1.SetError(estado, "PARA LA OPERACION ACTUAL ESTE CAMPO NO PUEDE PERMANECER VACIO");
            }
            else
            {
                this.errorProvider1.SetError(estado, "");
            }
        }

        private void codest_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codest.Text.Trim()))
            {
                cmd = "select max(codest)as mayor from estado";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codest.Text = cod.ToString();
                }
            }
            cmd = "select * from estado where codest=" + codest.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                estado.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
            }
        }

        private void descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void codtipo_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codtipo.Text.Trim()))
            {
                cmd = "select max(codtipo)as mayor from tipohab";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codtipo.Text = cod.ToString();
                }
            }
            cmd = "select * from tipohab where codtipo=" + codtipo.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                descripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void codhab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void descriphab_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void codtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void descriptem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void estado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void codest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void descripcion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(descripcion.Text.Trim()))
                return;
            string cmd = string.Format("select * from tipohab where descripcion = '{0}'", descripcion.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                codtipo.Text = ds.Tables[0].Rows[0]["codtipo"].ToString();
               
            }
            catch
            {
                MessageBox.Show("EL TIPO ACTUAL NO EXISTE");
            }
        }

        private void estado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(estado.Text.Trim()))
                return;
            string cmd = string.Format("select * from estado where estado = '{0}'", estado.Text.Trim());
            try
            {
                DataSet ds = utilidades.UTILIDADES.ejecutar(cmd);
                codest.Text = ds.Tables[0].Rows[0]["codest"].ToString();
                
            }
            catch
            {
                MessageBox.Show("EL ESTADO ACTUAL NO EXISTE");
            }
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consult_habit ch = new consult_habit();
            ch.ShowDialog();
            ch.Dispose();
        }
    }
}
