using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mantenimientos.sesion log = new mantenimientos.sesion();
            log.ShowDialog();

            label2.Text = prcesos.usuario;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void recepcion_Click(object sender, EventArgs e)
        {
            recepcion re = new recepcion();
            re.ShowDialog();
            re.Dispose();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.almacen al = new mantenimientos.almacen();
            al.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.articulos art = new mantenimientos.articulos();
            art.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " PRINCIPAL ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.clientes cli = new mantenimientos.clientes();
            cli.ShowDialog();
        }

        private void dEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.departamentos dep = new mantenimientos.departamentos();
            dep.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.empresa em = new mantenimientos.empresa();
            em.ShowDialog();
        }

        private void suplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.suplidor sup = new mantenimientos.suplidor();
            sup.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.empleados emp = new mantenimientos.empleados();
            emp.ShowDialog();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.vehiculos ve = new mantenimientos.vehiculos();
            ve.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.usuarios us = new mantenimientos.usuarios();
            us.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.compras co = new mantenimientos.compras();
            co.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.estado est = new mantenimientos.estado();
            est.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.cotizacion cot = new Procesos.cotizacion();
            cot.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.categoria cat = new mantenimientos.categoria();
            cat.ShowDialog();
        }

        private void itbisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.itbis it = new mantenimientos.itbis();
            it.ShowDialog();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.gastos ga = new mantenimientos.gastos();
            ga.ShowDialog();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.cxc cxc = new Procesos.cxc();
            cxc.ShowDialog();
        }

        private void devolucionSobreComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.devolucion_c dc = new Procesos.devolucion_c();
            dc.ShowDialog();
        }

        private void devolucionSobreVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.devolucion_v dv = new Procesos.devolucion_v();
            dv.ShowDialog();
        }

        private void cierreDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.factura fac = new Procesos.factura();
            fac.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mantenimientos.trabajos tr = new mantenimientos.trabajos();
            tr.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.marca ma = new mantenimientos.marca();
            ma.ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.modelo mo = new mantenimientos.modelo();
            mo.ShowDialog();
        }

        private void cuentasPorCobrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Procesos.cxp cxp = new Procesos.cxp();
            cxp.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.factura rf = new Reportes.factura();
            rf.ShowDialog();
        }

        private void datosDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.datos_sesiones dat = new Reportes.datos_sesiones();
            dat.ShowDialog();
        }

        private void cuentasPorPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.cxp rcxp = new Reportes.cxp();
            rcxp.ShowDialog();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.cxc rcxc = new Reportes.cxc();
            rcxc.ShowDialog();
        }

        private void cierreDeCajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.cierre_caja rcc = new Reportes.cierre_caja();
            rcc.ShowDialog();
        }

        private void recepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.recepciones rr = new Reportes.recepciones();
            rr.ShowDialog();
        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.trab_pend rt = new Reportes.trab_pend();
            rt.ShowDialog();
        }

        private void cotizacionesLlevadasAFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.cot_fact rcf = new Reportes.cot_fact();
            rcf.ShowDialog();
        }

        private void listadoDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.list_fact rl = new Reportes.list_fact();
            rl.ShowDialog();
        }

        private void reparacionesDelDiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.reparac_dia rrd = new Reportes.reparac_dia();
            rrd.ShowDialog();
        }

        private void trabajosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.trab_term rtt = new Reportes.trab_term();
            rtt.ShowDialog();
        }

        private void trabajosEvaluadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.trab_eval rte = new Reportes.trab_eval();
            rte.ShowDialog();
        }

        private void trabajosCotizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.trab_cot rtc = new Reportes.trab_cot();
            rtc.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultas.consult_cli cc= new consultas.consult_cli();
            cc.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.empleados ce = new consultas.empleados();
            ce.ShowDialog();
        }

        private void almacenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultas.almacen ca = new consultas.almacen();
            ca.ShowDialog();
        }

        private void suplidorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultas.suplidor cs = new consultas.suplidor();
            cs.ShowDialog();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultas.compras ccc = new consultas.compras();
            ccc.ShowDialog();
        }

        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultas.trabajos_re ctr = new consultas.trabajos_re();
            ctr.ShowDialog();
        }

        private void trabajosPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.trabajos_pen ctp = new consultas.trabajos_pen();
            ctp.ShowDialog();
        }

        private void ventasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.ventas_dia cv = new consultas.ventas_dia();
            cv.ShowDialog();
        }

        private void pagoDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.pago_imp cpi = new consultas.pago_imp();
            cpi.ShowDialog();
        }

        private void devolucionesSobreVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.dev_v cd = new consultas.dev_v();
            cd.ShowDialog();
        }

        private void devolucionesSobreComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.dev_c cdc = new consultas.dev_c();
            cdc.ShowDialog();
        }

        private void cuentasPorCobrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultas.cxc ccc = new consultas.cxc();
            ccc.ShowDialog();
        }

        private void cuentasPorPagarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultas.cxp ccp = new consultas.cxp();
            ccp.ShowDialog();
        }

        private void cierreDeCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultas.cierre_caja ccj = new consultas.cierre_caja();
            ccj.ShowDialog();
        }

        private void reparacionesDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultas.reparac_dia crd = new consultas.reparac_dia();
            crd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mantenimientos.reparacion mr = new mantenimientos.reparacion();
            mr.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mantenimientos.cierre_caja mcc = new mantenimientos.cierre_caja();
            mcc.ShowDialog();
        }

        private void noVaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientos.sesion se = new mantenimientos.sesion();
            se.ShowDialog();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajustesDeInvetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cierreDeCajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}