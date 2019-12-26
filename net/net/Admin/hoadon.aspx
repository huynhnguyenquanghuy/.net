<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admm.Master" AutoEventWireup="true" CodeBehind="hoadon.aspx.cs" Inherits="net.Admin.WebForm2" %>
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
        </td>

    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td align="left">
            <asp:GridView ID="grvitem" runat="server" AllowPaging="True"
            AllowSorting="True" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" >
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                    <asp:BoundField DataField="idem" HeaderText="idem" SortExpression="idem" />
                    <asp:BoundField DataField="iditem" HeaderText="id" SortExpression="id" />
                    <asp:BoundField DataField="sl" HeaderText="sl" SortExpression="sl" />                
                    <asp:BoundField DataField="tt" HeaderText="tt" SortExpression="tt" />
                    <asp:BoundField DataField="datecre" HeaderText="datecre" SortExpression="datecre" />
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
