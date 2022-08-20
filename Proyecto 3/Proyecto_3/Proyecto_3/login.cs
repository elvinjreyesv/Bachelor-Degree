using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

using MetroFramework;
using MetroFramework.Forms;

namespace Proyecto_3
{
    public partial class login : MetroForm
    {

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            string cmdd = "select * from empresa";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            nombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            usuario.Focus();
            usuario.Select();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {

            //if (MetroMessageBox.Show(this, "Deseas salir", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
           // {
               // this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
               //
                Application.Exit();
          //  }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
          //  Application.Exit();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection miConecion = new SqlConnection(utilidades.UTILIDADES.cs);
                miConecion.Open();
                SqlCommand comando = new SqlCommand("select usuario, clave,cod_usu from usuarios where usuario = '" + usuario.Text + "' ", miConecion);
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(ds, "usuario");
                DataRow DR;
                DR = ds.Tables["usuario"].Rows[0];
                string codigo = DR["cod_usu"].ToString();
                string nombre = DR["usuario"].ToString();
                if ((usuario.Text == DR["usuario"].ToString()) || (clave.Text == DR["clave"].ToString()))
                {

                  proceso.usuario = codigo;
                  proceso.nombre = nombre;
                  proceso.fechain = (System.DateTime.Now);
                 this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);

                this.Hide();
                //  this.Hide();

               Principal p = new Principal();
                p.ShowDialog();

                  //this.Close();

                }

            }
            catch
            {
              
                MetroMessageBox.Show(this, "USUARIO Y/O CONTRASENA INCORECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario.Clear();
                clave.Clear();
                usuario.Select();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
             this.Close();
            Application.Exit();
        }

    }
}
