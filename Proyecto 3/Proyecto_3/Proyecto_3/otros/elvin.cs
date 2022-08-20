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

namespace Proyecto_3.otros
{
    public partial class elvin : Form
    {

        string nombre = "";
        string telefono = "";
        string direccion = "";


        public elvin()
        {
            InitializeComponent();
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
        }

        private void elvin_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(MdiClient))
                {
                    ctl.BackColor = Color.White;
                }
            }

           ninguno.Select();
           ninguno.Focus();
           inicial();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.almacen al = new inv.mantenimientos.almacen();
            al.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            metroContextMenu_inv.Show(inventario, new Point(0, inventario.Height));
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

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Deseas salir del sistema", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
                Application.Exit();
                Application.Exit();
            }
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // inv.mantenimientos.almacen a = new inv.mantenimientos.almacen();
          //  a.Show();

            inv.mantenimientos.almacen a = new inv.mantenimientos.almacen();
            a.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.articulos ar = new inv.mantenimientos.articulos();
            ar.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.departamentos dep = new inv.mantenimientos.departamentos();
            dep.Show();
        }

        private void compañíasDeSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.comp_seguro comp = new inv.mantenimientos.comp_seguro();
            comp.Show();
        }

        private void fallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.fallas fall = new inv.mantenimientos.fallas();
            fall.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.marca mar = new inv.mantenimientos.marca();
            mar.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.modelo mod = new inv.mantenimientos.modelo();
            mod.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.provincia pro = new inv.mantenimientos.provincia();
            pro.Show();
        }

        private void tiposDeVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.tipos_vehiculos tip = new inv.mantenimientos.tipos_vehiculos();
            tip.Show();
        }

        private void tiposDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.familia_art fam = new inv.mantenimientos.familia_art();
            fam.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.unidades un = new inv.mantenimientos.unidades();
            un.Show();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.mantenimientos.vehiculos veh = new inv.mantenimientos.vehiculos();
            veh.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           // cxc2.mantenimientos.clientes cli = new cxc2.mantenimientos.clientes();
           // cli.Show();
        }

        private void porcientosDeDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // cxc2.mantenimientos.descuento des = new cxc2.mantenimientos.descuento();
          //  des.Show();
        }

        private void condicionesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   cxc2.mantenimientos.condiciones_pago con = new cxc2.mantenimientos.condiciones_pago();
           // con.Show();
        }

        private void tiposDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // cxc2.mantenimientos.tipo_cliente tc = new cxc2.mantenimientos.tipo_cliente();
           // tc.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.cotizacion co = new inv.procesos.cotizacion();
            co.Show();
        }

        private void diagnósticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.diagnostico di = new inv.procesos.diagnostico();
            di.Show();
        }

        private void entradasAlTallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.entrada_talle ent = new inv.procesos.entrada_talle();
            ent.Show();
        }

        private void factufaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.facturacion fact = new inv.procesos.facturacion();
            fact.Show();
        }

        private void inventarioInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.recibos_ingresos inv = new inv.procesos.recibos_ingresos();
            inv.Show();
        }

        private void precupuestoDeReparaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.presupuesto_reparacion pre = new inv.procesos.presupuesto_reparacion();
            pre.Show();
        }

        private void salidaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inv.procesos.salida_vehiculos sal = new inv.procesos.salida_vehiculos();
            sal.Show();
        }

        private void historialDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.mantenimientos.suplidor sup = new cxp2.mantenimientos.suplidor();
            sup.Show();
        }

        private void tipoDeSuplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.mantenimientos.tipos_suplidores tsup = new cxp2.mantenimientos.tipos_suplidores();
            tsup.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.compras com = new cxp2.procesos.compras();
            com.Show();
        }

        private void devolucionesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.notadc dcom = new cxp2.procesos.notadc();
            dcom.Show();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  cxp2.procesos.egresos eg = new cxp2.procesos.egresos();
          //  eg.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  cxp2.procesos.gastos ga = new cxp2.procesos.gastos();
          //  ga.Show();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   cxp2.procesos.movimientos mov = new cxp2.procesos.movimientos();
          //  mov.Show();
        }

        private void ordénesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.ordenes ord = new cxp2.procesos.ordenes();
            ord.Show();
        }

        private void pagosDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxp2.procesos.pagos pag = new cxp2.procesos.pagos();
            pag.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            nomina.mantenimientos.empleados emp = new nomina.mantenimientos.empleados();
            emp.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nomina.mantenimientos.usuarios usu = new nomina.mantenimientos.usuarios();
            usu.Show();
        }

        private void secuenciaDeNCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ncf.secuencias_ncf sn = new ncf.secuencias_ncf();
            sn.Show();
        }

        private void nCFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ncf.ncf_general ncf = new ncf.ncf_general();
            ncf.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuraciones.configuracion co = new configuraciones.configuracion();
            co.Show();
        }

        private void configuracionGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuraciones.configuracion conf = new configuraciones.configuracion();
            conf.Show();
        }

        private void permisos_Click(object sender, EventArgs e)
        {
            permisos per = new permisos();
            per.Show();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   prueba p = new prueba();
          //  p.Show(this);
        }
    }
}
