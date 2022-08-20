using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //inv.mantenimientos.almacen   cxp2.procesos.pagos inv.mantenimientos.articulos   inv.reportes.detalle_ventas cxc2.procesos.recibos_ingresos  cxc2.procesos.recibos_ingresos
        }
    }
}
