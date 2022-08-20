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
    public partial class vehiculos : MetroForm
    {
        public vehiculos()
        {
            InitializeComponent();
        }

        private void valor_form()
        {
            if (proceso.vehiculo != "")
            {
                cod_veh.Text = proceso.vehiculo;

            }
            else 
            {
                codigo_mayor();
            }
        }

        public void ejecutar_veh(string dato)
        {
            cod_veh.Text = dato;
            valida_vehiculo();
        }

        private void valida_vehiculo()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from vehiculo where cod_veh='" + cod_veh.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                detalles.Text = Convert.ToString(ds.Tables[0].Rows[0]["detalles"]);
            }
            else
            {
                cod_veh.Text = "";
                detalles.Text = "";
            }
        }

        private void busca()
        {
            proceso.titulo = "Vehículos";
            proceso.query = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1";
            proceso.query_cod = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh";
            proceso.query_desc = "select veh.cod_veh as 'Codigo', veh.detalles as 'Descripcion' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca where veh.estado=1 and veh.detalles ";
            proceso.query2 = "select distinct ma.descripcion as 'Marca',model.descripcion as 'Modelo',veh.motor as 'Motor', comentario as 'Comentario' from vehiculo as veh inner join marca as ma on veh.cod_marca=ma.cod_marca inner join modelo as model on model.cod_marca=ma.cod_marca where veh.estado=1 and veh.cod_veh= ";
        }

        private void nuevos()
        {
           
               cod_veh.Text = "";
                detalles.Text = "";
                cod_marca.Text = "";
                des_marca.Text="";
                des_modelo.Text="";
               // des_codcom.Text="";
                cod_modelo.Text = "";
                estado.Checked = false;
                comentario.Text = "";
                ano.Text = "";
                motor.Text = "";
                combustible.Text = "";
                tipo_veh.Text = "";
                num_placa.Text = "";
                color.Text = "";
                // codcom.Text="";

                 codcli.Text = "";
                 nomcli.Text = "";
                 cedcli.Text = "";
                 telcli.Text = "";
                 celcli.Text = "";
                 dircli.Text = "";
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (cod_veh+1) as Mayor from vehiculo";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            cod_veh.Text = numfac;
            detalles.Select();
        }

        public void ejecutar(string dato)
        {
            cod_veh.Text = dato;
            validating();
        }

        private void activar()
        {
            nuevo.Enabled = false;
            activar2.Enabled = false;
            salvar.Enabled = false;
        }

        private void desactivar()
        {
            nuevo.Enabled = true;
            salvar.Enabled = true;
        }

        private void valida_estado()
        {
            salvar.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
            cod_veh.Enabled = false;
            detalles.Enabled = false;
            cod_marca.Enabled = false;
            des_marca.Enabled = false;
            des_modelo.Enabled = false;
            //des_codcom.Enabled = false;
            cod_modelo.Enabled = false;
            estado.Enabled = false;
            comentario.Enabled = false;
            ano.Enabled = false;
            motor.Enabled = false;
            combustible.Enabled = false;
            tipo_veh.Enabled = false;
            num_placa.Enabled = false;
            color.Enabled = false;
            //codcom.Enabled = false;
            codcli.Enabled = false;
            nomcli.Enabled = false;
            cedcli.Enabled = false;
            telcli.Enabled = false;
            celcli.Enabled = false;
            dircli.Enabled = false;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            estado.Enabled = true;

            cod_veh.Enabled = true;
            detalles.Enabled = true;
            cod_marca.Enabled = true;
            des_marca.Enabled = true;
            des_modelo.Enabled = true;
            //des_codcom.Enabled = true;
            cod_modelo.Enabled = true;
            comentario.Enabled = true;
            ano.Enabled = true;
            motor.Enabled = true;
            combustible.Enabled = true;
            tipo_veh.Enabled = true;
            num_placa.Enabled = true;
            color.Enabled = true;
            //codcom.Enabled = true;
            codcli.Enabled = true;
            nomcli.Enabled = true;
            cedcli.Enabled = true;
            telcli.Enabled = true;
            celcli.Enabled = true;
            dircli.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from vehiculo where cod_veh='" + cod_veh.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                detalles.Text = Convert.ToString(ds.Tables[0].Rows[0]["detalles"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);

                string ma = Convert.ToString(ds.Tables[0].Rows[0]["cod_marca"]);

                cod_modelo.Text = Convert.ToString(ds.Tables[0].Rows[0]["cod_modelo"]);
                cod_marca.Text= Convert.ToString(ds.Tables[0].Rows[0]["cod_marca"]);
                //valid
               string mo = Convert.ToString(ds.Tables[0].Rows[0]["cod_modelo"]);
                comentario.Text = Convert.ToString(ds.Tables[0].Rows[0]["comentario"]);
                ano.Text = Convert.ToString(ds.Tables[0].Rows[0]["ano"]);
                motor.Text = Convert.ToString(ds.Tables[0].Rows[0]["motor"]);
                combustible.Text = Convert.ToString(ds.Tables[0].Rows[0]["combustible"]);
                tipo_veh.Text = Convert.ToString(ds.Tables[0].Rows[0]["tipo_veh"]);
                num_placa.Text = Convert.ToString(ds.Tables[0].Rows[0]["num_placa"]);
                color.Text = Convert.ToString(ds.Tables[0].Rows[0]["color"]);
                //.Text = Convert.ToString(ds.Tables[0].Rows[0]["codcli"]);

                validating_marca();
                vali();
            /*    string cmdd = "select * from marca where cod_marca='"+ma+"'";
                DataSet ds1 = utilidades.UTILIDADES.ejecutar(cmdd);
                des_marca.Text = ds1.Tables[0].Rows[0]["descripcion"].ToString();

                string cmdd3 = "select descripcion  from modelo where cod_modelo='"+mo+"'";
                DataSet ds2 = utilidades.UTILIDADES.ejecutar(cmdd3);
                des_modelo.Text = ds2.Tables[0].Rows[0]["descripcion"].ToString();*/
            }
            else
            {
                codigo_mayor();

                cod_veh.Text = "";
                detalles.Text = "";
                cod_marca.Text = "";
                des_marca.Text = "";
                des_modelo.Text = "";
                //des_codcom.Text = "";
                cod_modelo.Text = "";
                estado.Checked = false;
                comentario.Text = "";
                ano.Text = "";
                motor.Text = "";
                combustible.Text = "";
                tipo_veh.Text = "";
                num_placa.Text = "";
                color.Text = "";
                //codcom.Text = "";
                codcli.Text = "";
                nomcli.Text = "";
                cedcli.Text = "";
                telcli.Text = "";
                celcli.Text = "";
                dircli.Text = "";

                /*  cod_marca.Text != ""
                    des_marca.Text != ""
                
                     cod_modelo.Text != ""
                     comentario.Text != ""
                    ano.Text != ""
                    motor.Text != ""
                     num_placa.Text != ""
                    color.Text != ""
                    codcom.Text != ""
                    codcli.Text != ""
                     */
            }

            if (estado.Checked == false && detalles.Text != "")
            {
                valida_estado();
            }

        }

        private void vehiculos_Load(object sender, EventArgs e)
        {
            valor_form();
            codigo_mayor();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codigo_mayor();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void busca_vehiculo_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_veh);
            form2.ShowDialog();
        }

        private void busca_mod()
        {
            proceso.titulo = "Modelos";
            proceso.query = "select cod_modelo as 'Codigo', descripcion as 'Descripcion' from modelo where estado=1";
            proceso.query_cod = "select cod_modelo  as 'Codigo', descripcion as 'Descripcion' from modelo where estado=1 and cod_modelo ";
            proceso.query_desc = "select cod_modelo  as 'Codigo', descripcion as 'Descripcion' from modelo where estado=1 and descripcion ";

            proceso.query2 = "select cod_modelo  as 'Codigo', descripcion as 'Descripcion' from modelo where estado=5 and cod_modelo=";
        }

        public void ejecutar_mod(string dato)
        {
            cod_modelo.Text = dato;
            vali();
        }

        private void vali()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from modelo where cod_modelo='" + cod_modelo.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_modelo.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        private void validating_marca()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from marca where cod_marca='" + cod_marca.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                des_marca.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            }
        }

        public void ejecutar_ma(string dato)
        {
            cod_marca.Text = dato;
            validating_marca();
        }

        private void busca_ma()
        {
            proceso.titulo = "Marcas";
            proceso.query = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1";
            proceso.query_cod = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and cod_marca";
            proceso.query_desc = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and descripcion ";
            proceso.query2 = "select cod_marca as 'Codigo', descripcion as 'Descripcion' from marca where estado=1 and cod_marca=";
        }

        private void busca_marca_Click(object sender, EventArgs e)
        {
            busca_ma();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_ma);
            form2.ShowDialog();
        }

        private void busca_modelo_Click(object sender, EventArgs e)
        {
            busca_mod();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar_mod);
            form2.ShowDialog();
        }

        private void busca_marca_Validating(object sender, CancelEventArgs e)
        {
            validating_marca();
        }

        private void cod_marca_Validating(object sender, CancelEventArgs e)
        {
            validating_marca();
        }

        private void cod_modelo_Validating(object sender, CancelEventArgs e)
        {
            vali();
        }

        private void cod_marca_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cod_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void ano_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            
            int est;

            //if (estado.Checked == true)
                est = 1;
         //   else
           //     est = 0;

            if (string.IsNullOrEmpty(detalles.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                detalles.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_marca.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_marca.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cod_modelo.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod_modelo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(motor.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                motor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ano.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ano.Focus();
                return;
            }

            else
            {
                try
                {

                    //@cod_veh ,@fec_reg ,@detalles,@cod_marca ,@cod_modelo ,@estado ,@comentario ,@ano ,@motor,@combustible ,@tipo_veh,@num_placa ,@color ,@codcom
                    string cmd = "exec act_vehiculos '" + cod_veh.Text + "','" + DateTime.Now.ToShortDateString() + "','" + detalles.Text + "','" + cod_marca.Text + "','" + cod_modelo.Text + "','" + est + "','" + comentario.Text + "','" + ano.Text + "','" + motor.Text + "','" + combustible.Text + "','" + tipo_veh.Text + "','" + num_placa.Text + "','" + color.Text + "','" + 1 + "'";
                  
                    utilidades.UTILIDADES.ejecutar(cmd);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                nuevos();
                codigo_mayor();

            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cod_veh_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }
    }
}
