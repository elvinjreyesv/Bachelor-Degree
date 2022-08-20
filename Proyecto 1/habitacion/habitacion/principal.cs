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
    public partial class principal : Form
    {
        private int childFormNumber = 0;

        public principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tematica temat = new tematica();
            temat.ShowDialog();
            temat.Dispose();
            
            // temat.MdiParent = this;
            //temat.Show();
        }

        private void pRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            productos pro = new productos();
            pro.ShowDialog();
            pro.Dispose();
        }

        private void tIPODEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_productos tip = new tipo_productos();
            tip.ShowDialog();
            tip.Dispose();
        }

        private void habitacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            habitacion hab = new habitacion();
           hab.ShowDialog();
            hab.Dispose();
        }

        private void tipoDeHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_habitacion tih = new tipo_habitacion();
            tih.ShowDialog();
            tih.Dispose();
        }

        private void tipoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_empleado tiph = new tipo_empleado();
            tiph.ShowDialog();
            tiph.Dispose();
        }

        private void tipoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_cliente tcli = new tipo_cliente();
            tcli.ShowDialog();
            tcli.Dispose();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clientes cli = new clientes();
            cli.ShowDialog();
            cli.Dispose();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            empleados emp = new empleados();
            emp.ShowDialog();
            emp.Dispose();
        }

        private void facturacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            facturacion fact = new facturacion();
            fact.ShowDialog();
            fact.Dispose();
        }

        private void registrarUsusariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrar_usuarios reg = new registrar_usuarios();
            reg.ShowDialog();
            reg.Dispose();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservaciones res = new reservaciones();
            res.ShowDialog();
            res.Dispose();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void actualizarEstadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            change_state cs = new change_state();
            cs.ShowDialog();
            cs.Dispose();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado est = new estado();
            est.ShowDialog();
            est.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REALMENTE DESEA SALIR? ", " PRINCIPAL ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cmd = "exec actualizaraudit '" +( procesos.usuario )+ "','" +Convert.ToDateTime( procesos.fechain) + "','" +Convert.ToDateTime( System.DateTime.Now) + "'";
                utilidades.UTILIDADES.ejecutar(cmd);
                Application.Exit();
                Application.Exit();
                Application.Exit();
                Application.Exit();
            }
            Application.Exit();
            Application.Exit();
            Application.Exit();
            Application.Exit();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            usuarios us = new usuarios();
            us.ShowDialog();
            us.Dispose();
            tipotranscurrido.Enabled = true;
            mensajes.Text = "";
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            suplidores sup = new suplidores();
            sup.ShowDialog();
            sup.Dispose();
        }

        private void tipoDeSuplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_proveedor tpr = new tipo_proveedor();
            tpr.ShowDialog();
            tpr.Dispose();
            
        }

        private void estadiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_de_estadia ties = new tipo_de_estadia();
            ties.ShowDialog();
            ties.Dispose();
        }

        private void tipotranscurrido_Tick(object sender, EventArgs e)
        {
            //@codhab int,@codigo int,@horaentrada time,@horatranscurrida time,@horasalida time
            string cmd = "select h.codhab as[Codigo],c.codigo as[Cliente],o.horaentrada as[Entrada],o.horatranscurrida as [Transcurrido],o.horasalida as [Salida] from ocupadas o inner join habitacion h on h.codhab=o.codhab inner join cliente c on c.codigo=o.codigo";
            DataSet ds = new DataSet();
            int cod = 3;
            string est = "limpieza";
            try
            {
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                consultaocupadas.DataSource = ds.Tables[0];
                consultaocupadas.ClearSelection();
            }
            catch { }

            foreach (DataGridViewRow dr in consultaocupadas.Rows)
                
            {
                dr.DefaultCellStyle.BackColor = Color.OrangeRed;
                string n1 = dr.Cells[3].Value.ToString();
                string n2 = dr.Cells[4].Value.ToString();
                DateTime n3 = Convert.ToDateTime(dr.Cells[3].Value.ToString());
                DateTime n4 = Convert.ToDateTime(dr.Cells[4].Value.ToString());
                if (n1 == n2 || n3 > n4)
                {
                    mensajes.Text += "LA HABITACION " + dr.Cells[0].Value + " HA CONCLUIDO SU TIEMPO";
                    mensajes.Text += "\r\n";
                    cmd = "delete from ocupadas where codhab='" + dr.Cells[0].Value + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);
                   //cmd = "update  habitacion set codest='3',estado='limpieza' where codhab='" + dr.Cells[0].Value + "'";
                    cmd = "update habitacion set estado='" + est + "', " + "codest='" + cod + "' where codhab='" + dr.Cells[0].Value + "'";
                    utilidades.UTILIDADES.ejecutar(cmd);

                }
                else
                {

                    cmd = "update ocupadas set horatranscurrida='" + DateTime.Now.ToString("HH:mm:ss ").Trim() + "' where codhab=" + Convert.ToInt16(dr.Cells[0].Value);
                    utilidades.UTILIDADES.ejecutar(cmd);
                }
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            mensajes.Clear();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_auditoria ra = new reporte_auditoria();
            ra.ShowDialog();
            ra.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_cliente rc = new reporte_cliente();
            rc.ShowDialog();
            rc.Dispose();
        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reporte_empleados re = new reporte_empleados();
            re.ShowDialog();
            re.Dispose();
        }

        private void estadiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte_estadia ree = new reporte_estadia();
            ree.ShowDialog();
            ree.Dispose();
        }

        private void estadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte_estado er = new reporte_estado();
            er.ShowDialog();
            er.Dispose();
        }

        private void habitacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reporte_habitac rh = new reporte_habitac();
            rh.ShowDialog();
            rh.Dispose();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reporte_productos rp= new reporte_productos();
            rp.ShowDialog();
            rp.Dispose();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_proveedor rpp = new reporte_proveedor();
           rpp.ShowDialog();
            rpp.Dispose();
        }

        private void tematicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_tematica rt = new reporte_tematica();
            rt.ShowDialog();
            rt.Dispose();
        }

        private void tipoDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_tipoclient rti = new reporte_tipoclient();
            rti.ShowDialog();
            rti.Dispose();
        }

        private void tipoDeEmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte_tipoemp rte = new reporte_tipoemp();
            rte.ShowDialog();
            rte.Dispose();
        }

        private void tipoDeHabitacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte_tipohabit rth = new reporte_tipohabit();
            rth.ShowDialog();
            rth.Dispose();
        }

        private void tipoDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte_tipoproduct rtp = new reporte_tipoproduct();
            rtp.ShowDialog();
            rtp.Dispose();
        }

        private void tipoDeSuplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte_tiposupli rts = new reporte_tiposupli();
            rts.ShowDialog();
            rts.Dispose();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_usuarios ru = new reporte_usuarios();
            ru.ShowDialog();
            ru.Dispose();
        }

        private void habitacionesFacturadasHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_facturas2 rl = new reporte_facturas2();
            rl.ShowDialog();
            rl.Dispose();
        }

        private void productosFacturadosHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte_facturadetalle rs = new reporte_facturadetalle();
            rs.ShowDialog();
            rs.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
