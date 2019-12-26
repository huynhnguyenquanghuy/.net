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
    public partial class logon : System.Web.UI.Page
    {
        DataView dvitem;
        ConnectToSql conn = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        SqlDataAdapter sda;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool GetID(string name, string pw)  //lấy tên đăng nhập
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select UN from loginn where UN = '" + name + "' and PW = '" + pw + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
            }
            return false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GetID(txtuname.Text, txtpass.Text))
            {
                Response.Redirect("/Admin/editmon.aspx", true);
            }
            else
                Response.Redirect("/Admin/logon.aspx", true);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}