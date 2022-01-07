<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="yonetmenekle.aspx.cs" Inherits="MovieUpDown.yonetmenekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            margin-top: 57px;
        }
        .auto-style2 {
            width: 262px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="yntmnAdiLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Yönetmen Adı:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="yntmnAdiTxtBox" runat="server" Width="270px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yönetmen Ekle" Width="123px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Label ID="yntmnBilgiLbl" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
