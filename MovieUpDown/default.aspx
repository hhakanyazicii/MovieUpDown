<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MovieUpDown.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display: flex;
            flex-flow: row wrap;
            margin-left: 0px;
        }
        a {
            text-decoration: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="filmAkis" runat="server" CssClass="auto-style1" Wrap="False">
    </asp:Panel>
    <asp:Panel ID="filmGonderi" runat="server" Width="100%" Height="724px">
    </asp:Panel>

</asp:Content>
