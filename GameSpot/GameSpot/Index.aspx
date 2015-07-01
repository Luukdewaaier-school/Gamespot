<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="GameSpot.Index" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %></h1>
                <h2></h2>
            </hgroup>
            <p>
                Welkom op GameSpot, bekijk hier alle informatie over games!
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Table runat="server" id="tblNieuws">
      <asp:TableRow runat="server">
        <asp:TableCell runat="server"><b>Titel</b></asp:TableCell>
        <asp:TableCell runat="server"><b>The game</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Auteur</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Post-datum</b></asp:TableCell>
      </asp:TableRow>
    </asp:Table>
    <asp:Table runat="server" id="tblReview">
      <asp:TableRow runat="server">
        <asp:TableCell runat="server"><b>Titel</b></asp:TableCell>
        <asp:TableCell runat="server"><b>The game</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Auteur</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Post-datum</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Platform</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Rating</b></asp:TableCell>
      </asp:TableRow>
    </asp:Table>
    <asp:Table runat="server" id="tblVideoclip">
      <asp:TableRow runat="server">
        <asp:TableCell runat="server"><b>Titel</b></asp:TableCell>
        <asp:TableCell runat="server"><b>The game</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Auteur</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Post-datum</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Categorie</b></asp:TableCell>
      </asp:TableRow>
    </asp:Table>
    <asp:Table runat="server" id="tblShow">
      <asp:TableRow runat="server">
        <asp:TableCell runat="server"><b>Titel</b></asp:TableCell>
        <asp:TableCell runat="server"><b>The game</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Auteur</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Post-datum</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Startdatum</b></asp:TableCell>
        <asp:TableCell runat="server"><b>Live?</b></asp:TableCell>
      </asp:TableRow>
    </asp:Table>
</asp:Content>
