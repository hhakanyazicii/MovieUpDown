<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="oyuncuekle.aspx.cs" Inherits="MovieUpDown.oyuncuekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 313px;
        }
        .auto-style2 {
            width: 50%;
            margin-top: 65px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style2">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="oyuncularLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Oyuncular:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="oyuncularTxtBox" runat="server" Width="292px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="oyncuOynamakLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Oynadığı Film:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="filmlerDropDwnList" runat="server" DataSourceID="SqlDataSource1" DataTextField="adi" DataValueField="id" Width="186px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:projeConnectionString %>" SelectCommand="SELECT * FROM [film]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="oyuncuEkleBtn" runat="server" OnClick="oyuncuEkleBtn_Click" Text="Oyuncuları Ekle" Width="151px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="oyuncuBilgiLbl" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
