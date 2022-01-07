<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MovieUpDown.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 159px;
        }

        .auto-style2 {
            width: 121px;
        }

        .auto-style5 {
        width: 159px;
        height: 49px;
    }

        .auto-style6 {
            width: 121px;
            height: 49px;
        }

        .userLogo {
            margin-top: 25px;
            width: 150px;
            height: 150px;
        }

        .auto-style7 {
            width: 159px;
            height: 83px;
        }

        .auto-style8 {
            width: 121px;
            height: 83px;
        }

        .auto-style9 {
            width: 50%;
            margin-top: 17px;
        }
        .auto-style10 {
            margin-top: 25px;
            width: 150px;
            height: 150px;
            margin-left: 575px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <img src="/img/userpic.png" alt="Alternate Text" class="auto-style10" align="center"/>
        <table align="center" cellspacing="4" class="auto-style9">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="loginUNameLabel" runat="server" Font-Size="28px" ForeColor="White" Text="Kullanıcı Adı:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="loginUserNameTxtBox" runat="server" Height="29px" Width="234px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label runat="server" Font-Size="28px" ForeColor="White" Text="Şifre:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="loginPassTxtBox" runat="server" CssClass="mt-0" Height="29px" Width="234px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Button ID="loginBtn" runat="server" CssClass="mx-0" Text="Giriş Yap" Width="150px" Height="37px" OnClick="loginBtn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="login_warn_label" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
