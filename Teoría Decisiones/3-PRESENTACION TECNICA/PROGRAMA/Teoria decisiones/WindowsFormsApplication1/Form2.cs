using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Telerik.Charting;
using Telerik.WinControls.UI;
using Telerik.WinControls.Tests;

namespace WindowsFormsApplication1
{
    public partial class Form2 : DevComponents.DotNetBar.Metro.MetroForm
    {

        string valor = "";
        string valorj = "";

        public Form2(string elvin,string elvin2)
        {
            valor = elvin;
            valorj = elvin2;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DataSet d1 = Class1.ejecutar(valor);
            if (d1.Tables.Count > 0 && d1.Tables[0].Rows.Count > 0)
            {
                this.r1.Series.Clear();
                this.r1.AreaType = ChartAreaType.Pie;
                PieSeries series = new PieSeries();

                DataTable dr = d1.Tables[0];
                foreach (DataRow row in dr.Rows)
                {
                    string valor1 = Convert.ToString(row["Causa"]);
                    int valor2 = Convert.ToInt16(row["Ocurrencia"]);
                    series.DataPoints.Add(new PieDataPoint(valor2, valor1));
                }
                series.ShowLabels = true;
                this.r1.ShowLegend = true;
                this.r1.View.Palette = KnownPalette.Metro;
                this.r1.Series.Add(series);
            }

            DataSet d2 = Class1.ejecutar(valorj);
            if (d2.Tables.Count > 0 && d2.Tables[0].Rows.Count > 0)
            {
                this.r2.Series.Clear();
                this.r2.AreaType = ChartAreaType.Pie;
                PieSeries series = new PieSeries();

                DataTable dr1 = d2.Tables[0];
                foreach (DataRow row in dr1.Rows)
                {

                    //descripcion,pres_total
                    string valor1 = Convert.ToString(row["descripcion"]);
                    int valor2 = Convert.ToInt32(row["pres_total"]);
                    series.DataPoints.Add(new PieDataPoint(valor2, valor1));
                }
                series.ShowLabels = true;
                this.r2.ShowLegend = true;
                this.r2.View.Palette = KnownPalette.Spring;
                this.r2.Series.Add(series);
            }
        }

        private void e1_Click(object sender, EventArgs e)
        {

        }
    }
}