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
using MetroFramework;

namespace Proyecto_3.inv.mantenimientos
{
    public partial class tipos_vehiculos : MetroForm
    {
        public tipos_vehiculos()
        {
            InitializeComponent();
        }

        private void nuevos()
        {
            cod_tipo.Text = "";
            descrip.Text = "";
            estado.Checked = false;
        }

        private void tipos_vehiculos_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
        }
    }
}
