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
    public partial class editmon : System.Web.UI.Page
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
            cmd.CommandText = "select * from Master.Item";
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
            cmd.CommandText = "insert into Master.Item(ItemName,ItemPirce) values ('" + txtiname.Text + "','" + txtprice.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            cmd.ExecuteNonQuery();
            BindData();
        }


        protected void grvitem_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = grvitem.Rows[e.RowIndex].Cells[0].Text;
            //Thực hiện xóa
            cmd.CommandText = "Delete from Master.Item Where itemid ='" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            conn.OpenConn();
            cmd.ExecuteNonQuery();
            DataBind();
            BindData();
        }

        protected void grvitem_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvitem.EditIndex = e.NewEditIndex;
            //Gắn lại dữ liệu
            BindData();
        }

        protected void grvitem_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Retrieve the table from the session object
            GridViewRow row = grvitem.Rows[e.RowIndex];
            

            //Reset the edit index.
            grvitem.EditIndex = -1;
            
            //Bind data to the GridView control

            cmd.CommandText = "update Master.Item set itemname = N'" + ((TextBox)(row.Cells[1].Controls[0])).Text + "', itempirce = '"+ ((TextBox)(row.Cells[2].Controls[0])).Text + "' where itemid = '"+ ((TextBox)(row.Cells[0].Controls[0])).Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            conn.OpenConn();

            cmd.ExecuteNonQuery();
            
        }

        protected void grvitem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
        }
        protected void cancel() {
            grvitem.EditIndex = -1;
        }
        protected void grvitem_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            cancel();
            //Nạp lại dữ liệu
            BindData();
        }

        protected void grvitem_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        protected void grvitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}