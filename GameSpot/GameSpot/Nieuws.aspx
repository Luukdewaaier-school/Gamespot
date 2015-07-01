<%@ Page Title="Nieuws" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nieuws.aspx.cs" Inherits="GameSpot.Nieuws" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Een lijst van nieuwsartikelen</h2>
    </hgroup>
    <asp:Table runat="server" id="tblNieuws">
      <asp:TableRow runat="server">
        <asp:TableCell runat="server"><b>Titel</b></asp:TableCell>
        <asp:TableCell runat="server"><b>The game</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Auteur</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Post-datum</b></asp:TableCell>
      </asp:TableRow>
    </asp:Table>
</asp:Content>