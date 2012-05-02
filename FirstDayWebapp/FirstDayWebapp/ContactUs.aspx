<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="FirstDayWebapp.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="#CC0000" Visible="False"></asp:Label>
    Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
    Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
    Comments: <asp:TextBox ID="txtComments" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Go!" 
        onclick="btnSubmit_Click" />
</asp:Content>
