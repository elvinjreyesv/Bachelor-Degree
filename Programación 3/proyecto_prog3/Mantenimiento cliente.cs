using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto_prog3
{
    public partial class Mantenimiento_cliente : Form
    {
        public Mantenimiento_cliente()
        {
            InitializeComponent();
        }

        private void Mantenimiento_cliente_Load(object sender, EventArgs e)
        {

        }
        //check
        private void checkcliente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcliente.Checked == true)
            {
                checkcliente.Text = "Activado";
            }
            else
            {
                checkcliente.Text = "Desactivado";
            }
        }
        //guardar
        private void bcguardar_Click(object sender, EventArgs e)
        {
            string tb = "Clientes";
            string camp = "(Cod_cli,Nombre_cliente,Status)";
            string v = txtcodcli.Text + ",'" + txtnomcli.Text + "'," + (checkcliente.Checked ? 1 : 0);
            //conectarme.guardar(tb, camp, v);
            Utilidades.metodos.guardar(tb, camp, v);
            MessageBox.Show("Cliente guardado");

            if (camp == txtcodcli.Text)
            {
                MessageBox.Show("Cliente existe, digite uno nuevo");
                Close();
            }
            txtcodcli.Text = "";
            txtnomcli.Text = "";
            checkcliente.Text = "";
        }

        private void bcconsultar_Click(object sender, EventArgs e)
        {
            consultar_clientes cc = new consultar_clientes();
            cc.ShowDialog();

        }
        //actualizar
        private void bcactualizar_Click(object sender, EventArgs e)
        {

            string tb = "Clientes";
            string camp = "Nombre_cliente='" + txtnomcli.Text + "',Status=" + (checkcliente.Checked ? 1 : 0);
            string codcli = "Cod_cli";
            string cod = txtcodcli.Text;
            Utilidades.metodos.actualizar(tb, camp, codcli, cod);

            //check();
            // Utilidades.metodos.eliminar();
            // limpiar();
        }

        private void bceliminar_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Estas Seguro De Eliminar El Cliente " + txtnomcli.Text + "?", "Información",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            switch (msj)
            {
                case DialogResult.OK:
                    string tabla = "Clientes";
                    string codcli = "Cod_cli";
                    string cod = txtnomcli.Text;

                    Utilidades.metodos.eliminar(tabla, codcli, cod);

                    //limpiar();
                    //check();
                    break;
            }
        }

        private void bcsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
