using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace net.Admin
{
    public partial class bsl : System.Web.UI.Page
    {

        ConnectToSql conn = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void tdl()
        {
            int[] z = new int[99];
            int[] x = new int[99];
            int[] y = new int[99];
            string[] a = new string[99];
            int t = 1;
            cmd.CommandText = "select itemid from [Master].[Item]";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                z[t] = Convert.ToInt32(row[0]);
                t++;
            }
            
            for(int i = 1; i <= t; i++)
            {
                cmd.CommandText = "SELECT [Quantity],[Total]FROM [order].[OrderDetails] where ItemId= " + z[i].ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                conn.OpenConn();
                sda = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);
                x[z[i]] = 0;
                y[z[i]] = 0;
                foreach (DataRow row in dt2.Rows)
                {
                    int p = Convert.ToInt32(row[0]);
                    int q = Convert.ToInt32(row[1]);
                    x[z[i]] = x[z[i]] + p;
                    y[z[i]] = y[z[i]] + q;
                }
            }

            for(int i = 1; i < t; i++)
            {
                for(int j = i+1; j <= t; j++)
                {
                    if( x[z[i]] < x[z[j]])
                    {
                        int c;
                        c = z[i];
                        z[i] = z[j];
                        z[j] = c;
                    }
                }
            }

            for (int i = 1; i <= t; i++)
            {
                cmd.CommandText = "select itemname, ItemPirce from [Master].[Item] where itemid=" + z[i].ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                conn.OpenConn();
                sda = new SqlDataAdapter(cmd);
                DataTable dt3 = new DataTable();
                sda.Fill(dt3);
                foreach(DataRow row in dt3.Rows)
                a[i] = "itemID= " + z[i].ToString() + " ItemName= " + row[0].ToString() + " price= " + row[1].ToString() + " tổng số lượng bán ra= " + x[z[i]].ToString() + " tổng doanh thu= " + y[z[i]].ToString() + "\n";
            }

            string message = String.Join(" ", a);
            TextBox1.Text = message;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tdl();
        }
    }
}