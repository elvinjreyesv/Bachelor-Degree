using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Telerik.Charting;
using Telerik.WinControls.UI;
using Telerik.WinControls.Tests;
using MetroFramework;

namespace WindowsFormsApplication1
{
    public partial class Reportes : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=ELVIN-PC\SQLEXPRESS; Initial Catalog=Proyect_ebanisteria; Integrated security=true;");

        DataSet de = new DataSet();

        string cmd3 = "";

        string cmd4 = "";

        public Reportes()
        {
            InitializeComponent();
        }

        private void cambiar()
        {
            p1.Location = new Point(750,750);
            p1.Size = new Size(0, 0);
            p3.Location = new Point(760, 760);
            p3.Size = new Size(0, 0);
            p4.Location = new Point(770, 770);
            p4.Size = new Size(0, 0);
            p5.Location = new Point(780, 780);
            p5.Size = new Size(0, 0);
            p2.Location = new Point(790,790);
            p2.Size = new Size(0, 0);
        }

        private void invisible()
        {
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            b5.Visible = false;
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

            r1.Size = new Size(377, 359);
            r1.Location = new Point(3,3);

            r2.Size = new Size(325, 216);
            r2.Location = new Point(3, 3);

            r3.Size = new Size(325, 216);
            r3.Location = new Point(3, 3);

            r4.Size = new Size(325, 216);
            r4.Location = new Point(3, 3);

            r5.Size = new Size(325, 216);
            r5.Location = new Point(3, 3);

            p1.Click += metroPanel5_Click;
            p2.Click +=  p2_Click;
            p3.Click += p3_Click;
            p4.Click += p4_Click;
            p5.Click += p5_Click;

        }

        private void prueba()
        {
            this.r3.AreaType = ChartAreaType.Pie;
            PieSeries series = new PieSeries();
            series.DataPoints.Add(new PieDataPoint(50, "2000"));
            series.DataPoints.Add(new PieDataPoint(70, "2003"));
            series.DataPoints.Add(new PieDataPoint(40, "2004"));
            series.DataPoints.Add(new PieDataPoint(25, "2005"));
            series.ShowLabels = true;
            this.r3.Series.Add(series);
            //-----------------------------------------------------
            LineSeries lineSeries = new LineSeries();
            lineSeries.DataPoints.Add(new CategoricalDataPoint(20, "2005"));
            lineSeries.DataPoints.Add(new CategoricalDataPoint(22, "2006"));
            lineSeries.DataPoints.Add(new CategoricalDataPoint(12, "2007"));
            lineSeries.DataPoints.Add(new CategoricalDataPoint(19, "2008"));
            this.r2.Series.Add(lineSeries);

            LineSeries lineSeries2 = new LineSeries();
            lineSeries2.DataPoints.Add(new CategoricalDataPoint(18, "2005"));
            lineSeries2.DataPoints.Add(new CategoricalDataPoint(15, "2006"));
            lineSeries2.DataPoints.Add(new CategoricalDataPoint(17, "2007"));
            lineSeries2.DataPoints.Add(new CategoricalDataPoint(22, "2009"));
            this.r2.Series.Add(lineSeries2);
            //----------------------------------------------------

            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.Name = "Q1";
            barSeries.DataPoints.Add(new CategoricalDataPoint(177, "2009"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(128, "2010"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(143, "2011"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(111, "2012"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(118, "2013"));
            this.r1.Series.Add(barSeries);
            //--------------------------------------------------

            ScatterAreaSeries scatterSeries = new ScatterAreaSeries();
            scatterSeries.DataPoints.Add(new ScatterDataPoint(15, 19));
            scatterSeries.DataPoints.Add(new ScatterDataPoint(18, 10));
            scatterSeries.DataPoints.Add(new ScatterDataPoint(13, 15));
            scatterSeries.DataPoints.Add(new ScatterDataPoint(10, 8));
            scatterSeries.DataPoints.Add(new ScatterDataPoint(5, 2));

            this.r4.Series.Add(scatterSeries);

            ScatterAreaSeries scatterSeries2 = new ScatterAreaSeries();
            scatterSeries2.DataPoints.Add(new ScatterDataPoint(2, 24));
            scatterSeries2.DataPoints.Add(new ScatterDataPoint(7, 12));
            scatterSeries2.DataPoints.Add(new ScatterDataPoint(15, 10));
            scatterSeries2.DataPoints.Add(new ScatterDataPoint(18, 22));
            scatterSeries2.DataPoints.Add(new ScatterDataPoint(19, 19));
            scatterSeries2.Spline = true;
            this.r4.Series.Add(scatterSeries2);

            //----------------------------------------

            this.r5.Series.Clear();
            this.r5.AreaType = ChartAreaType.Pie;
            DonutSeries ser = new DonutSeries();
            ser.DataPoints.Add(new PieDataPoint(50, "2001"));
            ser.DataPoints.Add(new PieDataPoint(70, "2002"));
            ser.DataPoints.Add(new PieDataPoint(40, "2003"));
            ser.DataPoints.Add(new PieDataPoint(25, "2004"));
            ser.ShowLabels = true;
            this.r5.ShowLegend = true;
            this.r5.View.Palette = KnownPalette.Cold;
            this.r5.LegendTitle = "";
          
            this.r5.Series.Add(ser);

        }

        private void otro()
        {
            p1.Location = new Point(30, 16);
            p1.Size = new Size(1045, 550);

            r1.Size = new Size(655, 400);
            r1.Location = new Point(10, 48);

            r2.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);

            p1.Click -= metroPanel5_Click;
        }

        private void otro1()
        {
            p2.Location = new Point(30, 16);
            p2.Size = new Size(1045, 550);

            r2.Size = new  Size(655, 400);
            r2.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);

            p2.Click -= metroPanel5_Click;
        }

        private void otro2()
        {
            p3.Location = new Point(30, 16);
            p3.Size = new Size(1045, 550);

            r3.Size = new Size(655, 400);
            r3.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r2.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);

            p3.Click -= metroPanel5_Click;
        }

        private void otro3()
        {
            p4.Location = new Point(30, 16);
            p4.Size = new Size(1045, 550);

            r4.Size = new Size(655, 400);
            r4.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r2.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);

            p4.Click -= metroPanel5_Click;
        }

        private void otro4()
        {
            p5.Location = new Point(30, 16);
            p5.Size = new Size(1045, 550);

            r5.Size = new Size(655, 400);
            r5.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r2.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);

            p5.Click -= metroPanel5_Click;
        }

        private void colores1()
        {
            v1.Location = new Point(10, 16);
            v1.FontSize = MetroLabelSize.Tall;
            v1.Size = new Size(490,25);
            v1.FontWeight = MetroLabelWeight.Bold;

            l2.BackColor = Color.PaleGreen;
            l1.BackColor = Color.PaleGreen;
            e1.BackColor = Color.PaleGreen;
            e2.BackColor = Color.PaleGreen;
            e3.BackColor = Color.PaleGreen;
            e5.BackColor = Color.PaleGreen;
            e7.BackColor = Color.PaleGreen;
            t1.BackColor = Color.PaleGreen;
            t3.BackColor = Color.PaleGreen;
            t2.BackColor = Color.PaleGreen;
            t5.BackColor = Color.PaleGreen;
            t7.BackColor = Color.PaleGreen;
            c2.BackColor = Color.PaleGreen;
            c3.BackColor = Color.PaleGreen;
            c1.BackColor = Color.PaleGreen;
            c5.BackColor = Color.PaleGreen;
            c7.BackColor = Color.PaleGreen;
        }

        private void colores2()
        {
            v2.Location = new Point(10, 16);
            v2.FontSize = MetroLabelSize.Tall;
            v2.Size = new Size(490, 25);
            v2.FontWeight = MetroLabelWeight.Bold;

            e1.BackColor = Color.LightCyan;
            e2.BackColor = Color.LightCyan;
            e3.BackColor = Color.LightCyan;
            e4.BackColor = Color.LightCyan;
            e5.BackColor = Color.LightCyan;
            e7.BackColor = Color.LightCyan;
            t1.BackColor = Color.LightCyan;
            t3.BackColor = Color.LightCyan;
            t2.BackColor = Color.LightCyan;
            t5.BackColor = Color.LightCyan;
            t4.BackColor = Color.LightCyan;
            t7.BackColor = Color.LightCyan;
            c2.BackColor = Color.LightCyan;
            c3.BackColor = Color.LightCyan;
            c1.BackColor = Color.LightCyan;
            c4.BackColor = Color.LightCyan;
            c5.BackColor = Color.LightCyan;
            c7.BackColor = Color.LightCyan;
            l2.BackColor = Color.LightCyan;
            l1.BackColor = Color.LightCyan;
        }

        private void colores3()
        {
            v3.Location = new Point(10, 16);
            v3.FontSize = MetroLabelSize.Tall;
            v3.Size = new Size(490, 25);
            v3.FontWeight = MetroLabelWeight.Bold;

            e1.BackColor = Color.PaleTurquoise;
            e2.BackColor = Color.PaleTurquoise;
            e3.BackColor = Color.PaleTurquoise;
            e5.BackColor = Color.PaleTurquoise;
            e7.BackColor = Color.PaleTurquoise;
            e8.BackColor = Color.PaleTurquoise;
            t1.BackColor = Color.PaleTurquoise;
            t3.BackColor = Color.PaleTurquoise;
            t2.BackColor = Color.PaleTurquoise;
            t5.BackColor = Color.PaleTurquoise;
            t7.BackColor = Color.PaleTurquoise;
            t8.BackColor = Color.PaleTurquoise;
            c2.BackColor = Color.PaleTurquoise;
            c3.BackColor = Color.PaleTurquoise;
            c1.BackColor = Color.PaleTurquoise;
            c5.BackColor = Color.PaleTurquoise;
            c7.BackColor = Color.PaleTurquoise;
            c8.BackColor = Color.PaleTurquoise;
            l2.BackColor = Color.PaleTurquoise;
            l1.BackColor = Color.PaleTurquoise;
        }

        private void colores4()
        {
            v4.Location = new Point(10, 16);
            v4.FontSize = MetroLabelSize.Tall;
            v4.Size = new Size(490, 25);
            v4.FontWeight = MetroLabelWeight.Bold;

            e1.BackColor = Color.Azure;
            e2.BackColor = Color.Azure;
            e3.BackColor = Color.Azure;
            e5.BackColor = Color.Azure;
            e4.BackColor = Color.Azure;
            e7.BackColor = Color.Azure;
            t1.BackColor = Color.Azure;
            t4.BackColor = Color.Azure;
            t3.BackColor = Color.Azure;
            t2.BackColor = Color.Azure;
            t5.BackColor = Color.Azure;
            t7.BackColor = Color.Azure;
            c2.BackColor = Color.Azure;
            c3.BackColor = Color.Azure;
            c1.BackColor = Color.Azure;
            c4.BackColor = Color.Azure;
            c5.BackColor = Color.Azure;
            c7.BackColor = Color.Azure;
            l2.BackColor = Color.Azure;
            l1.BackColor = Color.Azure;
        }

        private void colores5()
        {
            v5.Location = new Point(10, 16);
            v5.FontSize = MetroLabelSize.Tall;
            v5.Size = new Size(550, 25);
            v5.FontWeight = MetroLabelWeight.Bold;

            e1.BackColor = Color.Gainsboro;
            e2.BackColor = Color.Gainsboro;
            e3.BackColor = Color.Gainsboro;
            e5.BackColor = Color.Gainsboro;
            e7.BackColor = Color.Gainsboro;
            e6.BackColor = Color.Gainsboro;
            t1.BackColor = Color.Gainsboro;
            t3.BackColor = Color.Gainsboro;
            t2.BackColor = Color.Gainsboro;
            t5.BackColor = Color.Gainsboro;
            t7.BackColor = Color.Gainsboro;
            t6.BackColor = Color.Gainsboro;
            c2.BackColor = Color.Gainsboro;
            c3.BackColor = Color.Gainsboro;
            c1.BackColor = Color.Gainsboro;
            c5.BackColor = Color.Gainsboro;
            c7.BackColor = Color.Gainsboro;
            c6.BackColor = Color.Gainsboro;
            l2.BackColor = Color.Gainsboro;
            l1.BackColor = Color.Gainsboro;
        }

        private void cargar()
        {
            
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select descripcion from meses", con);
            da.Fill(ds1);
            c1.DataSource = ds1.Tables[0].DefaultView;
            c1.ValueMember = "descripcion";
            c1.Text = "";
            //--------------------------------
            DataSet ds = new DataSet();
            SqlDataAdapter d1 = new SqlDataAdapter("select descripcion from año", con);
            d1.Fill(ds);
            c2.DataSource = ds.Tables[0].DefaultView;
            c2.ValueMember = "descripcion";
            c2.Text = "";
            //------------------------------
            DataSet d = new DataSet();
            SqlDataAdapter df1 = new SqlDataAdapter("select descripcion from año", con);
            df1.Fill(d);
            c3.DataSource = d.Tables[0].DefaultView;
            c3.ValueMember = "descripcion";
            c3.Text = "";
            //-------------------------

            //--------------------------------
            DataSet ds2 = new DataSet();
            SqlDataAdapter df2 = new SqlDataAdapter("select desmad from madera", con);
            df2.Fill(ds2);
            c4.DataSource = ds2.Tables[0].DefaultView;
            c4.ValueMember = "desmad";
            c4.Text = "";
            //------------------------------
            DataSet de = new DataSet();
            SqlDataAdapter dfg = new SqlDataAdapter("select descripcion,codpro from problemas", con);
            dfg.Fill(de);
            c5.DataSource = de.Tables[0].DefaultView;
            c5.ValueMember = "descripcion";
            c5.Text = "";
            //-------------------------

            //------------------------------
            DataSet de1 = new DataSet();
            SqlDataAdapter dfg1 = new SqlDataAdapter("select desmaq from maquinarias", con);
            dfg1.Fill(de1);
            c6.DataSource = de1.Tables[0].DefaultView;
            c6.ValueMember = "desmaq";
            c6.Text = "";
            //-------------------------

            DataSet de7 = new DataSet();
            SqlDataAdapter dfg7 = new SqlDataAdapter("select distinct(desque) from quejas", con);
            dfg7.Fill(de7);
            c8.DataSource = de7.Tables[0].DefaultView;
            c8.ValueMember = "desque";
            c8.Text = "";
            //-------------------------


            r1.Size = new Size(377, 359);
            r1.Location = new Point(3, 3);


            t1.Checked = true;
            t2.Checked = true;
            t3.Checked = true;
            t4.Checked = true;
            t5.Checked = true;
            t6.Checked = true;
            t7.Checked = false;
            t8.Checked = false;

            p1.Location = new Point(17,16);
            p1.Size = new Size(383, 550);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void metroPanel5_Click(object sender, EventArgs e)
        {
            c4.Visible = false;
            buscar1();
            b1.Location = new Point(10, 458);
            b1.Visible = true;

            m1.Location = new Point(12, 500);
            m1.Visible = true;
           
            //-----------------------
            cambiar();
            otro();
            causas.Location = new Point(711, 47);
            causas.Size = new Size(339,150);
            causas.Visible = true;

            consecuencias.Location = new Point(711, 215);
            consecuencias.Size = new Size(339, 160);
            consecuencias.Visible = true;

            l2.Location = new Point(711, 190);
            l2.Visible = true;

            l1.Location = new Point(711, 16);
            l1.Visible = true;
            //-----------------------------
            e1.Location = new Point(800, 400);
            e1.Visible = true;

            e2.Location = new Point(800, 425);
            e2.Visible = true;

            e3.Location = new Point(800, 450);
            e3.Visible = true;

            e5.Location = new Point(775, 475);
            e5.Visible = true;

            e7.Location = new Point(745, 500);
            e7.Visible = true;

           //------------------------------
            t1.Location = new Point(711, 400);
            t1.Visible = true;

            t3.Location = new Point(711, 425);
            t3.Visible = true;

            t2.Location = new Point(711, 450);
            t2.Visible = true;

            t5.Location = new Point(690, 475);
            t5.Visible = true;

            t7.Location = new Point(650, 500);
            t7.Visible = true;

            //----------------------------

            c2.Location = new Point(900, 395);
            c2.Visible = true;

            c3.Location = new Point(900, 420);
            c3.Visible = true;

            c1.Location = new Point(900, 445);
            c1.Visible = true;

            c5.Location = new Point(850, 470);
            c5.Visible = true;

            c7.Location = new Point(850, 495);
            c7.Visible = true;

            colores1();

        }

        private void p2_Click(object sender, EventArgs e)
        {

            b2.Location = new Point(560, 485);
            b2.Visible = true;
            cambiar();
            
            p2.Location = new Point(30, 16);
            p2.Size = new Size(1045, 550);

            r2.Size = new Size(700, 400);
            r2.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);
            
            //-----------------------------
            e1.Location = new Point(800, 400);
            e1.Visible = true;

            e2.Location = new Point(800, 425);
            e2.Visible = true;

            e3.Location = new Point(800, 450);
            e3.Visible = true;

            e4.Location = new Point(775, 475);
            e4.Visible = true;

            //------------------------------
            t1.Location = new Point(711, 400);
            t1.Visible = true;

            t3.Location = new Point(711, 425);
            t3.Visible = true;

            t2.Location = new Point(711, 450);
            t2.Visible = true;

            t4.Location = new Point(690, 475);
            t4.Visible = true;

            //----------------------------

            c2.Location = new Point(900, 395);
            c2.Visible = true;

            c3.Location = new Point(900, 420);
            c3.Visible = true;

            c1.Location = new Point(900, 445);
            c1.Visible = true;

            c4.Location = new Point(850, 470);
            c4.Visible = true;

            otro1();
            p2.Click -= p2_Click;

            colores2();

        }

        private void p4_Click(object sender, EventArgs e)
        {
            b4.Location = new Point(560, 485);
            b4.Visible = true;
            colores4();
            cambiar();
            p4.Location = new Point(30, 16);
            p4.Size = new Size(1045, 550);

            r4.Size = new Size(700, 400);
            r4.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);
            r2.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);

            p4.Click -= p4_Click;


            //-----------------------------
            e1.Location = new Point(800, 400);
            e1.Visible = true;

            e2.Location = new Point(800, 425);
            e2.Visible = true;

            e3.Location = new Point(800, 450);
            e3.Visible = true;


            //------------------------------
            t1.Location = new Point(711, 400);
            t1.Visible = true;

            t3.Location = new Point(711, 425);
            t3.Visible = true;

            t2.Location = new Point(711, 450);
            t2.Visible = true;

            //----------------------------

            c2.Location = new Point(900, 395);
            c2.Visible = true;

            c3.Location = new Point(900, 420);
            c3.Visible = true;

            c1.Location = new Point(900, 445);
            c1.Visible = true;


            e4.Location = new Point(775, 475);
            e4.Visible = true;

            t4.Location = new Point(690, 475);
            t4.Visible = true;


            c4.Location = new Point(850, 470);
            c4.Visible = true;

            otro3();
            
        }

        private void p3_Click(object sender, EventArgs e)
        {
            c4.Visible = false;
            c6.Visible = false;
            t8.Checked = false;
            b3.Location =new  Point(560, 485);

            b3.Visible = true;
            
            colores3();
            cambiar();
            p3.Location = new Point(30, 16);
            p3.Size = new Size(1045, 550);

            r3.Size = new Size(700, 400);
            r3.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r2.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r5.Size = new Size(1, 1);

            p3.Click -= p3_Click;


            e8.Location = new Point(775, 475);
            e8.Visible = true;

            t8.Location = new Point(690, 475);
            t8.Visible = true;

            c8.Location = new Point(850, 470);
            c8.Visible = true;

            //-----------------------------
            e1.Location = new Point(800, 400);
            e1.Visible = true;

            e2.Location = new Point(800, 425);
            e2.Visible = true;

            e3.Location = new Point(800, 450);
            e3.Visible = true;


            //------------------------------
            t1.Location = new Point(711, 400);
            t1.Visible = true;

            t3.Location = new Point(711, 425);
            t3.Visible = true;

            t2.Location = new Point(711, 450);
            t2.Visible = true;

            //----------------------------

            c2.Location = new Point(900, 395);
            c2.Visible = true;

            c3.Location = new Point(900, 420);
            c3.Visible = true;

            c1.Location = new Point(900, 445);
            c1.Visible = true;

            otro2();
           
        }

        private void p5_Click(object sender, EventArgs e)
        {

            causas.Location = new Point(711, 47);
            causas.Size = new Size(339, 150);
            causas.Visible = true;

            l3.Location = new Point(711, 16);
            l3.Visible = true;

            c4.Visible = false;
            b5.Location = new Point(560, 485);
            b5.Visible = true;
            
            colores5();
            cambiar();
            p5.Location = new Point(30, 16);
            p5.Size = new Size(1045, 550);

            r5.Size = new Size(700, 400);
            r5.Location = new Point(10, 48);

            r1.Size = new Size(1, 1);
            r3.Size = new Size(1, 1);
            r4.Size = new Size(1, 1);
            r2.Size = new Size(1, 1);

            //-----------------------------
            e1.Location = new Point(800, 400);
            e1.Visible = true;

            e2.Location = new Point(800, 425);
            e2.Visible = true;

            e3.Location = new Point(800, 450);
            e3.Visible = true;


            e6.Location = new Point(775, 475);
            e6.Visible = true;

            t6.Location = new Point(690, 475);
            t6.Visible = true;

            c6.Location = new Point(850, 470);
            c6.Visible = true;
            

            //------------------------------
            t1.Location = new Point(711, 400);
            t1.Visible = true;

            t3.Location = new Point(711, 425);
            t3.Visible = true;

            t2.Location = new Point(711, 450);
            t2.Visible = true;

            //----------------------------

            c2.Location = new Point(900, 395);
            c2.Visible = true;

            c3.Location = new Point(900, 420);
            c3.Visible = true;

            c1.Location = new Point(900, 445);
            c1.Visible = true;

            otro4();
            p5.Click -= p5_Click;
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            m1.Visible = false;
            
            c4.Visible = true;
            c6.Visible = false;
            invisible();
            v1.Location = new Point(19, 520);
            v1.FontSize = MetroLabelSize.Medium;
            v1.Size = new Size(325, 25);
            v1.FontWeight = MetroLabelWeight.Light;


            v2.Location = new Point(3, 245);
            v2.FontSize = MetroLabelSize.Medium;
            v2.Size = new Size(325, 25);
            v2.FontWeight = MetroLabelWeight.Light;

            v3.Location = new Point(3, 247);
            v3.FontSize = MetroLabelSize.Medium;
            v3.Size = new Size(325, 25);
            v3.FontWeight = MetroLabelWeight.Light;

            v4.Location = new Point(3, 245);
            v4.FontSize = MetroLabelSize.Medium;
            v4.Size = new Size(325, 25);
            v4.FontWeight = MetroLabelWeight.Light;

            v5.Location = new Point(3, 247);
            v5.FontSize = MetroLabelSize.Medium;
            v5.Size = new Size(325, 25);
            v5.FontWeight = MetroLabelWeight.Light;
            
            devolver();

            causas.Location = new Point(711, 47);
            causas.Size = new Size(1, 1);
            causas.Visible = false;

            consecuencias.Location = new Point(711, 215);
            consecuencias.Size = new Size(1,1);
            consecuencias.Visible = false;

            l2.Location = new Point(711, 190);
            l2.Visible = false;
            l3.Visible = false;

            l1.Location = new Point(711, 16);
            l1.Visible = false;

            e1.Visible = false;
            e2.Visible = false;
            e3.Visible = false;
            e4.Visible = false;
            e5.Visible = false;
            e6.Visible = false;
            e7.Visible = false;
            e8.Visible = false;

            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            t7.Visible = false;
            t8.Visible = false;

            c1.Visible = false;
            c2.Visible = false;
            c4.Visible = false;
            c3.Visible = false;
            c5.Visible = false;
            c7.Visible = false;
            c8.Visible = false;
            

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            cargar();
            t8.Checked = true;
            c7.Enabled = false;
            prueba();

        }

        private void microChart1_Click(object sender, EventArgs e)
        {

        }

        private void r5_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void t1_CheckedChanged(object sender, EventArgs e)
        {
            if (t1.Checked == true)
                c2.Enabled = true;
            else
                c2.Enabled = false;
        }

        private void t2_CheckedChanged(object sender, EventArgs e)
        {
            if (t2.Checked == true)
                c1.Enabled = true;
            else
                c1.Enabled = false;
        }

        private void t3_CheckedChanged(object sender, EventArgs e)
        {
            if (t3.Checked == true)
                c3.Enabled = true;
            else
                c3.Enabled = false;
        }

        private void t4_CheckedChanged(object sender, EventArgs e)
        {
            if (t4.Checked == true)
                c4.Enabled = true;
            else
                c4.Enabled = false;
        }

        private void t5_CheckedChanged(object sender, EventArgs e)
        {
            if (t5.Checked == true)
                c5.Enabled = true;
            else
                c5.Enabled = false;
        }

        private void t6_CheckedChanged(object sender, EventArgs e)
        {
            if (t6.Checked == true)
                c6.Enabled = true;
            else
                c6.Enabled = false;
        }

        private void t7_CheckedChanged(object sender, EventArgs e)
        {
            if (t7.Checked == true)
                c7.Enabled = true;
            else
                c7.Enabled = false;
        }

        private void r3_Click(object sender, EventArgs e)
        {

        }

        private void t1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t1.Checked == true)
                c2.Enabled = true;
            else
                c2.Enabled = false;
        }

        private void t3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t3.Checked == true)
                c3.Enabled = true;
            else
                c3.Enabled = false;
        }

        private void t2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t2.Checked == true)
                c1.Enabled = true;
            else
                c1.Enabled = false;
        }

        private void t4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t4.Checked == true)
                c4.Enabled = true;
            else
                c4.Enabled = false;
        }

        private void t5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t5.Checked == true)
                c5.Enabled = true;
            else
                c5.Enabled = false;
        }

        private void t6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t6.Checked == true)
                c6.Enabled = true;
            else
                c6.Enabled = false;
        }

        private void t7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (t7.Checked == true)
                c7.Enabled = true;
            else
            {
                c7.Enabled = false;
                de.Clear();
                c7.Text = "";
            }
        }

        private void buscar1()
        {
            //causas.Rows.Clear();
            //consecuencias.Rows.Clear();
            //--------------------------

            SqlDataAdapter dfg = new SqlDataAdapter("select alternativa from view_alternativas where problema='" + c5.Text.ToString() + "'", con);
            dfg.Fill(de);
            c7.DataSource = de.Tables[0].DefaultView;
            c7.ValueMember = "alternativa";
            c7.Text = "";
            if (t7.Checked == false)
            {
                de.Clear();
                c7.Text = "";
            }
            //----------------------

            DataSet ds = new DataSet();
            string cmd = "select codcon as Código,consecuencia as Consecuencia from view_problemas where problema='" + c5.Text.ToString() + "' group by consecuencia,codcon";
            ds = Class1.ejecutar(cmd);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                consecuencias.DataSource = ds.Tables[0];
                consecuencias.Columns[1].Width = 350;
            }
            string condi = "";

            //-----------------------
            if (t1.Checked == true)
            {
                condi = condi + " And año >= " + c2.Text + "";
            }

            if (t3.Checked == true)
            {
                condi = condi + " And año <= " + c3.Text + "";
            }
            else
            {
                condi = "";
                condi = condi + " And año = " + c3.Text + "";
            }

            if (t2.Checked == true)
            {
                condi = condi + " And meses = '" + c1.Text + "'";
            }


            DataSet d1 = new DataSet();
            // cmd = "select codcau as Código,causa as Causa,SUM(cantidad)*codcau/9 as Ocurrencia from view_problemas where problema='" + c5.Text.ToString() + "'" + condi + " group by causa,codcau";
            cmd = "select codcau as Código,causa as Causa,SUM(cantidad) as Ocurrencia from view_problemas where problema='" + c5.Text.ToString() + "'" + condi + " group by causa,codcau";

            cmd3 = "select codcau as Código,causa as Causa,SUM(cantidad)*codcau/2 as Ocurrencia from view_problemas where problema='" + c5.Text.ToString() + "'" + condi + " group by causa,codcau";

            cmd4 = "select descripcion,pres_total from view_alternativas_problemas where problema='" + c5.Text.ToString() + "'" + condi + "";

            d1 = Class1.ejecutar(cmd);
            if (d1.Tables.Count > 0 && d1.Tables[0].Rows.Count > 0)
            {
                causas.DataSource = d1.Tables[0];
                causas.Columns[1].Width = 350;
            }
            else
            {
                this.causas.DataSource = null;
                this.causas.Rows.Clear();
                d1.Clear();
                this.r1.Series.Clear();
                DevComponents.DotNetBar.MessageBoxEx.Show("NO HAY DATOS EN LOS PARÁMETROS", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
               
            }

//-------------------------------------------mostrar grafico-------------------------------------------------------------
            DataSet d2 = new DataSet();
            cmd = "select año,meses,SUM(cantidad) as Ocurrencia from view_problemas where problema='" + c5.Text.ToString() + "'" + condi + "  group by año,meses  order by año,meses";
            d2 = Class1.ejecutar(cmd);
            if (d2.Tables.Count > 0 && d2.Tables[0].Rows.Count > 0)
            {
                this.r1.Series.Clear();
                BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
                barSeries.Name = "Q1";

                DataTable dr = d2.Tables[0];
                foreach (DataRow row in dr.Rows)
                {
                    string valor1 = Convert.ToString(row["año"]);
                    int valor2 = Convert.ToInt16(row["Ocurrencia"]);
                    barSeries.DataPoints.Add(new CategoricalDataPoint(valor2, valor1));
                }
                this.r1.Series.Add(barSeries);


            }
//------------------------------------------------------------------------------------------
           
           
        }

        private void Buscar(object sender, EventArgs e)
        {
            buscar1();
        }

        private void buscar4()
        {
            string condi = "";

            //-----------------------
            if (t1.Checked == true)
            {
                condi = condi + " And año >= " + c2.Text + "";
            }

            if (t3.Checked == true)
            {
                condi = condi + " And año <= " + c3.Text + "";
            }
            else
            {
                condi = "";
                condi = condi + " And año = " + c3.Text + "";
            }

            if (t2.Checked == true)
            {
                condi = condi + " And mes = '" + c1.Text + "'";
            }

            if (t4.Checked == true)
            {
                condi = condi + " And madera ='" + c4.Text + "'";
            }


            DataSet d1 = new DataSet();
            string cmd = "select precio,madera,mes,año from view_movimientos  where año>=2000 " + condi + "";
            d1 = Class1.ejecutar(cmd);
            if (d1.Tables.Count > 0 && d1.Tables[0].Rows.Count > 0)
            {
                this.r4.Series.Clear();
                ScatterAreaSeries scatterSeries = new ScatterAreaSeries();
                DataTable dr = d1.Tables[0];
                foreach (DataRow row in dr.Rows)
                {
                    int valor1 = Convert.ToInt16(row["año"]);
                    int valor2 = Convert.ToInt16(row["precio"]);
                    scatterSeries.DataPoints.Add(new ScatterDataPoint(valor1, valor2));
                } 
                scatterSeries.Spline = true;
                this.r4.Series.Add(scatterSeries);
            }
            else
            {
                d1.Clear();
                this.r4.Series.Clear();
                DevComponents.DotNetBar.MessageBoxEx.Show("NO HAY DATOS EN LOS PARÁMETROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            buscar4();
        }

        private void buscar2()
        {

            string condi = "";

            //-----------------------
            if (t1.Checked == true)
            {
                condi = condi + " And año >= " + c2.Text + "";
            }

            if (t3.Checked == true)
            {
                condi = condi + " And año <= " + c3.Text + "";
            }
            else
            {
                condi = "";
                condi = condi + " And año = " + c3.Text + "";
            }

            if (t2.Checked == true)
            {
                condi = condi + " And mes = '" + c1.Text + "'";
            }

            if (t4.Checked == true)
            {
                condi = condi + " And madera ='" + c4.Text + "'";
            }


            DataSet d1 = new DataSet();
            string cmd = "select año,cantidad from view_perdida_madera where año>0 "  + condi + "";
            d1 = Class1.ejecutar(cmd);
            if (d1.Tables.Count > 0 && d1.Tables[0].Rows.Count > 0)
            {
                this.r2.Series.Clear();
                LineSeries lineSeries = new LineSeries();

                DataTable dr = d1.Tables[0];
                foreach (DataRow row in dr.Rows)
                {
                    string valor1 = Convert.ToString(row["año"]);
                    int valor2 = Convert.ToInt16(row["cantidad"]);
                    lineSeries.DataPoints.Add(new CategoricalDataPoint(valor2, valor1));
                }
                this.r2.Series.Add(lineSeries);
            }
            else
            {
                d1.Clear();
                this.r2.Series.Clear();
                DevComponents.DotNetBar.MessageBoxEx.Show("NO HAY DATOS EN LOS PARÁMETROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
        }

        private void b2_Click(object sender, EventArgs e)
        {
            buscar2();
        }

        private void buscar5()
        {
            string condi = "";

            //-----------------------
            if (t1.Checked == true)
            {
                condi = condi + " And año >= " + c2.Text + "";
            }

            if (t3.Checked == true)
            {
                condi = condi + " And año <= " + c3.Text + "";
            }
            else
            {
                condi = "";
                condi = condi + " And año = " + c3.Text + "";
            }

            if (t2.Checked == true)
            {
                condi = condi + " And mes = '" + c1.Text + "'";
            }

            if (t6.Checked == true)
            {
                condi = condi + " And desmaq ='" + c6.Text + "'";
            }


            DataSet d1 = new DataSet();
            string cmd = "select año as Año,codmaq as Código,desmaq as Maquinaria,sum(maquinaria) as Presupuesto,sum(gasto) as Gasto, sum(maquinaria)-sum(gasto) as Restante from view_reparacion where idano>0 " + condi + " group by desmaq,codmaq,Año";
           
            d1 = Class1.ejecutar(cmd);
            if (d1.Tables.Count > 0 && d1.Tables[0].Rows.Count > 0)
            {

                causas.DataSource = d1.Tables[0];
              //  causas.Columns[1].Width = 350;

                this.r5.Series.Clear();
                this.r5.AreaType = ChartAreaType.Pie;
                DonutSeries ser = new DonutSeries();
                ser.ShowLabels = true;
                this.r5.ShowLegend = true;
                this.r5.ShowGrid = true;
                this.r5.View.Palette = KnownPalette.Cold;
                this.r5.LegendTitle = "";

                DataTable dr = d1.Tables[0];
                foreach (DataRow row in dr.Rows)
                {
                    
                    string valor1 = Convert.ToString(row["Año"]);
                    int valor2 = Convert.ToInt32(row["Gasto"]);
                    ser.DataPoints.Add(new PieDataPoint(valor2, valor1));
                }
                this.r5.Series.Add(ser);
            }
            else
            {
                this.causas.DataSource = null;
                this.causas.Rows.Clear();
                d1.Clear();

                d1.Clear();
                this.r5.Series.Clear();
                DevComponents.DotNetBar.MessageBoxEx.Show("NO HAY DATOS EN LOS PARÁMETROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            buscar5();
          //  buscar6();
        }

        private void buscar3()
        {
            string condi = "";

            //-----------------------
            if (t1.Checked == true)
            {
                condi = condi + " And año >= " + c2.Text + "";
            }

            if (t3.Checked == true)
            {
                condi = condi + " And año <= " + c3.Text + "";
            }
            else
            {
                condi = "";
                condi = condi + " And año = " + c3.Text + "";
            }

            if (t2.Checked == true)
            {
                condi = condi + " And mes = '" + c1.Text + "'";
            }

            if (t8.Checked == true)
            {
                condi = condi + " And queja ='" + c8.Text + "'";
            }


            DataSet d1 = new DataSet();
            string cmd = "select distinct(queja),año,sum(cantidad) as cantidad from view_quejas where idano>0 " + condi + " group by queja,año";
            d1 = Class1.ejecutar(cmd);
            if (d1.Tables.Count > 0 && d1.Tables[0].Rows.Count > 0)
            {
                this.r3.Series.Clear();
                this.r3.AreaType = ChartAreaType.Pie;
                PieSeries series = new PieSeries();

                DataTable dr = d1.Tables[0];
                foreach (DataRow row in dr.Rows)
                {
                    string valor1 = Convert.ToString(row["queja"]);
                    int valor2 = Convert.ToInt16(row["cantidad"]);
                    series.DataPoints.Add(new PieDataPoint(valor2, valor1));
                }
                series.ShowLabels = true;
                this.r3.ShowLegend = true;
                this.r3.View.Palette = KnownPalette.Metro;
                this.r3.Series.Add(series);
            }
            else
            {
                d1.Clear();
                this.r3.Series.Clear();
                DevComponents.DotNetBar.MessageBoxEx.Show("NO HAY DATOS EN LOS PARÁMETROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
 
        }

        private void b3_Click(object sender, EventArgs e)
        {
            buscar3();
        }

        private void t8_CheckedChanged(object sender, EventArgs e)
        {
            if (t8.Checked == true)
                c8.Enabled = true;
            else
                c8.Enabled = false;
        }

        private void m1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(cmd3,cmd4);
            f.ShowDialog();
        }

    }
}
