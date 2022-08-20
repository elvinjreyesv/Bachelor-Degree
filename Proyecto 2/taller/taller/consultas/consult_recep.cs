using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.consultas
{
    public partial class consult_recep : Form
    {
        public consult_recep()
        {
            InitializeComponent();
        }

        private void consult_recep_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = "select  recepcion.cod_recep as Codigo_recepcion, cliente.cod_cli as Codigo_Cliente, tercero.nombre + ' ' + cliente.apellido as Nombre,recepcion.fecha_rec as Fecha_Recepcion,recepcion.cod_veh as Codigo_vehiculo,recepcion.tipo_veh as Tipo_vehiculo from tercero inner join cliente on tercero.cod_tercero=cliente.cod_tercero inner join recepcion on recepcion.cod_cli=cliente.cod_cli where  recepcion.cod_cli  like ('%" + prcesos.cod + "%')";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            consultar.DataSource = ds.Tables[0];
        }

        private void consultar_DoubleClick(object sender, EventArgs e)
        {
            prcesos.recep = consultar.CurrentRow.Cells[0].Value.ToString();
            this.Visible = false;

            Procesos.factura cot = new Procesos.factura();
            cot.Show();
        }
    }
}
