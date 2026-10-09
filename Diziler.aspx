<%@ Page Title="Diziler" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Diziler.aspx.cs" Inherits="DiziOneriWebSitesii.Diziler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1>Diziler</h1>

<asp:DataList ID="dlDiziler" runat="server">
    <ItemTemplate>
        <div class="liste-dizi">
            <img src='<%# Eval("Resim") %>' onerror="this.src='Images/no-image.jpg'" width="120" height="170" />
            <div>
                <a href='DiziDetay.aspx?id=<%# Eval("Id") %>'>
                    <h2><%# Eval("Baslik") %></h2>
                </a>
            </div>
        </div>
    </ItemTemplate>
</asp:DataList>

</asp:Content>