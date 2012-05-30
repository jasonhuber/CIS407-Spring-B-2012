<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Transactions.aspx.cs" Inherits="Transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:TextBox ID="txtTransactions" runat="server" TextMode="MultiLine" Rows="5">1,1,30</asp:TextBox><br />
    <asp:Button ID="btnGo" runat="server" Text="Run Trans" onclick="btnGo_Click" /> <br />
    <asp:Label ID="lbloutput" runat="server" Text="Label"></asp:Label>

    <br />
    1,1,30~1,2,40~1,3,60~1,4,10
</asp:Content>

