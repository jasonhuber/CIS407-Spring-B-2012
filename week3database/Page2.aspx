<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    Username: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
    Password: <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnInsert" runat="server" Text="INSERT!" 
        onclick="btnInsert_Click" />

</asp:Content>

