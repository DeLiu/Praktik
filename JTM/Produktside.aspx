<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Produktside.aspx.cs" Inherits="Produktside" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div id="productcontent" runat="server">
        <asp:SqlDataSource ID="productDBstring" runat="server" ConnectionString="<%$ ConnectionStrings:productString %>" SelectCommand="SELECT [productname], [amount], [price], [infomation], [productID] FROM [productinfo]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="productDBstring" Width="377px">
            <Columns>
                <asp:BoundField DataField="productname" HeaderText="productname" SortExpression="productname" />
                <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="infomation" HeaderText="infomation" SortExpression="infomation" />
            </Columns>
            <HeaderStyle BorderStyle="Solid" />
            <SelectedRowStyle BorderStyle="Groove" />
        </asp:GridView>
</div>
</asp:Content>

