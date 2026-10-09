<%@ Page Title="Ana Sayfa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DiziOneriWebSitesii._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2 class="baslik">⭐ Haftanın Önerileri</h2>

<div class="haftanin-liste">
    <asp:DataList ID="dlHaftaninOnerileri" runat="server" RepeatDirection="Horizontal">
        <ItemTemplate>
            <div class="haftanin-kart">
                <a class="dizi-link" href='DiziDetay.aspx?id=<%# Eval("Id") %>'>
                    <img src='<%# Eval("Resim") %>' onerror="this.src='Images/no-image.jpg'" />
                    <h3><%# Eval("Baslik") %></h3>
                </a>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>

<hr />

<h2 class="baslik">🆕 Yeni Eklenenler</h2>

<div class="yeni-liste">
    <asp:DataList ID="dlYeniDiziler" runat="server">
        <ItemTemplate>
            <div class="yeni-kart">
                <img src='<%# Eval("Resim") %>' onerror="this.src='Images/no-image.jpg'" />
                <div>
                    <a class="dizi-link" href='DiziDetay.aspx?id=<%# Eval("Id") %>'>
                        <h3><%# Eval("Baslik") %></h3>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</div>

</asp:Content>