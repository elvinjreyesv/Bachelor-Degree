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
using System.Data.Sql;
using System.Data.SqlClient;

namespace repuesto
{
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void rechazar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("SEGURO QUE DESEAS SALIR", "ABANDONAR INICIO DE SESION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                Application.Exit(); 
                Application.Exit();
                Application.Exit();
                Application.Exit();
                Application.Exit();
                Application.Exit();
                Application.Exit();
                Application.Exit();
            }
            else
            {
                usuario.Select();
            }
           
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }

        }

        private bool _altF4Pressed = false;

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void login_Load(object sender, EventArgs e)
        {
            usuario.Select();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection miConecion = new SqlConnection(@"server=ELVIN-PC; Initial Catalog = repuesto; Integrated Security=True;");
                miConecion.Open();
                SqlCommand comando = new SqlCommand("select login, clave from usuario where login = '" + usuario.Text + "'And clave = '" + contrasena.Text + "' ", miConecion);
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(ds, "login");
                DataRow DR;
                DR = ds.Tables["login"].Rows[0];
                if ((usuario.Text == DR["login"].ToString()) || contrasena.Text == DR["clave"].ToString())
                {
                    procesos.usuario = usuario.Text;
                    procesos.fechain = (System.DateTime.Now);
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("USUARIO Y/O CONTRSENA INCORRECTOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuario.Clear();
                contrasena.Clear();
                usuario.Select();
            }
        }
    }
}
