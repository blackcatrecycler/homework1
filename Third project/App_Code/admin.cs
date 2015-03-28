using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace God_admin
{
    public class admin
    {
        static string str = @"Data Source=(localdb)\v11.0; Initial Catalog=blog; User ID=sa;Password=sa";

        public static DataSet DataS(string Finselect)                       //返回DataSet
        {
            SqlConnection conn = new SqlConnection(str);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Finselect);
                SqlDataAdapter da = new SqlDataAdapter(Finselect, conn);
                da.Fill(ds);
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public static int In(string help)                            //增 删 改
        {
            SqlConnection conn = new SqlConnection(str);
            int result = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(help, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static DataTable DataT(string Finselect)                       //返回DataTable
        {
            SqlConnection conn = new SqlConnection(str);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Finselect);
                SqlDataAdapter da = new SqlDataAdapter(Finselect, conn);
                da.Fill(dt);
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static string TextC(string str)
        {
            str = str.Replace("<", "<");
            str = str.Replace(">", ">");
            str = str.Replace("'", "''");
            str = str.Replace("\r\n", "<br />");
            str = str.Replace(" ", " ");
            str = str.Replace(">", ">");
            str = str.Replace("<", "<");
            str = str.Trim();
            return str;
        }
    }
}
