<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admm.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="net.Admin.chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 887px;
        }
        .auto-style2 {
            width: 887px;
            height: 165px;
        }
        .auto-style3 {
            margin-top: 0px;
        }
        .auto-style4 {
            height: 477px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td colspan="2" class="tblhead" align="center">
                Chi tiet
            </td>
        </tr>
        <tr>
            <td class="auto-style1" align="left">
                <asp:Button ID="btnadd" runat="server" CssClass="btn"  PostBackUrl="~/Admin/hoadon.aspx" 
                    Text="Back" Height="30px" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Height="157px" ReadOnly="True" TextMode="MultiLine" Width="885px"></asp:TextBox>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
