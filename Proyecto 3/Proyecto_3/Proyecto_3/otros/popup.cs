using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Proyecto_3.otros
{
    public partial class popup : Form
    {
        public popup()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
           this.ShowInTaskbar = false;
        }

        private void popup_Load(object sender, EventArgs e)
        {
            login l=new login(); 
            l.ShowDialog();
            this.Hide();
        }
    }
}
