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
    public partial class comp_seguro : MetroForm
    {
        public comp_seguro()
        {
            InitializeComponent();
        }

        int est = 0;

        private void nuevos()
        {
            codcom.Text="";
            nom_com.Text="";
            dir_com.Text="";
            telcom.Text="";
            email.Text="";
            comentario.Text="";
            estado.Checked=false;

            codigo_mayor();
            cambia_estado();
        }

        private void codigo_mayor()
        {
            string cmdd = "select max (codcom+1) as Mayor from comp_seg";
            DataSet ds = utilidades.UTILIDADES.ejecutar(cmdd);
            string numfac = ds.Tables[0].Rows[0]["Mayor"].ToString();
            codcom.Text = numfac;
            nom_com.Select();
        }

        public void ejecutar(string dato)
        {
            codcom.Text = dato;
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
            nom_com.Enabled = false;
            telcom.Enabled = false;
            email.Enabled = false;
            dir_com.Enabled = false;
            comentario.Enabled = false;
            codcom.Enabled = false;
            estado.Enabled = false;
            activar2.Enabled = true;
        }

        private void cambia_estado()
        {
            salvar.Enabled = true;
            nom_com.Enabled = true;
            telcom.Enabled = true;
            email.Enabled = true;
            dir_com.Enabled = true;
            comentario.Enabled = true;
            codcom.Enabled = true;
            estado.Enabled = true;
        }

        private void validating()
        {
            DataSet ds = new DataSet();
            string cmd = "select * from comp_seg where codcom='" + codcom.Text.Trim() + "'";
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nom_com.Text = Convert.ToString(ds.Tables[0].Rows[0]["nom_con"]);
                telcom.Text = Convert.ToString(ds.Tables[0].Rows[0]["telcom"]);
                email.Text = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
                dir_com.Text = Convert.ToString(ds.Tables[0].Rows[0]["dircom"]);
                comentario.Text = Convert.ToString(ds.Tables[0].Rows[0]["comentario"]);
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
            }
            else
            {
                codigo_mayor();

                nom_com.Text = "";
                dir_com.Text = "";
                telcom.Text = "";
                email.Text = "";
                comentario.Text = "";
                estado.Checked = false;
            }

            if (estado.Checked == false && nom_com.Text != "")
            {
                valida_estado();
            }

        }

        private void busca()
        {
            proceso.titulo = "Compañía de Seguros";
            proceso.query = "select codcom as 'Codigo', nom_con as 'Descripcion' from comp_seg where estado=1";
            proceso.query_cod = "select codcom as 'Codigo', nom_con as 'Descripcion' from comp_seg where estado=1 and codcom";
            proceso.query_desc = "select codcom as 'Codigo', nom_con as 'Descripcion' from comp_seg where estado=1 and nom_con ";
        }

        private void comp_seguro_Load(object sender, EventArgs e)
        {
            codigo_mayor();
            activar();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevos();
            codigo_mayor();
            activar();
            salvar.Enabled = false;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telcom_TextChanged(object sender, EventArgs e)
        {
            if (nom_com.Text.Trim() != "" || dir_com.Text.Trim() != "" || telcom.Text.Trim() != "" || email.Text.Trim() != "" || comentario.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void comp_seguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            busca();
            consultas.tipo form2 = new consultas.tipo();
            form2.pasado += new consultas.tipo.pasar(ejecutar);
            form2.ShowDialog();
        }

        private void codcom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (estado.Checked == true)
                est = 1;
            else
                est = 0;

            if (string.IsNullOrEmpty(nom_com.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nom_com.Focus();
                return;
            }
            else
                if (string.IsNullOrEmpty(dir_com.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dir_com.Focus();
                    return;
                }
                else
                    if (string.IsNullOrEmpty(telcom.Text.Trim()))
                    {
                        MetroMessageBox.Show(this, "Valores no válidos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        telcom.Focus();
                        return;
                    }
            else
            {
                try
                {

                    string cmd = "exec act_compseg '" + codcom.Text + "','" + nom_com.Text + "','" + dir_com.Text + "','" + telcom.Text + "','" + email.Text + "','" + comentario.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "'";
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

        private void codcom_Validating(object sender, CancelEventArgs e)
        {
            validating();
        }

        private void activar2_Click(object sender, EventArgs e)
        {
            est = 1;
            estado.Checked = true;

            string cmd = "exec act_compseg '" + codcom.Text + "','" + nom_com.Text + "','" + dir_com.Text + "','" + telcom.Text + "','" + email.Text + "','" + comentario.Text + "','" + DateTime.Now.ToShortDateString() + "','" + est + "'";
            utilidades.UTILIDADES.ejecutar(cmd);
            cambia_estado();
        }

        private void nom_com_TextChanged(object sender, EventArgs e)
        {
            if (nom_com.Text.Trim() != "" || dir_com.Text.Trim() != "" || telcom.Text.Trim() != "" || email.Text.Trim() != "" || comentario.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (nom_com.Text.Trim() != "" || dir_com.Text.Trim() != "" || telcom.Text.Trim() != "" || email.Text.Trim() != "" || comentario.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void dir_com_TextChanged(object sender, EventArgs e)
        {
            if (nom_com.Text.Trim() != "" || dir_com.Text.Trim() != "" || telcom.Text.Trim() != "" || email.Text.Trim() != "" || comentario.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void comentario_TextChanged(object sender, EventArgs e)
        {
            if (nom_com.Text.Trim() != "" || dir_com.Text.Trim() != "" || telcom.Text.Trim() != "" || email.Text.Trim() != "" || comentario.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }

        private void estado_Click(object sender, EventArgs e)
        {
            if (nom_com.Text.Trim() != "" || dir_com.Text.Trim() != "" || telcom.Text.Trim() != "" || email.Text.Trim() != "" || comentario.Text.Trim() != "" || estado.Checked == true)
            {
                desactivar();
            }
            else
            {
                activar();
            }
        }
    }
}
