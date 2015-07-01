<%@ Page Title="Review" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="GameSpot.Review" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Een lijst van reviews</h2>
    </hgroup>
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
</asp:Content>