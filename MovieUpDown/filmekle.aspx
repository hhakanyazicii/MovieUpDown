<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="filmekle.aspx.cs" Inherits="MovieUpDown.addmovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 246px;
    }
        .auto-style2 {
            width: 50%;
            margin-top: 75px;
        }
        .auto-style3 {
            width: 246px;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style2">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="filmAdiLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Film Adı:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="filmAdiTxtBox" runat="server" Width="284px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="cikisTarihiLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Çıkış Tarihi:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="dateTxtBox" runat="server" Width="284px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="kategoriLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Kategori:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="kategoriList" runat="server" Width="293px" DataSourceID="SqlDataSource1" DataTextField="kategori_adi" DataValueField="id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:projeConnectionString %>" SelectCommand="SELECT * FROM [kategori]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="KonuLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Konu:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="konuTxtBox" runat="server" Height="148px" Width="284px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="ResimLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Resim:"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:FileUpload ID="filmImgUpld" runat="server" Width="291px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="yntmLbl" runat="server" Font-Size="25px" ForeColor="White" Text="Yönetmen:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="yonetmenList" runat="server" Width="290px" DataSourceID="SqlDataSource2" DataTextField="yonetmen_ad" DataValueField="id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:projeConnectionString %>" SelectCommand="SELECT * FROM [yonetmen]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Button ID="filmekleBtn" runat="server" Text="Film Ekle" CssClass="offset-sm-0" OnClick="filmekleBtn_Click" Width="197px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td>
            <asp:Label ID="filmbilgiLbl" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
