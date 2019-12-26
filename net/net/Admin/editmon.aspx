<%@ Page Title="edit menu" Language="C#" MasterPageFile="~/Admin/admm.Master" AutoEventWireup="true" CodeBehind="editmon.aspx.cs" Inherits="net.Admin.editmon" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1" style="height: 424px; width: 100%">
    <tr>
        <td colspan="2" class="tblhead" align="center">
            Add Item</td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td class="style18">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="lbl">
             Item Name:</td>
        <td style="text-align: left">
            <asp:TextBox ID="txtiname" runat="server" placeholder=" Type item name!!!" 
                CssClass="txt" Width="129px" Font-Bold="False" Font-Italic="False" 
                ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="lbl">
            Price:</td>
        <td style="text-align: left">
            <asp:TextBox ID="txtprice" runat="server" placeholder="Enter Price!!" 
              CssClass="txt"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style14">
            &nbsp;</td>
        <td class="style18" align="left">
            <asp:Button ID="btnadd" runat="server" CssClass="btn" onclick="btnadd_Click" 
                Text="ADD ITEM" Height="30px" Width="100px" />
            <asp:Label ID="lblmsg" runat="server" ForeColor="Black"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td align="left">
            <asp:GridView ID="grvitem" runat="server" AllowPaging="True"
            AllowSorting="True" AutoGenerateColumns="False" Width="100%" onpageindexchanging="grvitem_PageIndexChanging" onsorting="grvitem_Sorting" onrowdeleting="grvitem_RowDeleting" onrowediting="grvitem_RowEditing" onrowupdating="grvitem_RowUpdating" onrowcancelingedit="grvitem_RowCancelingEdit" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnSelectedIndexChanged="grvitem_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="ItemId" HeaderText="ItemId" SortExpression="ItemId" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                    <asp:BoundField DataField="ItemPirce" HeaderText="ItemPrice" SortExpression="ItemPrice" />
                    <asp:CommandField ButtonType="Button" CancelText="Hủy" DeleteText="Xóa" EditText="Sửa" ShowEditButton="True" UpdateText="Cập nhật" />
                    <asp:CommandField ButtonType="Button" CancelText="Hủy" DeleteText="Xóa" EditText="Sửa" ShowDeleteButton="True" />
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
