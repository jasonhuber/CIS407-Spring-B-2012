<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="week2.aspx.cs" Inherits="week2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Name is Required!" ControlToValidate="txtName"></asp:RequiredFieldValidator>
    <br />
    Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="Your email was not formatted correctly!" 
        ControlToValidate="txtEmail" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtEmail" ErrorMessage="Email is required!"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="btnGo" runat="server" Text="Go!" onclick="btnGo_Click" />
    <br />
    <br />
    You input:<br />
    <asp:Label runat="server" ID="lblOutput"></asp:Label>
</asp:Content>

