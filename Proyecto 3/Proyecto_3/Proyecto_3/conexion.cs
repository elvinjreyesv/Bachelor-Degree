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
        public static string key = "mikey";

        public static string Encriptar(string texto)
        {

            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }

        public static string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(textoEncriptado);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
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

        public static string cs = @"server=ELVIN-PC; initial catalog=taller; integrated security=true;";

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
                MessageBox.Show(e.ToString());
            }
            return ds;

        }

    }
}
