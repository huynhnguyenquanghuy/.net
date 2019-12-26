<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admm.Master" AutoEventWireup="true" CodeBehind="bsl.aspx.cs" Inherits="net.Admin.bsl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 887px;
        }
        .auto-style3 {
            margin-top: 0px;
        }
        .auto-style4 {
            height: 477px;
        }
        .auto-style5 {
            width: 887px;
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style5" align="left">
                <asp:Button ID="btnadd" runat="server" CssClass="btn"  PostBackUrl="~/Admin/hoadon.aspx" 
                    Text="Back" Height="30px" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="Button1" runat="server" CssClass="btn"  
                    Text="view" Height="30px" Width="100px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Height="249px" ReadOnly="True" TextMode="MultiLine" Width="885px"></asp:TextBox>
            </td>

        </tr>
    </table>
</asp:Content>
