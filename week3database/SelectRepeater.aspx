<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SelectRepeater.aspx.cs" Inherits="SelectRepeater" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Repeater ID="rptUsers" runat="server">
        
        <HeaderTemplate>
            <table>
                <tr>
                    <td>Username</td>
                    <td>password</td>
                    <td>Update</td>
                    <td>Delete</td>
                </tr>
        </HeaderTemplate>
        
        <ItemTemplate>
                <tr>
                    <td><%# DataBinder.Eval (Container.DataItem, "username") %></td>
                    <td><%# DataBinder.Eval (Container.DataItem, "userpass") %></td>
                    <td><a href="page2.aspx?k=<%# DataBinder.Eval (Container.DataItem, "username") %>&a=u">Update</a></td>
                    <td><a href="page2.aspx?k=<%# DataBinder.Eval (Container.DataItem, "username") %>&a=d">Delete</a></td>
                </tr>
        </ItemTemplate>

        <FooterTemplate>
            
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

