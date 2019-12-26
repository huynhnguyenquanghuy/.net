<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admm.Master" AutoEventWireup="true" CodeBehind="hoadon.aspx.cs" Inherits="net.Admin.hoadon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        color: green;
        font-size: 14px;
        font-weight: bold;
        text-align: right;
        height: 34px;
    }
    .auto-style2 {
        height: 34px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1" style="height: 424px; width: 100%">
    <tr>
        <td colspan="2" class="tblhead" align="center">
            hoadon</td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td class="style18">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
             date</td>
        <td style="text-align: left" class="auto-style2">
            <asp:TextBox ID="txtiname" runat="server" placeholder=" 2019-12-02!!!" type="date"
                CssClass="txt" Width="129px" Font-Bold="False" Font-Italic="False" 
                ></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td class="style14">
            &nbsp;</td>
        <td class="style18" align="left">
            <asp:Button ID="btnadd" runat="server" CssClass="btn" onclick="btnadd_Click" 
                Text="truy van" Height="30px" Width="100px" />
            <asp:Label ID="lblmsg" runat="server" ForeColor="Black"></asp:Label>
            <asp:Button ID="Button1" runat="server" CssClass="btn" onclick="btnt_Click" 
                Text="macdinh" Height="30px" Width="100px" />
            <asp:Label ID="Label1" runat="server" ForeColor="Black"></asp:Label>
            <asp:Button ID="Button3" runat="server" CssClass="btn" onclick="btnbs_Click" 
                Text="best sell" Height="30px" Width="100px" />
            <br />

        </td>

    </tr>
    <tr>
        <td class="auto-style1">
             orderid</td>
        <td style="text-align: left" class="auto-style2">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="nhập orderid muốn xem chi tiết"
                CssClass="txt" Width="129px" Font-Bold="False" Font-Italic="False" 
                ></asp:TextBox>
        
       <asp:Button ID="Button2" runat="server" CssClass="btn" onclick="btnchitiet_Click" 
                Text="chi tiet" Height="30px" Width="100px" />
            <asp:Label ID="Label2" runat="server" ForeColor="Black"></asp:Label>
            <br />
        </td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td align="left">
            <asp:GridView ID="grvitem" runat="server" AllowPaging="True"
            AllowSorting="True" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnSelectedIndexChanged="grvitem_SelectedIndexChanged" >
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="orderid" HeaderText="orderid" SortExpression="orderid" />
                    <asp:BoundField DataField="paymenttypeid" HeaderText="paymenttypeid" SortExpression="paymenttypeid" />
                    <asp:BoundField DataField="customerid" HeaderText="customerid" SortExpression="customerid" />
                    <asp:BoundField DataField="ordernumber" HeaderText="ordernumber" SortExpression="ordernumber" />                
                    <asp:BoundField DataField="Orderdate" HeaderText="Orderdate" SortExpression="Orderdate" />
                    <asp:BoundField DataField="finaltotal" HeaderText="finaltotal" SortExpression="finaltotal" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>

        </td>
    </tr>
</table>
</asp:Content>
