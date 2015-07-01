<%@ Page Title="Video" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Video.aspx.cs" Inherits="GameSpot.Video" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Een lijst van videos</h2>
    </hgroup>
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