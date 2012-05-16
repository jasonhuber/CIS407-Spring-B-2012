<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Week3MathWebConsumer.Calculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtNum2"
            runat="server"></asp:TextBox><br /><asp:TextBox ID="txtResult" 
            runat="server"></asp:TextBox><br />
        <asp:Button
                ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
                <asp:Button ID="btnDivide" runat="server" Text="Button" onclick="btnDivide_Click" />
    
    </div>
    </form>
</body>
</html>
