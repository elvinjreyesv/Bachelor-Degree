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

namespace taller.mantenimientos
{
    public partial class sesion : MetroForm
    {
        public sesion()
        {
            InitializeComponent();
        }

        private void sesion_Load(object sender, EventArgs e)
        {
            usuarios.Select();
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
                usuarios.Select();
            }
        }

        private void sesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private bool _altF4Pressed = false;

        private void sesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection miConecion = new SqlConnection(@"server=ELVIN-PC; Initial Catalog = taller_f; Integrated Security=True;");
                miConecion.Open();
                SqlCommand comando = new SqlCommand("select usuario, clave from usuarios where usuario = '" + usuarios.Text + "'And clave = '" + clave.Text + "' ", miConecion);
                comando.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(ds, "usuario");
                DataRow DR;
                DR = ds.Tables["usuario"].Rows[0];
                if ((usuarios.Text == DR["usuario"].ToString()) || clave.Text == DR["clave"].ToString())
                {
                    prcesos.usuario = usuarios.Text;
                   // prcesos.fechain = (System.DateTime.Now);
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("USUARIO Y/O CONTRSENA INCORRECTOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarios.Clear();
                clave.Clear();
                usuarios.Select();
            }
        }
    }
}
