using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.ProviderBase;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Media;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;


namespace utilidades
{
    public class UTILIDADES
    {
        public static string cs = @"server=ELVIN-PC; initial catalog=repuesto; integrated security=true;";
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
            catch (SqlException e)
            {
               // MessageBox.Show(e.ToString());
            }
            return ds;

        }

    }
}
