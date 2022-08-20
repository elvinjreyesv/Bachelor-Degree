using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.ProviderBase;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Class1
    {

        public static void imprimir(ReportDocument nombre_reporte, DataSet dataset_reporte, string Tabla, string Consulta)
        {

            string datosconect = "";

            if (File.Exists(@"C:\conexion\conexion.txt"))
                datosconect = File.ReadAllText(@"C:\conexion\conexion.txt");
            SqlDataAdapter dapter = new SqlDataAdapter(Consulta, datosconect);
            dapter.Fill(dataset_reporte, Tabla);// nombre de la tabla del dataset
            nombre_reporte.SetDataSource(dataset_reporte);
            mostrar contenedor = new mostrar();
            contenedor.documento.ReportSource = nombre_reporte;
            contenedor.ShowDialog();
        }

        public static void imprimir1(ReportDocument nombre_reporte, DataSet dataset_reporte, string Tabla, string Consulta,CrystalReportViewer df)
        {
            string datosconect = "";
            if (File.Exists(@"C:\conexion\conexion.txt"))
                datosconect = File.ReadAllText(@"C:\conexion\conexion.txt");
            SqlDataAdapter dapter = new SqlDataAdapter(Consulta, datosconect);
            dapter.Fill(dataset_reporte, Tabla);// nombre de la tabla del dataset
            nombre_reporte.SetDataSource(dataset_reporte);
         
            df.ReportSource = nombre_reporte;
            //   Reportes rep = new Reportes();
            //  rep.r1.ReportSource = nombre_reporte; 
           
        }

        public static string ejecuta(string cmd)
        {
            SqlConnection con = new SqlConnection();
            string cs = cmd;

            try
            {
                con.ConnectionString = cs;
                con.Open();
                return "conexión exitosa : " + con.Database;
            }

            catch
            {
                return "conexión fallida. Inténtelo nuevamente";
            }
        }

        public static string cs = @"server=ELVIN-PC; initial catalog=ebanisteria; integrated security=true;";

        public static DataSet ejecutar(string cmd)
        {
            DataSet ds = new DataSet();

            try
            {

                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                da.Fill(ds);
                con.Close();
            }
          //  catch { }
            catch (SqlException e)
            {
               
               // MessageBox.Show(e.ToString());
            }
            return ds;

        }

    }
}