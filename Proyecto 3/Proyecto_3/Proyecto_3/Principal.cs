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
using siempreEncima_cs.elGuille.Util;

namespace Proyecto_3
{
    public partial class Principal : MetroForm
    {
        string nombre = "";
        string telefono = "";
        string direccion = "";

        public Principal()
        {
            InitializeComponent();

          //  this.ShowInTaskbar = true;
        }


        private void desabilitar()
        {
           
            //  menuItem1.Enabled = false;
          //  menuItem1.Visible = false;
        }

        private void inicial()
        {
            string cmdd = "select * from empresa";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
            telefono = ds.Tables[0].Rows[0]["tel_emp"].ToString();
            direccion = ds.Tables[0].Rows[0]["dir_emp"].ToString();

            nom.Text = nombre;
            tel.Text = telefono;
            dir.Text = direccion;
          
            usuario.Text = proceso.nombre;


            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.White;
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ninguno.Select();
            ninguno.Focus();

            inicial();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroContextMenu_inv.Show(ninguno, new Point(0, ninguno.Height));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           // metroContextMenu3.Show(metroButton3, new Point(0, metroButton3.Height));
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
             if ( MetroMessageBox.Show(this, "Deseas salir del sistema", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
             {
                  this.Close();
                  Application.Exit();
                  Application.Exit();
                  Application.Exit();
             }
        }

        private void Principal_Load_1(object sender, EventArgs e)
        {
            inicial();

         
         // login log = new login();
          // log.ShowDialog(this);

            ninguno.Select();
            ninguno.Focus();

            
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            metroContextMenu_inv.Show(inventario, new Point(0, inventario.Height));
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void cxc_Click(object sender, EventArgs e)
        {
            metroContextMenu_cxc.Show(cxc, new Point(0, cxc.Height));
        }

        private void cxp_Click(object sender, EventArgs e)
        {
            metroContextMenu_cxp.Show(cxp, new Point(0, cxp.Height));
        }

        private void nomina_Click(object sender, EventArgs e)
        {
            metroContextMenu_nom.Show(nomina, new Point(0, nomina.Height));
        }

        private void ncf_Click(object sender, EventArgs e)
        {
            metroContextMenu_ncf.Show(ncf, new Point(0, ncf.Height));
        }

        private void conf_Click(object sender, EventArgs e)
        {
            metroContextMenu_conf.Show(conf, new Point(0, conf.Height));
        }

        private void permisosAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            permisos per = new permisos();
            per.Show();
        }

        private void devolucionesSobreComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compañíasDeSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.comp_seguro comp = new inv.mantenimientos.comp_seguro();
            comp.MdiParent = this;
            comp.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            inv.mantenimientos.almacen a = new inv.mantenimientos.almacen();
            a.MdiParent = this;
            a.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.articulos ar = new inv.mantenimientos.articulos();
            ar.MdiParent = this;
            ar.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.departamentos dep = new inv.mantenimientos.departamentos();
           dep.MdiParent = this;
            dep.Show();
        }

        private void fallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.fallas fall = new inv.mantenimientos.fallas();
            fall.MdiParent = this;
            fall.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.marca mar = new inv.mantenimientos.marca();
           mar.MdiParent = this;
            mar.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.modelo mod = new inv.mantenimientos.modelo();
            mod.MdiParent = this;
            mod.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.provincia pro = new inv.mantenimientos.provincia();
            pro.MdiParent = this;
            pro.Show();
        }

        private void tiposDeVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.tipos_vehiculos tip = new inv.mantenimientos.tipos_vehiculos();
            tip.MdiParent = this;
            tip.Show();
        }

        private void tiposDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.familia_art fam = new inv.mantenimientos.familia_art();
            fam.MdiParent = this;
            fam.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.unidades un = new inv.mantenimientos.unidades();
            un.MdiParent = this;
            un.Show();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.vehiculos veh = new inv.mantenimientos.vehiculos();
            veh.MdiParent = this;
            veh.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.cotizacion co = new inv.procesos.cotizacion();
           co.MdiParent = this;
            co.Show();
        }

        private void diagnósticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.diagnostico di = new inv.procesos.diagnostico();
            di.MdiParent = this;
            di.Show();
        }

        private void entradasAlTallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.entrada_talle ent = new inv.procesos.entrada_talle();
            ent.MdiParent = this;
            ent.Show();
        }

        private void factufaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.facturacion fact = new inv.procesos.facturacion();
            fact.MdiParent = this;
            fact.Show();
        }

        private void inventarioInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.recibos_ingresos inv = new inv.procesos.recibos_ingresos();
           inv.MdiParent = this;
            inv.Show();
        }

        private void precupuestoDeReparaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.presupuesto_reparacion pre = new inv.procesos.presupuesto_reparacion();
            pre.MdiParent = this;
            pre.Show();
        }

        private void salidaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.salida_vehiculos sal = new inv.procesos.salida_vehiculos();
            sal.MdiParent = this;
            sal.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
          //  cxc2.mantenimientos.clientes cli = new cxc2.mantenimientos.clientes();
            //cli.MdiParent = this;
           // cli.Show();
        }

        private void porcientosDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cxc2.mantenimientos.descuento des = new cxc2.mantenimientos.descuento();
           // des.MdiParent = this;
          //  des.Show();
        }

        private void condicionesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // cxc2.mantenimientos.condiciones_pago con = new cxc2.mantenimientos.condiciones_pago();
           // con.MdiParent = this;
           // con.Show();
        }

        private void tiposDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cxc2.mantenimientos.tipo_cliente tc = new cxc2.mantenimientos.tipo_cliente();
            //tc.MdiParent = this;
           // tc.Show();
        }

        private void cobrosDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.procesos.recibos_ingresos cobf = new cxc2.procesos.recibos_ingresos();
            cobf.MdiParent = this;
            cobf.Show();
        }

        private void cobrosAdelantadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.procesos.notadc cob = new cxc2.procesos.notadc();
            cob.MdiParent = this;
            cob.Show();
        }

        private void devolucionesDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.procesos.registros_facturas dev = new cxc2.procesos.registros_facturas();
           dev.MdiParent = this;
            dev.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.reportes.rep_recibo_ing cpc = new cxc2.reportes.rep_recibo_ing();
            cpc.MdiParent = this;
            cpc.Show();
        }

        private void suplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.mantenimientos.suplidor sup = new cxp2.mantenimientos.suplidor();
           sup.MdiParent = this;
            sup.Show();
        }

        private void tipoDeSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.mantenimientos.tipos_suplidores tsup = new cxp2.mantenimientos.tipos_suplidores();
           tsup.MdiParent = this;
            tsup.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.compras com = new cxp2.procesos.compras();
            com.MdiParent = this;
            com.Show();
        }

        private void devolucionesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.notadc dcom = new cxp2.procesos.notadc();
            dcom.MdiParent = this;
            dcom.Show();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.pagos eg = new cxp2.procesos.pagos();
            eg.MdiParent = this;
            eg.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.registros_fact ga = new cxp2.procesos.registros_fact();
          ga.MdiParent = this;
            ga.Show();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // cxp2.procesos.movimientos mov = new cxp2.procesos.movimientos();
           // mov.MdiParent = this;
           // mov.Show();
        }

        private void ordénesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.ordenes ord = new cxp2.procesos.ordenes();
           ord.MdiParent = this;
            ord.Show();
        }

        private void pagosDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.pagos pag = new cxp2.procesos.pagos();
           pag.MdiParent = this;
            pag.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            nomina.mantenimientos.empleados emp = new nomina.mantenimientos.empleados();
            emp.MdiParent = this;
            emp.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nomina.mantenimientos.usuarios usu = new nomina.mantenimientos.usuarios();
            usu.MdiParent = this;
            usu.Show();
        }

        private void secuenciaDeNCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ncf.secuencias_ncf sn = new ncf.secuencias_ncf();
            sn.MdiParent = this;
            sn.Show();
        }

        private void nCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ncf.ncf_general ncf = new ncf.ncf_general();
           ncf.MdiParent = this;
            ncf.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuraciones.configuracion co = new configuraciones.configuracion();
            co.MdiParent = this;
            co.Show();
        }

        private void configuracionGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuraciones.configuracion conf = new configuraciones.configuracion();
           conf.MdiParent = this;
            conf.Show();
        }

        private void dddToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void elvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void entrada_Click(object sender, EventArgs e)
        {
            inv.procesos.entrada_talle ent = new inv.procesos.entrada_talle();
            ent.MdiParent = this;
            ent.Show();
        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {
            inv.procesos.presupuesto_reparacion ent = new inv.procesos.presupuesto_reparacion();
            ent.MdiParent = this;
            ent.Show();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            inv.procesos.facturacion ent = new inv.procesos.facturacion();
            ent.MdiParent = this;
            ent.Show();
        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void tel_Click(object sender, EventArgs e)
        {

        }

        private void dir_Click(object sender, EventArgs e)
        {

        }

        private void historialDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.reportes.detalle_ventas ncf = new inv.reportes.detalle_ventas();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void recibosDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.con_cxc.consulta_recibos ncf = new cxc2.con_cxc.consulta_recibos();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void registroDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.reportes.rep_registro_facturas ncf = new cxc2.reportes.rep_registro_facturas();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void notasDebitoCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxc2.reportes.repnotdebcrecxp ncf = new cxc2.reportes.repnotdebcrecxp();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // cxp2.reportes.compra ncf = new cxp2.reportes.compra();
           // ncf.MdiParent = this;
           // ncf.Show();
        }

        private void pagosDeFacturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cxp2.reportes.dos ncf = new cxp2.reportes.dos();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void notasDebitoCreditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cxp2.reportes.notadebcrerep ncf = new cxp2.reportes.notadebcrerep();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void registroDeFacturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cxp2.reportes.registro_fact ncf = new cxp2.reportes.registro_fact();
            ncf.MdiParent = this;
            ncf.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.consultas_fact.consulta_factura ncf = new inv.consultas_fact.consulta_factura();
            ncf.MdiParent = this;
            ncf.Show();
        }
    }
}
