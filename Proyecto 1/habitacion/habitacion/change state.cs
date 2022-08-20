using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace habitacion
{
    public partial class change_state : Form
    {
        public change_state()
        {
            InitializeComponent();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(codhab.Text.Trim()))
                {
                    MessageBox.Show("EL CAMPO DE CODIGO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                    codhab.Focus();
                    return;

                }
                if (string.IsNullOrEmpty(estado.Text.Trim()))
                {
                    MessageBox.Show("EL CAMPO DE ESTADO ESTA VACIO,PARA CONTINUAR DEBE LLENAR ESTE ESPACIO");
                    estado.Focus();
                    return;
                }

                else
                {
                    try
                    {
                        string cmd = "update habitacion set estado='" + estado.Text +"', " + "codest='"+ codest.Text + "' where codhab='" + codhab.Text + "'";
                        utilidades.UTILIDADES.ejecutar(cmd);
                       // MessageBox.Show(cmd);
                        procesos.descripcion =  "select codhab as [Codigo], descriphab as [Descripcion],precio as [Precio],codest as[Codigo_Estado],estado as [Estado],descriptem as[Tematica],descripcion as [Tipo_habitacion] from habitacion";
                        codhab.Text = "";
                        estado.Text = "";
                        codest.Text = "";
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }
                }
            }

        private void salir_Click(object sender, EventArgs e)
        {
                this.Hide();
        }

        private void change_state_Load(object sender, EventArgs e)
        {
          
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select codhab from habitacion", con);
                da.Fill(ds);
                codhab.DataSource = ds.Tables[0].DefaultView;
                codhab.ValueMember = "codhab";
                codhab.Text = "";
            }
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select estado from estado", con);
                da.Fill(ds);
                estado.DataSource = ds.Tables[0].DefaultView;
                estado.ValueMember = "estado";
                estado.Text = "";
            }
            {
                SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=cabanas; Integrated security=true;");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select codest from estado", con);
                da.Fill(ds);
                codest.DataSource = ds.Tables[0].DefaultView;
                codest.ValueMember = "codest";
                codest.Text = "";
            }
            codhab.Select();
        }

        private void codhab_Validating(object sender, CancelEventArgs e)
        {
        }

        private void codest_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = " ";
            int cod = 0;
            if (string.IsNullOrEmpty(codest.Text.Trim()))
            {
                cmd = "select max(codest)as mayor from estado";
                ds = utilidades.UTILIDADES.ejecutar(cmd);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int m = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                    cod = 1 + m; codest.Text = cod.ToString();
                }
            }
            cmd = "select * from estado where codest=" + codest.Text.Trim();
            ds = utilidades.UTILIDADES.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //  codtem.Text = Convert.ToString(ds.Tables[0].Rows[0]["codtem"]);
                estado.Text = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);

            }
        }

        private void codhab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void codest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
                e.Handled = false;
            else
                if (e.KeyChar == ' ')
                    e.Handled = false;
                else
                    e.Handled = true;
        }
    }
}
