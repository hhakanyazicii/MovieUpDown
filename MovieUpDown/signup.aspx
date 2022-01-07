<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="MovieUpDown.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
        .auto-style3 {
            width: 200px;
        }

        #signupForm {
            margin-top: 100px;
        }

        tr {
            padding-bottom: 100px;
        }
        .auto-style4 {
            width: 42%
        }
        .auto-style6 {
            width: 200px;
            height: 44px;
        }
        .auto-style8 {
            margin-bottom: 0px;
        }
        .auto-style10 {
            margin-left: 75px;
            margin-top: 0;
        }
        .auto-style11 {
            width: 200px;
            height: 76px;
        }
        .auto-style12 {
            width: 249px;
            height: 44px;
        }
        .auto-style13 {
            width: 249px;
            height: 76px;
        }
        .auto-style14 {
            width: 249px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="signupForm">
        <table align="center" cellspacing="4" class="auto-style4">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="signupName_Label" runat="server" Font-Bold="False" Font-Size="26px" ForeColor="White" Text="Adınız:"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="signup_nameTxtBox" runat="server" Width="286px" Height="29px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="signupUsername_Label" runat="server" Font-Size="26px" ForeColor="White" Text="Kullanıcı Adı:"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="signup_usernameTxtBox" runat="server" Width="286px" Height="29px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="signupPass_Label" runat="server" Font-Size="26px" ForeColor="White" Text="Şifre:"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="signup_passTxtBox" runat="server" Width="286px" TextMode="Password" CssClass="auto-style8" Height="29px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="signupEmail_Label" runat="server" Font-Size="26px" ForeColor="White" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="signup_emailTxtBox" runat="server" Width="286px" TextMode="Email" CssClass="auto-style8" Height="29px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style13">
                    <asp:Button ID="btn_signup" runat="server" Text="Kayıt Ol" Width="127px" CssClass="auto-style10" OnClick="btn_signup_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="signup_uyari_label" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
