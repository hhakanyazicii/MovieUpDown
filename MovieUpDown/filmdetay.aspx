<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="filmdetay.aspx.cs" Inherits="MovieUpDown.filmdetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script defer src="/fontawesome/js/all.js"></script>
    <link href="/your-path-to-fontawesome/css/all.css" rel="stylesheet">
    <style type="text/css">
        .card {
            margin: 50px auto;
            width: 50%;
            height: 30%;
        }

        .card-img-top {
            width: 100%;
            height: 15vw;
            object-fit: cover;
            opacity: 0.6;
        }

        * {
            color: white;
        }

        .cardBody {
            text-align: center;
        }

        .yorum-li {
            border-bottom: 2px solid #6998AB;
        }

        .yorumYapma {
            margin: 0 auto;
            padding-left: 33%;
        }

        .yorum-textBox {
            margin-top: 10px;
        }

        .yorumBtn {
            margin-top: 15px;
            margin-left: 50px;
        }

        .yorumDrowDown {
            margin-left: 20px;
        }

        ul {
            list-style-type: none;
        }

        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" width="600px" runat="server">
    <asp:Panel ID="filmDetayPanelCard" CssClass="card bg-dark mb-3" runat="server">
        <asp:Panel ID="filmDetayCardBody" CssClass="cardBody" runat="server">
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="yorumKismi" CssClass="container justify-content-center yorum-liste" runat="server">
    </asp:Panel>
    <div class="yorumYapma container justify-content-center">
        <asp:TextBox ID="yorumTxtBox" runat="server" CssClass="offset-sm-0 yorum-textBox" Height="79px" Style="margin-left: 0; margin-bottom: 0;" Width="346px" ForeColor="Black" TextMode="MultiLine" />
        <br />
        <asp:Button ID="yorumYap" runat="server" Height="31px" Text="Yorum Yap" Width="104px" CssClass="mt-0 yorumBtn" ForeColor="Black" OnClick="yorumYap_Click" />
       <asp:DropDownList ID="puanlamaDL" runat="server" Width="104px" CssClass="yorumDropDown" Height="31px"  style="color:black;">
            <asp:ListItem style="color:black;" Value="0">0</asp:ListItem>
            <asp:ListItem style="color:black;" Value="1">1</asp:ListItem>
            <asp:ListItem style="color:black;" Value="2">2</asp:ListItem>
            <asp:ListItem style="color:black;" Value="3">3</asp:ListItem>
            <asp:ListItem style="color:black;" Value="4">4</asp:ListItem>
            <asp:ListItem style="color:black;" Value="5">5</asp:ListItem>
            <asp:ListItem style="color:black;" Value="6">6</asp:ListItem>
            <asp:ListItem style="color:black;" Value="7">7</asp:ListItem>
            <asp:ListItem style="color:black;" Value="8">8</asp:ListItem>
            <asp:ListItem style="color:black;" Value="9">9</asp:ListItem>
            <asp:ListItem style="color:black;" Value="10">10</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="yorumUyari" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>

        </asp:Content>
