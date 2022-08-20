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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
            
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            usuario.Select();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("REALMENTE DESEA SALIR", "ABANDONAR SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                usuario.Select();
            }
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            //para realizar un insert desde c# para sql
         // string  sd = "INSERT INTO animales (id, nombre, no_patas) Values (" + usuario.Text + ",'" + usuario.Text + "'," + usuario.Text + ")";

            try
            {
                SqlConnection miConecion = new SqlConnection(@"server=ELVIN-PC\SQLEXPRESS; Initial Catalog = cabanas; Integrated Security=True;");
                miConecion.Open();
                SqlCommand comando = new SqlCommand("select usuario, contrasena from usuarios where usuario = '" + usuario.Text + "'And contrasena = '" + utilidades.UTILIDADES.Encriptar( contrasena.Text) + "' ", miConecion);
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(ds, "usuario");
                DataRow DR;
                DR = ds.Tables["usuario"].Rows[0];
                if ((usuario.Text == DR["usuario"].ToString()) || (utilidades.UTILIDADES.Encriptar( contrasena.Text) == DR["contrasena"].ToString()))
                {
                    procesos.usuario = usuario.Text;
                    procesos.fechain = (System.DateTime.Now);
                    this.Close();
                }
                
            }
            catch
            {
                MessageBox.Show("ERROR! ALGUNO DE LOS CAMPOS DIGITADOS SON INCORRECTOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuario.Clear();
                contrasena.Clear();
                usuario.Select();
            }
        }

        private void usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }

        }
       
        private bool _altF4Pressed = false;

        private void usuarios_KeyDown(object sender, KeyEventArgs e)
        {
             if ( e.Alt && e.KeyCode == Keys.F4)
                  _altF4Pressed = true;
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                
                MessageBox.Show("DEBE DESACTIVAR LA TECLA CAPS LOCK PARA CONTINUAR LA OPERACION ");
                
            }
            else
            {

            }
        }
           
    }
}
