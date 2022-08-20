using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

using MetroFramework;
using MetroFramework.Forms;
public class ClienteRepository
{
    public static DataTable GetCliente()
    {
        using ( SqlConnection cn = new SqlConnection(@"Data Source=ELVIN-PC; Initial Catalog=taller; Integrated security=true;"))
        {
            cn.Open();
            using (SqlCommand cmd = cn.CreateCommand())
            {
                cmd.CommandText = "select cod_alm as 'Código',descrip as 'Descripción' from almacen";

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}