using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Utilidades;
namespace proyecto_prog3
{
    public partial class facturacion : Form
    {
       
     
        public facturacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = 0, c = 0, importe = 0, total = 0;
            if (cbcliente.Text.Length != 0 && txtcodigo.Text.Length != 0 && txtcantidad.Text.Length != 0)
            {
                


                p = Convert.ToDouble(txtprecio.Text);
                c = Convert.ToDouble(txtcantidad.Text);


                importe = p * c;
                dataGridView1.Rows.Add(txtcodigo.Text, txtdetalles.Text, txtprecio.Text, txtcantidad.Text, Utilidades.metodos.convertir(importe));
            
        
                for (int k = 0; k <= dataGridView1.Rows.Count - 1; k++)
                {

                    total += Convert.ToDouble(dataGridView1.Rows[k].Cells[4].Value);

                }

                txttotal.Text = Utilidades.metodos.convertir(total);

                //string consult = "Select * from Productos where Codpro=" + txtcodigo.Text;
                    // DataSet dt = new DataSet();

                    //  dt = Utilidades.metodos.dat(consult);
                     // int r=0,i =Convert.ToInt16(dt.Tables[0].Rows[0]["Cantexit"]);
                     // r = Convert.ToInt16(txtcantidad.Text);
                     // i = i - r;

                //Blanqueo de celdas
              txtcodigo.Text = "";
             txtdetalles.Text = "";
            txtprecio.Text = "";
              txtcantidad.Text = "";
              txtcodigo.Focus();
                  }
                  else
                  {
                     MessageBox.Show("Has dejado un cuadro de Texto vacio, Favor llenar","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     if (cbcliente.Text.Length == 0)
                         cbcliente.Focus(); 
                     else
                         if (txtcodigo.Text.Length == 0)
                             txtcodigo.Focus(); 
                     else
                      txtcantidad.Focus();
               
                 }
                 }
                 
            
        
/*
            
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

         }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcodigo.Text.Trim()))
            {
                return;
            }
            string cmd = "select * from Productos where Cod_prod=" + txtcodigo.Text.Trim();
            //----------------DataSet ds = utilidades.utilidades.ejecuta(cmd);
          DataSet ds=  Utilidades.metodos.select(cmd);
            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("Error");
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtdetalles.Text = ds.Tables[0].Rows[0]["dep_prod"].ToString();
                txtprecio.Text = ds.Tables[0].Rows[0]["prec_vent"].ToString();
            }
            else
            {
                txtdetalles.Text = "";
                txtprecio.Text = "";
            }        
        }
        

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // menu men = new menu();
           // men.ShowDialog();

        }

        private void cbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void facturacion_Load(object sender, EventArgs e)
        {

            SqlConnection cn;
            SqlCommand cm;
            SqlDataReader dr;

             string str = ("Data Source=COLMENA-PC;Initial Catalog=almacen;Integrated Security=SSPI;");

             cn = new SqlConnection();
             cn.ConnectionString = str;// Utilidades.metodos.conexion;

            cm = new SqlCommand("select * from empleado",cn);// Utilidades.metodos.conexion);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cbcliente.Items.Add(dr[0]);

            }
            
        }
        public string numfac = "";
        public string cmd = "";
        private void button2_Click(object sender, EventArgs e)
        {
         
        
            /*if (cbcliente.Text == "")

                MessageBox.Show ("Campos Vacios");
                return;
            
            
         
      
           // if(  .Rows.Count == 0)
             //   MessageBox.Show("no hay datos");

             cmd = string.Format("select max(numfac+1) as mayor from factura");
           // DataTable dt=Utilidades.metodos.insert(cmd);
          //-------------- DataTable dt= Utilidades.metodos.select(cmd);
           // DataTable dt = utilidades.estudiante.Class1.select(cmd);
             numfac = dt.Rows[0]["mayor"].ToString();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("no hay datos2");
            }
            string f = System.DateTime.Now.ToString("yyyyMMdd hh:mm:ss");
            cmd = string.Format("insert into factura(numfac,fechafac,codcliente,cancelado) values('{0}','{1}','{2}','{3}')", numfac, f, ctexbox1.Text, "0");
            //ejecutamos cmd
           //-------------------- utilidades.estudiante.Class1.insert(cmd);
            MessageBox.Show("Procesado");
    
    //        limpiar
    
            foreach(DataRow dr in tabla.Rows)
            {
                cmd = string.Format("insert into detalles(num_fac,can_ven,cod_pro,despro,prec_venta,desc_prod) values('{0}','{1}','{2}','{3}','{4}')", numfac, dr["cantidad"], dr["codigo"], dr["Descripcion"], dr["Precio"]);
                utilidades.estudiante.Class1.insert(cmd);
                cmd = string.Format("update productos set cantexistente=cantexistente-{0} where cod_prod={1}",dr["cantidad"],dr["codigo"]);
                utilidades.estudiante.Class1.insert(cmd);                      
            }
            txtcodigo.Focus();
           // ctexProducto.Focus();
            //cmd con todos los datos de la facturas
            cmd = string.Format("exec reporfactura '{0}'", numfac);
            MessageBox.Show(cmd);
            */
}

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Estas Cancelando Esta Facturacion, Desea Continuar?", "Información",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (msj)
            {
                case DialogResult.OK: this.Close();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show( "no hay Datos para eliminar para eliminar");

            int fill = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(fill);

            txttotal.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string cmd = "SELECT * FROM Productos";
            //DataSet ds = Utilidades.metodos.select(cmd);
            //DataSet ds = utilidades.utilidades.ejecuta(cmd);
            //dataGridView1.DataSource = ds.Tables[0];

            Consultar_productos p= new Consultar_productos();
            p.ShowDialog();


        }
}   
}   
              
        
        
    

