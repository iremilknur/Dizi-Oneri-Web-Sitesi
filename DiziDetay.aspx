<%@ Page Title="Dizi Detay" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DiziDetay.aspx.cs" Inherits="DiziOneriWebSitesii.DiziDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="detay">
    <div>
        <asp:Image ID="imgDizi" runat="server" Width="220" Height="300" Style="border-radius:10px; object-fit:cover;" onerror="this.src='Images/no-image.jpg'" />
    </div>

    <div class="detay-bilgi">
        <h1><asp:Label ID="lblBaslik" runat="server"></asp:Label></h1>

        <h3>Konu</h3>
        <p><asp:Label ID="lblAciklama" runat="server"></asp:Label></p>

        <p><b>Tür:</b> <asp:Label ID="lblTur" runat="server"></asp:Label></p>
    </div>
</div>

</asp:Content>