using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class consultas : UserControl
    {
        public consultas()
        {
            InitializeComponent();
        }

        private void cambiar()
        {
            p1.Location = new Point(750, 750);
            p1.Size = new Size(0, 0);
            p3.Location = new Point(760, 760);
            p3.Size = new Size(0, 0);
            p4.Location = new Point(770, 770);
            p4.Size = new Size(0, 0);
            p5.Location = new Point(780, 780);
            p5.Size = new Size(0, 0);
            p2.Location = new Point(790, 790);
            p2.Size = new Size(0, 0);
        }

        private void devolver()
        {
            p1.Location = new Point(17, 16);
            p1.Size = new Size(383, 549);
            p2.Location = new Point(406, 16);
            p2.Size = new Size(331, 272);
            p3.Location = new Point(406, 293);
            p3.Size = new Size(331, 272);
            p4.Location = new Point(743, 16);
            p4.Size = new Size(331, 272);
            p5.Location = new Point(743, 293);
            p5.Size = new Size(331, 272);

            p1.Click += p1_Click_1;
            p2.Click += p2_Click_1;
            p3.Click += p3_Click_1;
            p4.Click += p4_Click_1;
            p5.Click += p5_Click_1;

        }

        private void consultas_Click(object sender, EventArgs e)
        {
            devolver();
            consultas s = new consultas();
            s.InitLayout();
            s.Click -= consultas_Click;
        }

        private void p1_Click_1(object sender, EventArgs e)
        {
            cambiar();

            p1.Location = new Point(30, 16);
            p1.Size = new Size(1045, 550);

            p1.Click -= p1_Click_1;
            p2.Click += p2_Click_1;
            p3.Click += p3_Click_1;
            p4.Click += p4_Click_1;
            p5.Click += p5_Click_1;
            consultas s = new consultas();
            s.Click += consultas_Click;
        }

        private void p2_Click_1(object sender, EventArgs e)
        {

            cambiar();
            p2.Location = new Point(30, 16);
            p2.Size = new Size(1045, 550);

            p2.Click -= p2_Click_1;

            p1.Click += p1_Click_1;
            p3.Click += p3_Click_1;
            p4.Click += p4_Click_1;
            p5.Click += p5_Click_1;
            consultas s = new consultas();
            s.Click += consultas_Click;
        }

        private void p3_Click_1(object sender, EventArgs e)
        {
            cambiar();
            p3.Location = new Point(30, 16);
            p3.Size = new Size(1045, 550);

            p3.Click -= p3_Click_1;

            p2.Click += p2_Click_1;
            p1.Click += p1_Click_1;
            p4.Click += p4_Click_1;
            p5.Click += p5_Click_1;
            consultas s = new consultas();
            s.Click += consultas_Click;
        }

        private void p4_Click_1(object sender, EventArgs e)
        {
            cambiar();
            p4.Location = new Point(30, 16);
            p4.Size = new Size(1045, 550);

            p4.Click -= p4_Click_1;

            p2.Click += p2_Click_1;
            p3.Click += p3_Click_1;
            p1.Click += p1_Click_1;
            p5.Click += p5_Click_1;
            consultas s = new consultas();
            s.Click += consultas_Click;
        }

        private void p5_Click_1(object sender, EventArgs e)
        {
            cambiar();
            p5.Location = new Point(30, 16);
            p5.Size = new Size(1045, 550);

            p5.Click -= p5_Click_1;

            p2.Click += p2_Click_1;
            p3.Click += p3_Click_1;
            p4.Click += p4_Click_1;
            p1.Click += p1_Click_1;
            consultas s = new consultas();
            s.Click += consultas_Click;
        }

        private void consultas_Load(object sender, EventArgs e)
        {

        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
