<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="MovieUpDown.category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="kategoriPanel" CssClass="kategoriPanel" runat="server" Width="97%">
        <div class="row align-items-center">
            &nbsp;<a class="col category-card" href="/kategoriler.aspx?id=1">
                <img src="img/aksiyon.jpg" class="anc-img"/>
                <p class="ctTxt">Aksiyon</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=2">
                <img src="img/animasyon.jpg" class="anc-img"/>
                <p class="ctTxt">Animasyon</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=3">
                <img src="img/belgesel.jpg" class="anc-img"/>
                <p class="ctTxt">Belgesel</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=4">
                <img class="anc-img" src="img/bilimkurgu.jpg"/>
                <p class="ctTxt">Bilim Kurgu</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=5">
                <img src="img/biyografi.jpg" class="anc-img"/>
                <p class="ctTxt">Biyografi</p>
            </a>
        </div>
        <div class="row align-items-center">
            &nbsp;<a class="col category-card" href="/kategoriler.aspx?id=6">
                <img src="img/dram.jpg" class="anc-img"/>
                <p class="ctTxt">Dram</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=7">
                <img src="img/fantastik.jpg" class="anc-img"/>
                <p class="ctTxt">Fantastik</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=8">
                <img src="img/gerilim.jpg" class="anc-img"/>
                <p class="ctTxt">Gerilim</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=15">
                <img src="img/gizem.jpg" class="anc-img"/>
                <p class="ctTxt">Gizem</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=9">
                <img src="img/komedi.jpg" class="anc-img"/>
                <p class="ctTxt">Komedi</p>
            </a>
        </div>
        <div class="row align-items-center">
            <a class="col category-card" href="/kategoriler.aspx?id=10">
                <img src="img/korku.jpg" class="anc-img"/>
                <p class="ctTxt">Korku</p>
            </a>
            &nbsp;<a class="col category-card" href="/kategoriler.aspx?id=11">
                <img src="img/macera.jpg" class="anc-img"/>
                <p class="ctTxt">Macera</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=12">
                <img src="img/romantik.jpg" class="anc-img"/>
                <p class="ctTxt">Romantik</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=13">
                <img src="img/savas.jpg" class="anc-img"/>
                <p class="ctTxt">Savaş</p>
            </a>
            <a class="col category-card" href="/kategoriler.aspx?id=14">
                <img src="img/spor.jpg" class="anc-img"/>
                <p class="ctTxt">Spor</p>
            </a>
        </div>
    </asp:Panel>
</asp:Content>
