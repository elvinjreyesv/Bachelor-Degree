using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace habitacion
{
    public partial class reporte_usuarios : Form
    {
        public reporte_usuarios()
        {
            InitializeComponent();
        }

        private void reporte_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.v_usuarios' Puede moverla o quitarla según sea necesario.
            this.v_usuariosTableAdapter.Fill(this.DataSet1.v_usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
