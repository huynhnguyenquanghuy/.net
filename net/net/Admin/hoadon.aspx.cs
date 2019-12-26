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
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataView dvitem;
        ConnectToSql conn = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter sda;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                BindData();
            }
        }
        private void BindData()
        {
            cmd.CommandText = "select * from hoadon";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dvitem = dt.DefaultView;
            grvitem.DataSource = dvitem;
            grvitem.DataBind();
            Session["TaskTable"] = dt;
        }
        private void BindData(String x)
        {
            cmd.CommandText = "select * from hoadon where datecre BETWEEN '" + x + " 00:00:00' AND '" + x + " 23:59:59'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dvitem = dt.DefaultView;
            grvitem.DataSource = dvitem;
            grvitem.DataBind();
            Session["TaskTable"] = dt;
        }
        protected void btnadd_Click(object sender, EventArgs e)
        {
            
            
                BindData(txtiname.Text);
            
        }

        protected void btnt_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}