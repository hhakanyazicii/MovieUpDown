<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="MovieUpDown.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 44%;
            height: 163px;
            margin-top: 60px;
        }
        .auto-style2 {
            width: 144px;
        }
        .auto-style3 {
            width: 144px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
            width: 203px;
        }
        .auto-style5 {
            width: 203px;
        }
        .adminlogo {
            width: 200px;
            height: 200px;
            margin-left: 600px;
            margin-top: 70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="img/adminlogo.png" alt="Alternate Text" class="adminlogo" />
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="adminIdLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Admin ID:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="adminIDTxtBox" runat="server" Width="220px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="adminPassLbl" runat="server" Font-Bold="False" Font-Size="25px" ForeColor="White" Text="Şifre:"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="adminPassTxtBox" runat="server" Width="220px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="adminLgnBtn" runat="server" CssClass="offset-sm-0" Text="Giriş Yap" Width="123px" OnClick="adminLgnBtn_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="adminWarn" runat="server" ForeColor="White" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
