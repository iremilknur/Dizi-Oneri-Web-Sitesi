<%@ Page Title="Haftanın Önerileri" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HaftaninOnerileri.aspx.cs" Inherits="DiziOneriWebSitesii.HaftaninOnerileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1>⭐ Haftanın Önerileri</h1>

<asp:DataList ID="dlOneriler" runat="server" RepeatColumns="5">
    <ItemTemplate>
        <div class="dizi-kart">
            <a href='DiziDetay.aspx?id=<%# Eval("Id") %>'>
                <img src='<%# Eval("Resim") %>' onerror="this.src='Images/no-image.jpg'" width="180" height="250" />
                <br />
                <%# Eval("Baslik") %>
            </a>
        </div>
    </ItemTemplate>
</asp:DataList>

</asp:Content>