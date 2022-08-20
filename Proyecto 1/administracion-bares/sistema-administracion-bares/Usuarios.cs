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

namespace sistema_administracion_bares
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            usuario.Select();
        }

        private void rechazar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {



            try
            {
                SqlConnection miConecion = new SqlConnection(utilidades.UTILIDADES.cs);
                miConecion.Open();
                SqlCommand comando = new SqlCommand("select usuario, contrasena from usuarios where usuario = '" + usuario.Text + "' ", miConecion);
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(ds, "usuario");
                DataRow DR;
                DR = ds.Tables["usuario"].Rows[0];
                if ((usuario.Text == DR["usuario"].ToString()) || (utilidades.UTILIDADES.Encriptar(contrasena.Text) == DR["contrasena"].ToString()))
                {
                    procesos.usuario = usuario.Text;
                    procesos.fechain = (System.DateTime.Now);
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("LOS CAMPOS USUARIO Y/O CONTRASENA SON INCORECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuario.Clear();
                contrasena.Clear();
                usuario.Select();
            }
        }

        private bool _altF4Pressed = false;

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void Usuarios_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void Usuarios_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("LA TECLA CAPS LOCK DEBE DESACTIVARSE ");
            }
            else
            {

            }
        }
    }
}
