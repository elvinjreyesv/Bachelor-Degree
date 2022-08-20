using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace proyecto_prog3
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string c="select nom_usu, pass from Usuario where nom_usu='" + txtusuario.Text + "' and pass='" + txtcontrasena.Text + "'";
            
            Utilidades.metodos.select(c);
         
            try
            {
                //Utilidades.metodos.usuario = Utilidades.metodos.ds.Tables[0].Rows[0]["usuario"].ToString();
                this.DialogResult= DialogResult.OK;
                Close();
            }
            catch
            {
            MessageBox.Show("clave inco");

            }


            /*   menu menu = new menu();
            menu.ShowDialog();
            


            SqlConnection cn;
            // SqlCommand cm;
            // SqlDataReader dr;

            string str = ("Data Source=COLMENA-PC;Initial Catalog=almacen;Integrated Security=SSPI;");

            cn = new SqlConnection();
            cn.ConnectionString = str;

        
                        

            
           SqlConnection con = new SqlConnection("Data Source=COLMENA-PC;Initial Catalog=facturacion;Integrated Security=SSPI;");
          //  SqlConnection con;
            // SqlCommand cm;
            //SqlDataReader dr;

           /* string str = ("Data Source=COLMENA-PC;Initial Catalog=facturacion;Integrated Security=SSPI;");

            con = new SqlConnection();
            con.ConnectionString = str;
            

            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("select nom_usu, pass from Usuario where nom_usu='" + txtusuario.Text + "'and pass='" + txtcontrasena + "'", con);
               
                //comando.EndExecuteNonQuery(con);
                comando.ExecuteNonQuery();


                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comando);

                da.Fill(ds, "Usuario");

                DataRow dro;
                dro = ds.Tables["Usuario"].Rows[0];
                if ((txtusuario.Text == dro["nom_usu"].ToString()) || (txtcontrasena.Text == dro["pass"].ToString()))
                {
                    menu m = new menu();
                    m.ShowDialog();
                    this.Hide();
                    //DialogResult = DialogResult.OK;


                   /*    login log = new login();
                       if (log.ShowDialog() == DialogResult.OK)
                       {
                           Application.Run(new login());
                       }
                }

            }
            catch
            {
                MessageBox.Show("errro");

            }
            finally
            {
                con.Close();
            }
            */
            

        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
