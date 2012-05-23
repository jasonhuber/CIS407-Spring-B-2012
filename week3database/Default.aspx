<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   <a href="page2.aspx">Insert Page</a><br />
   <a href="SelectRepeater.aspx">Select Repeater</a><br />
   
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
    AutoGenerateColumns="False" CellPadding="4" DataKeyNames="username" 
    DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="userpass" HeaderText="userpass" 
                SortExpression="userpass" />
            <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" 
                SortExpression="username" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView> 
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConflictDetection="CompareAllValues" 
    ConnectionString="<%$ ConnectionStrings:democonnection %>" 
    DeleteCommand="DELETE FROM [HuberUsers2012spb] WHERE [username] = @original_username AND [userpass] = @original_userpass" 
    InsertCommand="INSERT INTO [HuberUsers2012spb] ([userpass], [username]) VALUES (@userpass, @username)" 
    OldValuesParameterFormatString="original_{0}" 
    SelectCommand="SELECT [userpass], [username] FROM [HuberUsers2012spb]" 
    UpdateCommand="UPDATE [HuberUsers2012spb] SET [userpass] = @userpass WHERE [username] = @original_username AND [userpass] = @original_userpass">
    <DeleteParameters>
        <asp:Parameter Name="original_username" Type="String" />
        <asp:Parameter Name="original_userpass" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="userpass" Type="String" />
        <asp:Parameter Name="username" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="userpass" Type="String" />
        <asp:Parameter Name="original_username" Type="String" />
        <asp:Parameter Name="original_userpass" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
&nbsp; &nbsp; &nbsp;
</asp:Content>
