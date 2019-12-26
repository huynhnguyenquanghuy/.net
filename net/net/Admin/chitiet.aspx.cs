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
    public partial class chitiet : System.Web.UI.Page
    {

        ConnectToSql conn = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda;
        string tenmon;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            tdl();
        }

        public void tdl()
        {
            int x = 1;
            string[] a=new string[99];

            cmd.CommandText = "select orderdate from [order].[Order] where orderid = "+Session["idorder"];
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Label2.Text = "time: " + dt.Rows[0][0].ToString();
            Label1.Text = "orderid: " + Session["idorder"];

            cmd.CommandText = "SELECT [ItemId],[Price],[Quantity],[Discount],[Total]FROM [order].[OrderDetails] where orderid =" + Session["idorder"];
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            sda = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            
            foreach (DataRow row in dt2.Rows)
            {
                
                cmd.CommandText = "SELECT [ItemName]FROM [Master].[Item] where itemid =" + row[0].ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                conn.OpenConn();
                sda = new SqlDataAdapter(cmd);
                DataTable dt3 = new DataTable();
                sda.Fill(dt3);
                tenmon = dt3.Rows[0][0].ToString();

                a[x] = "id iteam= "+row[0].ToString()+" name item= "+tenmon+" price= "+row[1].ToString() + " quantyti= "+row[2].ToString() + " dicount= "+row[3].ToString() + " total= "+row[4].ToString()+"\n";
                x++;
            }
            string message = String.Join(" ", a);
            TextBox1.Text = message;
        }
    }
}