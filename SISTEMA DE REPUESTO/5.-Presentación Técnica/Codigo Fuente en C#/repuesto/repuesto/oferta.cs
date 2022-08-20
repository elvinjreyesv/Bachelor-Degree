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

namespace repuesto
{
    public partial class oferta : MetroForm
    {
        public oferta()
        {
            InitializeComponent();
        }

        private void oferta_Load(object sender, EventArgs e)
        {

            label2.Text = procesos.descripcion;
            {
                DataSet ds = new DataSet();
                string cmd = "select recomendaciones.descrip as Recomendacion,riesgos.cantidad,riesgos.gastos,riesgos.prec_ven,riesgos.cod_art,riesgos.descrip as Riesgos,vehiculo.cod_veh from recomend_vs_riesgo inner join riesgos on recomend_vs_riesgo.cod_riesgo=riesgos.cod_riesgo inner join recomendaciones on recomend_vs_riesgo.cod_recom=recomendaciones.cod_recom inner join vehiculo on riesgos.cod_veh=vehiculo.cod_veh where riesgos.cod_art='" + procesos.articulo + "' and riesgos.cod_veh ='" + procesos.vehiculo + "'";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                consultar.DataSource = ds.Tables[0];
            }
        }

        private void consultar_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            cotizar cot = new cotizar();
            cot.ShowDialog();

            procesos.recomendacion = consultar.CurrentRow.Cells[0].Value.ToString();
            procesos.cantidad = consultar.CurrentRow.Cells[1].Value.ToString();
            procesos.gastos = consultar.CurrentRow.Cells[2].Value.ToString();
            procesos.precioventa = consultar.CurrentRow.Cells[3].Value.ToString();

            procesos.codigo_articulo = consultar.CurrentRow.Cells[4].Value.ToString();
            procesos.riesgos = consultar.CurrentRow.Cells[5].Value.ToString();
            procesos.precio = consultar.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
