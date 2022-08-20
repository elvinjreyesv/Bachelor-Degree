using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MetroFramework.Forms;

namespace sistema_administracion_bares
{
    public partial class progreso : MetroForm
    {
        public progreso()
        {
            InitializeComponent();

            {
                int i;
                Single j, k;


                for (i = 0; i <= 100; i++)
                {
                    progress.Value = i;
                    for (j = 0; j <= 1000; j++)
                    {
                        for (k = 0; k <= 500; k++)
                        {
                        }
                    }
                }



                if (progress.Value == 100)
                {
                    this.Hide();
                    articulos a = new articulos();
                    a.Show();
                }
            }
        }

        private void progreso_Load(object sender, EventArgs e)
        {
   
        }

        private void progres_Validating(object sender, CancelEventArgs e)
        {
            //int i;
            //Single j, k;

          
            //    for (i = 0; i <= 100; i++)
            //    {
            //        progres.Value = i;
            //        for (j = 0; j <= 500; j++)
            //        {
            //            for (k = 0; k <= 250; k++)
            //            {
            //            }
            //        }
            //    }

            //    if (progres.Value == 100)
            //    {
            //        articulos ar = new articulos();
            //        ar.Show();
            //    }
            
        }

        private void progres_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //int i;
            //Single j, k;

            
            //for (i = 0; i <= 100; i++)
            //{
            //   progress.Value = i;
            //    for (j = 0; j <= 1000; j++)
            //    {
            //        for (k = 0; k <= 500; k++)
            //        {
            //        }
            //    }
            //}
                


            //if (progress.Value == 100)
            //{
            //this.Hide();
            //articulos a = new articulos();
            //a.Show();
            //}
        }

      
    }
}
