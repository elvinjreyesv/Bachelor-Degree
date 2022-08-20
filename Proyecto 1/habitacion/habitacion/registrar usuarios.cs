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
    public partial class registrar_usuarios : Form
    {
        public registrar_usuarios()
        {
            InitializeComponent();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            usuario.Clear();
            contrasena.Clear();
            usuario.Focus();
            nombre.Clear();
            apellido.Clear();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
          /*  DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(usuario.Text.Trim()))
            {
                cmd = "select max(usuario)as mayor from usuarios";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; usuario.Text = cod.ToString();
                }
            }
            cmd = "select * from usuarios where usuario=" + usuario.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                contrasena.Text = Convert.ToString(ds.Tables[0].Rows[0]["contrasena"]);

            }*/
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuario.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE USUARIO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                usuario.Focus();
                return;

            }
            if (string.IsNullOrEmpty(contrasena.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE CONTRASENA ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                contrasena.Focus();
                return;
            }
            if (contrasena.Text != confirm.Text)
            {
                MessageBox.Show("LOS CAMPOS DE CONTRASENA Y CONFIRMAR CONTRASENA NO COINCIDEN");
                contrasena.Clear();
                confirm.Clear();
                contrasena.Focus();
            }
            if (string.IsNullOrEmpty(nombre.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE NOMBRE ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                nombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(apellido.Text.Trim()))
            {
                MessageBox.Show("EL CAMPO DE APELLIDO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                apellido.Focus();
                return;
            }

            else
            {
                try
                {
                    // string cmd = "exec actualizarhabitacion '" + codhab.Text + "','" + descriphab.Text + "','" + estado.Text + "','" + precio.Text + "','" + codtipo.Text + "'";
                    string cmd = "exec actualizarusu " + usuario.Text + ",'" + utilidades.UTILIDADES.Encriptar(contrasena.Text) + "','" + nombre.Text + "','" + apellido.Text + "','" + System.DateTime.Now + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                    MessageBox.Show("LOS DATOS ACTUALES SE HAN GUARDADO CORRECTAMENTE");
                    usuario.Clear();
                    contrasena.Clear();
                    usuario.Focus();
                    confirm.Clear();
                    nombre.Clear();
                    apellido.Clear();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }

            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA ELIMINAR EL CAMPO ACTUAL? ", " TEMATICA ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cmd = "delete from usuarios where usuario=" + usuario.Text.Trim();
                utilidades.UTILIDADES.ejecutar(cmd);
                MessageBox.Show("LOS DATOS SE HAN ELIMINADO CORRECTAMENTE");
                nombre.Clear();
                apellido.Clear();
                usuario.Clear();
                contrasena.Clear();
                usuario.Focus();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " REGISTRAR USUARIOS ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void registrar_usuarios_Load(object sender, EventArgs e)
        {
            usuario.Select();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }

        private void comsultar_Click(object sender, EventArgs e)
        {
            consult_regusu df = new consult_regusu();
            df.ShowDialog();
            df.Dispose();
        }
    }
}
